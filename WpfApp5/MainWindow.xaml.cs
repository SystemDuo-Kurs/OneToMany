using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Kontekst _con = new();
        public MainWindow()
        {
            InitializeComponent();
            _con.Database.EnsureCreated();

            _con.Peoplez.ToList();
            _con.Adresaz.ToList();

            //Adresa a = new Adresa { Grad = "Nesto", Broj = "123", Ulica = "sdfsef" };
            //_con.Peoplez.Add(new Osoba { Ime = "bla", Prezime = "blabla", Adresa = a });

            _con.SaveChanges();
        }
    }
}
