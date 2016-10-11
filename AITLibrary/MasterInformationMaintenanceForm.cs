using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Services.Protocols;
using SystemFramework;

namespace AITLibrary
{
    public partial class MasterInformationMaintenanceForm : LybraryTemplateForm
    {
        public MasterInformationMaintenanceForm()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            try
            {
                radioInsert.Checked = false;
                radioUpdate.Checked = false;
                radioDelete.Checked = false;
                labelSystemMessage.Text = Constants.msgLabelDefault;
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                textBoxName.Text = null;

                dataGridViewMasterInformation.DataSource = null;

                switch (comboBoxMasterInformation.SelectedItem.ToString())
                {
                    case "Author":
                        AuthorWSIntegration.AuthorWS authorWS = new AuthorWSIntegration.AuthorWS();
                        dataGridViewMasterInformation.DataSource = authorWS.GetAllAuthors();
                        break;
                    case "Category":
                        CategoryWSIntegration.CategoryWS categoryWS = new CategoryWSIntegration.CategoryWS();
                        dataGridViewMasterInformation.DataSource = categoryWS.GetAllCategories();
                        break;
                    case "Language":
                        LanguageWSIntegration.LanguageWS languageWS = new LanguageWSIntegration.LanguageWS();
                        dataGridViewMasterInformation.DataSource = languageWS.GetAllLanguages();
                        break;
                }

                dataGridViewMasterInformation.Columns[Constants.fieldID].Visible = false;

            }
            catch (SoapException ex)
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

        private void MasterInformationMaintenanceForm_Load(object sender, EventArgs e)
        {
            comboBoxMasterInformation.SelectedIndex = 0;
        }

        private void refreshNameTexBox(object sender, EventArgs e)
        {
            this.refreshNameTexBox();
        }

        private void refreshNameTexBox()
        {
            textBoxName.Text = null;
            if (dataGridViewMasterInformation.DataSource != null && dataGridViewMasterInformation.SelectedRows.Count > 0)
            {
                int descriptionColumnIndex = (int)AppEnum.TabMasterModel.Description;
                textBoxName.Text = dataGridViewMasterInformation.SelectedRows[0].Cells[descriptionColumnIndex].Value.ToString();
                radioInsert.Checked = false;
                radioUpdate.Checked = false;
                radioDelete.Checked = false;
            }
        }

        private void dataGridViewMasterInformation_Click(object sender, EventArgs e)
        {
            this.refreshNameTexBox();
        }

        private void radioInsert_Click(object sender, EventArgs e)
        {
            textBoxName.Text = null;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                labelSystemMessage.Text = Constants.msgLabelDefault;

                if (radioInsert.Checked)
                {
                    if (textBoxName.Text.Length == 0)
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = Constants.msgValidInformation;
                    }
                    else
                    {
                        int resultOperation = 0;
                        switch (comboBoxMasterInformation.SelectedItem.ToString())
                        {
                            case "Author":
                                AuthorWSIntegration.AuthorWS authorWS = new AuthorWSIntegration.AuthorWS();
                                resultOperation = authorWS.insertAuthor(textBoxName.Text);
                                break;
                            case "Category":
                                CategoryWSIntegration.CategoryWS categoryWS = new CategoryWSIntegration.CategoryWS();
                                resultOperation = categoryWS.insertCategory(textBoxName.Text);
                                break;
                            case "Language":
                                LanguageWSIntegration.LanguageWS languageWS = new LanguageWSIntegration.LanguageWS();
                                resultOperation = languageWS.insertLanguage(textBoxName.Text);
                                break;
                        }

                        if (resultOperation == 0)
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                            labelSystemMessage.Text = Constants.msgErrorBusinessToUser;
                        }
                        else
                        {
                            labelSystemMessage.Text = Constants.msgOperationCompleted;
                            this.buttonList_Click(sender, e);
                        }
                    }
                }
                else if (radioUpdate.Checked)
                {
                    if ((textBoxName.Text.Length == 0)||
                        (dataGridViewMasterInformation.DataSource == null && dataGridViewMasterInformation.SelectedRows.Count == 0))
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = Constants.msgSelectRecord; 
                    }
                    else
                    {
                        int resultOperation = 0;
                        int iDColumnIndex = (int)AppEnum.TabMasterModel.ID;
                        int informationID = (int)dataGridViewMasterInformation.SelectedRows[0].Cells[iDColumnIndex].Value;

                        switch (comboBoxMasterInformation.SelectedItem.ToString())
                        {
                            case "Author":
                                AuthorWSIntegration.AuthorWS authorWS = new AuthorWSIntegration.AuthorWS();
                                resultOperation = authorWS.updateAuthor(textBoxName.Text, informationID);
                                break;
                            case "Category":
                                CategoryWSIntegration.CategoryWS categoryWS = new CategoryWSIntegration.CategoryWS();
                                resultOperation = categoryWS.updateCategory(textBoxName.Text, informationID);
                                break;
                            case "Language":
                                LanguageWSIntegration.LanguageWS languageWS = new LanguageWSIntegration.LanguageWS();
                                resultOperation = languageWS.updateLanguage(textBoxName.Text, informationID);
                                break;
                        }

                        if (resultOperation == 0)
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                            labelSystemMessage.Text = Constants.msgErrorBusinessToUser;
                        }
                        else
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                            labelSystemMessage.Text = Constants.msgOperationCompleted;
                            this.buttonList_Click(sender, e);
                        }
                    }

                }
                else if (radioDelete.Checked)
                {
                    if ((textBoxName.Text.Length == 0) ||
                        (dataGridViewMasterInformation.DataSource == null && dataGridViewMasterInformation.SelectedRows.Count == 0))
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = Constants.msgSelectRecord;                        
                    }
                    else
                    {
                        int resultOperation = 0;
                        int iDColumnIndex = (int)AppEnum.TabMasterModel.ID;
                        int informationID = (int)dataGridViewMasterInformation.SelectedRows[0].Cells[iDColumnIndex].Value;

                        switch (comboBoxMasterInformation.SelectedItem.ToString())
                        {
                            case "Author":
                                AuthorWSIntegration.AuthorWS authorWS = new AuthorWSIntegration.AuthorWS();
                                resultOperation = authorWS.DeleteAuthor(informationID);
                                break;
                            case "Category":
                                CategoryWSIntegration.CategoryWS categoryWS = new CategoryWSIntegration.CategoryWS();
                                resultOperation = categoryWS.DeleteCategory(informationID);
                                break;
                            case "Language":
                                LanguageWSIntegration.LanguageWS languageWS = new LanguageWSIntegration.LanguageWS();
                                resultOperation = languageWS.DeleteLanguage(informationID);
                                break;
                        }

                        if (resultOperation == 0)
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                            labelSystemMessage.Text = Constants.msgErrorBusinessToUser;
                        }
                        else
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                            labelSystemMessage.Text = Constants.msgOperationCompleted;
                            this.buttonList_Click(sender, e);
                        }
                    }
                }
                else
                {
                    labelSystemMessage.Text = Constants.msgSelectRecord;
                }
            }
            catch (SoapException ex)
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

        private void comboBoxMasterInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                radioInsert.Checked = false;
                radioUpdate.Checked = false;
                radioDelete.Checked = false;
                labelSystemMessage.Text = Constants.msgLabelDefault;
                labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                textBoxName.Text = null;

                dataGridViewMasterInformation.DataSource = null;

                switch (comboBoxMasterInformation.SelectedItem.ToString())
                {
                    case "Author":
                        AuthorWSIntegration.AuthorWS authorWS = new AuthorWSIntegration.AuthorWS();
                        dataGridViewMasterInformation.DataSource = authorWS.GetAllAuthors();
                        break;
                    case "Category":
                        CategoryWSIntegration.CategoryWS categoryWS = new CategoryWSIntegration.CategoryWS();
                        dataGridViewMasterInformation.DataSource = categoryWS.GetAllCategories();
                        break;
                    case "Language":
                        LanguageWSIntegration.LanguageWS languageWS = new LanguageWSIntegration.LanguageWS();
                        dataGridViewMasterInformation.DataSource = languageWS.GetAllLanguages();
                        break;
                }

                dataGridViewMasterInformation.Columns[Constants.fieldID].Visible = false;

            }
            catch (SoapException ex)
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


    }
}
