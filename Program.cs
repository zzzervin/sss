using System;

namespace Uss_Mangi
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');// отправляют аргументы в конструктор Point в классе Point

            p1.Draw();//Выводет данные из метода Draw в классе Point

            Point p2 = new Point(4, 5, '*');
            
            p2.Draw();
          
            Console.ReadLine();
        }

      
    }
}
