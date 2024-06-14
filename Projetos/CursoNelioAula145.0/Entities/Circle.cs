using CursoNelioAula1450.Entities.Enums;

namespace CursoNelioAula1450.Entities
{
    class Circle : Shape
    {
        public  double Radius { get; set; }
        public Circle(double radius, Color color) : base(color) 
        {
        Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius;
        }

    }
}
