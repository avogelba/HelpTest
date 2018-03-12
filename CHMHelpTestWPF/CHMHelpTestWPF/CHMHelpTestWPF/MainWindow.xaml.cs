using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HelpProvider;

namespace CHMHelpTestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Brush btnBrush=null;
        private const string myHelpfile = "Test Help.chm";
        public enum NativeHtmlHelpCommand
        {
            Topic = 0,
            TableOfContents = 1,
            Index = 2,
        }

        [DllImport("hhctrl.ocx", CharSet = CharSet.Auto, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        public static extern int HtmlHelp(
            HandleRef hwndCaller,
            [MarshalAs(UnmanagedType.LPTStr)] string pszFile,
            NativeHtmlHelpCommand uCommand,
            [MarshalAs(UnmanagedType.LPTStr)] string dwData);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIndexOfHelp_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Help.ShowHelpIndex(null, myHelpfile);
        }

        private void btnShowPopUp_Click(object sender, RoutedEventArgs e)
        {
            Point locationFromWindow = btnShowPopUp.TranslatePoint(new Point(0, 0), this);

            Point locationFromScreen = btnShowPopUp.PointToScreen(locationFromWindow); //this its total wrong

            //222,295
            System.Drawing.Point pF1 = new System.Drawing.Point(Convert.ToInt32(locationFromScreen.X), Convert.ToInt32(locationFromScreen.Y- btnShowPopUp.ActualHeight-30));
            //Point pW = new Point(pF.X, pF.Y); //just for tests this would be the other way round

            //System.Windows.Forms.Help.ShowPopup(null, "My PopUp", pF1);

            Point point = this.PointToScreen(new Point(0, btnShowPopUp.ActualHeight));
            PresentationSource source = PresentationSource.FromVisual(btnShowPopUp);

            double dpiX = 96.0 * source.CompositionTarget.TransformToDevice.M11;
            double dpiY = 96.0 * source.CompositionTarget.TransformToDevice.M22;

            System.Drawing.Point pF2 = new System.Drawing.Point(Convert.ToInt32(point.X * 96.0 / dpiX), Convert.ToInt32(point.Y * 96.0 / dpiY));
            System.Drawing.Point pF3 = new System.Drawing.Point(Convert.ToInt32(point.X), Convert.ToInt32(point.Y));
            //System.Windows.Forms.Help.ShowPopup(null, "My PopUp", pF3);

            Point relativePoint = btnShowPopUp.TransformToAncestor(this)
                          .Transform(new Point(0, 0));
            System.Drawing.Point pF4 = new System.Drawing.Point(Convert.ToInt32(relativePoint.X), Convert.ToInt32(relativePoint.Y));

            Rect absPos = GetAbsolutePlacement(btnShowPopUp, true);
            System.Drawing.Point pF5 = new System.Drawing.Point(Convert.ToInt32(absPos.X+absPos.Width), Convert.ToInt32(absPos.Y));
          System.Windows.Forms.Help.ShowPopup(null, "My PopUp", pF5);
        }

        public Rect GetAbsolutePlacement(FrameworkElement element, bool relativeToScreen = false)
        {
            var absolutePos = element.PointToScreen(new System.Windows.Point(0, 0));
            if (relativeToScreen)
            {
                return new Rect(absolutePos.X, absolutePos.Y, element.ActualWidth, element.ActualHeight);
            }
            var posMW = Application.Current.MainWindow.PointToScreen(new System.Windows.Point(0, 0));
            absolutePos = new System.Windows.Point(absolutePos.X - posMW.X, absolutePos.Y - posMW.Y);
            return new Rect(absolutePos.X, absolutePos.Y, element.ActualWidth, element.ActualHeight);
        }

        private void btnShowContents_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(null, myHelpfile, "/hlp/Contents.htm");
        }

        private void btnShowMiscellaneous_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(null, myHelpfile, "/hlp/Miscellaneous.htm");
        }

        private void btnIndexOfHelp_ToolTip_Closing(object sender, ToolTipEventArgs e)
        {
            Button b = sender as Button;
            if (btnBrush != null)
            {
                btnIndexOfHelp.Foreground = btnBrush;
            }

        }

        private void btnIndexOfHelp_ToolTip_Opening(object sender, ToolTipEventArgs e)
        {
            Button b = sender as Button;
            if (btnBrush == null)
            {
                btnBrush = btnIndexOfHelp.Foreground;
            }
            
            btnIndexOfHelp.Foreground = Brushes.Red;
        }
    }
}
