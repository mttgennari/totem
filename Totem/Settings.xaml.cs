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

namespace Totem {
    /// <summary>
    /// Logica di interazione per Settings.xaml
    /// </summary>
    public partial class Settings : Window {
        private MainWindow mw;
        public Settings(MainWindow mw) {
            InitializeComponent();
            this.mw = mw;

            String szA, szB, szC, szD;

            szA = mw.getSize(mw.txtA);
            szB = mw.getSize(mw.txtB);
            szC = mw.getSize(mw.txtC);
            szD = mw.getSize(mw.txtD);

            wrSizeA.Text = szA;
            wrSizeB.Text = szB;
            wrSizeC.Text = szC;
            wrSizeD.Text = szD;
        }

        private void BtNull_Click(object sender, RoutedEventArgs e) {
        }

        private void BtConfirm_Click(object sender, RoutedEventArgs e) {
            String a = null, b = null, c = null, d = null;
            int la, lb, lc, ld;

            la = wrA.LineCount;
            lb = wrB.LineCount;
            lc = wrC.LineCount;
            ld = wrD.LineCount;

            for (int i = 0; i < la; i++) {
                a += wrA.GetLineText(i);
            }
            for (int i = 0; i < lb; i++) {
                b += wrB.GetLineText(i);
            }
            for (int i = 0; i < lc; i++) {
                c += wrC.GetLineText(i);
            }
            for (int i = 0; i < ld; i++) {
                d += wrD.GetLineText(i);
            }

            mw.Update(a, b, c, d,
                wrSizeA.GetLineText(0), wrSizeB.GetLineText(0), wrSizeC.GetLineText(0), wrSizeD.GetLineText(0));
        }

        private void Window_Closed(object sender, EventArgs e) {
            mw.Close();
        }

        private void aP_Click(object sender, RoutedEventArgs e) {
            mw.UpdDim("a+");
            wrSizeA.Text = (int.Parse(wrSizeA.GetLineText(0))+1).ToString();
        }
        private void aM_Click(object sender, RoutedEventArgs e) {
            mw.UpdDim("a-");
            wrSizeA.Text = (int.Parse(wrSizeA.GetLineText(0)) - 1).ToString();
        }

        private void bP_Click(object sender, RoutedEventArgs e) {
            mw.UpdDim("b+");
            wrSizeB.Text = (int.Parse(wrSizeB.GetLineText(0)) + 1).ToString();
        }
        private void bM_Click(object sender, RoutedEventArgs e) {
            mw.UpdDim("b-");
            wrSizeB.Text = (int.Parse(wrSizeB.GetLineText(0)) - 1).ToString();
        }

        private void cP_Click(object sender, RoutedEventArgs e) {
            mw.UpdDim("c+");
            wrSizeC.Text = (int.Parse(wrSizeC.GetLineText(0)) + 1).ToString();
        }
        private void cM_Click(object sender, RoutedEventArgs e) {
            mw.UpdDim("c-");
            wrSizeC.Text = (int.Parse(wrSizeC.GetLineText(0)) - 1).ToString();
        }

        private void dP_Click(object sender, RoutedEventArgs e) {
            mw.UpdDim("d+");
            wrSizeD.Text = (int.Parse(wrSizeD.GetLineText(0)) + 1).ToString();
        }
        private void dM_Click(object sender, RoutedEventArgs e) {
            mw.UpdDim("d-");
            wrSizeD.Text = (int.Parse(wrSizeD.GetLineText(0)) - 1).ToString();
        }
    }
}
