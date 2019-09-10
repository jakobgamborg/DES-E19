using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace System.Net.IPAddress;

public class Server
{
    public class Run {

        
        private IPAdress ipAdress  { get; set; }
        private int port { get; set; }
        public TcpListener listen { get; set; }
        public Socket socket { get; set; }

        internal Run() {
            try{
                ipAddress = IPAddress.Parse("127.0.0.1");
                listen = new TcpListener(ipAddress, 8888);
                listen.Start();
                Console.WriteLine("Server: open port 8888.... ");
                Console.WriteLine("End point is :" + listen.LocalEndpoint);
                socket = listen.AcceptSocket();


                Output();
                }
                catch (SocketException e) 
                { 
                    Console.WriteLine("you fuckd up \n" + e );
                }
        }
  /*       internal Run(IPAddress iPAddress, int port) {
                ipAddress = IPAddress.Parse(iPAddress);
                listen = new TcpListener(ipAddress, port);
                listen.Start();
                Console.WriteLine("Server: open port " + port + " ...");
                Console.WriteLine("End point is :" + listen.LocalEndpoint);
                socket = listen.AcceptSocket();
                Output();
        }
*/
        public void Output() {
                    while (true)
        {
            var information = new StringBuilder();
                byte[] info = new byte[100];
                int x = s.Receive(info);
                for (int i = 0; i < x; i++)
                    {
                    information.Append(Convert.ToChar(info[i]));
                    }
                Console.Write(information);
                ASCIIEncoding asciiData = new ASCIIEncoding();
                socket.Send(asciiData.GetBytes("Message recieved by the server."));
                Console.WriteLine("\nAcknowledgement Sent");
                socket.Close();
                listen.Stop();
        }
        }
        
    }
    public static void Main()
    {    
       Run run = new Run();
    }

}

