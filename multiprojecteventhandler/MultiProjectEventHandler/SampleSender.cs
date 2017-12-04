using System;
using System.Collections.Generic;
using System.Text;

namespace MultiProjectEventHandler
{
    public class SampleSender
    {
        public void SendDataToMain()
        {
            Handler.Fire("eventname", null); //replace eventname & null with your data
        }
    }
}
