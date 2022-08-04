namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Wpisz figurę");
          string Figure = Console.ReadLine();
          if(Figure == "Trójkąt" || Figure == "trójkąt")
          {
            Traingle();
          }
          else if(Figure == "Kwadrat" || Figure == "kwadrat")
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
          //hight
          Console.WriteLine("Podaj Wysokość");
          float hight = Convert.ToSingle(Console.ReadLine());
          
          Console.WriteLine("Pole/Obwód");
          string calculation = Console.ReadLine();
          if(calculation == "Pole")
          {
            Console.WriteLine((side_1*hight)/2);
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
          
          Console.WriteLine("Pole/Obwód");
          string calculation = Console.ReadLine();
          if(calculation == "Pole")
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