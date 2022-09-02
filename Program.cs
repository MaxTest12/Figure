using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Wpisz figurę");
          string Figure = Console.ReadLine();
          if(Figure.Equals("Trójkąt",StringComparison.InvariantCultureIgnoreCase))
          {
           Traingle();
          }
          else if(Figure.Equals("Kwadrat",StringComparison.InvariantCultureIgnoreCase))
          {
            Sqaure();
          }
        }
        static void Traingle()
        {
          //First side
          Console.WriteLine("Podaj pierwszy bok");
          float side_1 = Convert.ToSingle(Console.ReadLine());
          //Second side
          Console.WriteLine("Podaj Drugi bok");
          float side_2 = Convert.ToSingle(Console.ReadLine());
          //third side
          Console.WriteLine("Podaj Trzeci bok");
          float side_3 = Convert.ToSingle(Console.ReadLine());
          
          Console.WriteLine("1.Pole");
          Console.WriteLine("2.Obwód");
          string calculation = Console.ReadLine();
          if(calculation == "1")
          {
            Console.WriteLine((side_1 + side_2  + side_3)/2);
          }
          else
          {
            Console.WriteLine(side_1+side_2+side_3);
          }
        }
        static void Sqaure()
        {
          Console.WriteLine("Podaj  bok");
          float side_1 = Convert.ToSingle(Console.ReadLine()); 

          Console.WriteLine("1.Pole");
          Console.WriteLine("2.Obwód");
          string calculation = Console.ReadLine();
          if(calculation == "1")
          {
            Console.WriteLine(side_1*side_1);
          }
          else
          {
            Console.WriteLine(side_1*4);
          }   
        }
    }
}