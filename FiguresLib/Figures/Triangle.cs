namespace FiguresLib.Figures
{
    public class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            A = a; 
            B = b; 
            C = c; 
        }
        public override double GetArea()
        {
            // Checking is triangle rectangle
            bool isRectangular = IsRectangular();

            // Perimetr
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        /// <summary>
        /// Check if triange is rectangular
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            double max = 0;

            max = A;
            if (B > A)
            {
                max = B;
                if (B * B == A * A + C * C)
                    return true;
            }
            if (C > max)
            {
                max = C;
                if (C * C == A * A + B * B)
                    return true;
            }

            if (A * A == B * B + C * C)
                return true;

            return false;
        }
    }
}
