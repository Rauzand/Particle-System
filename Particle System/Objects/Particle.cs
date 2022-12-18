using System;
using System.Drawing;

namespace Particle_System.Objects
{
    public class Particle
    {
        public int Radius; // радиус частицы
        public float X; // X координата положения частицы в пространстве
        public float Y; // Y координата положения частицы в пространстве

        public float SpeedX; // скорость перемещения по оси X
        public float SpeedY; // скорость перемещения по оси Y
        public float Life; // запас здоровья частицы

        public static Random rand = new();

        public Particle()
        {
            var direction = (float)rand.Next(360);
            var speed = 1 + rand.Next(10);

            // рассчитываем вектор скорости
            SpeedX = MathF.Cos(direction / 180 * MathF.PI) * speed;
            SpeedY = -MathF.Sin(direction / 180 * MathF.PI) * speed;

            Radius = rand.Next(2, 12);
            Life = rand.Next(20, 120);
        }
    }
}
