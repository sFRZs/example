using System;

namespace Example2._1
{
    /*abstract*/ class A
    {
         public void Doit()
        {
            Console.Write("Do some work");
        }
        /*public abstract void xyz();// creating a signature with abstract*/
    }
    //class B is A
    class B : A
    {
        public void Test1()
        {
            Doit();
            Console.WriteLine("Try to do somthing");
        }

      /*  public override void xyz()
        {
            throw new NotImplementedException();
        }*/
    }
    // class C has a class A
    class C
    {
       private A a = new A();//when declaring abstract there will be an error
        public void Test2()
        {
            a.Doit();
            Console.WriteLine("Try to do somthing");
        }
    }
    class Program
    {
        static void xyz(A a)
        {
            a.Doit();
           /* a.xyz();// with abstract*/
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            B b = new B();
            C c = new C();
            c.Test2();
            b.Test1();
            xyz(b);
            /*xyz(c);// the argument is not passed because C cannot be assigned to A */
           /* A x = new B();
            x.Doit();*/
        }
    }
}
