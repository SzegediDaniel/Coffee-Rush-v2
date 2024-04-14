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
using System.Windows.Shapes;

namespace Coffee_Rush_v2
{
    public partial class EndGame : Window
    {
        public EndGame()
        {
            InitializeComponent();
            pontok();
        }
        public void pontok()
        {
            // A fájlnév, amit be akarunk olvasni
            string fileName = "output.txt";

            // Ellenőrizzük, hogy létezik-e a fájl
            if (File.Exists(fileName))
            {
                // A fájl sorainak beolvasása
                string[] adatok = File.ReadAllLines(fileName);
                int red_plus = int.Parse(adatok[0]);
                int red_minus = int.Parse(adatok[3]);
                int blue_plus = int.Parse(adatok[2]);
                int blue_minus = int.Parse(adatok[1]);
                l_RLP_win.Content = red_plus;
                l_RDP_win.Content = red_minus;
                l_BLP_win.Content = blue_plus;
                l_BDP_win.Content = blue_minus;

                l_RSUM_win.Content = red_plus - red_minus;
                l_BSUM_win.Content = blue_plus - blue_minus;

                int a = red_plus - red_minus;
                int b = blue_plus - blue_minus;
                if (a>b)
                {
                    l_r_win.Visibility = Visibility.Visible;
                }
                else if (a<b)
                {
                    l_b_win.Visibility = Visibility.Visible;
                }
                else
                {
                    l_r_win.Visibility = Visibility.Visible;
                    l_b_win.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
