﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ASasitharan_NETD3200_Lab1
{
   public class Program
    {
        //First private data member
        private string projectName;
        private double budget;
        private double amountSpent;
        private double hoursRemaining;
        private string projectStatus;
        //Complete the rest (there are four more mentioned in the description).
        //constructor, you need to complete it this is a no parameter constructor shown below.
        public Program(string projectName, double budget, double amountSpent, double hoursRemaining, string projectStatus)
        {
        }

        //Getters and Setters for each private data member go below.
        /*This one is an example, notice that the data member is called private string “projectName” the getter/setter property is named “ProjectName”(different capitalization).*/
        public string ProjectName
        {
            get { return this.projectName; }
            set { this.projectName = value; }
        }

        public double Budget
        {
            get { return this.budget; }
            set { this.budget = value; }
        }

        public double AmountSpent
        {
            get { return this.amountSpent; }
            set { this.amountSpent = value; }
        }

        public double HoursRemaining
        {
            get { return this.hoursRemaining; }
            set { this.hoursRemaining = value; }
        }

        public string ProjectStatus
        {
            get { return this.projectStatus; }
            set { this.projectStatus = value; }
        }
    }
}
