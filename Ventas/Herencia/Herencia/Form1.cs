using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var heroe1 = new Heroe();
            heroe1.Id = 1;
            heroe1.Nombre = "Diana Prince";
            heroe1.Alias = "Wonder Woman";
            heroe1.Poder = "Super fuerza";
            heroe1.Protegido = "Wonder girl";

            var heroe2 = new Heroe();
            heroe2.Id = 2;
            heroe2.Nombre = "Barry Allen";
            heroe2.Alias = "Flash";
            heroe2.Poder = "Fuerza de la velocidad";
            heroe2.Protegido = "Kid flash";

            var heroe3 = new Heroe();
            heroe3.Id = 3;
            heroe3.Nombre = "Clark Kent";
            heroe3.Alias = "Superman";
            heroe3.Poder = "Super fuerza y velocidad";
            heroe3.Protegido = "Superboy";

            var heroes = new List<Heroe>();
            heroes.Add(heroe1);
            heroes.Add(heroe2);
            heroes.Add(heroe3);

            foreach (var heroe in heroes)
            {
                MessageBox.Show(heroe.Alias + " - " + heroe.Poder + " - " + heroe.Protegido + " ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var villano1 = new Villano();
            villano1.Id = 1;
            villano1.Nombre = "Harvey Dent";
            villano1.Alias = "Dos caras";
            villano1.Poder = "Tirador y artes marciales";
            villano1.Psicopatologia = "Trastorno de identidad disociativo";

            var villano2 = new Villano();
            villano2.Id = 2;
            villano2.Nombre = "Pamela Isley";
            villano2.Alias = "Poison Ivy";
            villano2.Poder = "Control y manipulacion de plantas";
            villano2.Psicopatologia = "Trastorno paranoide de la personalidad";

            var villano3 = new Villano();
            villano3.Id = 3;
            villano3.Nombre = "Victor Fries";
            villano3.Alias = "Mr. Freeze";
            villano3.Poder = "Experto en criogenia";
            villano3.Psicopatologia = "Trastorno obsesivo-compulsivo esquizoide";

            var villanos = new List<Villano>();
            villanos.Add(villano1);
            villanos.Add(villano2);
            villanos.Add(villano3);

            foreach (var villano in villanos)
            {
                MessageBox.Show(villano.Alias + " - " + villano.Poder + " - " + villano.Psicopatologia + " ");
            }
        }
    }
}
