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
    public partial class BookMaintenanceForm : LybraryTemplateForm
    {
        public BookMaintenanceForm()
        {
            InitializeComponent();
        }



        private void BookMaintenanceForm_Load(object sender, EventArgs e)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                comboBoxAuthor.DataSource = masterLogic.GetAllAuthors();
                comboBoxAuthor.DisplayMember = "Description";
                comboBoxAuthor.ValueMember = "ID";

                comboBoxCategory.DataSource = masterLogic.GetAllCategories();
                comboBoxCategory.DisplayMember = "Description";
                comboBoxCategory.ValueMember = "ID";

                comboBoxLanguage.DataSource = masterLogic.GetAllLanguages();
                comboBoxLanguage.DisplayMember = "Description";
                comboBoxLanguage.ValueMember = "ID";

                this.disableComboBoxes();
                this.disableFieldsOfMaintenance();
                
                this.clearAllFields();


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



        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            try
            {
                radioInsert.Checked = false;
                radioUpdate.Checked = false;
                radioDelete.Checked = false;
                this.disableFieldsOfMaintenance();
                this.disableComboBoxes();
                labelSystemMessage.Text = Constants.msgLabelDefault;

                if (textBoxISBNSearch.Text.Length == 0 && textBoxBookNameSearch.Text.Length == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = Constants.msgNoSearchCriteria;
                }
                else 
                {
                    labelSystemMessage.Text = null;
                    BookLogic bookLogic = new BookLogic();
                    dataGridViewListBooks.DataSource = bookLogic.BookSearch(textBoxISBNSearch.Text, textBoxBookNameSearch.Text, null);

                    if (dataGridViewListBooks.RowCount == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = Constants.msgNoMatchesFound;
                    }
                }
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewListBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorBusinessToUser + ex.Message;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                dataGridViewListBooks.DataSource = null;
                labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                labelSystemMessage.Text = Constants.msgErrorSystemToUser;
            }
        }
        

        private void refreshBookMaintenanceFields()
        {
            textBoxNameMaintenance.Text = null;
            if (dataGridViewListBooks.DataSource != null && dataGridViewListBooks.SelectedRows.Count > 0)
            {
                int bookNameColumnIndex = (int)AppEnum.ViewBookModel.BookName;
                textBoxNameMaintenance.Text = dataGridViewListBooks.SelectedRows[0].Cells[bookNameColumnIndex].Value.ToString();

                int authorColumnIndex = (int)AppEnum.ViewBookModel.Author;
                comboBoxAuthor.Text = dataGridViewListBooks.SelectedRows[0].Cells[authorColumnIndex].Value.ToString();

                int categoryColumnIndex = (int)AppEnum.ViewBookModel.Category;
                comboBoxCategory.Text = dataGridViewListBooks.SelectedRows[0].Cells[categoryColumnIndex].Value.ToString();

                int languageColumnIndex = (int)AppEnum.ViewBookModel.Language;
                comboBoxLanguage.Text = dataGridViewListBooks.SelectedRows[0].Cells[languageColumnIndex].Value.ToString();

                int isbnColumnIndex = (int)AppEnum.ViewBookModel.Isbn;
                textBoxISBNMaintenace.Text = dataGridViewListBooks.SelectedRows[0].Cells[isbnColumnIndex].Value.ToString();

                int yearColumnIndex = (int)AppEnum.ViewBookModel.PublishYear;
                textBoxYear.Text = dataGridViewListBooks.SelectedRows[0].Cells[yearColumnIndex].Value.ToString();

                int pagesColumnIndex = (int)AppEnum.ViewBookModel.Pages;
                textBoxPages.Text = dataGridViewListBooks.SelectedRows[0].Cells[pagesColumnIndex].Value.ToString();

                int publisherColumnIndex = (int)AppEnum.ViewBookModel.Publisher;
                textBoxPublisher.Text = dataGridViewListBooks.SelectedRows[0].Cells[publisherColumnIndex].Value.ToString();


                radioInsert.Checked = false;
                radioUpdate.Checked = false;
                radioDelete.Checked = false;
            }

        }

        private void radioInsert_Click(object sender, EventArgs e)
        {
            this.clearAllFields();
            this.enableComboBoxes();
            this.enableFieldsOfMaintenance();
        }

        private void radioInsert_CheckedChanged(object sender, EventArgs e)
        {
            this.clearAllFields();
            this.enableComboBoxes();
            this.enableFieldsOfMaintenance();
        }

        private void clearAllFields()
        {
            textBoxISBNSearch.Text = null;
            textBoxBookNameSearch.Text = null;

            textBoxNameMaintenance.Text = null;
            textBoxISBNMaintenace.Text = null;
            textBoxYear.Text = null;
            textBoxPages.Text = null;
            textBoxPublisher.Text = null;

            comboBoxAuthor.SelectedIndex = 0;
            comboBoxCategory.SelectedIndex = 0;
            comboBoxLanguage.SelectedIndex = 0;

            dataGridViewListBooks.DataSource = null;
        }

        private void enableComboBoxes()
        {
            comboBoxAuthor.Enabled = true;
            comboBoxCategory.Enabled = true;
            comboBoxLanguage.Enabled = true;
        }

        private void disableComboBoxes()
        {
            comboBoxAuthor.Enabled = false;
            comboBoxCategory.Enabled = false;
            comboBoxLanguage.Enabled = false;
        }

        private void disableFieldsOfMaintenance()
        {
            textBoxNameMaintenance.Enabled = false;
            textBoxISBNMaintenace.Enabled = false;
            textBoxYear.Enabled = false;
            textBoxPages.Enabled = false;
            textBoxPublisher.Enabled = false;
        }

        private void enableFieldsOfMaintenance()
        {
            textBoxNameMaintenance.Enabled = true;
            textBoxISBNMaintenace.Enabled = true;
            textBoxYear.Enabled = true;
            textBoxPages.Enabled = true;
            textBoxPublisher.Enabled = true;
        }

        private void textBoxISBNSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;

            if (!Char.IsDigit(character) && character != 8)
            {
                e.Handled = true;
            }
            textBoxBookNameSearch.Text = null;
        }

        private void textBoxBookNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            textBoxISBNSearch.Text = null;
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;

            if (!Char.IsDigit(character) && character != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;

            if (!Char.IsDigit(character) && character != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxISBNMaintenace_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;

            if (!Char.IsDigit(character) && character != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridViewListBooks_Click(object sender, EventArgs e)
        {
            this.refreshBookMaintenanceFields();
        }

        private bool validationOfFieldsToPerformManutention()
        {
            bool fieldsValidation = true;
            if ((radioInsert.Checked) || (radioUpdate.Checked))
            {
                if ((textBoxNameMaintenance.Text.Length == 0) ||
                    (textBoxISBNMaintenace.Text.Length == 0) ||
                    (textBoxPages.Text.Length == 0) ||
                    (textBoxYear.Text.Length == 0) ||
                    (textBoxPublisher.Text.Length == 0))
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = Constants.msgValidInformation;
                    fieldsValidation = false;
                }
            }

            if ((radioUpdate.Checked) || (radioDelete.Checked))
            {
                if (dataGridViewListBooks.DataSource == null && dataGridViewListBooks.SelectedRows.Count == 0)
                {
                    labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                    labelSystemMessage.Text = Constants.msgSelectRecord;
                    fieldsValidation = false;
                }
            }

            return fieldsValidation;

        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                labelSystemMessage.Text = Constants.msgLabelDefault;
                int resultOperation = -1;

                if (validationOfFieldsToPerformManutention())
                {
                    BookLogic BookLogic = new BookLogic();
                    if (radioInsert.Checked)
                    {                        
                        resultOperation = BookLogic.InsertBook(textBoxISBNMaintenace.Text, textBoxNameMaintenance.Text, 
                                                               (int)comboBoxAuthor.SelectedValue,
                                                               (int)comboBoxCategory.SelectedValue, (int)comboBoxLanguage.SelectedValue,
                                                               Int32.Parse(textBoxYear.Text), Int32.Parse(textBoxPages.Text), textBoxPublisher.Text);
                    }
                    else if (radioUpdate.Checked)
                    {
                        int isbnColumnIndex = (int)AppEnum.ViewBookModel.Isbn;
                        String isbn = dataGridViewListBooks.SelectedRows[0].Cells[isbnColumnIndex].Value.ToString();
                        String updatedIsbn = textBoxISBNMaintenace.Text;
                        resultOperation = BookLogic.UpdateBook(updatedIsbn, textBoxNameMaintenance.Text, 
                                                               (int)comboBoxAuthor.SelectedValue,(int)comboBoxCategory.SelectedValue, 
                                                               (int)comboBoxLanguage.SelectedValue, Int32.Parse(textBoxYear.Text),
                                                               Int32.Parse(textBoxPages.Text), textBoxPublisher.Text, isbn);
                    }
                    else if (radioDelete.Checked)
                    {
                           int isbnColumnIndex = (int)AppEnum.ViewBookModel.Isbn;
                           String isbn = dataGridViewListBooks.SelectedRows[0].Cells[isbnColumnIndex].Value.ToString();

                           resultOperation = BookLogic.DeleteBook(isbn);
                    }

                    if (resultOperation == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = Constants.msgErrorBusinessToUser;
                    }
                    else
                    {
                        labelSystemMessage.Text = Constants.msgOperationCompleted;
                        this.BookMaintenanceForm_Load(sender, e);
                        //   dataGridViewListUsers.DataSource = null;
                    }
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

        private void radioUpdate_CheckedChanged(object sender, EventArgs e)
        {
            this.enableComboBoxes();
            this.enableFieldsOfMaintenance();
        }

        private void radioUpdate_Click(object sender, EventArgs e)
        {
            this.enableComboBoxes();
            this.enableFieldsOfMaintenance();
        }

   }
}
