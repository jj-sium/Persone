using ghinelli.johan._4h.persone.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using static ghinelli.johan._4h.persone.Models.Persona;

namespace ghinelli.johan._4h.persone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ATA a = new ATA();
            Debug.WriteLine(a);
        }
        private void dgbDati_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            
        }

        private void btnApriFile_Click(object sender, RoutedEventArgs e)
        {
            ATA a = new ATA()
            Debug.WriteLine("Sono io:" + a);
        }
    }
}