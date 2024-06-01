using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChiayinYanping_Assignment1
{
    internal class VenueBook
    {
        string[,] venueArray = new string[3, 4];
        List<string> waitList = new List<string>();
        public VenueBook()
        {

        }

        public string AddBook(string row, int column, string userName)
        {
            int indexRow = returnRowIndex(row);
            string seatAvailable = venueArray[indexRow, column - 1];
            if (string.IsNullOrEmpty(seatAvailable))
            {
                venueArray[indexRow, column - 1] = userName;
            }
            else
            {
                waitList.Add(userName);
            }
            return seatAvailable;

        }

        public void StatusButton(string row, int column, string userName)
        {

        }

        public string AddToWaitList(string userName)
        {
            string message = "Seats are available";
            if (venueArray.Length > 0)
            {
                Console.WriteLine("venueArray.Length : " + venueArray.Length);
                for (int i = 0; i < venueArray.GetLength(0); i++)
                {
                    for (int j = 0; j < venueArray.GetLength(1); j++)
                    {
                        if (string.IsNullOrEmpty(venueArray[i, j]))
                        {
                            return message;
                        }
                    }
                }
                waitList.Add(userName);
                message = "Add to wait list successful";
            }
            return message;
        }

        public string Cancel(string row, int column)
        {
            int indexRow = returnRowIndex(row);
            string seatAvailable = venueArray[indexRow, column - 1];
            string message = "Cancel successful";
            if (!string.IsNullOrEmpty(seatAvailable))
            {
                if (waitList.Count != 0)
                {
                    venueArray[indexRow, column - 1] = waitList[0];
                    waitList.RemoveAt(0);
                    message = "Cancel successful! wait list userName:" +
                        venueArray[indexRow, column - 1] + " add this seat successful";
                }
                else
                {
                    venueArray[indexRow, column - 1] = "";
                }

            }
            else
            {
                message = "This seat no book, no need cancel";
            }

            return message;

        }

        public void CancelAll()
        {
            venueArray = new string[3, 4];

        }

        public int returnRowIndex(string row)
        {
            int indexRow = 0;
            if (row.Equals("B"))
            {
                indexRow = 1;
            }
            else if (row.Equals("C"))
            {
                indexRow = 2;
            }
            return indexRow;

        }

    }
}
