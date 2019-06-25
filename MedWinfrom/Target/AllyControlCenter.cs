using MedWinfrom.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedWinfrom.Target
{
    public abstract class AllyControlCenter
    {
        public string AllyName { get; set; }
        protected IList<Iobserver> playerList = new List<Iobserver>();

        public void Join(Iobserver observer)
        {
            playerList.Add(observer);
            Console.WriteLine("Message：{0} join {1} team", "12", this.AllyName);
        }
        public void Quit(Iobserver observer)
        {
            playerList.Remove(observer);
            Console.WriteLine("Message：{0} exis {1} team", "12", this.AllyName);
        }
        // 声明抽象通知方法
        public abstract void NotifyObserver(string name);
    }
}
