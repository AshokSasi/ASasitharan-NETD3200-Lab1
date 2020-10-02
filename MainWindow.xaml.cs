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

namespace ASasitharan_NETD3200_Lab1
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

        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            string ProjectName;
            double Budget;
            double Spent;
            double EstHoursRemaining;
            string Status;

            if(txtProjectName.Text!=string.Empty)
            {
                if(double.TryParse(txtBudget.Text,out Budget))
                {
                    if(Budget >= 0)
                    {
                        if (double.TryParse(txtSpent.Text, out Spent))
                        {
                            if(Spent >=0)
                            {
                               if(double.TryParse(txtEstHoursRemaining.Text,out EstHoursRemaining))
                                {
                                    if(EstHoursRemaining >=0)
                                    {
                                        
                                    }
                                    else if(EstHoursRemaining==0)
                                    {
                                        cmbStatus.SelectedIndex = 5;
                                    }
                                    else
                                    {
                                        txtEstHoursRemaining.Clear();
                                        MessageBox.Show("Hours remaining must be a positive number.");
                                    }
                                }
                                else
                                {
                                    txtEstHoursRemaining.Clear();
                                    MessageBox.Show("Hours remaining must be numeric");
                                }
                            }
                            else
                            {
                                txtSpent.Clear();
                                MessageBox.Show("Money spent must be a positive number.");
                            }
                        }
                        else
                        {
                            txtSpent.Clear();
                            MessageBox.Show("Money spent must be numeric");
                        }
                    }
                    else
                    {
                        txtBudget.Clear();
                        MessageBox.Show("Budget must be a positive number.");

                    }
                }
                else
                {
                    txtBudget.Clear();
                    MessageBox.Show("Budget must be numeric.");
                }
            }
            else
            {
                txtProjectName.Clear();
                MessageBox.Show("Project Name cannot be empty.");
            }

        }
    }
}
