using mestint_beadando.AllapotTer;
using mestint_beadando.Keresok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mestint_beadando
{
    public partial class Form1 : Form
    {
        private const int meret = 40;
        private const int hely = 30;
        List<Kereso> keresok = new List<Kereso>();
        int aktualisAllapotIndex = 0;

        public Form1()
        {
            keresok.Add(new Backtrack());
            keresok.Add(new BestFirst());
            keresok.Add(new Melysegi());

            InitializeComponent();

            foreach (Kereso kereso in keresok)
            {
                cbKeresok.Items.Add(kereso.GetType().Name);
            }

        }

        public void Draw(Graphics g, Allapot a)
        {
            int width = pbJatek.Width;
            int height = pbJatek.Height;
            Bitmap image = new Bitmap(width, height);
            pbJatek.Image = image;
            g = Graphics.FromImage(image);

            Brush brush;
            for (int j = 0; j < a.matrix.GetLength(0); j++)
            {
                for (int i = 0; i < a.matrix.GetLength(1); i++)
                {
                    if (a.matrix[j, i] == "U")
                        brush = Brushes.DarkGray;
                    else if (a.matrix[j, i] == "F")
                    {
                        brush = Brushes.White;
                    }
                    else if (a.matrix[j, i] == "Z1" || a.matrix[j, i] == "Z2" || a.matrix[j, i] == "Z3")
                    {
                        brush = Brushes.Green;
                    }
                    else if (a.matrix[j, i] == "P1" || a.matrix[j, i] == "P2" || a.matrix[j, i] == "P3")
                    {
                        brush = Brushes.Red;
                    }
                    else brush = Brushes.AliceBlue;
                    g.FillRectangle(brush, i * (meret + hely), j * (meret + hely), meret, meret);
                }
            }

        }
        static Graphics g;

        private void pbJatek_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
        }

        private void eloreBtn_Click(object sender, EventArgs e)
        {
            if (cbKeresok.SelectedItem == null)
            {
                MessageBox.Show("Válassz egy keresőt a listából!");
            }
            else
            {
                if (keresok[cbKeresok.SelectedIndex].Utvonal.Count == aktualisAllapotIndex)
                {

                }
                else
                {
                    Draw(g, keresok[cbKeresok.SelectedIndex].Utvonal[aktualisAllapotIndex]);
                    aktualisAllapotIndex++;
                    lepes.Text = aktualisAllapotIndex.ToString();
                    osszlepes.Text = keresok[cbKeresok.SelectedIndex].Utvonal.Count.ToString();
                }
            }
        }

        private void hatraBtn_Click(object sender, EventArgs e)
        {
            if (aktualisAllapotIndex == 0)
            {
                Draw(g, keresok[cbKeresok.SelectedIndex].Utvonal[aktualisAllapotIndex]);

                lepes.Text = aktualisAllapotIndex.ToString();

            }
            else if (aktualisAllapotIndex > 0)
            {
                Draw(g, keresok[cbKeresok.SelectedIndex].Utvonal[aktualisAllapotIndex]);

                lepes.Text = aktualisAllapotIndex.ToString();
                aktualisAllapotIndex--;
            }
            else if (aktualisAllapotIndex == keresok[cbKeresok.SelectedIndex].Utvonal.Count)
            {
                aktualisAllapotIndex--;
                Draw(g, keresok[cbKeresok.SelectedIndex].Utvonal[aktualisAllapotIndex]);

                lepes.Text = aktualisAllapotIndex.ToString();
            }
        }

        private void cbKeresok_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktualisAllapotIndex = 0;
        }
    }
}
