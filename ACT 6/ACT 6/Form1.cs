using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT_6
{
    public partial class Form1 : Form
    {
        public Form1(object cmbBoxPriority)
        {
            InitializeComponent();

            // Initialize ComboBox
            cmbPriority.Items.AddRange(new string[] { "High", "Medium", "Low" });
            cmbPriority.SelectedIndex = 0;

            // Lambda expression for button click
            btnNotify.Click += (sender, e) =>
            {
                string priority = cmbPriority.SelectedItem.ToString();

                // INITIAL STATE (Label empty)
                if (string.IsNullOrWhiteSpace(lblStatus.Text))
                {
                    lblStatus.Text = "System Initializing";
                    btnNotify.Text = "Start Notifications";
                    MessageBox.Show("Preparing classroom notification system...");
                    return;
                }

                // SYSTEM INITIALIZING
                if (lblStatus.Text == "System Initializing")
                {
                    lblStatus.Text = "System Online";
                    btnNotify.Text = "Deactivate Notifications";
                    MessageBox.Show("Notifications Activated");

                    foreach (var student in lstStudents.SelectedItems)
                    {
                        Console.WriteLine($"{student} | Priority: {priority} | State: System Online");
                    }
                    return;
                }

                // SYSTEM ONLINE
                if (lblStatus.Text == "System Online")
                {
                    lblStatus.Text = "System Offline";
                    btnNotify.Text = "Activate Notifications";
                    MessageBox.Show("Notifications Deactivated");

                    foreach (var student in lstStudents.SelectedItems)
                    {
                        Console.WriteLine($"{student} | Notifications Deactivated");
                    }
                    return;
                }

                // SYSTEM OFFLINE
                if (lblStatus.Text == "System Offline")
                {
                    lblStatus.Text = "System Online";
                    btnNotify.Text = "Deactivate Notifications";
                    MessageBox.Show("Notifications Reactivated");

                    foreach (var student in lstStudents.SelectedItems)
                    {
                        Console.WriteLine($"{student} | Notifications Reactivated");
                    }
                }
            };
        }

    }
}