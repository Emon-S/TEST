using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationservice
{
    public class SaveFile
    {
        private string Path { get; set; }
        private DateTime CurrentDate { get; set; }
        private string fileName = "";
        public void CreateorWritefile(string content)
        {
            content = content + "  SplitFlag+\n";
            Path = "C:/MedicineRequestFolder/medicine"; 
            CurrentDate = DateTime.Now;
            fileName = "medicine" + CurrentDate.Year + CurrentDate.Month + CurrentDate.Day + ".txt";
            if (!File.Exists(fileName))
            {
                FileStream fs = new FileStream(Path, FileMode.CreateNew);
                byte[] info = Encoding.UTF8.GetBytes(content);
                fs.Write(info, 0, info.Length);
                fs.Dispose();
                fs.Close();
            }
            else
            {
                FileStream fs = new FileStream(Path, FileMode.Append);
                byte[] info = Encoding.UTF8.GetBytes(content);
                fs.Write(info, 0, info.Length);
                fs.Dispose();
                fs.Close();
            }
        }
    }
}
