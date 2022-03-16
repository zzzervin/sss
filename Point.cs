using System;
using System.Collections.Generic;
using System.Text;

namespace Uss_Mangi
{
    class Point
    {

        public int x;
        public int y;
        public char sym;

        public Point() { }

        public Point(int _x, int _y, char _sym)//конструктор приравнивает _x,  _y,  _sym к   x, y, sym
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
