/* Form for maintenance of User details by the User logged
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
    ///  Form for maintenance of User details by the User logged.
    /// </summary>
    public partial class UserDetailsForm : LybraryTemplateForm
    {
        public UserDetailsForm()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = null;
                System.Threading.Thread threadForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChangePasswordForm));
                threadForm.Start();
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

        public void OpenChangePasswordForm()
        {
            try
            {
                Application.Run(new ChangePasswordForm());
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

        private void UserDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxUserLevel.DataSource = Constants.userLevelList;

                /* User level can not change his level */
                if (staticUserLevelCode == Constants.userCode)
                {
                    comboBoxUserLevel.Enabled = false;
                }

                textBoxUserName.Text = staticUserName;
                comboBoxUserLevel.SelectedItem = staticUserLevelDescription;
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

        private void buttonSaveUserModification_Click(object sender, EventArgs e)
        {
            try
            {
                labelSystemMessage.Text = null;

                if (textBoxUserName.Text == null)
                {
                    labelSystemMessage.Text = Constants.msgUserNameBlank;
                }
                else
                {
                    UserLogic userLogic = new UserLogic();
                    int returnOperation = userLogic.updateUser(textBoxUserName.Text, staticUserPassword, comboBoxUserLevel.Text, staticUserID);
                    if (returnOperation < 1)
                    {
                        labelSystemMessage.Text = Constants.msgNoRecordUpdated;
                    }
                    else
                    {
                        labelSystemMessage.Text = Constants.msgOperationCompleted;
                        staticUserName = textBoxUserName.Text;
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
    }
}
