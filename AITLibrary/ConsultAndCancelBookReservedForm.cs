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
    public partial class ConsultAndCancelBookReservedForm : LybraryTemplateForm
    {
        public ConsultAndCancelBookReservedForm()
        {
            InitializeComponent();
        }

        private void buttonCancelBookReserve_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                labelSystemMessage.Text = null;

                if (dataGridViewBookReserved.DataSource != null && dataGridViewBookReserved.SelectedRows.Count > 0)
                {
                    int reserveId = (int) dataGridViewBookReserved.SelectedRows[0].Cells[(int)AppEnum.ViewBookReservedModel.ReserveId].Value;
                    labelSystemMessage.Text = reserveId.ToString();

                    BookLogic bookLogic = new BookLogic();
                    int resultOperation = bookLogic.DeleteBookReserved(reserveId);
                    if (resultOperation == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = Constants.msgErrorBusinessToUser;
                    }
                    else
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                        labelSystemMessage.Text = Constants.msgOperationCompleted;
                        this.ConsultAndCancelBookReservedForm_Load(sender,  e);                       

                    }
                }
                else
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = Constants.msgSelectRecord;
                }
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorBusinessToUser + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorSystemToUser;
            }
        }

        private void ConsultAndCancelBookReservedForm_Load(object sender, EventArgs e)
        {
            try
            {
                BookLogic bookLogic = new BookLogic();
                dataGridViewBookReserved.DataSource = bookLogic.GetAllBooksReservedViewByUserId(staticUserID);

                if (dataGridViewBookReserved.RowCount == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = Constants.msgNoMatchesFound;
                }
                else
                {
                    dataGridViewBookReserved.Columns[Constants.fieldUser].Visible = false;
                    dataGridViewBookReserved.Columns[Constants.fieldReserveId].Visible = false;
                    dataGridViewBookReserved.Columns[Constants.fieldUserId].Visible = false;
                }
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBookReserved.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorBusinessToUser + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewBookReserved.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorSystemToUser;
            }
        }
    }
}
