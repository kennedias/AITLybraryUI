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
    public partial class TesteWSForm : Form
    {
        public TesteWSForm()
        {
            InitializeComponent();
        }

        private void TesteWSForm_Load(object sender, EventArgs e)
        {
            UserWSIntegration.UserWS userWS = new UserWSIntegration.UserWS();

            DataTable dataTableUserLogin = userWS.UserLogin("Bolt","Escola10");

            if (dataTableUserLogin.Rows.Count > 0)
            {
                //pass to Myform the informations of the user

                int id = Convert.ToInt32(dataTableUserLogin.Rows[0]["ID"]);
                int code = Convert.ToInt32(dataTableUserLogin.Rows[0]["LevelCode"]);

                label1.Text = id.ToString();
                label1.Text = dataTableUserLogin.Rows[0]["Name"].ToString();
                label1.Text = code.ToString();
                label1.Text = dataTableUserLogin.Rows[0]["LevelDescription"].ToString();
            }
        }
    }
}
