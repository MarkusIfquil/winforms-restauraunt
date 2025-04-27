using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nmark_csaba_etterem_projekt
{
    public partial class Form2 : Form
    {
        public Etterem Etterem { get; private set; }
        public Form2(Etterem e)
        {
            InitializeComponent();
            Etterem = e;
            LoadStudentPanels();
        }

        private void LoadStudentPanels()
        {
            int panelWidth = 400;
            int panelHeight = 400;
            int margin = 10;

            for (int i = 0; i < Etterem.asztalok.Count; i++)
            {
                Panel panel = new Panel();
                panel.Width = panelWidth;
                panel.Height = panelHeight;
                panel.Left = ( i % 4 ) * ( panelWidth + margin );
                panel.Top = ( i / 4 ) * ( panelHeight + margin );
                panel.BorderStyle = BorderStyle.FixedSingle;

                // Add student info as labels
                Label nameLabel = new Label();
                nameLabel.AutoS
                nameLabel.Text =
                    $"Időpont: {Etterem.asztalok[i].idopont}\n" +
                    $"Főszám: {Etterem.asztalok[i].foSzam}\n" +
                    $"Férőhely: {Etterem.asztalok[i].feroHely}\n" +
                    $"Foglalt: {Etterem.asztalok[i].foglalt}\n" +
                    $"Főszám: {Etterem.asztalok[i].foSzam}\n" +
                    $"Pincérnév: {Etterem.asztalok[i].pincerNev}\n";
                nameLabel.Top = 10;
                nameLabel.Left = 10;



                // Add labels to panel
                panel.Controls.Add(nameLabel);

                // Add panel to the form
                this.Controls.Add(panel);
            }
        }
    }
}
