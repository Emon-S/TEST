using MedWinfrom.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationservice.TargetClass
{
    //这里  文件保存数据的时候调用方法通知winform
    public abstract class AbstructTarget
    {
        protected IList<Iobserver> list = new List<Iobserver>();
        public void Join(Iobserver observer)
        {
            list.Add(observer);
            Console.WriteLine("Message");
        }
        public abstract void NotifyObserver(string name);
    }
}
