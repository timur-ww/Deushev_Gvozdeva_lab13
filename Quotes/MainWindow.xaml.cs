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

namespace Quotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] quotes = {
            "Чак Норрис никогда не спит. Он выжидает.", 
            "Когда Стетхем говорит \"Hello World\", мир отвечает \"Простите сэр\"",
            "Пары - не удары, можно и пропустить.",
            "Чак Норрис сломал ребро пчеле."
        };

        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lableQuotes.Text = quotes[random.Next(quotes.Count())];
        }
    }
}