using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cw_3_RAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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
        Storyboard v_storyboardLogoColor;
        Storyboard v_storyboardHighscoreTabOpen;
        Storyboard v_storyboardHighscoreTabClose;
        Storyboard v_storyboardAboutTabOpen;
        Storyboard v_storyboardAboutTabClose;
        Storyboard v_storyboardSettingsTabOpen;
        Storyboard v_storyboardSettingsTabClose;

        string v_hintCloseTab = "Zamknij kartę.";
        string v_hintHighscore = "Sprawdź do kogo należą najlepsze wyniki.";
        string v_hintClear = "Usuń wszystkie dotychczasowe najlepsze wyniki.";
        string v_hintAbout = "Dowiedz się więcej na temat aplikacji.";
        string v_hintExit = "Zamknij aplikację.";
        string v_hintSettings = "Zmień ustawienia aplikacji.";
        string v_hintGraj = "Rozpocznij grę.";
        string v_hintZatwierdz = "Zatwierdza wprowadzone zmiany";
        string v_SettingsWrong = "Wprowadzone dane są niepoprawne.";
        string v_SettingsGood = "Możesz zatwierdzić wprowadzone dane.";
        string v_SettingsTooltip = "Nie możesz zatwierdzić wprowadzonych wartości, ponieważ są one nieprawidłowe, ok?";

        public struct Miejsca
        {
            public string nick { get; set; }
            public string score { get; set; }
            public string date { get; set; }
        }

        Regex v_RegexBuffer;
        Regex v_RegexOkres;
        Regex v_RegexIle;

        //==================================================================================================================
        //=============================================== PROPERTY =========================================================
        //==================================================================================================================

        /// <summary>
        /// Przelacznik sluzacy do animowania minimalizacji okna.
        /// </summary>
        public bool p_recureWindowAnimation { get; private set; } = true;

        //==================================================================================================================
        //======================================= CONSTRUCTOR / DESTRUCTOR =================================================
        //==================================================================================================================

        public MainWindow()
        {
            InitializeComponent();

            //Animacje
            v_storyboardCloseToRed = (Storyboard)FindResource("Storyboard_Close_ToRed");
            v_storyboardCloseToWhite = (Storyboard)FindResource("Storyboard_Close_ToWhite");
            v_storyboardMinimizeToBlue = (Storyboard)FindResource("Storyboard_Minimize_ToBlue");
            v_storyboardMinimizeToWhite = (Storyboard)FindResource("Storyboard_Minimize_ToWhite");

            v_storyboardMinimizeWindow = (Storyboard)FindResource("Storyboard_Minimize_Window");
            v_storyboardMinimizeWindow.Completed += em_storyboardMinimizeWindow_OnComplete;

            v_storyboardRestoreWindow = (Storyboard)FindResource("Storyboard_Restore_Window");

            v_storyboardLogoColor = (Storyboard)FindResource("Storyboard_Logo_Rotate");
            v_storyboardLogoColor.Begin(this, true);

            v_storyboardHighscoreTabOpen = (Storyboard)FindResource("Storyboard_Highscore_TabOpen");
            v_storyboardHighscoreTabClose = (Storyboard)FindResource("Storyboard_Highscore_TabClose");
            v_storyboardAboutTabOpen = (Storyboard)FindResource("Storyboard_About_TabOpen");
            v_storyboardAboutTabClose = (Storyboard)FindResource("Storyboard_About_TabClose");
            v_storyboardSettingsTabOpen = (Storyboard)FindResource("Storyboard_Settings_TabOpen");
            v_storyboardSettingsTabClose = (Storyboard)FindResource("Storyboard_Settings_TabClose");

            xe_Settings_Label_Komunikat.Content = null;
            v_RegexBuffer = new Regex("^[0-9]{1,6}$");
            v_RegexOkres = new Regex("^[0-9]{1,6}$");
            v_RegexIle = new Regex("^[0-9]{1,6}$");
            xe_Settings_ApplyChanges.ToolTip = v_SettingsTooltip;
            ToolTipService.SetShowOnDisabled(xe_Settings_ApplyChanges, true);

        }

        



        //==================================================================================================================
        //============================================= STD METHODS ========================================================
        //==================================================================================================================

        /// <summary>
        /// Wczytuje wyniki do tabeli Highscores z Resources Projektu
        /// </summary>
        private void sm_FillHighScoresTable()
        {
            Properties.Settings.Default.Reload();
            for(int i = 0; i < Properties.Settings.Default.HighscoreListNicks.Count; i++)
            {
                xe_Highscore_ListView.Items.Add(new Miejsca
                {
                    nick = Properties.Settings.Default.HighscoreListNicks[i],
                    score = Properties.Settings.Default.HighscoreListScore[i],
                    date = Properties.Settings.Default.HighscoreListDate[i]
                }
                );
            }

        }

        /// <summary>
        /// Uzupelnia textBoxy w settingsach ustawieniami z resources
        /// </summary>
        private void sm_FillSettingsTextBox()
        {
            Properties.Settings.Default.Reload();
            xe_Settings_TextBox_Bufor.Text = Properties.Settings.Default.Buffer.ToString();
            xe_Settings_TextBox_Okres.Text = Properties.Settings.Default.Okres.ToString();
            xe_Settings_TextBox_Ile.Text = Properties.Settings.Default.ileKlikniec.ToString();
        }

        /// <summary>
        /// Ustawia wyglad TextBoxa (i nie tylko) w zakladce ustawienia tak, aby sygnalizowal ze wpisane dane sa poprawne.
        /// </summary>
        /// <param name="textbox">Textbox, ktorego wyglad ma byc ustawiony.</param>
        private void sm_SettingsTextBoxGood(TextBox textbox)
        {
            textbox.Background = Brushes.LightGreen;
            if (xe_Settings_TextBox_Bufor.Background == Brushes.LightGreen && xe_Settings_TextBox_Okres.Background == Brushes.LightGreen && xe_Settings_TextBox_Ile.Background == Brushes.LightGreen) //wiem, super rozwiazanie :)
            {
                xe_Settings_ApplyChanges.IsEnabled = true;
                xe_Settings_Label_Komunikat.Content = v_SettingsGood;
                xe_Settings_Label_Komunikat.Foreground = Brushes.Green;
                ToolTipService.SetIsEnabled(xe_Settings_ApplyChanges, false);
            }
            
        }

        /// <summary>
        /// Ustawia wyglad TextBoxa (i nie tylko) w zakladce ustawienia tak, aby sygnalizowal ze wpisane dane sa NIEpoprawne.
        /// </summary>
        /// <param name="textbox">Textbox, ktorego wyglad ma byc ustawiony.</param>
        private void sm_SettingsTextBoxWrong(TextBox textbox)
        {
            xe_Settings_Label_Komunikat.Content = v_SettingsWrong;
            xe_Settings_Label_Komunikat.Foreground = Brushes.Red;
            textbox.Background = Brushes.Red;
            xe_Settings_ApplyChanges.IsEnabled = false;
            ToolTipService.SetIsEnabled(xe_Settings_ApplyChanges, true);
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

        private void em_MainWindow_OnStateChanged(object sender, EventArgs e)
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
            v_storyboardLogoColor.Pause(this);
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void em_TitleBar_Grid_OnMouseButtonRelease(object sender, MouseButtonEventArgs e)
        {
            v_storyboardLogoColor.Resume(this);
        }

        private void em_Highscore_Button_Back_OnClick(object sender, RoutedEventArgs e)
        {
            //xe_SideBar_Grid_Highscore.Width = 0;
            v_storyboardHighscoreTabClose.Begin(this);
            
        }

        private void em_SideMenu_Button_Highscore_OnClick(object sender, RoutedEventArgs e)
        {
            xe_SideBar_Grid_About.SetValue(Panel.ZIndexProperty, 0);
            xe_SideBar_Grid_Highscore.SetValue(Panel.ZIndexProperty, 1);
            xe_SideBar_Grid_Settings.SetValue(Panel.ZIndexProperty, 0);

            if (xe_SideBar_Grid_Highscore.Width == 0)
            {
                xe_Highscore_ListView.Items.Clear();
                sm_FillHighScoresTable();
                //MessageBox.Show(Properties.Settings.Default.HighscoreListScore.Count.ToString());

                v_storyboardHighscoreTabOpen.Begin(this);
            }
            else v_storyboardHighscoreTabClose.Begin(this);

            v_storyboardAboutTabClose.Begin(this);
            v_storyboardSettingsTabClose.Begin(this);
        }

        private void em_SideMenu_Highscore_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (xe_SideBar_Grid_Highscore.Width == 0) xe_StatusBar_Label_Hint.Content = v_hintHighscore;
            else xe_StatusBar_Label_Hint.Content = v_hintCloseTab;

        }

        private void em_SideMenu_Highscore_OnMouseLeave(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = null;
        }

        private void em_Highscore_Back_OnMouseEnter(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = v_hintCloseTab;   
        }

        private void em_Highscore_Back_OnMouseLeave(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = null;
        }

        private void em_About_Back_OnClick(object sender, RoutedEventArgs e)
        {
            v_storyboardAboutTabClose.Begin(this);
        }

        private void em_About_Button_OnClick(object sender, RoutedEventArgs e)
        {
            xe_SideBar_Grid_About.SetValue(Panel.ZIndexProperty, 1);
            xe_SideBar_Grid_Highscore.SetValue(Panel.ZIndexProperty, 0);
            xe_SideBar_Grid_Settings.SetValue(Panel.ZIndexProperty, 0);

            if (xe_SideBar_Grid_About.Width == 0) v_storyboardAboutTabOpen.Begin(this);
            else v_storyboardAboutTabClose.Begin(this);

            v_storyboardHighscoreTabClose.Begin(this);
            v_storyboardSettingsTabClose.Begin(this);
        }

        private void em_About_Button_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (xe_SideBar_Grid_About.Width == 0) xe_StatusBar_Label_Hint.Content = v_hintAbout;
            else xe_StatusBar_Label_Hint.Content = v_hintCloseTab;
        }

        private void em_About_Button_OnMouseLeave(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = null;
        }

        private void em_About_Back_OnMouseEnter(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = v_hintCloseTab;
        }

        private void em_About_Back_OnMouseLeave(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = null;
        }

        private void em_Exit_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void em_Exit_OnMouseEnter(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = v_hintExit;
        }

        private void em_Exit_OnMouseLeave(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = null;
        }

        private void em_Opcje_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (xe_SideBar_Grid_Settings.Width == 0) xe_StatusBar_Label_Hint.Content = v_hintSettings;
            else xe_StatusBar_Label_Hint.Content = v_hintCloseTab;
        }

        private void em_Opcje_OnMouseLeave(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = null;
        }

        private void em_Graj_OnMouseEnter(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = v_hintGraj;
        }

        private void em_Graj_OnMouseLeave(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = null;
        }

        private void em_Highscores_Button_Clear_OnMouseEnter(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = v_hintClear;
        }

        private void em_Highscores_Button_Clear_OnMouseLeave(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = null;
        }

        private void em_Settings_Back_OnClick(object sender, RoutedEventArgs e)
        {
            v_storyboardSettingsTabClose.Begin(this);
        }

        private void em_Opcje_OnClick(object sender, RoutedEventArgs e)
        {
            xe_SideBar_Grid_About.SetValue(Panel.ZIndexProperty, 0);
            xe_SideBar_Grid_Highscore.SetValue(Panel.ZIndexProperty, 0);
            xe_SideBar_Grid_Settings.SetValue(Panel.ZIndexProperty, 1);

            if (xe_SideBar_Grid_Settings.Width == 0)
            {
                sm_FillSettingsTextBox();

                v_storyboardSettingsTabOpen.Begin(this);
                v_storyboardHighscoreTabClose.Begin(this);
                v_storyboardAboutTabClose.Begin(this);
            }
            else v_storyboardSettingsTabClose.Begin(this);

        }

        private void Losuj_kolor(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            LinearGradientBrush gradientBrush = new LinearGradientBrush(Color.FromRgb((byte)r.Next(1, 255),
              (byte)r.Next(1, 255), (byte)r.Next(1, 233)), Color.FromRgb(255, 255, 255), new Point(0, 0), new Point(1, 0.9));
            xe_GridTitleBar.Background = gradientBrush;
        }

        private void em_Settings_Apply_OnMouseEnter(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = v_hintZatwierdz;
        }

        private void em_Settings_Apply_OnMouseLeave(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = null;
        }

        private void em_Settings_Back_OnMouseEnter(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = v_hintCloseTab;
        }

        private void em_Settings_Back_OnMouseLeave(object sender, MouseEventArgs e)
        {
            xe_StatusBar_Label_Hint.Content = null;
        }

        private void em_Graj_OnClick(object sender, RoutedEventArgs e)
        {
            Game OknoGry = new Game(Properties.Settings.Default.Buffer, Properties.Settings.Default.Okres, Properties.Settings.Default.ileKlikniec);
            Properties.Settings.Default.Reload();
            //OknoGry.p_buffer = Properties.Settings.Default.Buffer;
            //OknoGry.p_okres = Properties.Settings.Default.Okres;
            //OknoGry.p_clicksLeft = Properties.Settings.Default.ileKlikniec;
            OknoGry.Show();
            Close();
        }

        private void em_Highscore_Clear_OnClick(object sender, RoutedEventArgs e)
        {
            xe_Highscore_ListView.Items.Clear();
            Properties.Settings.Default.HighscoreListNicks.Clear();
            Properties.Settings.Default.HighscoreListScore.Clear();
            Properties.Settings.Default.HighscoreListDate.Clear();
            Properties.Settings.Default.Save();
            sm_FillHighScoresTable();
        }

        private void em_Settings_Apply_OnClick(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.Buffer = int.Parse(xe_Settings_TextBox_Bufor.Text);
            Properties.Settings.Default.Okres = int.Parse(xe_Settings_TextBox_Okres.Text);
            Properties.Settings.Default.ileKlikniec = int.Parse(xe_Settings_TextBox_Ile.Text);

            Properties.Settings.Default.Save();

            em_Opcje_OnClick(null, null);
        }

        private void em_Settings_Bufor_OnTextChange(object sender, EventArgs e)
        {
            if(v_RegexBuffer.IsMatch(xe_Settings_TextBox_Bufor.Text))
            {
                /*xe_Settings_Label_Komunikat.Content = v_SettingsGood;
                xe_Settings_Label_Komunikat.Foreground = Brushes.Green;
                xe_Settings_TextBox_Bufor.Background = Brushes.LightGreen;
                xe_Settings_ApplyChanges.IsEnabled = true;
                ToolTipService.SetIsEnabled(xe_Settings_ApplyChanges, false);*/
                sm_SettingsTextBoxGood(xe_Settings_TextBox_Bufor);
            }
            else
            {
                /*xe_Settings_Label_Komunikat.Content = v_SettingsWrong;
                xe_Settings_Label_Komunikat.Foreground = Brushes.Red;
                xe_Settings_TextBox_Bufor.Background = Brushes.Red;
                xe_Settings_ApplyChanges.IsEnabled = false;
                ToolTipService.SetIsEnabled(xe_Settings_ApplyChanges, true);*/
                sm_SettingsTextBoxWrong(xe_Settings_TextBox_Bufor);

            }
        }

        private void em_Settings_Okres_OnTextChange(object sender, EventArgs e)
        {
            if (v_RegexOkres.IsMatch(xe_Settings_TextBox_Okres.Text))
            {
                sm_SettingsTextBoxGood(xe_Settings_TextBox_Okres);
            }
            else
            {
                sm_SettingsTextBoxWrong(xe_Settings_TextBox_Okres);
            }
        }

        private void em_Settings_Ile_OnTextChange(object sender, EventArgs e)
        {
            if (v_RegexOkres.IsMatch(xe_Settings_TextBox_Ile.Text))
            {
                sm_SettingsTextBoxGood(xe_Settings_TextBox_Ile);
            }
            else
            {
                sm_SettingsTextBoxWrong(xe_Settings_TextBox_Ile);
            }
        }


        //==================================================================================================================
        //============================================= UNCATEGORIZED ======================================================
        //==================================================================================================================






    }
}
