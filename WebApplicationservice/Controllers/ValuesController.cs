using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedWinfrom;
using MedWinfrom.Observer;
using MedWinfrom.Target;
using Microsoft.AspNetCore.Mvc;
using WebApplicationservice.TargetClass;

namespace WebApplicationservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values   test
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            string connetionString = "Data Source = DLC5CG82627CPLH\\sql2014;Database=medicine_db;Persist Security Info=True;Integrated Security=SSPI;";
            DBHelper dBHelper = new DBHelper(connetionString);
            string sql = string.Format("insert into ApplyInfo values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", value, "1", "12", "t", "1", "S", DateTime.Now);
            var A = dBHelper.ExcuteSQL(sql);
            SaveFile saveFile = new SaveFile();
            saveFile.CreateorWritefile(value);
        }

    }
}
