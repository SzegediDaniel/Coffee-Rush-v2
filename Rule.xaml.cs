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
using System.Windows.Shapes;

namespace Coffee_Rush_v2
{
    public partial class Rule : Window
    {

        public Rule()
        {
            InitializeComponent();
            contentfiller();
        }

        public void contentfiller()
        {
            l_con.Content = "A Coffee Rush kávézó otthonos hangulatban, finom kávéval várja vendégeit. Ám, amíg ők\r\npihenni térnek be ide, addig a pult mögött hatalmas a verseny. Ha egy rendelés nem készül\r\nel időben, akár be is zárhatunk! Itt csak a legjobb baristáknak van hely... Teljesíts minél\r\ntöbb rendelést, és légy te a legjobb barista!  \n \n Játékostér magyarázat: \n \n A játék indításakor bal felső sarokban színnel (piros/kék) és névvel (Red/Blue) van jelölve mely játékos van soron. \n Sárga gombbal melyen a Next felírat található lehet tovább adni a kört a következő játékosnak. \n Baloldalt megjelenítve láthatjuk a teljesítendő rendeléseinket kártyák formájában\n Jobb oldalt legfelül van az épp a körünkben mozgás által felvett hozzávalónk. \n Alatta a játékostér található ahol a bábukkal lehet mozogni W-A-S-D vagy nyilak segítségével. \n Ez alatt pedig a csészék találhatóak amelyekbe a felvett készletünket tudjuk belehelyezni. \n A csészéket a vörös gombbal lehet üríteni, a zöld gombbal pedig felszolgálni. \n Legalul pedig folyamattal követhetjük a teljesített illetve kudarcba fulladt rendeléseinket. \n \n Alapvető információk: \n \n A játék elején elsőnek a piros majd a kék bábunak le kell kerülnie. \n Minden játékosnak kötelezően mozognia kell három egységet. \n Arra a mezőre nem lehet lépni ahol már állnak. \n Ha egy rendelést teljesítették akkor az ellenfél egy vagy kettő további rendelést kap az első sorba. \n A rendeléseket négy körön át teljesíthetjük. Ha átadjuk a kört akkor minden rendelés eggyel lejebb csúszik. \n Csak akkor adhatjuk át a körünket ha mozogtunk hármat, a készletünk üres, a csészébe bele raktuk a hozzávalókat. \n A játék véget amint az a játékos újra sorra kerül aki szerzett három minusz pontot. (Piros dislike jel)\n \n A végső pont számításához a Zöld Like pontokat ki kell vonni a Piros Dislike pontokból. \n Az a játékos nyer aki a legtöbb pontot szerezte.";
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
