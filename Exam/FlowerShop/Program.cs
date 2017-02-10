using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolias = int.Parse(Console.ReadLine());
            var hyacinth = int.Parse(Console.ReadLine());
            var rose = int.Parse(Console.ReadLine());
            var cactus = int.Parse(Console.ReadLine());
            var presentPrice = double.Parse(Console.ReadLine());

            var money = (magnolias * 3.25) + (hyacinth * 4) + (rose * 3.5) + (cactus * 8);
            var totalMoney = money - (0.05 * money);
            var diff = Math.Abs(presentPrice - totalMoney);

            if (presentPrice <= totalMoney)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(diff));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(diff));
            }
        }
    }
}
