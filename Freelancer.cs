using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_MVC_Lesson_3
{
    public class Freelancer : BaseClass
    {
        public override decimal MonthlySalary(decimal Rate)
        {
            decimal monthlySalary = (decimal)20.8 * 8 * Rate;
            return monthlySalary;
        }
        public void Print()
        {
            Console.WriteLine(employee[0] = $"{Name = "Иван"} / {TypeWorker = "Фрилансер"} / Зарплата = {MonthlySalary(250)} руб.");
            Console.WriteLine(employee[1] = $"{Name = "Олег"} / {TypeWorker = "Фрилансер"} / Зарплата = {MonthlySalary(350)} руб.");
            Console.WriteLine(employee[2] = $"{Name = "Никита"} / {TypeWorker = "Фрилансер"} / Зарплата = {MonthlySalary(500)} руб.");
        }
    }
}
