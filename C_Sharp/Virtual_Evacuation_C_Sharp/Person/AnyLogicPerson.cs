using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace AnyLogicDataServerLib
{
    public class AnyLogicPerson
    {
       

        // private static DataContractJsonSerializer serializer =
        //    new DataContractJsonSerializer(typeof(AnyLogicPerson));



        public int ID { get; set; }
        public string Xpos { get; set; }
        public string Ypos { get; set; }

        public void AnylogicPerson(int ID, String Xpos, String Ypos)
        {
            this.ID = ID;
            this.Xpos = Xpos;
            this.Ypos = Ypos;
        }


        

        public void Print()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Xpos:" + Xpos);
            Console.WriteLine("Ypos." + Ypos);
            Console.WriteLine();
            Console.WriteLine();
        }

       /* public void Serialize(Stream outputStream)
        {
            serializer.WriteObject(outputStream, this);
        }

        public void Deserialize(Stream inputStream)
        {
           serializer.ReadObject(inputStream);
        }*/
    }
}
