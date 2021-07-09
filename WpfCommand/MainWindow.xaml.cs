using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfCommand.Commands;

namespace WpfCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Text { get; set; } = "Salam";
        public MainWindow()
        {
            this.DataContext = this;
            MessageCommand = new MessageCommand(Display);
            SendCommand = new SendCommand(Send);
            InitializeComponent();
        }
        public MessageCommand MessageCommand { get; set; }
        public SendCommand SendCommand { get; set; }

        public void Display()
        {
            MessageBox.Show("Hakuna Matata");
        }

        public void Send()
        {
            MessageBox.Show("Message was sent successfully");
        }

        //private void Help_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        //{
        //    if (Text.Length > 10)
        //    {
        //        e.CanExecute = true;
        //    }
        //    else
        //    {
        //        e.CanExecute = false;
        //    }
        //}

        //private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //    Process.Start("msedge.exe");
        //}
    }
}
