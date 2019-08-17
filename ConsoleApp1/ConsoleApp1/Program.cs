using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin:");
            var cavab1 = Console.ReadLine();
            Console.WriteLine("Xos Geldiniz:" + " " + cavab1);
            Console.WriteLine("Telebesiniz?");
            var cavab2 = Console.ReadLine();
            if (cavab2 == "He" || cavab2 == "he" || cavab2 == "HE" || cavab2 == "Beli" || cavab2 == "BELI")
            {
                Console.WriteLine("Hansi Universitetde Oxuyursuz?");
                var he1 = Console.ReadLine();
                Console.WriteLine("Ixtisas adiniz nedir?");
                var he2 = Console.ReadLine();
                Console.WriteLine("1-den 100-e qeder tek ededlerin cemini hesabla:");
                int sum = 0;
                for (var i = 1; i < 100; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum = sum + i;
                    }
                }
                Console.WriteLine(sum);
                Console.WriteLine("Tesekkur edirik " + cavab1 + " sen " + he1 + "-de oxuyursan, " + he2 + " tehsili alirsan ve 1-den 100-e qeder tek ededlerin ceminin " + sum + " oldugunu bilirsen" );
            }
            else{
                Console.WriteLine("Isleyirsiniz?");
                var yox1 = Console.ReadLine();
                if(yox1 == "He" || yox1 == "he" || yox1 == "HE" || yox1 == "Beli" || yox1 == "BELI")
                {
                    Console.WriteLine("Harda isleyirsiniz?");
                    var yox3 = Console.ReadLine();
                    Console.WriteLine("Vezifeniz?");
                    var yox4 = Console.ReadLine();
                    Console.WriteLine("1-den 100-e qeder tek ededlerin cemini hesabla:");
                    int sum = 0;
                    for (var i = 1; i < 100; i++)
                    {
                        if (i % 2 == 1)
                        {
                            sum = sum + i;
                        }
                    }
                    Console.WriteLine(sum);
                    Console.WriteLine("Tesekkur edirik " + cavab1 + " sen " + yox3 + "-de " + yox4 + " vezifesinde isleyirsen, ve 1-den 100-e qeder tek ededlerin ceminin " + sum + " oldugunu bilirsen");
                }
                else
                {
                    int sum2 = 0;
                    for(var j = 0; j<200; j++)
                    {
                        if (j % 3 == 0 && j % 2 == 0)
                        {
                            sum2 = sum2 + j;
                        }
                    }
                    Console.WriteLine("Boyuk ehtimalla sen sagirdsen, buna baxmayaraq 1-den 200-e qeder olan 3-e bolunen cut ededlerin ceminin " + sum2 + " oldugunu bilirsen");
                }
            }
        }
    }
}
