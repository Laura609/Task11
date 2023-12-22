using System.CodeDom;
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

namespace Task11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            string inputText = Txt1.Text;
            StringBuilder binary = new StringBuilder();

            foreach(char c in inputText) 
            {
                binary.Append(Convert.ToString(c,2).PadLeft(2,'0'));
            }
            Txt1.Text = binary.ToString();
        }
    }
}