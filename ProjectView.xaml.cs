using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ASasitharan_NETD3200_Lab1
{
    /// <summary>
    /// Interaction logic for ProjectView.xaml
    /// </summary>
    public partial class ProjectView : Window
    {
        public ProjectView( Project selectedProject)
        {
            InitializeComponent();
            //passes the data from the selected project object to the textboxes
            txtProjectName2.Text = selectedProject.ProjectName;
            txtBudget2.Text = selectedProject.Budget.ToString();
            txtSpent2.Text = selectedProject.AmountSpent.ToString();
            txtHoursRemaining.Text = selectedProject.HoursRemaining.ToString();
            cmbStatus2.SelectedIndex = selectedProject.ProjectStatus;
        }
        
        //closes the window
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
