using MultiProjectEventHandler;

namespace MultiProjectEventHanlder.Main
{
    public class Sample
    {
        public Sample()
        {
            Handler.Add("eventname", OnEvent);
        }

        public void OnEvent(dynamic eventdata)
        {
            //do something with the payload
        }
    }
}
