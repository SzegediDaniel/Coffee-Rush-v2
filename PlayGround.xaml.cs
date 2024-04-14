using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Coffee_Rush_v2
{
    public partial class PlayGround : Window
    {
        public PlayGround()
        {
            InitializeComponent();
        }

        private bool KezdoJatekos = true; // kezdő játékos a piros
        private bool BabuRakasFazis = true;

        int[,] JatekTabla = { { 0, 1, 2, 3 },  // 0 - jég ; 1 - Karamell
                              { 3, 4, 0, 5 },  // 2 - gőz ; 3 - kávébab
                              { 6, 2, 4, 3 },  // 4 - tej ; 5 - víz
                              { 4, 0, 7, 2 }   // 6 - tea ; 7 - csoki
        };

        int[,] FoglaloTabla = { { 0, 0, 0, 0 },
                                { 0, 0, 0, 0 },
                                { 0, 0, 0, 0 },
                                { 0, 0, 0, 0 }
        };

        private void FiguraShower()
        {

            // ELSO SOR
            if (FoglaloTabla[0, 0] == 0)
            {
                _00_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/JEG.png", UriKind.Relative)));
            }
            if (FoglaloTabla[0, 0] == 1)
            {
                _00_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_JEG_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[0, 0] == 2)
            {
                _00_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_JEG_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[0, 1] == 0)
            {
                _01_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KARAMELL.png", UriKind.Relative)));
            }
            if (FoglaloTabla[0, 1] == 1)
            {
                _01_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_KARAMELL_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[0, 1] == 2)
            {
                _01_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_KARAMELL_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[0, 2] == 0)
            {
                _02_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/GOZ.png", UriKind.Relative)));
            }
            if (FoglaloTabla[0, 2] == 1)
            {
                _02_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_GOZ_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[0, 2] == 2)
            {
                _02_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_GOZ_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[0, 3] == 0)
            {
                _03_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KAVEBAB.png", UriKind.Relative)));
            }
            if (FoglaloTabla[0, 3] == 1)
            {
                _03_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_KAVEBAB_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[0, 3] == 2)
            {
                _03_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_KAVEBAB_BABU.png", UriKind.Relative)));
            }


            // MASODIK SOR
            if (FoglaloTabla[1, 0] == 0)
            {
                _10_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KAVEBAB.png", UriKind.Relative)));
            }
            if (FoglaloTabla[1, 0] == 1)
            {
                _10_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_KAVEBAB_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[1, 0] == 2)
            {
                _10_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_KAVEBAB_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[1, 1] == 0)
            {
                _11_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEJ.png", UriKind.Relative)));
            }
            if (FoglaloTabla[1, 1] == 1)
            {
                _11_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_TEJ_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[1, 1] == 2)
            {
                _11_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_TEJ_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[1, 2] == 0)
            {
                _12_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/JEG.png", UriKind.Relative)));
            }
            if (FoglaloTabla[1, 2] == 1)
            {
                _12_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_JEG_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[1, 2] == 2)
            {
                _12_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_JEG_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[1, 3] == 0)
            {
                _13_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/VIZ.png", UriKind.Relative)));
            }
            if (FoglaloTabla[1, 3] == 1)
            {
                _13_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_VIZ_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[1, 3] == 2)
            {
                _13_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_VIZ_BABU.png", UriKind.Relative)));
            }

            // HARMADIK SOR
            if (FoglaloTabla[2, 0] == 0)
            {
                _20_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEA.png", UriKind.Relative)));
            }
            if (FoglaloTabla[2, 0] == 1)
            {
                _20_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_TEA_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[2, 0] == 2)
            {
                _20_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_TEA_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[2, 1] == 0)
            {
                _21_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/GOZ.png", UriKind.Relative)));
            }
            if (FoglaloTabla[2, 1] == 1)
            {
                _21_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_GOZ_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[2, 1] == 2)
            {
                _21_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_GOZ_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[2, 2] == 0)
            {
                _22_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEJ.png", UriKind.Relative)));
            }
            if (FoglaloTabla[2, 2] == 1)
            {
                _22_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_TEJ_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[2, 2] == 2)
            {
                _22_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_TEJ_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[2, 3] == 0)
            {
                _23_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KAVEBAB.png", UriKind.Relative)));
            }
            if (FoglaloTabla[2, 3] == 1)
            {
                _23_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_KAVEBAB_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[2, 3] == 2)
            {
                _23_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_KAVEBAB_BABU.png", UriKind.Relative)));
            }

            // NEGYEDIK SOR
            if (FoglaloTabla[3, 0] == 0)
            {
                _30_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEJ.png", UriKind.Relative)));
            }
            if (FoglaloTabla[3, 0] == 1)
            {
                _30_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_TEJ_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[3, 0] == 2)
            {
                _30_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_TEJ_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[3, 1] == 0)
            {
                _31_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/JEG.png", UriKind.Relative)));
            }
            if (FoglaloTabla[3, 1] == 1)
            {
                _31_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_JEG_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[3, 1] == 2)
            {
                _31_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_JEG_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[3, 2] == 0)
            {
                _32_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/CSOKI.png", UriKind.Relative)));
            }
            if (FoglaloTabla[3, 2] == 1)
            {
                _32_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_CSOKI_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[3, 2] == 2)
            {
                _32_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_CSOKI_BABU.png", UriKind.Relative)));
            }

            if (FoglaloTabla[3, 3] == 0)
            {
                _33_lb.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/GOZ.png", UriKind.Relative)));
            }
            if (FoglaloTabla[3, 3] == 1)
            {
                _33_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/R_GOZ_BABU.png", UriKind.Relative)));
            }
            if (FoglaloTabla[3, 3] == 2)
            {
                _33_lb.Background = new ImageBrush(new BitmapImage(new Uri("../BABU/B_GOZ_BABU.png", UriKind.Relative)));
            }
        }

        int[] pirosCsesze_1 = { 8, 8, 8, 8 };
        int[] pirosCsesze_2 = { 8, 8, 8, 8 };
        int[] pirosCsesze_3 = { 8, 8, 8, 8 };
        string pirosCsesze_1S;
        string pirosCsesze_2S;
        string pirosCsesze_3S;

        Random r = new Random();


        string[] b =
        {
            "0134", //0 
            "0138", //1
            "0347", //2
            "0348", //3
            "0358", //4
            "0468", //5
            "0478", //6
            "0568", //7
            "1234", //8
            "2348", //9
            "2358", //10
            "2388", //11
            "2338", //12
            "2347", //13
            "2468", //14
            "2478", //15
            "2568"  //16
        };


        string[,] PirosKarytaStatus = { { "8", "8", "8", "8", "8" },
                                        { "8", "8", "8", "8", "8" },
                                        { "8", "8", "8", "8", "8" },
                                        { "8", "8", "8", "8", "8" }
        };
        string[,] KekKarytaStatus =   { { "8", "8", "8", "8", "8" },
                                        { "8", "8", "8", "8", "8" },
                                        { "8", "8", "8", "8", "8" },
                                        { "8", "8", "8", "8", "8" }
        };
        public int PirosMinuszPont = 0;
        public int PirosPluszPont = 0;

        private void EndGameTrigger()
        {
            if (lb_name.Content == "Red" && PirosMinuszPont >= 3 || lb_name.Content == "Blue" && KekMinuszPont >= 3)
            {
                // A string tömb létrehozása
                string[] strings = { $"{PirosPluszPont}", $"{PirosMinuszPont}", $"{KekPluszPont}", $"{KekMinuszPont}" };

                // A fájlnév meghatározása
                string fileName = "output.txt";

                // A fájl megnyitása a megadott fájlnéven, írás módra
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // A string tömb elemeinek kiírása a fájlba
                    for (int i = 0; i < 4; i++)
                    {
                        writer.WriteLine(strings[i]);
                    }
                }

                EndGame pontok = new EndGame();
                pontok.Show();
                this.Close();
            }
        }




        private void PirosKarytakLe()
        {
            if (lb_name.Content == "Red" && BabuRakasFazis == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (PirosKarytaStatus[3, i] != "8")
                    {
                        KekMinuszPont++;
                        EndGameTrigger();
                    }
                }
                PirosKarytaStatus[3, 0] = PirosKarytaStatus[2, 0];
                PirosKarytaStatus[3, 1] = PirosKarytaStatus[2, 1];
                PirosKarytaStatus[3, 2] = PirosKarytaStatus[2, 2];
                PirosKarytaStatus[3, 3] = PirosKarytaStatus[2, 3];
                PirosKarytaStatus[3, 4] = PirosKarytaStatus[2, 4];

                PirosKarytaStatus[2, 0] = PirosKarytaStatus[1, 0];
                PirosKarytaStatus[2, 1] = PirosKarytaStatus[1, 1];
                PirosKarytaStatus[2, 2] = PirosKarytaStatus[1, 2];
                PirosKarytaStatus[2, 3] = PirosKarytaStatus[1, 3];
                PirosKarytaStatus[2, 4] = PirosKarytaStatus[1, 4];

                PirosKarytaStatus[1, 0] = PirosKarytaStatus[0, 0];
                PirosKarytaStatus[1, 1] = PirosKarytaStatus[0, 1];
                PirosKarytaStatus[1, 2] = PirosKarytaStatus[0, 2];
                PirosKarytaStatus[1, 3] = PirosKarytaStatus[0, 3];
                PirosKarytaStatus[1, 4] = PirosKarytaStatus[0, 4];

                PirosKarytaStatus[0, 0] = "8";
                PirosKarytaStatus[0, 1] = "8";
                PirosKarytaStatus[0, 2] = "8";
                PirosKarytaStatus[0, 3] = "8";
                PirosKarytaStatus[0, 4] = "8";

                L_Minus.Content = PirosMinuszPont;
            }
        }
        public int KekMinuszPont = 0;
        public int KekPluszPont = 0;

        public void GUI_Szinezes()
        {
            if (lb_name.Content == "Red")
            {
                lb_name.Background = new ImageBrush(new BitmapImage(new Uri("../RedDesigne/Red_Header.png", UriKind.Relative)));
                lb_sarok.Background = new ImageBrush(new BitmapImage(new Uri("../RedDesigne/Red_Sarok.png", UriKind.Relative)));
                lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../RedDesigne/Red_Numero1.png", UriKind.Relative)));
                lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../RedDesigne/Red_Numero2.png", UriKind.Relative)));
                lb_3.Background = new ImageBrush(new BitmapImage(new Uri("../RedDesigne/Red_Numero3.png", UriKind.Relative)));
                lb_4.Background = new ImageBrush(new BitmapImage(new Uri("../RedDesigne/Red_Numero4.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue")
            {
                lb_name.Background = new ImageBrush(new BitmapImage(new Uri("../KekDesigne/Kek_Header.png", UriKind.Relative)));
                lb_sarok.Background = new ImageBrush(new BitmapImage(new Uri("../KekDesigne/Kek_Sarok.png", UriKind.Relative)));
                lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../KekDesigne/Kek_1.png", UriKind.Relative)));
                lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../KekDesigne/Kek_2.png", UriKind.Relative)));
                lb_3.Background = new ImageBrush(new BitmapImage(new Uri("../KekDesigne/Kek_3.png", UriKind.Relative)));
                lb_4.Background = new ImageBrush(new BitmapImage(new Uri("../KekDesigne/Kek_4.png", UriKind.Relative)));
            }
            SpotChecker();
        }
        private int CounterForSpotChecker = 0;
        private void SpotChecker()
        {
            if (BabuRakasFazis == false && CounterForSpotChecker == 3)
            {
                ;
                Pass.IsEnabled = true;
            }
            else
            {
                Pass.IsEnabled = false;
            }
        }

        private void KekKarytakLe()
        {
            if (lb_name.Content == "Blue" && BabuRakasFazis == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (KekKarytaStatus[3, i] != "8")
                    {
                        PirosMinuszPont++;
                        EndGameTrigger();
                    }
                }
                KekKarytaStatus[3, 0] = KekKarytaStatus[2, 0];
                KekKarytaStatus[3, 1] = KekKarytaStatus[2, 1];
                KekKarytaStatus[3, 2] = KekKarytaStatus[2, 2];
                KekKarytaStatus[3, 3] = KekKarytaStatus[2, 3];
                KekKarytaStatus[3, 4] = KekKarytaStatus[2, 4];

                KekKarytaStatus[2, 0] = KekKarytaStatus[1, 0];
                KekKarytaStatus[2, 1] = KekKarytaStatus[1, 1];
                KekKarytaStatus[2, 2] = KekKarytaStatus[1, 2];
                KekKarytaStatus[2, 3] = KekKarytaStatus[1, 3];
                KekKarytaStatus[2, 4] = KekKarytaStatus[1, 4];

                KekKarytaStatus[1, 0] = KekKarytaStatus[0, 0];
                KekKarytaStatus[1, 1] = KekKarytaStatus[0, 1];
                KekKarytaStatus[1, 2] = KekKarytaStatus[0, 2];
                KekKarytaStatus[1, 3] = KekKarytaStatus[0, 3];
                KekKarytaStatus[1, 4] = KekKarytaStatus[0, 4];

                KekKarytaStatus[0, 0] = "8";
                KekKarytaStatus[0, 1] = "8";
                KekKarytaStatus[0, 2] = "8";
                KekKarytaStatus[0, 3] = "8";
                KekKarytaStatus[0, 4] = "8";
                L_Minus.Content = KekMinuszPont;
            }
        }
        private void KezdoKarytaGeneralo()
        {
            if (PirosBabuLent == false && PirosKarytaStatus[0, 0] == "8")
            {
                PirosKarytaStatus[0, 0] = b[r.Next(0, 17)];
                PirosKarytaStatus[0, 1] = b[r.Next(0, 17)];
                PirosKarytaStatus[1, 0] = b[r.Next(0, 17)];
                KekKarytaStatus[0, 0] = b[r.Next(0, 17)];
                KekKarytaStatus[0, 1] = b[r.Next(0, 17)];
            }
        }
        private void csesze_szamolas()
        {
            Array.Sort(pirosCsesze_1);
            Array.Sort(pirosCsesze_2);
            Array.Sort(pirosCsesze_3);
            pirosCsesze_1S = System.String.Join("", pirosCsesze_1.Select(p => p.ToString()).ToArray());
            pirosCsesze_2S = System.String.Join("", pirosCsesze_2.Select(p => p.ToString()).ToArray());
            pirosCsesze_3S = System.String.Join("", pirosCsesze_3.Select(p => p.ToString()).ToArray());

            Array.Sort(kekCsesze_1);
            Array.Sort(kekCsesze_2);
            Array.Sort(kekCsesze_3);
            kekCsesze_1S = System.String.Join("", kekCsesze_1.Select(p => p.ToString()).ToArray());
            kekCsesze_2S = System.String.Join("", kekCsesze_2.Select(p => p.ToString()).ToArray());
            kekCsesze_3S = System.String.Join("", kekCsesze_3.Select(p => p.ToString()).ToArray());
        }
        int[] kekCsesze_1 = { 8, 8, 8, 8 };
        int[] kekCsesze_2 = { 8, 8, 8, 8 };
        int[] kekCsesze_3 = { 8, 8, 8, 8 };
        string kekCsesze_1S;
        string kekCsesze_2S;
        string kekCsesze_3S;
        int PirosXpoz;
        int PirosYpoz;
        int KekXpoz;
        int KekYpoz;
        int[] PirosRaktar = { 8, 8, 8 };
        int[] KekRaktar = { 8, 8, 8 };
        private bool PirosBabuLent = false;
        private bool KekBabuLent = false;
        private void Window_Activated(object sender, EventArgs e)
        {
            Background_Coloring();
            CardPictureShower();
        }

        // BÁBU LERAKÁS FÁZIS
        public void showanyag()
        {
            if (lb_name.Content == "Red")
            {
                r_lb_0.Content = PirosRaktar[0];
                r_lb_1.Content = PirosRaktar[1];
                r_lb_2.Content = PirosRaktar[2];

                P_CS_1.Content = pirosCsesze_1S;
                P_CS_2.Content = pirosCsesze_2S;
                P_CS_3.Content = pirosCsesze_3S;

                if (pirosCsesze_1[3] != 8)
                {
                    P_CS_1.IsEnabled = false;
                }
                else
                {
                    P_CS_1.IsEnabled = true;
                }

                if (pirosCsesze_2[3] != 8)
                {
                    P_CS_2.IsEnabled = false;
                }
                else
                {
                    P_CS_2.IsEnabled = true;
                }

                if (pirosCsesze_3[3] != 8)
                {
                    P_CS_3.IsEnabled = false;
                }
                else
                {
                    P_CS_3.IsEnabled = true;
                }

                CardsShower();
                CardPictureShower();
                FiguraShower();
            }
            else if (lb_name.Content == "Blue")
            {
                r_lb_0.Content = KekRaktar[0];
                r_lb_1.Content = KekRaktar[1];
                r_lb_2.Content = KekRaktar[2];

                P_CS_1.Content = kekCsesze_1S;
                P_CS_2.Content = kekCsesze_2S;
                P_CS_3.Content = kekCsesze_3S;

                if (kekCsesze_1[3] != 8)
                {
                    P_CS_1.IsEnabled = false;
                }
                else
                {
                    P_CS_1.IsEnabled = true;
                }

                if (kekCsesze_2[3] != 8)
                {
                    P_CS_2.IsEnabled = false;
                }
                else
                {
                    P_CS_2.IsEnabled = true;
                }

                if (kekCsesze_3[3] != 8)
                {
                    P_CS_3.IsEnabled = false;
                }
                else
                {
                    P_CS_3.IsEnabled = true;
                }

                CardsShower();
                CardPictureShower();
                FiguraShower();
            }
            POINTSHOWER();
            StoragePictureShower();
            CseszeTartalomPictures();
        }
        private void POINTSHOWER()
        {
            if (lb_name.Content == "Red")
            {
                L_Plus.Content = PirosPluszPont;
            }
            if (lb_name.Content == "Blue")
            {
                L_Plus.Content = KekPluszPont;
            }
        }

        public void StorageFiller()
        {
            if (lb_name.Content == "Red")
            {
                int anyag = JatekTabla[PirosXpoz, PirosYpoz];
                for (int i = 0; i < PirosRaktar.Length; i++)
                {
                    if (PirosRaktar[i] == 8)
                    {
                        PirosRaktar[i] = anyag;
                        anyag = 8;
                    }
                }
            }
            else if (lb_name.Content == "Blue")
            {
                int anyag = JatekTabla[KekXpoz, KekYpoz];
                for (int i = 0; i < KekRaktar.Length; i++)
                {
                    if (KekRaktar[i] == 8)
                    {
                        KekRaktar[i] = anyag;
                        anyag = 8;
                    }
                }

            }
            StoragePictureShower();
            CseszeTartalomPictures();
        }

        public void Background_Coloring()
        {

            if (KezdoJatekos)
            {
                lb_name.Content = "Red";
                GUI_Szinezes();
            }
            else
            {
                lb_name.Content = "Blue";
                GUI_Szinezes();
            }
            csesze_szamolas();
            showanyag();
            StoragePictureShower();
            CseszeTartalomPictures();
        }




        private bool RedRound = true;

        private bool BlueRound = false;
        Random ARAN = new Random();
        Random BRAN = new Random();

        public void ElsoSorKartyaGeneralasHaKeszEgyRendeles()
        {
            int szam = BRAN.Next(1, 3);
            if (lb_name.Content == "Red")
            {
                for (int i = 0; i < KekKarytaStatus.GetLength(0); i++)
                {
                    if (KekKarytaStatus[0, i] == "8" && szam != 0)
                    {
                        int a = ARAN.Next(0, 17);
                        KekKarytaStatus[0, i] = b[a];
                        szam--;
                    }
                }
            }
            if (lb_name.Content == "Blue")
            {
                for (int i = 0; i < PirosKarytaStatus.GetLength(0); i++)
                {
                    if (PirosKarytaStatus[0, i] == "8" && szam != 0)
                    {
                        int a = ARAN.Next(0, 17);
                        PirosKarytaStatus[0, i] = b[a];
                        szam--;
                    }
                }
            }
        }

        private void Pass_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            KekKarytakLe();
            PirosKarytakLe();
            CardPictureShower();
            SpotChecker();
            if (BabuRakasFazis == false)
            {
                CounterForSpotChecker = 0;
            }
            if (lb_name.Content == "Blue" && KekRaktar[0] == 8 && KekRaktar[1] == 8 && KekRaktar[2] == 8)
            {
                lb_name.Content = "Red";
                GUI_Szinezes();
                RedRound = true;
                BlueRound = false;
                MaxMozgas = 3;
                showanyag();
            }
            else if (lb_name.Content == "Red" && PirosRaktar[0] == 8 && PirosRaktar[1] == 8 && PirosRaktar[2] == 8)
            {

                lb_name.Content = "Blue";
                GUI_Szinezes();
                RedRound = false;
                BlueRound = true;
                MaxMozgas = 3;
                showanyag();
            }
        }

        int kivalasztott = 8;
        bool kivalasztva = false;


        private void P_CS_1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (kivalasztva == true && lb_name.Content == "Red")
            {
                for (int i = 0; i < pirosCsesze_1.Length; i++)
                {
                    if (pirosCsesze_1[i] == 8)
                    {
                        pirosCsesze_1[i] = kivalasztott;
                        csesze_szamolas();
                        (sender as Label).Content = pirosCsesze_1S;
                        if (BabuRakasFazis == true)
                        {
                            Pass.IsEnabled = true;
                        }
                        if (BabuRakasFazis == false)
                        {
                            CounterForSpotChecker++;
                            SpotChecker();
                        }
                        break;
                    }
                }
                kivalasztott = 8;
                kivalasztva = false;
            }
            if (kivalasztva == true && lb_name.Content == "Blue")
            {
                for (int i = 0; i < kekCsesze_1.Length; i++)
                {
                    if (kekCsesze_1[i] == 8)
                    {
                        kekCsesze_1[i] = kivalasztott;
                        csesze_szamolas();
                        (sender as Label).Content = kekCsesze_1S;
                        if (BabuRakasFazis == false)
                        {
                            CounterForSpotChecker++;
                            SpotChecker();
                        }
                        break;
                    }
                }
                kivalasztott = 8;
                kivalasztva = false;
                if (BabuRakasFazis == true)
                {
                    Pass_MouseDoubleClick(sender, e);
                }
                BabuRakasFazis = false;
            }
            CseszeTartalomPictures();
        }
        private void P_CS_2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (kivalasztva == true && lb_name.Content == "Red")
            {
                for (int i = 0; i < pirosCsesze_2.Length; i++)
                {
                    if (pirosCsesze_2[i] == 8)
                    {
                        pirosCsesze_2[i] = kivalasztott;
                        csesze_szamolas();
                        (sender as Label).Content = pirosCsesze_2S;
                        if (BabuRakasFazis == true)
                        {
                            Pass.IsEnabled = true;
                        }
                        if (BabuRakasFazis == false)
                        {
                            CounterForSpotChecker++;
                            SpotChecker();
                        }
                        break;
                    }
                }
                kivalasztott = 8;
                kivalasztva = false;
            }
            if (kivalasztva == true && lb_name.Content == "Blue")
            {
                for (int i = 0; i < kekCsesze_2.Length; i++)
                {
                    if (kekCsesze_2[i] == 8)
                    {
                        kekCsesze_2[i] = kivalasztott;
                        csesze_szamolas();
                        (sender as Label).Content = kekCsesze_2S;
                        if (BabuRakasFazis == false)
                        {
                            CounterForSpotChecker++;
                            SpotChecker();
                        }
                        break;
                    }
                }
                kivalasztott = 8;
                kivalasztva = false;
                if (BabuRakasFazis == true)
                {
                    Pass_MouseDoubleClick(sender, e);
                }
                BabuRakasFazis = false;
            }
            CseszeTartalomPictures();
        }

        private void P_CS_3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (kivalasztva == true && lb_name.Content == "Red")
            {
                for (int i = 0; i < pirosCsesze_3.Length; i++)
                {
                    if (pirosCsesze_3[i] == 8)
                    {
                        pirosCsesze_3[i] = kivalasztott;
                        csesze_szamolas();
                        (sender as Label).Content = pirosCsesze_3S;
                        if (BabuRakasFazis == true)
                        {
                            Pass.IsEnabled = true;
                        }
                        if (BabuRakasFazis == false)
                        {
                            CounterForSpotChecker++;
                            SpotChecker();
                        }
                        break;
                    }
                }
                kivalasztott = 8;
                kivalasztva = false;
            }
            if (kivalasztva == true && lb_name.Content == "Blue")
            {
                for (int i = 0; i < kekCsesze_3.Length; i++)
                {
                    if (kekCsesze_3[i] == 8)
                    {
                        kekCsesze_3[i] = kivalasztott;
                        csesze_szamolas();
                        (sender as Label).Content = kekCsesze_3S;
                        if (BabuRakasFazis == false)
                        {
                            CounterForSpotChecker++;
                            SpotChecker();
                        }
                        break;
                    }
                }
                kivalasztott = 8;
                kivalasztva = false;
                if (BabuRakasFazis == true)
                {
                    Pass_MouseDoubleClick(sender, e);
                }
                BabuRakasFazis = false;
            }
            CseszeTartalomPictures();
        }

        private int MaxMozgas = 3;

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (KekBabuLent == true && PirosBabuLent == true && RedRound == true && BabuRakasFazis == false)
            {
                if (MaxMozgas != 0)
                {
                    if (e.Key == Key.Right && PirosYpoz < 3 || e.Key == Key.D && PirosYpoz < 3)
                    {
                        if (FoglaloTabla[PirosXpoz, PirosYpoz + 1] == 0)
                        {
                            FoglaloTabla[PirosXpoz, PirosYpoz] = 0;
                            PirosYpoz++;
                            FoglaloTabla[PirosXpoz, PirosYpoz] = 1;
                            MaxMozgas--;
                            RaktarLepeskorFeltoltes(PirosXpoz, PirosYpoz);
                        }
                    }
                    if (e.Key == Key.Left && PirosYpoz > 0 || e.Key == Key.A && PirosYpoz > 0)
                    {
                        if (FoglaloTabla[PirosXpoz, PirosYpoz - 1] == 0)
                        {
                            FoglaloTabla[PirosXpoz, PirosYpoz] = 0;
                            PirosYpoz--;
                            FoglaloTabla[PirosXpoz, PirosYpoz] = 1;
                            MaxMozgas--;
                            RaktarLepeskorFeltoltes(PirosXpoz, PirosYpoz);
                        }
                    }
                    if (e.Key == Key.Down && PirosXpoz < 3 || e.Key == Key.S && PirosXpoz < 3)
                    {
                        if (FoglaloTabla[PirosXpoz + 1, PirosYpoz] == 0)
                        {
                            FoglaloTabla[PirosXpoz, PirosYpoz] = 0;
                            PirosXpoz++;
                            FoglaloTabla[PirosXpoz, PirosYpoz] = 1;
                            MaxMozgas--;
                            RaktarLepeskorFeltoltes(PirosXpoz, PirosYpoz);
                        }
                    }
                    if (e.Key == Key.Up && PirosXpoz > 0 || e.Key == Key.W && PirosXpoz > 0)
                    {
                        if (FoglaloTabla[PirosXpoz + -1, PirosYpoz] == 0)
                        {
                            FoglaloTabla[PirosXpoz, PirosYpoz] = 0;
                            PirosXpoz--;
                            FoglaloTabla[PirosXpoz, PirosYpoz] = 1;
                            MaxMozgas--;
                            RaktarLepeskorFeltoltes(PirosXpoz, PirosYpoz);
                        }
                    }
                }
            }
            if (KekBabuLent == true && PirosBabuLent == true && BlueRound == true && BabuRakasFazis == false)
            {
                if (MaxMozgas != 0)
                {
                    if (e.Key == Key.Right && KekYpoz < 3 || e.Key == Key.D && KekYpoz < 3)
                    {
                        if (FoglaloTabla[KekXpoz, KekYpoz + 1] == 0)
                        {
                            FoglaloTabla[KekXpoz, KekYpoz] = 0;
                            KekYpoz++;
                            FoglaloTabla[KekXpoz, KekYpoz] = 2;
                            MaxMozgas--;
                            RaktarLepeskorFeltoltes(KekXpoz, KekYpoz);
                        }
                    }
                    if (e.Key == Key.Left && KekYpoz > 0 || e.Key == Key.A && KekYpoz > 0)
                    {
                        if (FoglaloTabla[KekXpoz, KekYpoz - 1] == 0)
                        {
                            FoglaloTabla[KekXpoz, KekYpoz] = 0;
                            KekYpoz--;
                            FoglaloTabla[KekXpoz, KekYpoz] = 2;
                            MaxMozgas--;
                            RaktarLepeskorFeltoltes(KekXpoz, KekYpoz);
                        }
                    }
                    if (e.Key == Key.Down && KekXpoz < 3 || e.Key == Key.S && KekXpoz < 3)
                    {
                        if (FoglaloTabla[KekXpoz + 1, KekYpoz] == 0)
                        {
                            FoglaloTabla[KekXpoz, KekYpoz] = 0;
                            KekXpoz++;
                            FoglaloTabla[KekXpoz, KekYpoz] = 2;
                            MaxMozgas--;
                            RaktarLepeskorFeltoltes(KekXpoz, KekYpoz);
                        }
                    }
                    if (e.Key == Key.Up && KekXpoz > 0 || e.Key == Key.W && KekXpoz > 0)
                    {
                        if (FoglaloTabla[KekXpoz - 1, KekYpoz] == 0)
                        {
                            FoglaloTabla[KekXpoz, KekYpoz] = 0;
                            KekXpoz--;
                            FoglaloTabla[KekXpoz, KekYpoz] = 2;
                            MaxMozgas--;
                            RaktarLepeskorFeltoltes(KekXpoz, KekYpoz);
                        }
                    }
                }
            }
            FiguraShower();
        }

        private void seged2(int szam, object sender)
        {
            if (PirosRaktar[szam] != 8 && kivalasztva == false && lb_name.Content == "Red")
            {
                kivalasztott = PirosRaktar[szam];
                PirosRaktar[szam] = 8;
                showanyag();
                kivalasztva = true;
            }
            if (KekRaktar[szam] != 8 && kivalasztva == false && lb_name.Content == "Blue")
            {
                kivalasztott = KekRaktar[szam];
                KekRaktar[szam] = 8;
                showanyag();
                kivalasztva = true;
            }
        }

        public void RaktarLepeskorFeltoltes(int x, int y)
        {
            if (lb_name.Content == "Red")
            {
                PirosXpoz = x;
                PirosYpoz = y;
                StorageFiller();
                showanyag();

            }
            else if (lb_name.Content == "Blue")
            {
                KekXpoz = x;
                KekYpoz = y;
                StorageFiller();
                showanyag();

            }

        }

        public void StoragePictureShower()
        {
            //RED
            // EGYES
            if (lb_name.Content == "Red" && PirosRaktar[0] == 8)
            {
                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/URES.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[0] == 0)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/JEG.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[0] == 1)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KARAMELL.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[0] == 2)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/GOZ.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[0] == 3)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[0] == 4)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[0] == 5)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[0] == 6)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[0] == 7)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/CSOKI.png", UriKind.Relative)));
            }


            // KETTES
            if (lb_name.Content == "Red" && PirosRaktar[1] == 8)
            {
                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/URES.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[1] == 0)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/JEG.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[1] == 1)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KARAMELL.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[1] == 2)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/GOZ.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[1] == 3)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[1] == 4)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[1] == 5)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[1] == 6)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[1] == 7)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/CSOKI.png", UriKind.Relative)));
            }

            // HARMAS
            if (lb_name.Content == "Red" && PirosRaktar[2] == 8)
            {
                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/URES.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[2] == 0)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/JEG.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[2] == 1)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KARAMELL.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[2] == 2)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/GOZ.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Red" && PirosRaktar[2] == 3)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[2] == 4)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[2] == 5)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[2] == 6)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && PirosRaktar[2] == 7)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/CSOKI.png", UriKind.Relative)));
            }



            //BLUE
            // EGYES
            if (lb_name.Content == "Blue" && KekRaktar[0] == 8)
            {
                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/URES.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[0] == 0)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/JEG.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[0] == 1)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KARAMELL.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[0] == 2)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/GOZ.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[0] == 3)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[0] == 4)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[0] == 5)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[0] == 6)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[0] == 7)
            {

                r_lb_0.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/CSOKI.png", UriKind.Relative)));
            }


            // KETTES
            if (lb_name.Content == "Blue" && KekRaktar[1] == 8)
            {
                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/URES.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[1] == 0)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/JEG.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[1] == 1)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KARAMELL.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[1] == 2)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/GOZ.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[1] == 3)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[1] == 4)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[1] == 5)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[1] == 6)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[1] == 7)
            {

                r_lb_1.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/CSOKI.png", UriKind.Relative)));
            }

            // HARMAS
            if (lb_name.Content == "Blue" && KekRaktar[2] == 8)
            {
                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/URES.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[2] == 0)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/JEG.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[2] == 1)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KARAMELL.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[2] == 2)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/GOZ.png", UriKind.Relative)));
            }

            if (lb_name.Content == "Blue" && KekRaktar[2] == 3)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[2] == 4)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[2] == 5)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[2] == 6)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && KekRaktar[2] == 7)
            {

                r_lb_2.Background = new ImageBrush(new BitmapImage(new Uri("../Hozzavalo/CSOKI.png", UriKind.Relative)));
            }
        }

        public void CseszeTartalomPictures()
        {
            //VÖRÖS
            char a = pirosCsesze_1S[0];
            char b = pirosCsesze_1S[1];
            char c = pirosCsesze_1S[2];
            char d = pirosCsesze_1S[3];

            // A
            if (lb_name.Content == "Red" && a == '8')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '0')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '1')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '2')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '3')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '4')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '5')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '6')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '7')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }
            ;
            // B
            if (lb_name.Content == "Red" && b == '8')
            {

                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            ;
            if (lb_name.Content == "Red" && b == '0')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '1')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '2')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '3')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '4')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '5')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '6')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '7')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // C
            if (lb_name.Content == "Red" && c == '8')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '0')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '1')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '2')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '3')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '4')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '5')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '6')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '7')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // D
            if (lb_name.Content == "Red" && d == '8')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '0')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '1')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '2')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '3')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '4')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '5')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '6')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '7')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            a = pirosCsesze_2S[0];
            b = pirosCsesze_2S[1];
            c = pirosCsesze_2S[2];
            d = pirosCsesze_2S[3];
            // A
            if (lb_name.Content == "Red" && a == '8')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '0')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '1')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '2')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '3')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '4')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '5')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '6')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '7')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // B
            if (lb_name.Content == "Red" && b == '8')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '0')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '1')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '2')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '3')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '4')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '5')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '6')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '7')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // C
            if (lb_name.Content == "Red" && c == '8')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '0')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '1')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '2')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '3')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '4')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '5')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '6')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '7')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // D
            if (lb_name.Content == "Red" && d == '8')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '0')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '1')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '2')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '3')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '4')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '5')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '6')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '7')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            a = pirosCsesze_3S[0];
            b = pirosCsesze_3S[1];
            c = pirosCsesze_3S[2];
            d = pirosCsesze_3S[3];
            // A
            if (lb_name.Content == "Red" && a == '8')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '0')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '1')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '2')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '3')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '4')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '5')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '6')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && a == '7')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // B
            if (lb_name.Content == "Red" && b == '8')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '0')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '1')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '2')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '3')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '4')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '5')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '6')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && b == '7')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // C
            if (lb_name.Content == "Red" && c == '8')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '0')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '1')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '2')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '3')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '4')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '5')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '6')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && c == '7')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // D
            if (lb_name.Content == "Red" && d == '8')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '0')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '1')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '2')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '3')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '4')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '5')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '6')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Red" && d == '7')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }
            // KEK

            a = kekCsesze_1S[0];
            b = kekCsesze_1S[1];
            c = kekCsesze_1S[2];
            d = kekCsesze_1S[3];
            // A
            if (lb_name.Content == "Blue" && a == '8')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '0')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '1')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '2')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '3')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '4')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '5')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '6')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '7')
            {
                CS_1_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // B
            if (lb_name.Content == "Blue" && b == '8')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '0')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '1')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '2')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '3')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '4')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '5')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '6')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '7')
            {
                CS_1_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // C
            if (lb_name.Content == "Blue" && c == '8')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '0')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '1')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '2')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '3')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '4')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '5')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '6')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '7')
            {
                CS_1_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // D
            if (lb_name.Content == "Blue" && d == '8')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '0')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '1')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '2')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '3')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '4')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '5')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '6')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '7')
            {
                CS_1_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            a = kekCsesze_2S[0];
            b = kekCsesze_2S[1];
            c = kekCsesze_2S[2];
            d = kekCsesze_2S[3];
            // A
            if (lb_name.Content == "Blue" && a == '8')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '0')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '1')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '2')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '3')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '4')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '5')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '6')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '7')
            {
                CS_2_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // B
            if (lb_name.Content == "Blue" && b == '8')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '0')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '1')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '2')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '3')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '4')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '5')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '6')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '7')
            {
                CS_2_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // C
            if (lb_name.Content == "Blue" && c == '8')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '0')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '1')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '2')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '3')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '4')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '5')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '6')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '7')
            {
                CS_2_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // D
            if (lb_name.Content == "Blue" && d == '8')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '0')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '1')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '2')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '3')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '4')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '5')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '6')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '7')
            {
                CS_2_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            a = kekCsesze_3S[0];
            b = kekCsesze_3S[1];
            c = kekCsesze_3S[2];
            d = kekCsesze_3S[3];
            // A
            if (lb_name.Content == "Blue" && a == '8')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '0')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '1')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '2')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '3')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '4')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '5')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '6')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && a == '7')
            {
                CS_3_0.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // B
            if (lb_name.Content == "Blue" && b == '8')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '0')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '1')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '2')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '3')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '4')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '5')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '6')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && b == '7')
            {
                CS_3_1.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // C
            if (lb_name.Content == "Blue" && c == '8')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '0')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '1')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '2')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '3')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '4')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '5')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '6')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && c == '7')
            {
                CS_3_2.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }

            // D
            if (lb_name.Content == "Blue" && d == '8')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/URES.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '0')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/JEG.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '1')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KARAMELL.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '2')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/GOZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '3')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/KAVEBAB.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '4')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEJ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '5')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/VIZ.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '6')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/TEA.png", UriKind.Relative)));
            }
            if (lb_name.Content == "Blue" && d == '7')
            {
                CS_3_3.Background = new ImageBrush(new BitmapImage(new Uri("../Poharban/CSOKI.png", UriKind.Relative)));
            }
        }

        public void CardsShower()
        {
            KezdoKarytaGeneralo();
            if (lb_name.Content == "Red")
            {
                ElsoSor1.Content = PirosKarytaStatus[0, 0];
                ElsoSor2.Content = PirosKarytaStatus[0, 1];
                ElsoSor3.Content = PirosKarytaStatus[0, 2];
                ElsoSor4.Content = PirosKarytaStatus[0, 3];
                ElsoSor5.Content = PirosKarytaStatus[0, 4];

                MasodikSor1.Content = PirosKarytaStatus[1, 0];
                MasodikSor2.Content = PirosKarytaStatus[1, 1];
                MasodikSor3.Content = PirosKarytaStatus[1, 2];
                MasodikSor4.Content = PirosKarytaStatus[1, 3];
                MasodikSor5.Content = PirosKarytaStatus[1, 4];

                HarmadikSor1.Content = PirosKarytaStatus[2, 0];
                HarmadikSor2.Content = PirosKarytaStatus[2, 1];
                HarmadikSor3.Content = PirosKarytaStatus[2, 2];
                HarmadikSor4.Content = PirosKarytaStatus[2, 3];
                HarmadikSor5.Content = PirosKarytaStatus[2, 4];

                NegyedikSor1.Content = PirosKarytaStatus[3, 0];
                NegyedikSor2.Content = PirosKarytaStatus[3, 1];
                NegyedikSor3.Content = PirosKarytaStatus[3, 2];
                NegyedikSor4.Content = PirosKarytaStatus[3, 3];
                NegyedikSor5.Content = PirosKarytaStatus[3, 4];
            }
            if (lb_name.Content == "Blue")
            {
                ElsoSor1.Content = KekKarytaStatus[0, 0];
                ElsoSor2.Content = KekKarytaStatus[0, 1];
                ElsoSor3.Content = KekKarytaStatus[0, 2];
                ElsoSor4.Content = KekKarytaStatus[0, 3];
                ElsoSor5.Content = KekKarytaStatus[0, 4];

                MasodikSor1.Content = KekKarytaStatus[1, 0];
                MasodikSor2.Content = KekKarytaStatus[1, 1];
                MasodikSor3.Content = KekKarytaStatus[1, 2];
                MasodikSor4.Content = KekKarytaStatus[1, 3];
                MasodikSor5.Content = KekKarytaStatus[1, 4];

                HarmadikSor1.Content = KekKarytaStatus[2, 0];
                HarmadikSor2.Content = KekKarytaStatus[2, 1];
                HarmadikSor3.Content = KekKarytaStatus[2, 2];
                HarmadikSor4.Content = KekKarytaStatus[2, 3];
                HarmadikSor5.Content = KekKarytaStatus[2, 4];

                NegyedikSor1.Content = KekKarytaStatus[3, 0];
                NegyedikSor2.Content = KekKarytaStatus[3, 1];
                NegyedikSor3.Content = KekKarytaStatus[3, 2];
                NegyedikSor4.Content = KekKarytaStatus[3, 3];
                NegyedikSor5.Content = KekKarytaStatus[3, 4];
            }
        }


        private void r_lb_0_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged2(0, sender);
        }

        private void r_lb_1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged2(1, sender);
        }

        private void r_lb_2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged2(2, sender);
        }



        private void seged(int x, int y, object sender)
        {
            if (FoglaloTabla[x, y] == 0 && PirosBabuLent == false && lb_name.Content == "Red")
            {
                FoglaloTabla[x, y] = 1;
                PirosBabuLent = true;
                PirosXpoz = x;
                PirosYpoz = y;
                StorageFiller();
                showanyag();

            }
            else if (FoglaloTabla[x, y] == 0 && PirosBabuLent == true && KekBabuLent == false && lb_name.Content == "Blue")
            {
                FoglaloTabla[x, y] = 2;
                KekBabuLent = true;
                KekXpoz = x;
                KekYpoz = y;
                StorageFiller();
                showanyag();

            }
        }

        private void _00_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(0, 0, sender);
        }
        private void _01_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(0, 1, sender);
        }
        private void _02_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(0, 2, sender);
        }
        private void _03_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(0, 3, sender);
        }
        private void _10_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(1, 0, sender);
        }
        private void _11_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(1, 1, sender);
        }
        private void _12_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(1, 2, sender);
        }
        private void _13_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(1, 3, sender);
        }
        private void _20_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(2, 0, sender);
        }
        private void _21_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(2, 1, sender);
        }
        private void _22_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(2, 2, sender);
        }
        private void _23_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(2, 3, sender);
        }
        private void _30_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(3, 0, sender);
        }
        private void _31_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(3, 1, sender);
        }
        private void _32_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(3, 2, sender);
        }
        private void _33_lb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seged(3, 3, sender);
        }

        private void CS_1_Kuka_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lb_name.Content == "Red")
            {
                pirosCsesze_1[0] = 8;
                pirosCsesze_1[1] = 8;
                pirosCsesze_1[2] = 8;
                pirosCsesze_1[3] = 8;
                pirosCsesze_1S = "8888";
                showanyag();
            }
            if (lb_name.Content == "Blue")
            {
                kekCsesze_1[0] = 8;
                kekCsesze_1[1] = 8;
                kekCsesze_1[2] = 8;
                kekCsesze_1[3] = 8;
                kekCsesze_1S = "8888";
                showanyag();
            }

        }

        private void CS_2_Kuka_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lb_name.Content == "Red")
            {
                pirosCsesze_2[0] = 8;
                pirosCsesze_2[1] = 8;
                pirosCsesze_2[2] = 8;
                pirosCsesze_2[3] = 8;
                pirosCsesze_2S = "8888";
                showanyag();
            }
            if (lb_name.Content == "Blue")
            {
                kekCsesze_2[0] = 8;
                kekCsesze_2[1] = 8;
                kekCsesze_2[2] = 8;
                kekCsesze_2[3] = 8;
                kekCsesze_2S = "8888";
                showanyag();
            }
        }

        private void CS_3_Kuka_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lb_name.Content == "Red")
            {
                pirosCsesze_3[0] = 8;
                pirosCsesze_3[1] = 8;
                pirosCsesze_3[2] = 8;
                pirosCsesze_3[3] = 8;
                pirosCsesze_3S = "8888";
                showanyag();
            }
            if (lb_name.Content == "Blue")
            {
                kekCsesze_3[0] = 8;
                kekCsesze_3[1] = 8;
                kekCsesze_3[2] = 8;
                kekCsesze_3[3] = 8;
                kekCsesze_3S = "8888";
                showanyag();
            }
        }

        private void CS_1_Pipa_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lb_name.Content == "Red")
            {
                for (int i = 0; i < PirosKarytaStatus.GetLength(0); i++)
                {
                    for (int j = 0; j < PirosKarytaStatus.GetLength(1); j++)
                    {
                        if (pirosCsesze_1S == PirosKarytaStatus[i, j])
                        {
                            PirosPluszPont++;
                            L_Plus.Content = PirosPluszPont;

                            pirosCsesze_1[0] = 8;
                            pirosCsesze_1[1] = 8;
                            pirosCsesze_1[2] = 8;
                            pirosCsesze_1[3] = 8;
                            pirosCsesze_1S = "8888";
                            PirosKarytaStatus[i, j] = "8";
                            ElsoSorKartyaGeneralasHaKeszEgyRendeles();
                            showanyag();
                            break;
                        }
                    }
                }
            }
            if (lb_name.Content == "Blue")
            {
                for (int i = 0; i < KekKarytaStatus.GetLength(0); i++)
                {
                    for (int j = 0; j < KekKarytaStatus.GetLength(1); j++)
                    {
                        if (kekCsesze_1S == KekKarytaStatus[i, j])
                        {
                            KekPluszPont++;
                            L_Plus.Content = KekPluszPont;

                            kekCsesze_1[0] = 8;
                            kekCsesze_1[1] = 8;
                            kekCsesze_1[2] = 8;
                            kekCsesze_1[3] = 8;
                            kekCsesze_1S = "8888";
                            KekKarytaStatus[i, j] = "8";
                            ElsoSorKartyaGeneralasHaKeszEgyRendeles();
                            showanyag();
                            break;
                        }
                    }
                }
            }
        }

        private void CS_2_Pipa_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lb_name.Content == "Red")
            {
                for (int i = 0; i < PirosKarytaStatus.GetLength(0); i++)
                {
                    for (int j = 0; j < PirosKarytaStatus.GetLength(1); j++)
                    {
                        if (pirosCsesze_2S == PirosKarytaStatus[i, j])
                        {
                            PirosPluszPont++;
                            L_Plus.Content = PirosPluszPont;

                            pirosCsesze_2[0] = 8;
                            pirosCsesze_2[1] = 8;
                            pirosCsesze_2[2] = 8;
                            pirosCsesze_2[3] = 8;
                            pirosCsesze_2S = "8888";
                            PirosKarytaStatus[i, j] = "8";
                            ElsoSorKartyaGeneralasHaKeszEgyRendeles();
                            showanyag();
                            break;
                        }
                    }
                }
            }
            if (lb_name.Content == "Blue")
            {
                for (int i = 0; i < KekKarytaStatus.GetLength(0); i++)
                {
                    for (int j = 0; j < KekKarytaStatus.GetLength(1); j++)
                    {
                        if (kekCsesze_2S == KekKarytaStatus[i, j])
                        {
                            KekPluszPont++;
                            L_Plus.Content = KekPluszPont;

                            kekCsesze_2[0] = 8;
                            kekCsesze_2[1] = 8;
                            kekCsesze_2[2] = 8;
                            kekCsesze_2[3] = 8;
                            kekCsesze_2S = "8888";
                            KekKarytaStatus[i, j] = "8";
                            ElsoSorKartyaGeneralasHaKeszEgyRendeles();
                            showanyag();
                            break;
                        }
                    }
                }
            }
        }

        private void CS_3_Pipa_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lb_name.Content == "Red")
            {
                for (int i = 0; i < PirosKarytaStatus.GetLength(0); i++)
                {
                    for (int j = 0; j < PirosKarytaStatus.GetLength(1); j++)
                    {
                        if (pirosCsesze_3S == PirosKarytaStatus[i, j])
                        {
                            PirosPluszPont++;
                            L_Plus.Content = PirosPluszPont;

                            pirosCsesze_3[0] = 8;
                            pirosCsesze_3[1] = 8;
                            pirosCsesze_3[2] = 8;
                            pirosCsesze_3[3] = 8;
                            pirosCsesze_3S = "8888";
                            PirosKarytaStatus[i, j] = "8";
                            ElsoSorKartyaGeneralasHaKeszEgyRendeles();
                            showanyag();
                            break;
                        }
                    }
                }
            }
            if (lb_name.Content == "Blue")
            {
                for (int i = 0; i < KekKarytaStatus.GetLength(0); i++)
                {
                    for (int j = 0; j < KekKarytaStatus.GetLength(1); j++)
                    {
                        if (kekCsesze_3S == KekKarytaStatus[i, j])
                        {
                            KekPluszPont++;
                            L_Plus.Content = KekPluszPont;

                            kekCsesze_3[0] = 8;
                            kekCsesze_3[1] = 8;
                            kekCsesze_3[2] = 8;
                            kekCsesze_3[3] = 8;
                            kekCsesze_3S = "8888";
                            KekKarytaStatus[i, j] = "8";
                            ElsoSorKartyaGeneralasHaKeszEgyRendeles();
                            showanyag();
                            break;
                        }
                    }
                }
            }
        }

        public void CardPictureShower()
        {
            // LATHATATLAN KARYTAK
            if (ElsoSor1.Content == "8")
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (ElsoSor2.Content == "8")
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (ElsoSor3.Content == "8")
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (ElsoSor4.Content == "8")
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (ElsoSor5.Content == "8")
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }


            if (MasodikSor1.Content == "8")
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (MasodikSor2.Content == "8")
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (MasodikSor3.Content == "8")
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (MasodikSor4.Content == "8")
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (MasodikSor5.Content == "8")
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }

            if (HarmadikSor1.Content == "8")
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (HarmadikSor2.Content == "8")
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (HarmadikSor3.Content == "8")
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (HarmadikSor4.Content == "8")
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (HarmadikSor5.Content == "8")
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }

            if (NegyedikSor1.Content == "8")
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (NegyedikSor2.Content == "8")
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (NegyedikSor3.Content == "8")
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (NegyedikSor4.Content == "8")
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }
            if (NegyedikSor5.Content == "8")
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri("../Kartyak/Atlatszo_Kartya.png", UriKind.Relative)));
            }

            //KARAMELLAS FRAPPE 0,1,3,4
            string karytamutato2 = "../Kartyak/Kartya_0134.png";
            string Content = "0134";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //KARAMELLAS Jegeskávé 0,1,3,4
            karytamutato2 = "../Kartyak/Kartya_0138.png";
            Content = "0138";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Jeges Mocha 0,3,4,7
            karytamutato2 = "../Kartyak/Kartya_0347.png";
            Content = "0347";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Jeges Caffé Latte 0,3,4,8
            karytamutato2 = "../Kartyak/Kartya_0348.png";
            Content = "0348";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Cold Brew 0,3,5,8
            karytamutato2 = "../Kartyak/Kartya_0358.png";
            Content = "0358";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Jeges Tejes Tea	0,4,6,8
            karytamutato2 = "../Kartyak/Kartya_0468.png";
            Content = "0468";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Csokoládé Shake	0,4,7,8
            karytamutato2 = "../Kartyak/Kartya_0478.png";
            Content = "0478";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Csokoládé Shake	0568
            karytamutato2 = "../Kartyak/Kartya_0568.png";
            Content = "0568";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Csokoládé Shake	1,2,3,4
            karytamutato2 = "../Kartyak/Kartya_1234.png";
            Content = "1234";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Csokoládé Shake	2348
            karytamutato2 = "../Kartyak/Kartya_2348.png";
            Content = "2348";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Csokoládé Shake	2,3,5,8
            karytamutato2 = "../Kartyak/Kartya_2358.png";
            Content = "2358";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Csokoládé Shake	2,3,8,8
            karytamutato2 = "../Kartyak/Kartya_2388.png";
            Content = "2388";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Csokoládé Shake	2,3,3,8
            karytamutato2 = "../Kartyak/Kartya_2338.png";
            Content = "2338";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Csokoládé Shake	2,3,4,7
            karytamutato2 = "../Kartyak/Kartya_2347.png";
            Content = "2347";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Csokoládé Shake	2468
            karytamutato2 = "../Kartyak/Kartya_2468.png";
            Content = "2468";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Csokoládé Shake	2,4,7,8
            karytamutato2 = "../Kartyak/Kartya_2478.png";
            Content = "2478";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            //Csokoládé Shake	2568
            karytamutato2 = "../Kartyak/Kartya_2568.png";
            Content = "2568";
            if (ElsoSor1.Content == Content)
            {
                ElsoSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor2.Content == Content)
            {
                ElsoSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor3.Content == Content)
            {
                ElsoSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor4.Content == Content)
            {
                ElsoSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (ElsoSor5.Content == Content)
            {
                ElsoSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }


            if (MasodikSor1.Content == Content)
            {
                MasodikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor2.Content == Content)
            {
                MasodikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor3.Content == Content)
            {
                MasodikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor4.Content == Content)
            {
                MasodikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (MasodikSor5.Content == Content)
            {
                MasodikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (HarmadikSor1.Content == Content)
            {
                HarmadikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor2.Content == Content)
            {
                HarmadikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor3.Content == Content)
            {
                HarmadikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor4.Content == Content)
            {
                HarmadikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (HarmadikSor5.Content == Content)
            {
                HarmadikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }

            if (NegyedikSor1.Content == Content)
            {
                NegyedikSor1.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor2.Content == Content)
            {
                NegyedikSor2.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor3.Content == Content)
            {
                NegyedikSor3.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor4.Content == Content)
            {
                NegyedikSor4.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
            if (NegyedikSor5.Content == Content)
            {
                NegyedikSor5.Background = new ImageBrush(new BitmapImage(new Uri(karytamutato2, UriKind.Relative)));
            }
        }
    }
}
