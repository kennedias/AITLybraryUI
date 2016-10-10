namespace AITLibrary
{
    partial class ConsultAndCancelBookReservedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewBookReserved = new System.Windows.Forms.DataGridView();
            this.buttonCancelBookReserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookReserved)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookReserved
            // 
            this.dataGridViewBookReserved.AllowUserToAddRows = false;
            this.dataGridViewBookReserved.AllowUserToDeleteRows = false;
            this.dataGridViewBookReserved.AllowUserToOrderColumns = true;
            this.dataGridViewBookReserved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookReserved.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewBookReserved.MultiSelect = false;
            this.dataGridViewBookReserved.Name = "dataGridViewBookReserved";
            this.dataGridViewBookReserved.ReadOnly = true;
            this.dataGridViewBookReserved.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookReserved.Size = new System.Drawing.Size(919, 495);
            this.dataGridViewBookReserved.TabIndex = 2;
            // 
            // buttonCancelBookReserve
            // 
            this.buttonCancelBookReserve.Location = new System.Drawing.Point(795, 542);
            this.buttonCancelBookReserve.Name = "buttonCancelBookReserve";
            this.buttonCancelBookReserve.Size = new System.Drawing.Size(136, 23);
            this.buttonCancelBookReserve.TabIndex = 3;
            this.buttonCancelBookReserve.Text = "Cancel Reserve";
            this.buttonCancelBookReserve.UseVisualStyleBackColor = true;
            this.buttonCancelBookReserve.Click += new System.EventHandler(this.buttonCancelBookReserve_Click);
            // 
            // ConsultAndCancelBookReservedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.buttonCancelBookReserve);
            this.Controls.Add(this.dataGridViewBookReserved);
            this.Name = "ConsultAndCancelBookReservedForm";
            this.Text = " Consult and Cancel Books Reserves";
            this.Load += new System.EventHandler(this.ConsultAndCancelBookReservedForm_Load);
            this.Controls.SetChildIndex(this.labelSystemMessage, 0);
            this.Controls.SetChildIndex(this.dataGridViewBookReserved, 0);
            this.Controls.SetChildIndex(this.buttonCancelBookReserve, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookReserved)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBookReserved;
        private System.Windows.Forms.Button buttonCancelBookReserve;
    }
}