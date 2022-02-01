namespace Urok1
{
    public class Body
    {
        public double x1 { get; set; } = 0;
        public double y1 { get; set; } = 0;

        public Body(double x1, double y1)
        {
           this.x1 = x1;
           this.y1 = y1;
        }

        public double Area()
        {
            return x1 * x1 * y1 * y1;
        }

        public string Print()
        {
            return $"{x1 * x1 * y1 * y1}";
            //return $"x1:{x1}, y1:{y1}";
        }
    }
}