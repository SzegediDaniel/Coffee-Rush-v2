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

namespace Coffee_Rush_v2
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            PlayGround playground = new PlayGround();
            playground.Show();
            this.Close();
        }

        private void RuleButton_Click(object sender, RoutedEventArgs e)
        {
            Rule rule = new Rule();
            rule.Show(); 
            this.Close();
        }
    }
}