/* Principal form of the application
 * This form is used to held the principal information 
 * about the user logged.
 *  
 * Project: Assignment 2 - AIT
 * Developer: Kennedy Oliveira - ID 5399
 * Data of release: 12/09/2016
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

namespace AITLibrary
{
    /// <summary>
    /// Principal form of the application.
    /// Attributes from the logged user should be shared with the forms behind this one.
    /// </summary>
    public partial class LybraryPrincipalForm : Form
    {
        public static int staticUserID;
        public static string staticUserName;
        public static int staticUserLevelCode;
        public static string staticUserLevelDescription;
        public static string staticUserPassword;


        public LybraryPrincipalForm()
        {
            InitializeComponent();
        }
    }
}