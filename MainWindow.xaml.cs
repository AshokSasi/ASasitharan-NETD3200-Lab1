/*
 * Name: Ashok Sasitharan
 * Student Id: 100745484
 */
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
        //initiate and launch the MainWindow
        public MainWindow()
        {
            InitializeComponent();
        }

        //function to clear all inputs and set combo box back to requirements
        public void SetDefault()
        {
            txtProjectName.Clear();
            txtBudget.Clear();
            txtSpent.Clear();
            txtEstHoursRemaining.Clear();
            cmbStatus.SelectedIndex = 0;
            txtProjectName.Focus();

        }
        // Open up the Project view window when a list box object is double clicked.
        private void lbProjectDisplay_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            int projectIndex = lbProjectDisplay.SelectedIndex;

            Project selectedProject = projectList[projectIndex];
            ProjectView secondWindow = new ProjectView(selectedProject);
            secondWindow.Show();
        }
       
        //declare a new list called projectList
        static List<Project> projectList = new List<Project>();
        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
          //Variable declaration
            double Budget;
            double Spent;
            double EstHoursRemaining;
            int projectStatus;
            //run if project name is not empty
            if(txtProjectName.Text!=string.Empty)
            {
                //run if the budget is a number
                if(double.TryParse(txtBudget.Text,out Budget))
                {
                    //run if budget is a positive number
                    if (Budget >= 0)
                    {
                        //run if spent money is numeric
                        if (double.TryParse(txtSpent.Text, out Spent))
                        {
                            //run if spent money is a positive number
                            if(Spent >=0)
                            {
                                //run if estimated hours remaining is numeric
                               if(double.TryParse(txtEstHoursRemaining.Text,out EstHoursRemaining))
                                {
                                    //run if est hours remaining is a positive number
                                    if(EstHoursRemaining >=0)
                                    {
                                        //run if est hours remaining is equal to 0
                                        if(EstHoursRemaining == 0)
                                        {
                                            cmbStatus.SelectedIndex = 5; // change the status to completed
                                           
                                        }
                                        else if (cmbStatus.SelectedIndex == 5)
                                        {
                                            EstHoursRemaining = 0;
                                        }
                                        projectStatus = cmbStatus.SelectedIndex;
                                        //add the project object to the list
                                        projectList.Add(new Project(txtProjectName.Text, Budget, Spent, EstHoursRemaining, projectStatus));
                                        
                                        //clear the list box
                                        lbProjectDisplay.Items.Clear();

                                        //loop through he items in the list
                                        for(int i=0; i<projectList.Count; i++)
                                        {
                                            //add the object to the list box
                                            lbProjectDisplay.Items.Add(projectList[i].ProjectName);
                                        }

                                        //call SetDefault() to set all inputs back to default
                                        SetDefault();
                                    }
                                    //run if est hours remaining is below 0
                                    else
                                    {
                                        //clear the field
                                        txtEstHoursRemaining.Clear();
                                        //display error message
                                        MessageBox.Show("Hours remaining must be a positive number.");
                                    }
                                }
                               //run if est hours remaining is not numeric
                                else
                                {
                                    //clear the field
                                    txtEstHoursRemaining.Clear();
                                    //display error message
                                    MessageBox.Show("Hours remaining must be numeric");
                                }
                            }
                            //run if money spent is below 0
                            else
                            {
                                //clear the field
                                txtSpent.Clear();
                                //display error message
                                MessageBox.Show("Money spent must be a positive number.");
                            }
                        }
                        //run if money spent is not a number
                        else
                        {
                            //clear the field
                            txtSpent.Clear();
                            //display error message
                            MessageBox.Show("Money spent must be numeric");
                        }
                    }
                    //run if budget is a number below 0
                    else
                    {
                        //clear the field
                        txtBudget.Clear();
                        //display error message
                        MessageBox.Show("Budget must be a positive number.");

                    }
                }
                //run if budget is not numeric
                else
                {
                    //clear the field
                    txtBudget.Clear();
                    //display error message
                    MessageBox.Show("Budget must be numeric.");
                }
            }
            //run if project name is empty
            else
            {
                //clear the field
                txtProjectName.Clear();
                //display error message
                MessageBox.Show("Project Name cannot be empty.");
            }

        }
    }
}
