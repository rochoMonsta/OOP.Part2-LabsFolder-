using System.Collections.Generic;

namespace ConsoleApp1
{
    class Arc
    {
        public int X_Degree { get; set; }
        public int Y_Degree { get; set; }
        public Arc() { }
        public Arc(int X_Degree, int Y_Degree)
        {
            this.X_Degree = X_Degree;
            this.Y_Degree = Y_Degree;
        }
        //метод який шукає замальовану частину.
        public Arc GetDrawPart(List<Arc> arcs, int count)
        {
            int X_MAX = 0, Y_MIN = 360;
            for (int i = 0; i < count; ++i)
            {
                int BothMax = arcs[i].X_Degree > arcs[i].Y_Degree ? arcs[i].X_Degree : arcs[i].Y_Degree;
                X_MAX = X_MAX > BothMax ? X_MAX : BothMax;

                int BothMin = arcs[i].X_Degree < arcs[i].Y_Degree ? arcs[i].X_Degree : arcs[i].Y_Degree;
                Y_MIN = Y_MIN < BothMin ? Y_MIN : BothMin;
            }
            return new Arc(X_MAX, Y_MIN);
        }
        public override string ToString()
        {
            return $"X: {X_Degree}; Y: {Y_Degree};";
        }
    }
}
