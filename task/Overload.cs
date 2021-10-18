using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_2
{
    public class Overload
    {
        //Task1
        /*public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload: int a={a}");
        }
        public void DisplayOverload(string s)
        {
            Console.WriteLine($"DisplayOverload: string s={s}");
        }
        public void DisplayOverload(string s, int a)
        {
            Console.WriteLine($"DisplayOverload: string s={s} int a={a}");
        }*/
        //---------------------------------------------------------------

        //Task 2
        /*
        private int _count = 0;
        *//*  public void Show(string s)
          {
              _count++;
              Console.WriteLine(s);
              Console.WriteLine($"metod Show called {_count} times");
          }*/
        //---------------------------------------------------------------

        // Task3

        /* private string _name = "Ilua";

         private void Display1(ref string x, ref string y)// by link
         {
             Console.WriteLine(_name);
             x = "ilua 1";
             Console.WriteLine(_name);
             y = "ilua 2";
             Console.WriteLine(_name);
             _name = "Ilua3";
         }
         private void Display2(out string x, out string y)//not by link
         {
             x = "vika";
             y="vika2";
         }
         public void Display3()
         {
             Display1(x: ref _name, y: ref _name);// by link
           //  Display1(_name, _name);// not by link because there is confusion
             Console.WriteLine(_name);
         }*/
        //---------------------------------------------------------------

        //Task 4
         public void Display()
         {
             DisplayOverload( 23,"ilua","vika","lida");
             DisplayOverload( 22,"ilua" );
             DisplayOverload( 26,"vika" );
             DisplayOverload( 23,"lida" );
             DisplayOverload( 250);
         }
         private void DisplayOverload(int a, params string[] parameterArray)
         {
             foreach(string str in parameterArray)
             {
                 Console.WriteLine($"{str} {a} \n");
             }
         }
        //-------------------------------------------------

        //Task5

    }
}
