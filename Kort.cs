using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
    enum Färg{Klöver=1,Spader,Hjärter,Ruter}
    enum Valör{Två=2,Tre,Fyra,Fem,Sex,Sju,Åtta,Nio,Tio,Knekt,Dam,Kung,Ess}

    class Kort:Button
    {
        public Färg KortFärg { get; set; }
        public Valör KortValör { get; set; }
        public bool Framsida { get; set; }
        //Image bild;       


        public Kort()
        {

        }

        public Kort(Färg färg, Valör valör,int fil)
        {
            KortFärg = färg;
            KortValör = valör;
            Framsida = false;
            Image = Image.FromFile(@"C:\Users\Jörgen\documents\visual studio 2012\Projects\C# grundkurs\21\bilder\" + (fil+1) + ".png");
            Size = Image.Size;
        }

        public override string ToString()
        {
            return KortFärg.ToString() + " " + KortValör.ToString();
        }

    }
}
