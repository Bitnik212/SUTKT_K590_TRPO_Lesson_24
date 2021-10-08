using System;
using System.Windows;

namespace Variant_1.Model
{
    public class SquareEquation
    {
        public int calcSimpleExercise(string exercise)
        {
            MessageBox.Show("Решение сложных уровнение пока не реализованно");
            throw new NotImplementedException("Решение сложных уровнение пока не реализованно");
        }
        
        public string calc(int[] numbers)
        {
            var result = calcNumbers(numbers);
            if (result == null) return "Корней нет";
            else if (result[1] != null) return "x1 = " + result[0] + " x2 = " + result[1];
            else return "x1 = " + result[0] + " x2 = нет";
        }

        private double?[] calcNumbers(int[] numbers)
        {
            
            double x1;
            double? x2;
            double a = numbers[0], b = numbers[1], c = numbers[2], d = b * b - 4 * a * c;
            if(d < 0) return null;
            else{
                x1 = Math.Round((-b + Math.Sqrt(d)) / (2 * a), 2);
                if (d > 0) x2 = Math.Round((-b - Math.Sqrt(d)) / (2 * a), 2);
                else x2 = null;
            }
            return new double?[] {x1, x2};
        }
        
        
    }
}