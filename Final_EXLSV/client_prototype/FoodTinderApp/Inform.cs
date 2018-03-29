using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace FoodTinderApp
{
    static class Inform
    {
        static Socket m_socClient;
        static IPAddress ip;
        static int iPortNo;
        static IPEndPoint ipEnd;
        static byte[] msg = new byte[15];
        static string msgText = "";

        static public void OpenConn()
        {
            try
            {
                m_socClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ip = IPAddress.Parse(User.IP);
                iPortNo = System.Convert.ToInt32(9999);
                ipEnd = new IPEndPoint(ip.Address, iPortNo);
                m_socClient.Connect(ipEnd);
            } catch (Exception) { MessageBox.Show("No connection to the server!"); }
        }

        static public void SendSome(string message)
        {
            try
            {
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(message);
                m_socClient.Send(byData);
            }
            catch (Exception)
            {
                MessageBox.Show("No connection to the server!");
            }
        }

            static public void CloseConn()
        {
            try
            {
                m_socClient.Close();
            }
            catch (Exception) { MessageBox.Show("No connection to the server!"); }
        }

        static public string RecieveMessage()
        {
            try
            {
                m_socClient.Receive(msg);
                msgText = String.Join("", msg.ToList().Select(x => (char)x));
                return msgText;
            } catch (Exception) { MessageBox.Show("No connection to the server!"); return "1"; }
}
    }
}
