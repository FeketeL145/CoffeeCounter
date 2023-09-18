using System;
using System.Collections.Generic;
using System.IO;
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

namespace Coffee_Counter_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Kavek
        {
            public string tipus { get; set; }
            public string fajta { get; set; }
            public int mennyiseg { get; set; }
            public int ar { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
            StreamReader sr1 = new StreamReader("kavek.txt");
            sr1.ReadLine();
            List<Kavek> klista = new List<Kavek>();
            List<string[]> beolvas = new List<string[]>();
            while (!sr1.EndOfStream)
            {
                beolvas.Add(sr1.ReadLine().Split(';'));
            }
            foreach (var item in beolvas)
            {
                ktipusbox.Items.Add(item[1]);
            }
            for (int i = 0; i < beolvas.Count; i++)
            {
                Kavek kave1 = new Kavek();
                kave1.tipus = beolvas[i][0];
                kave1.fajta = beolvas[i][1];
                kave1.mennyiseg = Convert.ToInt32(beolvas[i][2]);
                kave1.ar = Convert.ToInt32(beolvas[i][3]);
                klista.Add(kave1);
            }
            sr1.Close();
            StreamReader sr2 = new StreamReader("emberek.txt");
            while (!sr2.EndOfStream)
            {
                nevbox.Items.Add(sr2.ReadLine());
            }
            sr2.Close();
        }

        private void HozzaadasButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void UjkaveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
