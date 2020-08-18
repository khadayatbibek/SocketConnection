
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Json;
using System.Text;

using AnyLogicDataServerLib;

public class TestProgram
{
   
    public static void Main(String[] args)
    {
        Server srv = new Server();
        srv.StartServerInstance();

        do
        {
            AnyLogicPerson pers = srv.GetPerson();
            if (pers != null)
            {
                Console.WriteLine("ID:" + pers.ID);
                Console.WriteLine("Xpos:" + pers.Xpos);
                Console.WriteLine("Ypos:" + pers.Ypos);
                Console.WriteLine("Zpos:" + pers.Zpos);
                Console.WriteLine("OutPed:" + pers.OutPed);
                Console.WriteLine("timestmp:" + pers.timestmp);
                Console.WriteLine("FireAlarm:" + pers.FireAlarm);
                Console.WriteLine("PeopleInside:" + pers.PeopleInside);
                Console.WriteLine("EvacuationTime:" + pers.EvacuationTime);

            }
            else
            {
                
            }
        } while (true);

        //string tester = "{\"ID\":1876,\"OutPedestrsins\":0,\"Xpos\":\"256.1215747512619\",\"Ypos\":\"265.64445882606543\",\"Zpos\":\"0\",\"timestmp\":12.065217409969408}";
        //AnyLogicPerson pers = srv.Deserialize(tester);
    }
}
