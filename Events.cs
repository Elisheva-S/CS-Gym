using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    internal class Events
    {
        public delegate void TimeOutDel(int time);
        public event TimeOutDel TimeOutHandler;
        public void Run()
        {
            //broadcast events to all listeners
            if(TimeOutHandler != null)
                TimeOutHandler(1200);
        }
    }
    public class Operate
    {
        Events events=new Events();
        DB db=new DB();
        UI ui=new UI();
        public void Init()
        {
            events.TimeOutHandler += db.UpdateDBAfterTimeOut;
            events.TimeOutHandler += ui.UpdateUIAfterTimeOut;
            events.Run();
            //unregister from broadcast list
            events.TimeOutHandler -= ui.UpdateUIAfterTimeOut;
            events.Run();
        }
    public class DB
    {
        public void UpdateDBAfterTimeOut(int time)
        {

        }
    }
    public class UI
    {
        public void UpdateUIAfterTimeOut(int time)
        {

        }
    }
}
