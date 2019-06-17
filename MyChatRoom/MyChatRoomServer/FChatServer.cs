using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net; //IP,IPAdress(port)
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;

namespace MyChatRoomServer
{
    public partial class FChatServer : Form
    {
        public FChatServer()
        {
            InitializeComponent();
            //Отключение проверки на перекрёстные потоки текстовых полей
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        Thread threadWatch = null;//Поток, отвечающий за прослушивание клиентских запросов
        Socket socketWatch = null;//Сокет, отвечающий за прослушивание клиентских запросов


        //Сохраняет все сокеты для коммуникации с клиентом
        Dictionary<string, Socket> dict = new Dictionary<string, Socket>();

        //Сохраняет все потоки, отвечающие за вызов метода Recieve
        Dictionary<string, Thread> dictThread = new Dictionary<string, Thread>();

        //Открываем соединение
        private void btnBeginListen_Click(object sender, EventArgs e)
        {
            //Создание сокета, отвечающего за прослушивание
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Получение IP-адреса объекта из текстового поля
            IPAddress address = IPAddress.Parse(txtIP.Text.Trim());
            //Создание оъекта сетевого узла, содержащего IP-адрес и порт
            IPEndPoint endpoint = new IPEndPoint(address, int.Parse(txtPort.Text.Trim()));
            //Привязываем сокет, отвечающий за уникальный IP-адрес и порт
            try
            {
                socketWatch.Bind(endpoint);
            }
            catch (SocketException ex)
            {
                ShowMsg("An exception: " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                ShowMsg("An exception: " + ex.Message);
                return;
            }

            //Установка длины очереди прослушивания
            socketWatch.Listen(10);

            //Создаем поток, отвечающий за прослушивание 
            threadWatch = new Thread(WatchConnection);
            threadWatch.IsBackground = true;//Поток фоновый
            threadWatch.Start();//Открываем поток

            ShowMsg("Server successfuly starts monitoring");

        }

        //Отправка сообщений клиенту
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbOnline.Text))
            {
                MessageBox.Show("Pleace, select a user");
            }
            else
            {
                string strMsg = txtMsgSend.Text.Trim();
                //Конвертируем строку в байтовый массив
                byte[] arrMsg = Encoding.UTF8.GetBytes(strMsg);

                //Получаем ключ выбранного IP-адреса
                string strClientKey = lbOnline.Text;
                try
                {
                    //Находим необходимый сокет в словаре и отправляем сообщение
                    dict[strClientKey].Send(arrMsg);

                    ShowMsg(string.Format("I said to {0}： {1}", strClientKey, strMsg));
                    //Очищаем поле отправки
                    this.txtMsgSend.Text = "";
                }
                catch (SocketException ex)
                {
                    ShowMsg("An exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    ShowMsg("An exception: " + ex.Message);
                }                
            }
        }

        //Отправка массовых сообщений
        private void btnSendToAll_Click(object sender, EventArgs e)
        {
            string strMsg = txtMsgSend.Text.Trim();
            //Конвертируем сообщение в байтовый массив
            byte[] arrMsg = Encoding.UTF8.GetBytes(strMsg);
            foreach (Socket s in dict.Values)
            {
                try
                {
                    s.Send(arrMsg);
                    ShowMsg("Message was sent");
                }
                catch (SocketException ex)
                {
                    ShowMsg("An exception: " + ex.Message);
                    break;
                }
                catch (Exception ex)
                {
                    ShowMsg("An exception: " + ex.Message);
                    break;
                }
            }
            
        }


        /// <summary>
        /// Прослушивание клиентских запросов
        /// </summary>
        void WatchConnection()
        {
            //Постоянное прослушивание запросов на подключение
            while (true)
            {
                Socket socketConnection = null;
                try
                {
                    //Получаем запрос и возвращаем новый сокет
                    socketConnection = socketWatch.Accept();
                }
                catch (SocketException ex)
                {
                    ShowMsg("An exception: " + ex.Message);
                    break;
                }
                catch (Exception ex)
                {
                    ShowMsg("An exception: " + ex.Message);
                    break;
                }

                //Добавляем IP-адрес в список онлайн               
                lbOnline.Items.Add(socketConnection.RemoteEndPoint.ToString());

                //Сохраняем новый сокет и загружаем его в словарь
                dict.Add(socketConnection.RemoteEndPoint.ToString(), socketConnection);

                //Создаем новый поток для прослушивания
                Thread threadCommunicate = new Thread(ReceiveMsg);
                threadCommunicate.IsBackground = true;
                threadCommunicate.Start(socketConnection);//Поток с входящими параметрами

                dictThread.Add(socketConnection.RemoteEndPoint.ToString(), threadCommunicate);

                ShowMsg(string.Format("{0} is online ", socketConnection.RemoteEndPoint.ToString()));
            }
        }

        /// <summary>
        /// Прослушивание данных отправленных клиентом
        /// </summary>
        void ReceiveMsg(object socketClientPara)
        {
            Socket socketClient = socketClientPara as Socket;
            while (true)
            {
                //Буфер для получения сообщений
                byte[] arrMsgRev = new byte[1024 * 1024 * 2];
                //Сохранение полученных данных в массив и получение фактической длины
                int length = -1;
                try
                {
                    length = socketClient.Receive(arrMsgRev);
                }
                catch (SocketException ex)
                {
                    ShowMsg("An exception: " + ex.Message+", RemoteEndPoint: "+socketClient.RemoteEndPoint.ToString());
                    //Удаляем сокет 
                    dict.Remove(socketClient.RemoteEndPoint.ToString());
                    //Удаляем поток
                    dictThread.Remove(socketClient.RemoteEndPoint.ToString());
                    //Удаляем IP-адрес из списка онлайн
                    lbOnline.Items.Remove(socketClient.RemoteEndPoint.ToString());
                    break;
                }
                catch (Exception ex)
                {
                    ShowMsg("An exception：" + ex.Message);
                    break;
                }
                if (arrMsgRev[0] == 0) //Если первый элемент данных, отправленных клиентом 0, принимаем текст
                {
                    //Конвертируем элементы массива в строку
                    string strMsgReceive = Encoding.UTF8.GetString(arrMsgRev, 1, length - 1);
                    ShowMsg(string.Format("{0} said：{1}", socketClient.RemoteEndPoint.ToString(), strMsgReceive));
                }
                else if (arrMsgRev[0] == 1)//Принимаем файл
                {
                    
                    SaveFileDialog sfd = new SaveFileDialog();
                    //Открываем диалоговое окно
                    if (sfd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        //Получаем путь, где будет сохранён файл
                        string fileSavePath = sfd.FileName;
                        //Создаем файловый поток и позволяем создать файл на основе пути
                        using (FileStream fs = new FileStream(fileSavePath, FileMode.Create))
                        {
                            fs.Write(arrMsgRev, 1, length - 1);
                            ShowMsg("File was successfully saved to: " + fileSavePath);
                        }
                    }

                }
            }
        }

        void ShowMsg(string msg)
        {
            txtMsg.AppendText(msg + "\r\n");
        }



    }
}
