using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationservice.TargetClass
{
    public  class Target:AbstructTarget
    {
        //这个方法是实现通知的方法
        public override void NotifyObserver(string name)
        {
            foreach (var item in list)
            {
                item.updateInfo();
            }
        }
    }
}
