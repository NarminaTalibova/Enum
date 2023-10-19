namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("AZN daxil edin:");
            //double azn = Convert.ToDouble(Console.ReadLine());

            //// valyuta seçimi
            //Console.WriteLine("Valyuta seçin:");
            //Console.WriteLine("1. Usd - Dollar");
            //Console.WriteLine("2. Eur - Yevro");
            //Console.WriteLine("3. Try - Türk lirası");
            //Console.WriteLine("4. Rub - Rubl");


            //int choice = Convert.ToInt32(Console.ReadLine());
            //Currency currency;

            //switch (choice)
            //{
            //    case 1:
            //        currency = Currency.Usd;
            //        break;
            //    case 2:
            //        currency = Currency.Eur;
            //        break;
            //    case 3:
            //        currency = Currency.Tryl;
            //        break;
            //    case 4:
            //        currency = Currency.Rub;
            //        break;
            //    default:
            //        currency = Currency.Usd;
            //        break;
            //}
            //// ConvertAZN methodu çağırılır
            //double result = ConvertAZN(currency, azn);
            //// Nəticə göstərilir
            //Console.WriteLine($"{azn} AZN = {result} {currency}");





            // 100 AZN-ni müxtelif valyutalara çeviririk
            double usd = ConvertAZN(Currency.Usd, 100); 
            double eur = ConvertAZN(Currency.Eur, 100); 
            double tryl = ConvertAZN(Currency.Tryl, 100); 
            double rub = ConvertAZN(Currency.Rub, 100); 

            // Neticeleri konsola cap edirik
            Console.WriteLine("100 AZN = :");
            Console.WriteLine("{0:0.00} USD", usd);
            Console.WriteLine("{0:0.00} EUR", eur);
            Console.WriteLine("{0:0.00} TRYL", tryl);
            Console.WriteLine("{0:0.00} RUB", rub);

        }




        public static double ConvertAZN(Currency currency, double azn)
        {

            const double UsdRate = 1.7;
            const double EurRate = 1.79;
            const double TrylRate = 0.19;
            const double RubRate = 0.02;


            switch (currency)
            {
                case Currency.Usd:
                    return azn * UsdRate;
                case Currency.Eur:
                    return azn * EurRate;
                case Currency.Tryl:
                    return azn * TrylRate;
                case Currency.Rub:
                    return azn * RubRate;
                default:
                    return 0;
            }
        }
    }
}

    
