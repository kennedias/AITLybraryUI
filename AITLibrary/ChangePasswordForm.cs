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
    public partial class ChangePasswordForm : LybraryPrincipalForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                labelReturnMsg.Text = null;
                LoginLogic loginLogic = new LoginLogic();

                if (textBoxNewPassword.Text == staticUserPassword)
                {
                    labelReturnMsg.Text = "New Password is equals to the previous.";
                }
                else if (textBoxNewPassword.Text == "")
                {
                    labelReturnMsg.Text = "New Password is blank.";
                }
                else if (!loginLogic.passwordFormatValidation(textBoxNewPassword.Text))
                {
                    labelReturnMsg.Text = "New Password. " + loginLogic.MessageOfValidation;

                }
                else if (textBoxConfirmPassword.Text == "")
                {
                    labelReturnMsg.Text = "Confirm Password is blank.";
                }
                else if (!loginLogic.passwordFormatValidation(textBoxConfirmPassword.Text))
                {
                    labelReturnMsg.Text = "Confirm Password. " + loginLogic.MessageOfValidation;

                }
                else if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
                {
                    labelReturnMsg.Text = "New and Confirm Password have to be equals.";

                }
                else
                {
                    UserLogic userLogic = new UserLogic();
                    int resultQuery = userLogic.updateUser(staticUserName, textBoxNewPassword.Text, staticUserLevelDescription, staticUserID);
                    if (resultQuery < 1)
                    {
                        labelReturnMsg.Text = Constants.msgErrorBusinessToUser;                        
                    }
                    else
                    {
                        staticUserPassword = textBoxNewPassword.Text;
                        this.Close();
                    }
                }
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelReturnMsg.ForeColor = System.Drawing.Color.Red;
                labelReturnMsg.Text = Constants.msgErrorBusinessToUser;
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelReturnMsg.ForeColor = System.Drawing.Color.Red;
                labelReturnMsg.Text = Constants.msgErrorSystemToUser;
            }
        }

        public void OpenTemplateForm()
        {
            try
            {
                Application.Run(new LybraryTemplateForm());
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelReturnMsg.ForeColor = System.Drawing.Color.Red;
                labelReturnMsg.Text = Constants.msgErrorSystemToUser;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelReturnMsg.ForeColor = System.Drawing.Color.Red;
                labelReturnMsg.Text = Constants.msgErrorSystemToUser;
            }
        }
    }
}
