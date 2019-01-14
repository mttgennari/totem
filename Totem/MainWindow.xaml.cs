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

namespace Totem {
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private Window settings;
        private bool full = false;

        public MainWindow() {
            Keyboard.Focus(this);
            InitializeComponent();

            settings = new Settings(this);
            settings.Show();
        }

        public void FullScreen(Object sender, KeyEventArgs e) {
            if (e.Key == Key.F11) {
                switch(full){
                    case false:
                        WindowStyle = WindowStyle.None;
                        ResizeMode = ResizeMode.NoResize;
                        Left = 0;
                        Top = 0;
                        Width = SystemParameters.VirtualScreenWidth;
                        Height = SystemParameters.VirtualScreenHeight;
                        full = true;
                        return;
                    case true:
                        WindowStyle = WindowStyle.SingleBorderWindow;
                        ResizeMode = ResizeMode.CanResize;
                        Left = 350;
                        Top = 350;
                        Width = 800;
                        Height = 450;
                        full = false;
                        return;
                }
            }
        }

        public void Update(String A, String B, String C, String D, 
            String szA, String szB, String szC, String szD) {
            txtA.Text = A;
            txtB.Text = B;
            txtC.Text = C;
            txtD.Text = D;

            txtA.FontSize = int.Parse(szA);
            txtB.FontSize = int.Parse(szB);
            txtC.FontSize = int.Parse(szC);
            txtD.FontSize = int.Parse(szD);
        }

        public String getSize(TextBlock e) {
            return e.FontSize.ToString();
        }

        public void UpdDim(String elem) {
            switch (elem) {
                case "a+":
                    txtA.FontSize += 1;
                    return;
                case "b+":
                    txtB.FontSize += 1;
                    return;
                case "c+":
                    txtC.FontSize += 1;
                    return;
                case "d+":
                    txtD.FontSize += 1;
                    return;
                case "a-":
                    txtA.FontSize -= 1;
                    return;
                case "b-":
                    txtB.FontSize -= 1;
                    return;
                case "c-":
                    txtC.FontSize -= 1;
                    return;
                case "d-":
                    txtD.FontSize -= 1;
                    return;
            }
        }

        private void Window_Closed(object sender, EventArgs e) {
            settings.Close();
        }
    }
}
