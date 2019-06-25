using MedWinfrom.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedWinfrom.Observer
{
    public interface Iobserver
    {
         void updateInfo(AllyControlCenter abstructTarget);
         void beinsertedData();
    }
}
