using CursoNelioAula1450.Entities.Enums;

namespace CursoNelioAula1450.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();  
                      

    }

}
