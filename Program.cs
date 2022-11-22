using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
 // remove internal in order to make class visilbe anywhere not just in same assembly
    class Program
        {
            static void Main(string[] args)
            {
                Rectangle aRec = new Rectangle();

                Console.WriteLine("Width = {0}, Height = {1}", aRec.Width, aRec.Height);
                aRec.Width = 4;
                aRec.Height = 5;
                Console.WriteLine("Width = {0}, Height = {1}", aRec.Width, aRec.Height);

                Console.ReadKey();

                Square aSq = new Square(8);

                //must be .Len because it from IShape = newParents
                Console.WriteLine("Width = {0}, Height = {1}", aSq.Len, aSq.Len);
                Console.WriteLine("Area = {0}, Circumference = {1}", aSq.Area(), aSq.Circumference());

                Console.ReadKey();
            }
        }

    }


