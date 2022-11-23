using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri_4
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string cumle1 = "Merhaba \nDunya \nNasılsın";  // \n bir alt satıra geçirir
            Console.WriteLine(cumle1);

            string cumle2 = "Merhaba Dunya Nasılsın"; 
            Console.WriteLine(cumle2.ToUpper());  //ToUpper bütün karakterleri büyük harf yapar.

            string cumle3 = "MerhABA DUNYA NasılSın";
            Console.WriteLine(cumle3.ToLower()); //ToLower bütün karakteri küçük harf yapar.




            Console.ReadLine();
        }
    }
}
