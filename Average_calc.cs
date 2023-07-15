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

namespace ArrayLab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = int.Parse(txt.Text);
                lb.Items.Add(number.ToString());
                txt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please insert the number value");
            }
            
        }

        private void cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("please choose your number to update");
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lb.Items.Clear();
            txt_res.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int index = lb.SelectedIndex;
            if (index >= 0)
            {
                try
                {
                    int number = int.Parse(txt.Text);
                    lb.Items[index] = number.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please insert the number value");
                }
            }
            else
                MessageBox.Show("please choose your number to update");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (avg.IsSelected == true)
            {
                int n = lb.Items.Count;
                double sum = 0;
                for(int i=0; i<n;i++)
                {
                    sum = sum + double.Parse(lb.Items[i].ToString());
                }
                double res = sum / n;
                txt_res.Text = res.ToString();
            }
            if (sum.IsSelected == true)
            {
                int n = lb.Items.Count;
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum = sum + double.Parse(lb.Items[i].ToString());
                }
                double res = sum;
                txt_res.Text = res.ToString();
            }
            if (max.IsSelected == true)
            {
                int n = lb.Items.Count;
                       
                    int max = int.Parse(lb.Items[0].ToString());  
                for (int i = 1; i < n; ++i)
                { 
                        if (int.Parse(lb.Items[i].ToString()) > max) max = int.Parse(lb.Items[i].ToString());
                
                }
                int res = max;
                txt_res.Text = res.ToString();
            }
            if (min.IsSelected == true)
            {
                int n = lb.Items.Count;

                int min = int.Parse(lb.Items[0].ToString());
                for (int i = 1; i < n; ++i)
                {
                    if (int.Parse(lb.Items[i].ToString()) < min) min = int.Parse(lb.Items[i].ToString());

                }
                int res = min;
                txt_res.Text = res.ToString();
            }
            if (avgquad.IsSelected == true)
            {
                int n = lb.Items.Count;
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum = sum + Math.Pow(double.Parse(lb.Items[i].ToString()), 2);
                }
                double res = sum / n;
                txt_res.Text = res.ToString();
            }
            if (sumquad.IsSelected == true)
            {
                int n = lb.Items.Count;
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum = sum + Math.Pow(double.Parse(lb.Items[i].ToString()), 2);
                }
                double res = sum;
                txt_res.Text = res.ToString();
            }
            if (avggeom.IsSelected == true)
            {
                int n = lb.Items.Count;
                double Geom;
                int dob = 1;
                for (int i = 0; i < n; ++i)
                {
                    dob = dob * int.Parse(lb.Items[i].ToString());
                }
                Geom = Math.Pow(dob, 1.0 / n);
                double res = Geom;
                txt_res.Text = res.ToString();
            }
            if (avggarm.IsSelected == true)
            {
                int n = lb.Items.Count;
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum = sum + 1/(double.Parse(lb.Items[i].ToString()));
                }
                double res = n/sum;
                txt_res.Text = res.ToString();
            }
            if (avgcron.IsSelected == true)
            {
                int n = lb.Items.Count;
                double sum = 0;
                double sum1 = 0.5*int.Parse(lb.Items[0].ToString()) + 0.5*int.Parse(lb.Items[n - 1].ToString());
                for (int i = 0; i < n; i++)
                {
                    sum = sum + double.Parse(lb.Items[i].ToString());
                }
                double res = (sum - sum1)/(n-1);
                txt_res.Text = res.ToString();
            }

        }
    }
}
