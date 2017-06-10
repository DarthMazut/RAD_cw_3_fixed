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
    /// Interaction logic for Wynik.xaml
    /// </summary>
    public partial class Wynik : Window
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

        List<int> v_listaWynikowDoPrzekazania;
        float v_sumaWynik = 0;
        float v_sredniaWynik = 0;

        //==================================================================================================================
        //=============================================== PROPERTY =========================================================
        //==================================================================================================================


        //==================================================================================================================
        //======================================= CONSTRUCTOR / DESTRUCTOR =================================================
        //==================================================================================================================
        /// <summary>
        /// Tworzy okno z wynikami gry.
        /// </summary>
        /// <param name="listaWynikow">Lista wynikow z poszczegolnych klikniec</param>
        public Wynik(List<int> listaWynikow)
        {
            InitializeComponent();
            xe_TextBlock_wyniki.Text = "";
            
            v_listaWynikowDoPrzekazania = listaWynikow;

            foreach (int wynik in v_listaWynikowDoPrzekazania)
            {
                v_sumaWynik += wynik;
                xe_TextBlock_wyniki.Text += ("[ "+(v_listaWynikowDoPrzekazania.IndexOf(wynik)+1).ToString()+" ] " +wynik.ToString() + "\n");
            }
            v_sredniaWynik = v_sumaWynik / v_listaWynikowDoPrzekazania.Count;

            v_storyboardCloseToRed = (Storyboard)FindResource("Storyboard_Close_ToRed");
            v_storyboardCloseToWhite = (Storyboard)FindResource("Storyboard_Close_ToWhite");

            xe_TextBox_name.Text = "Anonim " + DateTime.Now.ToString();

            xe_WYNIK.Content = v_sredniaWynik.ToString();
        }

        //==================================================================================================================
        //============================================= STD METHODS ========================================================
        //==================================================================================================================

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
            Close();
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

        private void em_TextBox_OnTextChange(object sender, TextChangedEventArgs e)
        {
            if(xe_TextBox_name.Text.Length >= 60)
            {
                MessageBox.Show("SRLSLY??");
                xe_TextBox_name.Text = "Bez jaj, podaj normalny nick...";
            }
        }

        private void em_Button_NieTymRazem(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void em_ZapiszWynik_OnClick(object sender, RoutedEventArgs e)
        {
            //Properties.Settings.Default.HighscoreListNicks[0] = xe_TextBox_name.Text;
            Properties.Settings.Default.HighscoreListNicks.Add(xe_TextBox_name.Text);
            Properties.Settings.Default.HighscoreListScore.Add(xe_WYNIK.Content.ToString());
            Properties.Settings.Default.HighscoreListDate.Add(DateTime.Now.ToString());
            Properties.Settings.Default.Save();
            Close();
        }

        private void em_TextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                em_ZapiszWynik_OnClick(null, null);
            }
        }

        //==================================================================================================================
        //============================================= UNCATEGORIZED ======================================================
        //==================================================================================================================




    }
}
