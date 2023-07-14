namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void number_only(object sender, RoutedEventArgs e)
        {
            if ((txt_result.Text == "0")||(operation_pressed))
                txt_result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            txt_result.Text = txt_result.Text + b.Content;

        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txt_result.Text = "0";
            value = 0;
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txt_result.Text = "0";
        }

        private void operator_click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Content.ToString();
            value = Double.Parse(txt_result.Text);
            operation_pressed = true;
            equation.Content = value + " " + operation;
        }
        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (txt_result.Text.Length > 0)
            {
                txt_result.Text = txt_result.Text.Remove(txt_result.Text.Length - 1, 1);
            }
            if (txt_result.Text == "")
            {
                txt_result.Text = "0";
            }
        }

        private void btnEq_Click(object sender, RoutedEventArgs e)
        {
            equation.Content = "";
            switch (operation)
            {
                case "+":
                    txt_result.Text = (value + Double.Parse(txt_result.Text)).ToString();
                    break;
                case "–":
                    txt_result.Text = (value - Double.Parse(txt_result.Text)).ToString();
                    break;
                case "*":
                    txt_result.Text = (value * Double.Parse(txt_result.Text)).ToString();
                    break;
                case "/":
                    txt_result.Text = (value / Double.Parse(txt_result.Text)).ToString();
                    break;
                case "1/x":
                    txt_result.Text = (1 / Double.Parse(txt_result.Text)).ToString();
                    break;
                case "^":
                    txt_result.Text = (Math.Pow(value, Double.Parse(txt_result.Text))).ToString();
                    break;
                case "√":
                    txt_result.Text = (Math.Sqrt(value)).ToString();
                    break;
                default:
                    break;
            } 
           // operation_pressed = false;
        }
    }
}
