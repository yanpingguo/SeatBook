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
    }
}
