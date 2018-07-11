using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    class Ticket
    {
        private int _distance;
        private decimal _price;

        public int Distance
        {
            get {
                
                return _distance;
            }
        }
        public decimal Price
        {
            get {
                if (this.Distance >=0 && this.Distance <= 100)
                {
                    return this.Distance * 1;
                }
                else if (this.Distance > 100 && this.Distance <= 200)
                {
                    return (decimal)(this.Distance * 1 * 0.95);
                }
                else if (this.Distance > 200 && this.Distance <= 300)
                {
                    return (decimal)(this.Distance * 1 * 0.9);
                }
                else
                {
                    return (decimal)(this.Distance * 1 * 0.8);
                }
            }

        }

        public Ticket(int distance)
        {
            if (distance < 0)
            {
                _distance = 0;
            }
            else
            {
                _distance = distance;
            }
        }

        ~Ticket()
        {
            Console.WriteLine("类{0}凉凉了", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);
            Console.ReadKey();

        }
    }
}
