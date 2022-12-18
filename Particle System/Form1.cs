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

    }
}