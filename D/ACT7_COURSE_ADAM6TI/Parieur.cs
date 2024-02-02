using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ACT7_COURSE_ADAM6TI
{
    class Parieur
    {
        string _nom;
        Pari _monPari;
        int _cash;
        TextBlock _textBlockEtatPari;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Pari MonPari
        {
            get { return _monPari; }
            set { _monPari = value; }
        }
       
        public int Cash

        {
            get { return _cash; }
            set { _cash = value; }
        }
        public TextBlock TextBlockEtatPari
        {
            get { return _textBlockEtatPari; }
            set { _textBlockEtatPari = value; }
        }

        public Parieur(string nom, Pari monPari, int cash, TextBlock textBlockEtatPari)
        {
            _nom = nom;
            _monPari = monPari;
            _cash = cash;
            _textBlockEtatPari = textBlockEtatPari;

        }
        public void Pari(int valeurPari, int numChien)
        {
            
        }
        public void ResetPari()
        {

        }
        public void MajInfos()
        {

        }

    }
    
}
