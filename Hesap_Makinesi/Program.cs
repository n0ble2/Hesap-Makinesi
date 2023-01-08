using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Enter'a basınız!");
            string KD = Console.ReadLine();

            switch (KD)
            {
                case "":
                    Console.WriteLine("Lütfen değer giriniz...");
                    Console.WriteLine("");
                    Console.WriteLine("1: Toplama (+)");
                    Console.WriteLine("2: Çıkartma (-)");
                    Console.WriteLine("3: Bölme (÷)");
                    Console.WriteLine("4: Çarpma (x)");
                    Console.WriteLine();
                    string z = Console.ReadLine();
                    switch (z)
                    {
                        case "1":

                            break;

                        case "2":

                            break;
                        case "3":

                            break;
                        case "4":

                            break;
                        default:
                            Console.WriteLine("Yanlış işlem yaptınız..");
                            Environment.Exit(0);
                            break;
                    }

                    int zd = Convert.ToInt32(z);
                    Console.WriteLine("");
                    Console.WriteLine("İlk sayı değerini giriniz..");

                    string fv = "0";
                    ConsoleKeyInfo karakter;

                    do
                    {
                        karakter = Console.ReadKey(true);
                      
                        if (karakter.Key != ConsoleKey.Backspace)
                        {
                            double val = 0;
                            
                            bool kontrol = double.TryParse(karakter.KeyChar.ToString(), out val);
                            if (kontrol)
                            {
                                fv += karakter.KeyChar;
                                Console.Write(karakter.KeyChar);
                            }
                        }
                        else

                        {
                            if (karakter.Key == ConsoleKey.Backspace && fv.Length > 0)
                            {
                                fv = fv.Substring(0, (fv.Length - 1));
                                Console.Write("\b \b");
                            }
                        }
                    }

                    while (karakter.Key != ConsoleKey.Enter);
                    Console.WriteLine();
                    int fvd = Convert.ToInt32(fv);
                    switch (fv)
                    {
                        case "0":
                            Console.WriteLine("Yanlış değer girdiniz!");
                            Environment.Exit(0);
                            break;


                        default:

                            break;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("İkinci sayı değerini giriniz..");

                    string sv = "0";
                    ConsoleKeyInfo car;
                    do
                    {
                        car = Console.ReadKey(true);
                       
                        if (car.Key != ConsoleKey.Backspace)
                        {//
                            double val = 0;
                          
                            bool kontrol = double.TryParse(car.KeyChar.ToString(), out val);
                            if (kontrol)
                            {
                                sv += car.KeyChar;
                                Console.Write(car.KeyChar);
                            }
                        }
                        else
                        
                        {//
                            if (car.Key == ConsoleKey.Backspace && sv.Length > 0)
                            {
                                sv = sv.Substring(0, (sv.Length - 1));
                                Console.Write("\b \b");
                            }
                        }
                    }
                    // Enter a basıldığında döngüden çıkıyoruz
                    while (car.Key != ConsoleKey.Enter);
                    Console.WriteLine();

                    int svd = Convert.ToInt32(sv);
                    switch (fv)
                    {
                        case "0":
                            Console.WriteLine("Yanlış değer girdiniz!");
                            Environment.Exit(0);
                            break;


                        default:

                            break;
                    }

                    switch (zd)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Sonuç: " + (fvd + svd));
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Sonuç: " + (fvd - svd));
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("Sonuç: " + (fvd / svd));
                            break;
                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("Sonuç: " + (fvd * svd));
                            break;
                        default:
                            Console.WriteLine("Yanlış karakter kullandınız..");
                            Environment.Exit(0);
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Yanlış işlem yaptınız!");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}