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
    public partial class BookBrowseForm : LybraryTemplateForm
    {
        public BookBrowseForm()
        {
            InitializeComponent();
        }

        private void BookBrowseForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewBookBrowse.DataSource = null;
                BookLogic bookLogic = new BookLogic();
                dataGridViewBookBrowse.DataSource = bookLogic.GetAllBooksView();
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBookBrowse.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorBusinessToUser + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBookBrowse.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorSystemToUser;
            }
        }
    }
}
