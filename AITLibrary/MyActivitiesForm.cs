/* Form to show users activities. 
 * 
 * Project: Assignment 2 - AIT
 * Developer: Kennedy Oliveira - ID 5399
 * Data of release: 19/08/2016
 * Version: 1.0 - Release
 * 
 */
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
    /// <summary>
    ///  Form to show users activities.
    /// </summary>
    public partial class MyActivitiesForm : LybraryTemplateForm
    {
        public MyActivitiesForm()
        {
            InitializeComponent();
        }

        private void radioButtonBorrowed_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = Constants.msgLabelDefault;
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                dataGridViewUserBookActivity.DataSource = null;

                BookLogic bookLogic = new BookLogic();
                dataGridViewUserBookActivity.DataSource = bookLogic.GetAllBorrowedBooksByUserId(staticUserID);
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewUserBookActivity.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorBusinessToUser + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewUserBookActivity.DataSource = null;
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
                dataGridViewUserBookActivity.DataSource = null;

                BookLogic bookLogic = new BookLogic();
                dataGridViewUserBookActivity.DataSource = bookLogic.GetAllBooksReservedViewByUserId(staticUserID);
                dataGridViewUserBookActivity.Columns[Constants.fieldUser].Visible = false;
                dataGridViewUserBookActivity.Columns[Constants.fieldReserveId].Visible = false;
                dataGridViewUserBookActivity.Columns[Constants.fieldUserId].Visible = false;
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewUserBookActivity.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red; 
                labelSystemMessage.Text = Constants.msgErrorBusinessToUser + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewUserBookActivity.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red; 
                labelSystemMessage.Text = Constants.msgErrorSystemToUser;
            }
        }
    }
}
