using System;
using System.Collections.Generic;
using System.Drawing;

namespace Particle_System.Objects
{
    public class Emitter
    {
        public List<Particle> particles = new();

        public int X; // координата X центра эмиттера
        public int Y; // координата Y центра эмиттера
        public int Direction = 0; // вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 360; // разброс частиц относительно Direction
        public int SpeedMin = 1; // начальная минимальная скорость движения частицы
        public int SpeedMax = 10; // начальная максимальная скорость движения частицы
        public int RadiusMin = 2; // минимальный радиус частицы
        public int RadiusMax = 10; // максимальный радиус частицы
        public int LifeMin = 20; // минимальное время жизни частицы
        public int LifeMax = 100; // максимальное время жизни частицы

        public int ParticlesPerTick = 1; // количество частиц в тик

        public Color ColorFrom = Color.White; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.Black); // конечный цвет частиц

        public float GravitationX = 0;
        public float GravitationY = 1; // пусть гравитация будет силой один пиксель за такт, нам хватит

        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick; // фиксируем счетчик сколько частиц нам создавать за тик


            foreach (var particle in particles)
            {
                particle.Life -= 1;
                if (particle.Life < 0)
                {
                    particlesToCreate -= 1;
                    ResetParticle(particle);
                }
                else
                {
                    // гравитация воздействует на вектор скорости, поэтому пересчитываем его
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }

            while (particlesToCreate >= 1)
            {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
        }
        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful
            {
                FromColor = ColorFrom,
                ToColor = ColorTo
            };

            return particle;
        }

        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);

            particle.X = X;
            particle.Y = Y;

            float direction = Direction
                + Particle.rand.Next(Spreading)
                - Spreading / 2;

            var speed = Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = MathF.Cos(direction / 180 * MathF.PI) * speed;
            particle.SpeedY = -MathF.Sin(direction / 180 * MathF.PI) * speed;

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }
    }
}