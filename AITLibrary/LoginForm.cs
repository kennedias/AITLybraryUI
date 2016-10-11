using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemFramework;
using System.Web.Services.Protocols;

namespace AITLibrary
{
    public partial class LoginForm : LybraryPrincipalForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                labelReturnMsg.Text = null;

                if ((string.IsNullOrEmpty(textBoxUserName.Text)) && (string.IsNullOrEmpty(textBoxPassword.Text)))
                {
                    labelReturnMsg.Text = Constants.msgNamePasswordBlank;
                }
                else if (string.IsNullOrEmpty(textBoxUserName.Text))
                {
                    labelReturnMsg.Text = Constants.msgUserNameBlank;  
                }
                else if (string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    labelReturnMsg.Text = Constants.msgPasswordBlank;
                }
                else 
                {                   
                    LoginValidationWSIntegration.LoginValidationWS loginWS = new LoginValidationWSIntegration.LoginValidationWS();
                    loginWS.passwordFormatValidation(textBoxPassword.Text);

                    UserWSIntegration.UserWS userWS = new UserWSIntegration.UserWS();
                    DataTable dataTableUserLogin = userWS.UserLogin(textBoxUserName.Text, textBoxPassword.Text);                                   
                    
                    if (dataTableUserLogin.Rows.Count == 0)
                    {
                        labelReturnMsg.Text = Constants.msgNoMatchesFound; 
                    } 
                    else 
                    {
                        //pass to Myform the informations of the user
                        staticUserID = Convert.ToInt32(dataTableUserLogin.Rows[0][Constants.fieldID]);
                        staticUserName = dataTableUserLogin.Rows[0][Constants.fieldName].ToString();
                        staticUserLevelCode = Convert.ToInt32(dataTableUserLogin.Rows[0][Constants.fieldLevelCode]);
                        staticUserLevelDescription = dataTableUserLogin.Rows[0][Constants.fieldLevelDescription].ToString();
                        staticUserPassword = textBoxPassword.Text;

                        if (staticUserLevelCode == Constants.userCode) 
                        {
                            System.Threading.Thread threadChangePasswordForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChangePasswordForm));
                            threadChangePasswordForm.Start();
                            System.Threading.Thread threadLybraryBaseForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLybraryTemplateForm));
                            threadLybraryBaseForm.Start();
                            this.Close();
                        }
                        else
                        {
                            System.Threading.Thread threadLybraryBaseForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLybraryTemplateForm));
                            threadLybraryBaseForm.Start();
                            this.Close();
                        }
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

        public void OpenLybraryTemplateForm()
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
                labelReturnMsg.ForeColor = System.Drawing.Color.Red;
                labelReturnMsg.Text = Constants.msgErrorSystemToUser;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            /* Once this form is loaded, all the user information should be cleaned.
             * This works for a login/logoff functionality.
            */
            staticUserID = 0;
            staticUserName = null;
            staticUserLevelCode = 0;
            staticUserLevelDescription = null;
        }



    }
}
