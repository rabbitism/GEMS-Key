using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using AutoHotkey.Interop;

namespace GEMS_Key
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ///This hotkey is for Windows 10 users. Win+G is reserved by system to call out XBOX and game center bar. This might be fixed in the future.
            HotKey MainKeyInWin10 = new HotKey(Key.G, KeyModifier.Alt, Callout);

        }

        private void ColorZone_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        AutoHotkeyEngine ahk;
        private void Callout(HotKey hotkey)
        {
            ahk = AutoHotkeyEngine.Instance;
            if (WindowState == WindowState.Minimized)
            {
                ahk.ExecRaw("Send, ^c");
                Thread.Sleep(300);
                Box.Text = Clipboard.GetText().Trim();
                WindowState = WindowState.Normal;
                Activate();
                Focus();
                ShowInTaskbar = true;
                //Topmost = true;                
            }
            else
            {
                WindowState = WindowState.Minimized;
                ShowInTaskbar = true;
            }
        }
    }
}
