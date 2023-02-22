
namespace WindowsFormsApp1
{
    partial class Userlist
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
            this.dgvUserlist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserlist
            // 
            this.dgvUserlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserlist.Location = new System.Drawing.Point(32, 2);
            this.dgvUserlist.Name = "dgvUserlist";
            this.dgvUserlist.Size = new System.Drawing.Size(667, 406);
            this.dgvUserlist.TabIndex = 0;
            // 
            // Userlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUserlist);
            this.Name = "Userlist";
            this.Text = "UserList";
            this.Load += new System.EventHandler(this.Userlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserlist;
    }
}

