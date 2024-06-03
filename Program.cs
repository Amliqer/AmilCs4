using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace Amil_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число от 0 до 9:");     
            string input1 = Console.ReadLine();
            try {
                int number = Convert.ToInt32(input1);
                if (number < int.MinValue || number > int.MaxValue)
                { 
                    throw new 
                        
                        OverflowException("число вышло за рамки"); 
                }
                Console.WriteLine("преобразованное число" + number); 
            }
            catch (FormatException)
            {
                Console.WriteLine("не явялется числом");
            }
            catch (OverflowException ex)
            {  
                Console.WriteLine(ex.Message);
            }






            Console.WriteLine("введите число от 0 до 9:"); 
            string input2 = Console.ReadLine();
            try
            {
                float number = Convert.ToSingle(input2);
                if (number < int.MinValue || number > int.MaxValue)
                {
                    throw new
   OverflowException("число вышло за рамки");
                }
                Console.WriteLine("преобразованное число" + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("не явялется числом");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Введите математическое выражение (например, 3*2*1*4):"); string input = Console.ReadLine();
            try
            {
                string[] tokens = input.Split('*');
                int result = Convert.ToInt32(tokens[0]);
                for (int i = 1; i < tokens.Length; i++)
                {
                    result *= Convert.ToInt32(tokens[i]);
                }
                Console.WriteLine("Результат выражения: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода: " + ex.Message);
            }

        }
        class CreditCard
        {
            private string cardNumber; private string fullName;
            private int cvc; private DateTime expiryDate;
            public CreditCard(string cardNumber, string fullName, int cvc, DateTime expiryDate)
            {
                if (string.IsNullOrEmpty(cardNumber) || cardNumber.Length != 16)
                    throw new ArgumentException("Invalid card number");
                if (string.IsNullOrEmpty(fullName)) throw new ArgumentException("Invalid full name");
                if (cvc.ToString().Length != 3)
                    throw new ArgumentException("Invalid CVC");
                if (expiryDate < DateTime.Today) throw new ArgumentException("Invalid expiry date");
                this.cardNumber = cardNumber;
                this.fullName = fullName; this.cvc = cvc;
                this.expiryDate = expiryDate;
            }

        }
    }
}