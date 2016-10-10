using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using SystemFramework;

namespace AITLibrary
{
    public partial class BooksBorrowedAndReservedForm : LybraryTemplateForm
    {
        public BooksBorrowedAndReservedForm()
        {
            InitializeComponent();
        }

        private void radioBorrowed_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = Constants.msgLabelDefault;
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                dataGridViewBooks.DataSource = null;

                BookLogic bookLogic = new BookLogic();
                dataGridViewBooks.DataSource = bookLogic.GetAllBorrowedBooksWithUser();
                dataGridViewBooks.Columns[Constants.fieldBorrowId].Visible = false;
                dataGridViewBooks.Columns[Constants.fieldLatefee].Visible = false;
                dataGridViewBooks.Columns[Constants.fieldUserId].Visible = false;
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorBusinessToUser + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorSystemToUser;
            }
        }

        private void radioButtonReserved_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = Constants.msgLabelDefault;
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                dataGridViewBooks.DataSource = null;

                BookLogic bookLogic = new BookLogic();
                dataGridViewBooks.DataSource = bookLogic.GetAllBooksReservedView();
                dataGridViewBooks.Columns[Constants.fieldReserveId].Visible = false;
                dataGridViewBooks.Columns[Constants.fieldUserId].Visible = false;
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorBusinessToUser + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorSystemToUser;
            }
        }
    }
}
