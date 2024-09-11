using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigure
{
    public abstract class Figure
    {
        string name;
        public string Name { get => name; set => name = value; }
        public Figure() { }
        public Figure(string enterNameFigure) => Name = enterNameFigure;
        public static float GetArea(Figure figure) => figure.GetArea();
        public override string ToString() => $"Фигура: {Name}";
        public abstract float GetArea();
    }
}
