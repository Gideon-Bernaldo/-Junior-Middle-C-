using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigure
{
    public class Circle : Figure
    {
        float radius_;
        public float Radius { get => radius_; set => radius_ = value; }
        public Circle(float radius) => Radius = radius;
        public Circle(string enterNameFigure, float radius) : base(enterNameFigure) => Radius = radius;
        public override float GetArea() => (float)Math.Round(3.14f * Math.Pow(Radius, 2), 1);
    }
}
