using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_MVC_Lesson_3
{
    public class FixWorker : BaseClass
    {
        public override decimal MonthlySalary(decimal Rate)
        {
            decimal monthlySalary = Rate;
            return monthlySalary;
        }

        public void Print()
        {
            Console.WriteLine(employee[3] = $"{Name = "Женя"} / {TypeWorker = "Полная ставка"} / Зарплата = {MonthlySalary(35000)} руб.");
            Console.WriteLine(employee[4] = $"{Name = "Миша"} / {TypeWorker = "Полная ставка"} / Зарплата = {MonthlySalary(45000)} руб.");
            Console.WriteLine(employee[5] = $"{Name = "Оля"} / {TypeWorker = "Полная ставка"} / Зарплата = {MonthlySalary(50000)} руб.");
        }
    }
}
