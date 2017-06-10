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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cw_3_RAD
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {

        //  v_      - variables
        //  p_      - property
        //  sm_     - standard methods
        //  xe_     - XAML elements
        //  em_     - event methods

        //==================================================================================================================
        //============================================== VARIABLES =========================================================
        //==================================================================================================================

        Storyboard v_storyboardCloseToRed;
        Storyboard v_storyboardCloseToWhite;
        Storyboard v_storyboardMinimizeToBlue;
        Storyboard v_storyboardMinimizeToWhite;
        Storyboard v_storyboardMinimizeWindow;
        Storyboard v_storyboardRestoreWindow;

        string v_hintGetReady = "Przygotuj sie...";
        string v_hintClickNow = "Klikaj teraz!";
        string v_hintPlayAgain = "Zagraj jeszcze raz!";
        string v_hintGratz = "Gratulacje, zakończyłeś grę :-)";
        //string v_TIPP = "#TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP #TIPP";

        /// <summary>
        /// Glowny Timer do aplikacji - nie zlicza czasu pomiedzy kliknieciami
        /// </summary>
        System.Windows.Threading.DispatcherTimer timerMain; // TIMER

        /// <summary>
        /// Stoper - on zlicza czas miedzy kliknieciami
        /// </summary>
        System.Diagnostics.Stopwatch stopwatch; // STOPER

        /// <summary>
        /// Przechowuje ilosc tickow Timera ostatniego klikniecia
        /// </summary>
        int v_odstep = 0; 

        /// <summary>
        /// Przechowuje wszystkie wyniki z biezacej gry
        /// </summary>
        List<int> v_listaWynikow = new List<int>();

        //==================================================================================================================
        //=============================================== PROPERTY =========================================================
        //==================================================================================================================

        /// <summary>
        /// Przelacznik sluzacy do animowania minimalizacji okna.
        /// </summary>
        public bool p_recureWindowAnimation { get; private set; } = true;

        /// <summary>
        /// Okresla ile graczowi pozostalo jeszcze klikniec do konca gry
        /// </summary>
        public int p_clicksLeft { get; set; } = Properties.Settings.Default.ileKlikniec;//10; //wstepnie, ok?

        /// <summary>
        /// Okresla minimalna przerwe pomiedzy kolejnymi kliknieciami [ms]
        /// </summary>
        public int p_buffer { get; set; } = 1000;

        /// <summary>
        /// Okresla przedzial wewnatrz ktorego moze zmienic sie kolor KWADRATU [ms]
        /// </summary>
        public int p_okres { get; set; } = 3000;

        /// <summary>
        /// Okresla czy aplikacja jest w stanie w ktorym powinna mierzyc czas
        /// </summary>
        public bool p_czyMierzyCzas { get; set; } = false;

        /// <summary>
        /// Okresla czy gra sie zakonczyla i jest gotowa do zresetowania
        /// </summary>
        public bool p_isGameOver { get; set; } = true;

        //==================================================================================================================
        //======================================= CONSTRUCTOR / DESTRUCTOR =================================================
        //==================================================================================================================

        public Game(int cbuffer, int cokres, int cIle)
        {
            InitializeComponent();

            p_buffer = cbuffer;
            p_okres = cokres;
            //p_clicksLeft = cIle;

            //Animacje
            v_storyboardCloseToRed = (Storyboard)FindResource("Storyboard_Close_ToRed");
            v_storyboardCloseToWhite = (Storyboard)FindResource("Storyboard_Close_ToWhite");
            v_storyboardMinimizeToBlue = (Storyboard)FindResource("Storyboard_Minimize_ToBlue");
            v_storyboardMinimizeToWhite = (Storyboard)FindResource("Storyboard_Minimize_ToWhite");

            v_storyboardMinimizeWindow = (Storyboard)FindResource("Storyboard_Minimize_Window");
            v_storyboardMinimizeWindow.Completed += em_storyboardMinimizeWindow_OnComplete;

            v_storyboardRestoreWindow = (Storyboard)FindResource("Storyboard_Restore_Window");

            //Inne rzeczy
            //xe_TextBlock_TIPP.Text = v_TIPP;
            xe_BUTTON_face_img.Visibility = Visibility.Collapsed;

            timerMain = new System.Windows.Threading.DispatcherTimer();
            timerMain.Tick += timerMain_Tick;
            timerMain.Interval = new TimeSpan(0,0,0,0,1);

            stopwatch = new System.Diagnostics.Stopwatch();

            xe_Label_NumberLeft.Content = p_clicksLeft.ToString();

            //Wyolosuj 1st odstep
            v_odstep = sm_LosujZPrzedzialu();
        }

        

        //==================================================================================================================
        //============================================= STD METHODS ========================================================
        //==================================================================================================================

        /// <summary>
        /// Zwraca liczbe pomiedzy 0 a max. okres dla [ms]
        /// </summary>
        private int sm_LosujZPrzedzialu()
        {
            Random kostka = new Random();
            return kostka.Next(p_okres);
        }

        /// <summary>
        /// Inicjalizuje tyle komorek listy z wynikami ile uzytkownik ma razy kliknac
        /// </summary>
        private void sm_InicjalizujListe()
        {
            v_listaWynikow = new List<int>();
            for (int i = 0; i < p_clicksLeft; i++)
            {
                v_listaWynikow.Add(0);
            }
        }

        //==================================================================================================================
        //============================================= EVENT METHODS ======================================================
        //==================================================================================================================

        private void em_Close_OnMouseEnter(object sender, MouseEventArgs e)
        {
            v_storyboardCloseToRed.Begin(this);
        }

        private void em_Close_OnMouseLeave(object sender, MouseEventArgs e)
        {
            v_storyboardCloseToWhite.Begin(this);
        }

        private void em_Close_OnClick(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void em_Minimize_OnMouseEnter(object sender, MouseEventArgs e)
        {
            v_storyboardMinimizeToBlue.Begin(this);
        }

        private void em_Minimize_OnMouseLeave(object sender, MouseEventArgs e)
        {
            v_storyboardMinimizeToWhite.Begin(this);
        }

        private void em_Minimize_OnClick(object sender, MouseButtonEventArgs e)
        {
            v_storyboardMinimizeWindow.Begin(this);
            p_recureWindowAnimation = false;
        }

        private void em_storyboardMinimizeWindow_OnComplete(object sender, EventArgs e)
        {
            WindowState = WindowState.Minimized;

        }

        private void em_Window_OnStateChanged(object sender, EventArgs e)
        {

            if (WindowState == WindowState.Minimized)
            {
                if (p_recureWindowAnimation) WindowState = WindowState.Normal;
                v_storyboardMinimizeWindow.Begin(this);
                p_recureWindowAnimation = false;
            }
            else
            {
                v_storyboardRestoreWindow.Begin(this);
                p_recureWindowAnimation = true;
            }

        }

        private void em_TitleBar_Grid_OnClick(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void Losuj_kolor(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            LinearGradientBrush gradientBrush = new LinearGradientBrush(Color.FromRgb((byte)r.Next(1, 255),
              (byte)r.Next(1, 255), (byte)r.Next(1, 233)), Color.FromRgb(255, 255, 255), new Point(0, 0), new Point(1, 0.9));
            xe_Grid_TitleBar.Background = gradientBrush;
        }

        private void em_Back_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow OknoGlowne = new MainWindow();
            OknoGlowne.Show();
            Close();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (p_czyMierzyCzas)
            {
                //W trakcie mierzenia czasu: od zmiany koloru KWADRATU na czerwony az do momentu klikniecia
                //nie wykonuja sie zadne instrukcje OnTimerTick
            }
            else
            {
                if(stopwatch.ElapsedMilliseconds > p_buffer + v_odstep)
                {
                    //Gdy KWADRAT jest zielony to jesli minela ilosc czasu [buffer]+[0 - okres (rnd)] zmieniamy
                    //kolor na czerwony i cos tam...
                    stopwatch.Stop();
                    stopwatch.Reset();
                    p_czyMierzyCzas = true;
                    xe_DUZY_ZIELONY_KWADRAT.Fill = Brushes.PaleVioletRed;
                    xe_KWADRAT_textBlock.Text = v_hintClickNow;
                    stopwatch.Start();
                }
            }
        }

        private void em_BUTTON_CLICK(object sender, RoutedEventArgs e)
        {
            
            if(p_isGameOver)
            {
                sm_InicjalizujListe();
                stopwatch.Reset(); //Bo cos sie tam fixuje
                timerMain.Start();
                xe_BUTTON_Label_text.Visibility = Visibility.Collapsed;
                xe_BUTTON_face_img.Visibility = Visibility.Visible;
                xe_KWADRAT_textBlock.Text = v_hintGetReady;
                xe_Label_NumberLeft.Content = p_clicksLeft.ToString();
                xe_DUZY_ZIELONY_KWADRAT.Fill = Brushes.LightGreen;
                p_isGameOver = false;
                stopwatch.Start();
            }
            else
            {
                if (p_czyMierzyCzas)
                {
                    //WYLOSUJ OKRES
                    v_odstep = sm_LosujZPrzedzialu();
                    //STOP LICZENIA CZASU
                    stopwatch.Stop();
                    //ZMIANA Z CZERWONEGO NA ZIELONY
                    xe_DUZY_ZIELONY_KWADRAT.Fill = Brushes.LightGreen;
                    xe_KWADRAT_textBlock.Text = v_hintGetReady;
                    //ZMIANA TEJ PROPRTY
                    p_czyMierzyCzas = false;
                    //ZAPISANIE WYNIKU DO LISTY
                    v_listaWynikow[p_clicksLeft - 1] = (int)stopwatch.ElapsedMilliseconds;
                    //AKTUALIZACJA CLICK LEFT
                    p_clicksLeft--;
                    xe_Label_NumberLeft.Content = p_clicksLeft.ToString();
                    stopwatch.Reset();
                    stopwatch.Start();
                    if(p_clicksLeft == 0)//KONIEC GRY
                    {
                        p_isGameOver = true;
                        timerMain.Stop();
                        xe_KWADRAT_textBlock.Text = v_hintGratz;
                        xe_DUZY_ZIELONY_KWADRAT.Fill = Brushes.Orange;

                        Wynik oknoWynik = new Wynik(v_listaWynikow);
                        oknoWynik.ShowDialog();

                        p_clicksLeft = Properties.Settings.Default.ileKlikniec;
                        xe_BUTTON_face_img.Visibility = Visibility.Collapsed;
                        xe_BUTTON_Label_text.Content = v_hintPlayAgain;
                        xe_BUTTON_Label_text.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    //NOTHING HAPPENS...
                    //Cw_3_RAD.Properties.Resources
                    //Cw_3_RAD.Properties.Settings.Default.Save()
                }
            }

            

        }

        //==================================================================================================================
        //============================================= UNCATEGORIZED ======================================================
        //==================================================================================================================



    }
}
