using System;
using static System.Console;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace Week14HW
{
     class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the my cake order shop");
            WriteLine("You will be ordering a cake and choosing a design and decoration for the cake");

            char moreItems = 'y';
            int counter = 0;
            List<Orders> orders = new List<Orders>();

            while (moreItems == 'y')
            { 
                WriteLine("Lets get the items for order {0}", counter + 1);

                collectOrder(ref orders);
                counter++;
                WriteLine("would you like to continue y/n");
                moreItems = Convert.ToChar(ReadLine());
                               
            }
            WriteLine("{0,-15}{1,-20},{2,-20}", "NAME", "DESIGN", "DECORATION");

            foreach (Orders o in orders)
            {
                WriteLine("{0,-15}{1,-20},{2,-20}", o.OrderName, o.OrderDesign, o.OrderDecortation);


            }

            ReadKey();


            static void collectOrder (ref List<Orders> orders) 
            { 
                var listOfDesign = File.ReadLines("Design.csv").Select(Line => new  Design(Line)).ToList();
                var listOfDecorations = File.ReadLines("Decorations.csv").Select(Line => new Decoration(Line)).ToList();
                
                WriteLine("Give me a name for this order");
                string name = ReadLine();

                WriteLine("Which Design do you want?");
                foreach (Design f in listOfDesign) 
                {
                    WriteLine($"{f.DesignID}\t{f.DesignName}");

                }
                int a = Convert.ToInt32(ReadLine());
                string design = listOfDesign[a - 1].DesignName;

                WriteLine("Which decoration do you want?");
                foreach (Decoration t in listOfDecorations)
                {
                    WriteLine($"{t.DecorationID}\t{t.DecorationName}");
                              
                }
                int b = Convert.ToInt32(ReadLine());
                string decoration = listOfDecorations[b - 1].DecorationName;

                orders.Add(new Orders(name, design, decoration));
            
            
            }

        }
    }
}
