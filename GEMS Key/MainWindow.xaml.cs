using AutoHotkey.Interop;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace GEMS_Key
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //This hotkey is for Windows 10 users. Win+G is reserved by system to call out XBOX and game center bar. This might be fixed in the future.
            HotKey hotKey = new HotKey(Key.G, KeyModifier.Alt, Callout);
        }

        private void ColorZone_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


        public AutoHotkeyEngine Ahk;
        private void Callout(HotKey hotkey)
        {
            if (hotkey == null) throw new ArgumentNullException(nameof(hotkey));
            Ahk = AutoHotkeyEngine.Instance;
            if (WindowState == WindowState.Minimized)
            {
                Ahk.ExecRaw("Send, ^c");
                Thread.Sleep(300);
                Box.Text = Clipboard.GetText().Trim();
                GlobalVariables.Text = Box.Text;
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

        private void Box_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            GlobalVariables.Text = Box.Text;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.Text = null;
            Box.Clear();
        }
    }

    public static class GlobalVariables
    {
        public static string Text { get; set; }
    }
}
