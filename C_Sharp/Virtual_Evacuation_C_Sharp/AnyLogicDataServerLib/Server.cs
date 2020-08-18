using System;

using System.Text;


using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace AnyLogicDataServerLib
{

    public class Server
    {
        ConcurrentQueue<String> persons;
        

        public Server()
        {
            this.persons = new ConcurrentQueue<String>();
        }

        private static DataContractJsonSerializer deserializer = 
            new DataContractJsonSerializer(typeof(AnyLogicPerson));
        //Deserialize person from String
        private AnyLogicPerson Deserialize(string path)
        {
            var deserializerALP = new AnyLogicPerson();
            var per = new MemoryStream(Encoding.UTF8.GetBytes(path));
            deserializerALP = deserializer.ReadObject(per) as AnyLogicPerson;
            per.Close();
            per.Dispose();
            return deserializerALP;
        }

        public AnyLogicPerson GetPerson()
        {
            //Get last string from queue
            //Deserialize

            String personString;
            if (this.persons.TryDequeue(out personString))
            {
                return this.Deserialize(personString);

            }
            else
            {
                return null;
            }

        }

        private Task receiveTask;
        public void StartServerInstance()
        {
            this.receiveTask = new Task(this.Run);
            this.receiveTask.Start();
        }

        //    //=================================================================================================

        public string personString;
        public string dataStringMy;
        public string data = null;
        public byte[] buffer = new byte[2048];
        public bool telegramReceived = false;
        public int bytesRec;
        Socket serverListner;
        public int port = 9090;
        public string IpAddress = "127.0.0.1";
        Socket socketForClients;
        private void Run()
        {

            serverListner = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAddress), port);
            string dataString = null;

            try
            {

                serverListner.Bind(ep);
                serverListner.Listen(100);

                while (true)
                {
                    Console.WriteLine("Waiting for a Data...");

                    socketForClients = serverListner.Accept();

                    socketForClients.ReceiveTimeout = 1000;

                    while (!telegramReceived)
                    {
                        bytesRec = socketForClients.Receive(buffer);
                        
                        dataString += Encoding.ASCII.GetString(buffer, 0, bytesRec);
                        telegramReceived = dataString.IndexOf("\r\n") > -1;
                    }

                    if (telegramReceived)
                    {
                        this.persons.Enqueue(dataString);
                        dataString = null;
                        telegramReceived = false;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
