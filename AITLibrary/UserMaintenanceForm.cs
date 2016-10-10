using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace AITLibrary
{
    public partial class UserMaintenanceForm : LybraryTemplateForm
    {
        public UserMaintenanceForm()
        {
            InitializeComponent();
        }

        private void buttonListAllUsers_Click(object sender, EventArgs e)
        {
            try
            {
                radioInsert.Checked = false;
                radioUpdate.Checked = false;
                radioDelete.Checked = false;
                comboBoxUserLevel.Enabled = false;
                UserLogic userLogic = new UserLogic();
                dataGridViewListUsers.DataSource = userLogic.GetAllUser();
                dataGridViewListUsers.Columns[Constants.fieldID].Visible = false;
                dataGridViewListUsers.Columns[Constants.fieldLevelCode].Visible = false;
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

        private void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                radioInsert.Checked = false;
                radioUpdate.Checked = false;
                radioDelete.Checked = false;
                comboBoxUserLevel.Enabled = false;
                labelSystemMessage.Text = Constants.msgLabelDefault;

                if (textBoxNameForSearch.Text == "")
                {
                    labelSystemMessage.Text = Constants.msgUserNameBlank;
                }
                else
                {
                    UserLogic userLogic = new UserLogic();

                    dataGridViewListUsers.DataSource = userLogic.GetUsersByName(textBoxNameForSearch.Text);
                    dataGridViewListUsers.Columns[Constants.fieldID].Visible = false;
                    dataGridViewListUsers.Columns[Constants.fieldLevelCode].Visible = false;

                    if (dataGridViewListUsers.RowCount == 0)
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

        private void radioInsert_Click(object sender, EventArgs e)
        {
            textBoxNameForSearch.Text = null;
            comboBoxUserLevel.Enabled = true;
        }

        private void refreshUserMaintenanceFields()
        {
            textBoxName.Text = null;
            if (dataGridViewListUsers.DataSource != null && dataGridViewListUsers.SelectedRows.Count > 0)
            {
                int userNameColumnIndex = (int)AppEnum.TabUserModel.Name;
                textBoxName.Text = dataGridViewListUsers.SelectedRows[0].Cells[userNameColumnIndex].Value.ToString();

                int levelDescriptionColumnIndex = (int)AppEnum.TabUserModel.LevelDescription;
                comboBoxUserLevel.SelectedItem = dataGridViewListUsers.SelectedRows[0].Cells[levelDescriptionColumnIndex].Value.ToString();

                radioInsert.Checked = false;
                radioUpdate.Checked = false;
                radioDelete.Checked = false;
            }
        }

        private void dataGridViewListUsers_Click(object sender, EventArgs e)
        {
            this.refreshUserMaintenanceFields();
        }

        private void UserMaintenanceForm_Load(object sender, EventArgs e)
        {
            comboBoxUserLevel.DataSource = Constants.userLevelList;
            comboBoxUserLevel.Enabled = false;
        }

        private void radioInsert_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxUserLevel.Enabled = true;
            textBoxName.Text = null;
            comboBoxUserLevel.SelectedIndex = 0;
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
                        UserLogic userLogic = new UserLogic();
                        resultOperation = userLogic.insertUser(textBoxName.Text, comboBoxUserLevel.Text);

                        if (resultOperation == 0)
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                            labelSystemMessage.Text = Constants.msgErrorBusinessToUser;
                        }
                        else
                        {
                            labelSystemMessage.Text = Constants.msgOperationCompleted;
                            this.UserMaintenanceForm_Load(sender, e);
                            dataGridViewListUsers.DataSource = null;
                        }
                    }
                }
                else if (radioUpdate.Checked)
                {
                    if ((textBoxName.Text.Length == 0)||
                        (dataGridViewListUsers.DataSource == null && dataGridViewListUsers.SelectedRows.Count == 0))
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = Constants.msgSelectRecord; 
                    }
                    else
                    {
                        int resultOperation = 0;
                        UserLogic userLogic = new UserLogic();
                        int iDColumnIndex = (int)AppEnum.TabUserModel.ID;
                        int informationID = (int)dataGridViewListUsers.SelectedRows[0].Cells[iDColumnIndex].Value;

                        resultOperation = userLogic.updateUserWithoutPassword(textBoxName.Text, comboBoxUserLevel.Text, informationID);

                        if (resultOperation == 0)
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                            labelSystemMessage.Text = Constants.msgErrorBusinessToUser;
                        }
                        else
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                            labelSystemMessage.Text = Constants.msgOperationCompleted;                            
                            dataGridViewListUsers.DataSource = null;
                        }
                    }

                }
                else if (radioDelete.Checked)
                {
                    if ((textBoxName.Text.Length == 0) ||
                        (dataGridViewListUsers.DataSource == null && dataGridViewListUsers.SelectedRows.Count == 0))
                    {
                        labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                        labelSystemMessage.Text = Constants.msgSelectRecord;                        
                    }
                    else
                    {
                        int resultOperation = 0;
                        UserLogic userLogic = new UserLogic();
                        int iDColumnIndex = (int)AppEnum.TabUserModel.ID;
                        int informationID = (int)dataGridViewListUsers.SelectedRows[0].Cells[iDColumnIndex].Value;

                        resultOperation = userLogic.deleteUser(informationID);

                        if (resultOperation == 0)
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Red;
                            labelSystemMessage.Text = Constants.msgErrorBusinessToUser;
                        }
                        else
                        {
                            labelSystemMessage.ForeColor = System.Drawing.Color.Black;
                            labelSystemMessage.Text = Constants.msgOperationCompleted;
                            dataGridViewListUsers.DataSource = null;
                        }
                    }
                }
                else
                {
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
    }
}
