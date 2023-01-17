using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C_Sharp_prac
{
    interface IDrawingObject
    {
        void Draw();
    }

    class Line : IDrawingObject
    {
        public void Draw() { Console.WriteLine("Line"); }
    }

    class Rectangle : IDrawingObject
    {
        public void Draw() { Console.WriteLine("Rectangle"); }
    }

    public class interfaceInheritance
    {
        static void Main(string[] args)
        {
            // 인터페이스 자체는 new로 인스턴스화할 수 없지만, 인터페이스 배열은 가능하다.
            IDrawingObject[] instances = new IDrawingObject[] { new Line(), new Rectangle() };

            foreach (IDrawingObject item in instances) { item.Draw(); }

            IDrawingObject instance = new Line();
            instance.Draw();

            Array.Sort(instances);
        }

    }
}
