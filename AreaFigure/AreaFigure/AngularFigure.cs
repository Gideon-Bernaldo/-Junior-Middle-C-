using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigure
{
    public class AngularFigure : Figure
    {
        int height_;
        public int Height { get => height_; set => height_ = value; }
        /// <summary>
        /// Храним длину каждой стороны
        /// </summary>
        float[] sides_;
        public float[] Sides { get => sides_; set => sides_ = value; }

        public AngularFigure(params float[] sides)
        {
            if (IsExit(sides)) Sides = sides;
        }

        public AngularFigure(string enterNameFigure, params float[] sides) : base(enterNameFigure)
        {
            if (IsExit(sides)) Sides = sides;
        }

        bool IsExit(float[] sides)
        {
            if (sides.Length == 3)
            {
                if (sides[0] > (sides[1] + sides[2]) ||
                    sides[1] > (sides[0] + sides[2]) ||
                    sides[2] > (sides[0] + sides[1]))
                    throw new FiguresException($"Не существует треугольника, сумма 2-х сторон которого меньше длины 3-ей. Вы указали {sides[0]}, {sides[1]}, {sides[2]}");
            }


            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] <= 0) throw new FiguresException($"Длина стороны не может быть <= 0. Вы указали {sides[i]}, индекс {i}");
            }

            if (sides.Length <= 0) throw new FiguresException($"Необходимо указать хотя бы одну сторону. Вы указали {sides.Length}");

            return true;
        }

        public override float GetArea()
        {
            switch (Sides.Length)
            {
                case 1: return Sides[0] * Sides[0];
                case 2: return Sides[0] * Sides[1];
                case 3:
                    var perimeter = (Sides[0] + Sides[1] + Sides[2]) / 2;
                    return (float)Math.Sqrt(perimeter * (perimeter - Sides[0]) * (perimeter - Sides[1]) * (perimeter - Sides[2]));
                default: return default;
            }
        }

        public bool IsStraightTriangle() => (
            Sides[0] == Math.Sqrt(Math.Pow(Sides[1], 2) + Math.Pow(Sides[2], 2)) ||
            Sides[1] == Math.Sqrt(Math.Pow(Sides[0], 2) + Math.Pow(Sides[2], 2)) ||
            Sides[2] == Math.Sqrt(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2))) &&
            Sides.Length == 3;
    }
}
