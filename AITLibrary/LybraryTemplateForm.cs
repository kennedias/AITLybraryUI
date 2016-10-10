using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemFramework;

namespace AITLibrary
{
    public partial class LybraryTemplateForm : LybraryPrincipalForm
    {
        public LybraryTemplateForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemUserDetails_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadUserDetailsForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenUserDetailsForm));
            threadUserDetailsForm.Start();
            this.Close();
        }

        private void OpenUserDetailsForm()
        {
            Application.Run(new UserDetailsForm());
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadLoginForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            threadLoginForm.Start();
            this.Close();
        }

        private void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBookSearchForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBookSearchForm));
            threadBookSearchForm.Start();
            this.Close();
        }

        private void OpenBookSearchForm()
        {
            Application.Run(new BookSearchForm());
        }

        private void consultCancelReserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadConsultAndCancelBookReservedForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenConsultAndCancelBookReservedForm));
            threadConsultAndCancelBookReservedForm.Start();
            this.Close();
        }

        private void OpenConsultAndCancelBookReservedForm()
        {
            Application.Run(new ConsultAndCancelBookReservedForm());
        }

        private void reserveABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBookReserveForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBookReserveForm));
            threadBookReserveForm.Start();
            this.Close();
        }

        private void OpenBookReserveForm()
        {
            Application.Run(new BookReserveForm());
        }

        private void borrowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (staticUserLevelCode == Constants.administratorCode || staticUserLevelCode == Constants.supervisorCode)
            {
                System.Threading.Thread threadBorrowBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBorrowBookForm));
                threadBorrowBookForm.Start();
                this.Close();
            }
        }

        private void OpenBorrowBookForm()
        {
            Application.Run(new BorrowBookForm());
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBookMaintenanceForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBookMaintenanceForm));
            threadBookMaintenanceForm.Start();
            this.Close();
        }

        private void OpenBookMaintenanceForm()
        {
            Application.Run(new BookMaintenanceForm());
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadReturnBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenReturnBookForm));
            threadReturnBookForm.Start();
            this.Close();
        }

        private void OpenReturnBookForm()
        {
            Application.Run(new ReturnBookForm());
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBrowseBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBookBrowseForm));
            threadBrowseBookForm.Start();
            this.Close();

        }

        private void OpenBookBrowseForm()
        {
            Application.Run(new BookBrowseForm());
        }

        private void viewBorrowedReservedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadBorrowedReservedBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenBooksBorrowedAndReservedForm));
            threadBorrowedReservedBookForm.Start();
            this.Close();
        }

        private void OpenBooksBorrowedAndReservedForm()
        {
            Application.Run(new BooksBorrowedAndReservedForm());
        }

        private void myActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadMyActivitiesBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMyActivitiesForm));
            threadMyActivitiesBookForm.Start();
            this.Close();
        }

        private void OpenMyActivitiesForm()
        {
            Application.Run(new MyActivitiesForm());
        }

        private void informationMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadMasterInformationMaintenanceBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMasterInformationMaintenanceForm));
            threadMasterInformationMaintenanceBookForm.Start();
            this.Close();

        }

        private void OpenMasterInformationMaintenanceForm()
        {
            Application.Run(new MasterInformationMaintenanceForm());
        }

        private void userMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenUserMaintenanceForm()
        {
            Application.Run(new UserMaintenanceForm());
        }

        private void bookBorrowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadReportBookBorrowedForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenReportBookBorrowedForm));
            threadReportBookBorrowedForm.Start();
            this.Close();
        }

        private void OpenReportBookBorrowedForm()
        {
            Application.Run(new ReportBookBorrowedForm());
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadUserMaintenanceBookForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenUserMaintenanceForm));
            threadUserMaintenanceBookForm.Start();
            this.Close();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadUserListForm = new System.Threading.Thread(new System.Threading.ThreadStart(OpenUserListForm));
            threadUserListForm.Start();
            this.Close();
        }

        private void OpenUserListForm()
        {
            Application.Run(new UserListForm());
        }

        private void LybraryTemplateForm_Load(object sender, EventArgs e)
        {
            if (staticUserLevelCode != Constants.administratorCode && staticUserLevelCode != Constants.supervisorCode)
            {
                borrowToolStripMenuItem.Visible = false;
                viewBorrowedReservedToolStripMenuItem.Visible = false;
                administrationToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = false;
            }
                
        }
    }
}
