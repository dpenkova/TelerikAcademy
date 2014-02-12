using System;
using System.Text;

namespace Humans
{
    public class Worker : Human
    {
        public decimal WeekSalary { get; set; }
        public decimal WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public Worker(string name, string lastName, decimal weekPay, decimal workHours)
            : base(name, lastName)
        {
            if (weekPay <= 0 )
            {
                throw new ArgumentException("Week salary should be a positive number.");
            }

            if (workHours <= 0)
            {
                throw new ArgumentException("Work hours per day should be a positive number.");
            }

            this.WeekSalary = weekPay;
            this.WorkHoursPerDay = workHours;
        }

        public override string ToString()
        {
            StringBuilder workerInfo = new StringBuilder();
            workerInfo.AppendFormat("{0} - {1: 0.00} per hour", base.ToString(), this.MoneyPerHour());
            return workerInfo.ToString();
        }
    }
}

