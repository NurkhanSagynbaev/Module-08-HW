using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08_HW
{
    using System;

    class UtilityPaymentsCalculator
    {
        public static void Main()
        {
            double heatingRate = 5.0;
            double waterRate = 2.0; 
            double gasRate = 3.0;
            double repairRate = 1.5; 

            Console.WriteLine("Введите метраж помещения:");
            double area = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество проживающих людей:");
            int numberOfResidents = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите сезон (1 - лето, 2 - осень/зима):");
            int seasonChoice = Convert.ToInt32(Console.ReadLine());
            bool isWinter = (seasonChoice == 2);

            Console.WriteLine("Есть ли льготы? (1 - Да, 2 - Нет):");
            int discountChoice = Convert.ToInt32(Console.ReadLine());
            double discountPercentage = 0.0;

            if (discountChoice == 1)
            {
                Console.WriteLine("Выберите категорию льготы (1 - ветеран труда, 2 - ветеран войны):");
                int categoryChoice = Convert.ToInt32(Console.ReadLine());

                if (categoryChoice == 1)
                {
                    discountPercentage = 0.3;
                }
                else if (categoryChoice == 2)
                {
                    discountPercentage = 0.5;
                }
            }

            double heatingPayment = area * heatingRate;
            double waterPayment = numberOfResidents * waterRate;
            double gasPayment = numberOfResidents * gasRate;
            double repairPayment = area * repairRate;

            if (isWinter)
            {
                heatingPayment *= 1.2; 
            }

            double totalAmount = heatingPayment + waterPayment + gasPayment + repairPayment;

            double discountAmount = totalAmount * discountPercentage;
            double discountedTotal = totalAmount - discountAmount;
            Console.WriteLine("Вид платежа\tНачислено\tЛьготная скидка\tИтого");
            Console.WriteLine($"Отопление\t{heatingPayment:C}\t{discountAmount:C}\t{heatingPayment - discountAmount:C}");
            Console.WriteLine($"Вода\t\t{waterPayment:C}\t{discountAmount:C}\t{waterPayment - discountAmount:C}");
            Console.WriteLine($"Газ\t\t{gasPayment:C}\t{discountAmount:C}\t{gasPayment - discountAmount:C}");
            Console.WriteLine($"Ремонт\t\t{repairPayment:C}\t{discountAmount:C}\t{repairPayment - discountAmount:C}");

            Console.WriteLine($"Итоговая сумма: {discountedTotal:C}");
        }
    }

}
