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

                UserWSIntegration.UserWS userWS = new UserWSIntegration.UserWS();

                if ((textBoxUserName.Text == "") && (textBoxPassword.Text == ""))
                {
                    labelReturnMsg.Text = "User name and password are blank.";
                }
                else if (textBoxUserName.Text == "")
                {
                    labelReturnMsg.Text = "User name is blank.";
                }
                else if (textBoxPassword.Text == "")
                {
                    labelReturnMsg.Text = "Password is blank.";
                }
                else if (!loginLogic.passwordFormatValidation(textBoxPassword.Text))
                {
                    labelReturnMsg.Text = loginLogic.MessageOfValidation;

                }
                else
                {
                 //   UserLogic userLogic = new UserLogic();
                  //  List<TabUserModel> tmpListUser = userLogic.PerformLogin(textBoxUserName.Text, textBoxPassword.Text);

                    DataTable dataTableUserLogin = userWS.UserLogin(textBoxUserName.Text, textBoxPassword.Text);


                //    if (tmpListUser.Count > 0)
                    if (dataTableUserLogin.Rows.Count > 0)
                    {
                        //pass to Myform the informations of the user
                        staticUserID = Convert.ToInt32(dataTableUserLogin.Rows[0]["ID"]);
                        staticUserName = dataTableUserLogin.Rows[0]["Name"].ToString();
                        staticUserLevelCode = Convert.ToInt32(dataTableUserLogin.Rows[0]["LevelCode"]);
                        staticUserLevelDescription = dataTableUserLogin.Rows[0]["LevelDescription"].ToString();
                        staticUserPassword = textBoxPassword.Text;

                        if (staticUserLevelCode == Constants.userCode) //TODO Constants.userCode)
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
                    else
                    {
                        labelReturnMsg.Text = "User not found or password invalid.";
                    }
                }
            }
            catch (BusinessLogicException ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelReturnMsg.ForeColor = System.Drawing.Color.Red;
                labelReturnMsg.Text = "This action can not be completed! Please contact the system support team.";
            }
            catch (Exception ex)
            {
                //Error log simulate
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.GetBaseException().ToString());
                labelReturnMsg.ForeColor = System.Drawing.Color.Red;
                labelReturnMsg.Text = "Sorry, something went wrong! Please contact the system support team.";
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
                labelReturnMsg.Text = "Sorry, something went wrong! Please contact the system support team.";
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
                labelReturnMsg.Text = "Sorry, something went wrong! Please contact the system support team.";
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
