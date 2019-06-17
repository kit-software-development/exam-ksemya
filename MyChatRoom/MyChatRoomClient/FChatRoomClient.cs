using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace MyChatRoomClient
{
    public partial class FChatRoomClient : Form
    {
        //Поток, отвечающий за получение ссобщений с сервера
        Thread threadClient = null;
        //Клинтский сокет, который отвечает за соединение с сервером
        Socket socketClient = null;

        public FChatRoomClient()
        {
            InitializeComponent();
            //Выключение проверки на перекрёстные потоки текстовых полей
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        //Подключение к серверу
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Получение IP-адреса из текстового поля
            IPAddress address = IPAddress.Parse(txtIP.Text.Trim());
            //Создание объекта сетевого узла, содержащего IP и порт 
            IPEndPoint endpoint = new IPEndPoint(address, int.Parse(txtPort.Text.Trim()));
            //Создание клинтского сокета, который отвечает за соединение с сервером
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                //Подключение к серверу
                socketClient.Connect(endpoint);
            }
            catch (SocketException ex)
            {
                ShowMsg("An exception：" + ex.Message);
            }
            catch (Exception ex)
            {
                ShowMsg("An exception：" + ex.Message);
            }

            threadClient = new Thread(ReceiveMsg);
            threadClient.IsBackground = true;
            threadClient.Start();
        }

        //Отправка текстового сообщения на сервер
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            string strMsg = txtMsgSend.Text.Trim();
            //Преобразование строки в двоичный массив
            byte[] arrMsg = Encoding.UTF8.GetBytes(strMsg);
            byte[] arrMsgSend = new byte[arrMsg.Length + 1];
            arrMsgSend[0] = 0;//установка флага, 0 - отправляем текст 
            Buffer.BlockCopy(arrMsg, 0, arrMsgSend, 1, arrMsg.Length);
            try
            {
                socketClient.Send(arrMsgSend);

                ShowMsg(string.Format("I said to {0}：{1}", socketClient.RemoteEndPoint.ToString(), strMsg));
                //Очищаем поле с сообщением 
                this.txtMsgSend.Text = "";
            }
            catch (SocketException ex)
            {
                ShowMsg("An exception：" + ex.Message);
            }
            catch (Exception ex)
            {
                ShowMsg("An exception：" + ex.Message);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            //Выбираем файл для пересылки
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        //Отправка файла на сервер
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            //Открываем выбранный файл в потоке
            using (FileStream fs = new FileStream(txtFilePath.Text, FileMode.Open))
            {
                //Буфер
                byte[] arrFile = new byte[1024 * 1024 * 2];
                //Считывание данных из файла в массив и получение длины файла
                int length = fs.Read(arrFile, 0, arrFile.Length);
                //Массив для отправки данных + 1 бит
                byte[] arrFileSend = new byte[length + 1];
                //Первый бит - бит протокола: 1-файл
                arrFileSend[0] = 1;
                Buffer.BlockCopy(arrFile, 0, arrFileSend, 1, length);
                //Отправка новый массив данных, содержащий флаг, на сервер
                socketClient.Send(arrFileSend);
            }
        }

        void ShowMsg(string msg)
        {
            txtMsg.AppendText(msg + "\r\n");
        }

        /// <summary>
        /// Получение сообщений с сервера
        /// </summary>
        void ReceiveMsg()
        {
            while (true)
            {
                //Буфер для получения сообщений
                byte[] arrMsgRev = new byte[1024 * 1024 * 2];
                //Сохраниение полученных данных в массив и получение фактической длины данных
                int length = -1;
                try
                {
                    length = socketClient.Receive(arrMsgRev);
                }
                catch (SocketException ex)
                {
                    ShowMsg("An exeption: " + ex.Message);
                    break;
                }
                catch (Exception ex)
                {
                    ShowMsg("An exeption: " + ex.Message);
                    break;
                }

                //Преобразование элементов массива в строку
                string strMsgReceive = Encoding.UTF8.GetString(arrMsgRev, 0, length);
                ShowMsg(string.Format("{0} said：{1}", socketClient.RemoteEndPoint.ToString(), strMsgReceive));
            }
        }






    }
}
