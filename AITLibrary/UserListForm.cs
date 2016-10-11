/* Form to list all users. 
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
using System.Web.Services.Protocols;
using SystemFramework;

namespace AITLibrary
{
    /// <summary>
    ///   Form to list all users.
    /// </summary>
    public partial class UserListForm : LybraryTemplateForm
    {
        public UserListForm()
        {
            InitializeComponent();
        }
                
        private void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                UserWSIntegration.UserWS userWS = new UserWSIntegration.UserWS();
                dataGridViewListUsers.DataSource = userWS.GetAllUser();
                dataGridViewListUsers.Columns[Constants.fieldID].Visible = false;
                dataGridViewListUsers.Columns[Constants.fieldLevelCode].Visible = false;
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
