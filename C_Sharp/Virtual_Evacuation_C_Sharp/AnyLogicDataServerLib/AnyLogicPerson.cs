using System;

using System.Runtime.Serialization;


namespace AnyLogicDataServerLib
{
    [DataContract]
    public class AnyLogicPerson
    {

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Xpos { get; set; }

        [DataMember]
        public string Ypos { get; set; }

        [DataMember]
        public string Zpos { get; set; }

        [DataMember]
        public int OutPed { get; set; }

        [DataMember]
        public Double timestmp { get; set; }

        [DataMember]
        public int FireAlarm { get; set; }

        [DataMember]
        public string PeopleInside { get; set; }
        [DataMember]
        public string EvacuationTime { get; set; }




        public void AnylogicPerson(int ID, string Xpos, string Ypos,string Zpos, int OutPed,double timestmp,int FireAlarm,string PeopleInside,string EvacuationTime)
        {
            this.ID = ID;
            this.Xpos = Xpos;
            this.Ypos = Ypos;
            this.Zpos = Zpos;
            this.OutPed = OutPed;
            this.timestmp = timestmp;
            this.FireAlarm = FireAlarm;
            this.PeopleInside = PeopleInside;
            this.EvacuationTime = EvacuationTime;
        }

        public void AnylogicPerson()
        {

        }



        public void Print()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Xpos:" + Xpos);
            Console.WriteLine("Ypos." + Ypos);
            Console.WriteLine("Zpos."+ Zpos);
            Console.WriteLine("OutPed." + OutPed);
            Console.WriteLine("timestmp." + timestmp);
            Console.WriteLine("FireAlarm." + FireAlarm);
            Console.WriteLine("PeopleInside." + PeopleInside);
            Console.WriteLine("EvacuationTime." + EvacuationTime);
            Console.WriteLine();
            Console.WriteLine();
            
        }

       
    }
}
