using System.Collections.Generic;

namespace ConsoleApp1
{
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vector (int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        #region Adding
        //Вертає новий вектор який отримується в результаті суми векторів.
        public static Vector AddingVectors(Vector vector1, Vector vector2)
        {
            return new Vector((vector1.X + vector2.X), (vector1.Y + vector2.Y));
        }
        //Вертає новий вектор який отримується в результаті суми векторів (як параметр передаються n векторів).
        public static Vector AddingVectors(params Vector[] list)
        {
            int x_sum = 0, y_sum = 0;
            foreach (var element in list)
            {
                x_sum += element.X;
                y_sum += element.Y;
            }
            return new Vector(x_sum, y_sum);
        }
        //Вертає новий вектор який отримується в результаті суми векторів з переданої колекції векторів.
        public static Vector AddingVectors(List<Vector> list)
        {
            int x_sum = 0, y_sum = 0;
            foreach (var element in list)
            {
                x_sum += element.X;
                y_sum += element.Y;
            }
            return new Vector(x_sum, y_sum);
        }
        #endregion
        #region Product
        //Метод який вертає скалярний добуток двох векторів.
        public static int ScalarProductOfVectors(Vector vector1, Vector vector2)
        {
            return ((vector1.X * vector2.X) + (vector1.Y + vector2.Y));
        }
        //Метод який вертає скалярний добуток векторів (n веторів).
        public static int ScalarProductOfVectors(params Vector[] list)
        {
            int x_sum = 1, y_sum = 1;
            foreach (var element in list)
            {
                x_sum *= element.X;
                y_sum *= element.Y;
            }
            return x_sum + y_sum;
        }
        //Метод який вертає скалярний добуток векторів в колекції.
        public static int ScalarProductOfVectors(List<Vector> list)
        {
            int x_sum = 1, y_sum = 1;
            foreach (var element in list)
            {
                x_sum *= element.X;
                y_sum *= element.Y;
            }
            return x_sum + y_sum;
        }
        #endregion
        public override string ToString()
        {
            return $"\tX: {X}  Y: {Y}";
        }
    }
}
