using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_MVC_Lesson_3
{
    public abstract class BaseClass
    {
        public string Name { get; set; }
        public string TypeWorker { get; set; }

        public abstract decimal MonthlySalary(decimal Rate);

        public string[] employee = new string[6];
    }
}
