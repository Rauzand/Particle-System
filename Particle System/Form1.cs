using Particle_System.Objects;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Particle_System
{
    public partial class Form1 : Form
    {
        Emitter emitter;
        Portal? portal;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);

                if (portal != null)
                {
                    portal.Draw(g);
                    foreach (var particle in emitter.particles)
                        portal.Overlap(particle);
                }
            }
            picDisplay.Invalidate();
        }
        private void PicDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            //если портал не создан
            if (portal == null)
            {
                portal = new Portal
                {
                    input = new(e.X, e.Y),
                    output = new(e.X, e.Y),
                    direction = (ushort)emitter.Direction
                };

                //реакция на пересечение частицы с входом портала
                portal.OnPortalParticle += (particle) =>
                {
                    particle.X = portal.output.X;
                    particle.Y = portal.output.Y;

                    //перерасчёт направления с учётом направления портала
                    particle.SpeedX = MathF.Cos((float)portal.direction / 180 * MathF.PI)
                        * particle.SpeedX;
                    particle.SpeedY = -MathF.Sin((float)portal.direction / 180 * MathF.PI)
                        * particle.SpeedY;
                };
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    portal.input.X = e.X;
                    portal.input.Y = e.Y;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    portal.output.X = e.X;
                    portal.output.Y = e.Y;
                }
            }
        }

        private void TbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirectionValue.Text = tbDirection.Value.ToString();
        }

        private void TbSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
            lblSpreadingValue.Text = tbSpreading.Value.ToString();
        }

        private void TbSpeed_Scroll(object sender, EventArgs e)
        {
            //минимальная скорость = 20% от максимальной
            emitter.SpeedMin = (int)(tbSpeed.Value * 0.2f);
            emitter.SpeedMax = tbSpeed.Value;
            lblSpeedValue.Text = tbSpeed.Value.ToString();
        }
        private void TbLife_Scroll(object sender, EventArgs e)
        {
            //минимальная продолжительность жизни = 25% от максимума
            emitter.LifeMin = tbLife.Value / 4;
            emitter.LifeMax = tbLife.Value;
            lblLifeValue.Text = tbLife.Value.ToString();
        }

        private void TbRadiusPortal_Scroll(object sender, EventArgs e)
        {
            if (portal != null)
            {
                portal.radius = (byte)tbRadiusPortal.Value;
                lblRadiusPortalValue.Text = tbRadiusPortal.Value.ToString();
            }
        }

        private void TbDirectionPortal_Scroll(object sender, EventArgs e)
        {
            if (portal != null)
            {
                portal.direction = (ushort)tbDirectionPortal.Value;
                lblDirectionPortalValue.Text = tbDirectionPortal.Value.ToString();
            }
        }
    }
}