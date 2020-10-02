/*
 * Name: Ashok Sasitharan
 * Student Id: 100745484
 */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ASasitharan_NETD3200_Lab1
{
   public class Project
    {
        //private data members
        private string projectName;
        private double budget;
        private double amountSpent;
        private double hoursRemaining;
        private int projectStatus;
        
        //constructor
        public Project(string projectName, double budget, double amountSpent, double hoursRemaining, int projectStatus)
        {
            this.projectName = projectName;
            this.budget = budget;
            this.amountSpent = amountSpent;
            this.hoursRemaining = hoursRemaining;
            this.projectStatus = projectStatus;
        }

        //getter and setter for ProjectName
        public string ProjectName
        {
            get { return this.projectName; }
            set { this.projectName = value; }
        }
        
        //getter and setter for Budget
        public double Budget
        {
            get { return this.budget; }
            set { this.budget = value; }
        }

        //getter and setter for AmountSpent
        public double AmountSpent
        {
            get { return this.amountSpent; }
            set { this.amountSpent = value; }
        }

        //getter and setter for Hours Remaining
        public double HoursRemaining
        {
            get { return this.hoursRemaining; }
            set { this.hoursRemaining = value; }
        }
        //getter and setter for ProjectStatus
        public int ProjectStatus
        {
            get { return this.projectStatus; }
            set { this.projectStatus = value; }
        }
    }
}
