using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedWinfrom.Target
{
    public class ConcreteAllyControlCenter:AllyControlCenter
    {
        public ConcreteAllyControlCenter(string allyName)
        {
            Console.WriteLine("system info：{0} team build success！", this.AllyName);
            Console.WriteLine("-------------------------------------------------------");
            this.AllyName = allyName;
        }

        // 实现通知方法
        public override void NotifyObserver(string playerName)
        {
            Console.WriteLine("Message：browers，{0} was being attaced by others，please help！", playerName);
            playerList.First().beinsertedData();
        }
    }
}
