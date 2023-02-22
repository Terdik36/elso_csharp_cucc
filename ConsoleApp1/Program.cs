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
        // itt ez most megadja a konzolnak a tulajdonságait ha én okos elfelejteném
            Console.Title = "asdasd";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WindowHeight = 69;

        // és itt van a MEDZSIK!!44!!4!
            Console.WriteLine("helo guyz wazup xddd");
            Console.ReadLine();
            Console.WriteLine("ok akkor baszodj meg \nbudos nigger");       // a "\n" egy új sort csinál
            Console.ReadLine();
            Console.WriteLine("HOGY MERTÉL BESZÓLNI NEKEM TE BÜDÖS ROMÁN??????");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("jól van nem érdekelsz na most HÚZZÁKIFELÉ TE PEDOFAN6969696942069666");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WindowHeight = 69;
            Console.WriteLine("egyébként szerinted noahnak milyen jogai vannak? \nírd ide:");

        // variable szórakozás rafl
            string NoahJogai = Console.ReadLine();
            Console.WriteLine("Noah jogai: " + NoahJogai + "! talán helyes a válasz idfk");

            double num1;
            double num2;
            Console.WriteLine("");
            Console.WriteLine("matek kovetkezik rafl");

            Console.Write("agy egy szamót: ");                               // itt a matek szekció, a convert szükséges eléggé xd
            num1 = Convert.ToDouble( Console.ReadLine() );                   // össze fogja majd szorozni
            Console.Write("agy meg megegy szamót: ");
            num2 = Convert.ToDouble( Console.ReadLine() );

            double result = num1 * num2;
            Console.WriteLine("it van az ösesorzót szam: " + result);
            Console.WriteLine("");

            // chaleng
            Console.WriteLine("ITS AVERAGING TIMEEEEEEE");
            double avg1;
            double avg2;
            double avg3;
            Console.Write("első szám: ");
            avg1 = Convert.ToDouble( Console.ReadLine() );
            Console.Write("második szám: ");
            avg2 = Convert.ToDouble( Console.ReadLine() );
            Console.Write("harmadik szám: ");
            avg3 = Convert.ToDouble( Console.ReadLine() );

            double avgresult = avg1 + avg2 + avg3 / 3;
            Console.WriteLine("itt az átlag: kb " + avgresult);

            Console.Title = "itt a vége fuss el véle";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WindowHeight = 69;

            Console.WriteLine("nos hát itt a vége a programnak remélem tetszett xd");

            Console.ReadKey();

        }
    }
}
