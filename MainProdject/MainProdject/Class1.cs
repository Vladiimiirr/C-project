using System;

namespace SquareFigures
{
    public static class Squeare
    {
        //вычисление площади кргуга
        public static double AreaCircle(double circleRadios)
        {
            Console.WriteLine("Площадь круга");
            return Math.PI*Math.Pow(circleRadios, 2);
        }

        public static double AreaTriangle(double sideA, double sideB, double sideC)
        {
            //проверка на существование треугольника
            if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB)
            {
                double perimeterTriangle = (sideA + sideB + sideC) / 2;

                double res = perimeterTriangle * (perimeterTriangle - sideA) *
                    (perimeterTriangle - sideB) * (perimeterTriangle - sideC);
                
                if (res >= 0) 
                { 
                    res = Math.Sqrt(res);
                    Rectangle(sideA, sideB, sideC);
                }
                Console.WriteLine("Площадь треугольника");
                return res;
            }

            else
            {
                
                if (sideA < 0 && sideB < 0 && sideC < 0)
                {
                    Console.WriteLine("Значение сторон должны быть положительными!");
                }
                else 
                {
                    Console.WriteLine("Сумма двух сторон должна быть больше третьей стороны!");
                }
                
                return 0;
            }
        }
            //проверка треугольника на прямой угол
        public static void Rectangle(double sideA, double sideB, double sideC)
        {
            double rectangleAB = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
            double rectangleBC = Math.Pow(sideB, 2) + Math.Pow(sideC, 2);
            double rectangleCA = Math.Pow(sideC, 2) + Math.Pow(sideA, 2);

            if (Math.Pow(sideC, 2) == rectangleAB && sideA!=0 && sideB !=0 && sideC != 0) 
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            if (Math.Pow(sideC, 2) == rectangleBC && sideA != 0 && sideB != 0 && sideC != 0)
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            if (Math.Pow(sideC, 2) == rectangleCA && sideA != 0 && sideB != 0 && sideC != 0)
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
        }
    }
}
