/* 
 * Name of Project: ChiayinYanping_Assignment1
 * Purpose: Understaing how to create a booking system using C#
 * Revision History: 
 * - Chiayin Yang and Yanping Guo, May 31th 2024, Create basic design and functions.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiayinYanping_Assignment1
{
    public partial class Venue : Form
    {
        string row;
        int column;
        VenueBook book = new VenueBook();
        public Venue()
        {
            InitializeComponent();
            // adding items to listboxs

            listBoxRows.Items.Add("A");
            listBoxRows.Items.Add("B");
            listBoxRows.Items.Add("C");

            listBoxColums.Items.Add("1");
            listBoxColums.Items.Add("2");
            listBoxColums.Items.Add("3");
            listBoxColums.Items.Add("4");
        }

        private void Venue_Load(object sender, EventArgs e)
        {


        }

        //booking seat
        private void btnBook_Click(object sender, EventArgs e)
        {
            string txtCustomerNames = txtCustomerName.Text;
            string returnValue = book.AddBook(row, column, txtCustomerNames);
            if (string.IsNullOrEmpty(returnValue))
            {
                lblMessage.Text = "This seat book sucessfull";
            }
            else
            {
                lblMessage.Text = "This seat is already booked";
            }
        }

        private void btnAddToWaitList_Click(object sender, EventArgs e)
        {
            lblMessage.Text = book.AddToWaitList(txtCustomerName.Text);
        }

        //cancel one booking
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblMessage.Text = book.Cancel(row, column);

            //DialogResult result = MessageBox.Show("Are you sure you want to delete this userName",
            // MessageBoxButtons.YesNo,MessageBoxIcon.Warning);


        }

        //cancel all booking
        private void btnCancelAllBookings_Click(object sender, EventArgs e)
        {
            book.CancelAll();
            lblMessage.Text = "Cancel all successfull";
        }

        // get listBoxRow  selected value
        private void listBoxRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            row = listBoxRows.SelectedItem.ToString();
        }

        // get  listBoxColumn value
        private void listBoxColums_SelectedIndexChanged(object sender, EventArgs e)
        {
            column = int.Parse(listBoxColums.SelectedItem.ToString());
        }
        

    }
}
