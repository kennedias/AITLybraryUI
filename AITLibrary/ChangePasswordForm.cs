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

                if (textBoxNewPassword.Text == staticUserPassword)
                {
                    labelReturnMsg.Text = Constants.msgPasswordEqualsToPrevious;
                }
                else if (string.IsNullOrEmpty(textBoxNewPassword.Text))
                {
                    labelReturnMsg.Text = Constants.msgNewPasswordBlank;
                }                
                else if (string.IsNullOrEmpty(textBoxConfirmPassword.Text))
                {
                    labelReturnMsg.Text = Constants.msgConfirmPasswordBlank;
                }                
                else if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
                {
                    labelReturnMsg.Text = Constants.msgNewAndConfirmPasswordNotEquals;
                }
                else
                {
                    LoginValidationWSIntegration.LoginValidationWS loginWS = new LoginValidationWSIntegration.LoginValidationWS();
                    loginWS.passwordFormatValidation(textBoxNewPassword.Text);
                    loginWS.passwordFormatValidation(textBoxConfirmPassword.Text);

                    UserWSIntegration.UserWS userWS = new UserWSIntegration.UserWS();
                    int resultQuery = userWS.updateUser(staticUserName, textBoxNewPassword.Text, staticUserLevelDescription, staticUserID);
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
            catch (SoapException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelReturnMsg.ForeColor = System.Drawing.Color.Red;
                labelReturnMsg.Text = ex.Message;
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
