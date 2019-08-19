using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TherapyBuddy.Classes
{
    public class Appointment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Service { get; set; }
        public int ClientID { get; set; }

        public Appointment(int id, string name, string startTime, string endTime, string service, int clientID)
        {
            ID = id;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            Service = service;
            ClientID = clientID;
        }

    }
}
