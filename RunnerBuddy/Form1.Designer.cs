namespace RunnerBuddy
{
    partial class RBMainform
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnINILocation = new System.Windows.Forms.Button();
            this.lblINIFileLocation = new System.Windows.Forms.Label();
            this.btnAddIPAddress = new System.Windows.Forms.Button();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.tbIPAlias = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemoveEntry = new System.Windows.Forms.Button();
            this.lblCurrentAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "ini";
            this.openFileDialog1.FileName = "artemis.ini";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnINILocation
            // 
            this.btnINILocation.Location = new System.Drawing.Point(95, 28);
            this.btnINILocation.Name = "btnINILocation";
            this.btnINILocation.Size = new System.Drawing.Size(75, 23);
            this.btnINILocation.TabIndex = 0;
            this.btnINILocation.Text = "Browse";
            this.btnINILocation.UseVisualStyleBackColor = true;
            this.btnINILocation.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblINIFileLocation
            // 
            this.lblINIFileLocation.AutoSize = true;
            this.lblINIFileLocation.Location = new System.Drawing.Point(199, 28);
            this.lblINIFileLocation.Name = "lblINIFileLocation";
            this.lblINIFileLocation.Size = new System.Drawing.Size(159, 17);
            this.lblINIFileLocation.TabIndex = 1;
            this.lblINIFileLocation.Text = "Artemis INI File Location";
            // 
            // btnAddIPAddress
            // 
            this.btnAddIPAddress.Location = new System.Drawing.Point(64, 89);
            this.btnAddIPAddress.Name = "btnAddIPAddress";
            this.btnAddIPAddress.Size = new System.Drawing.Size(106, 23);
            this.btnAddIPAddress.TabIndex = 2;
            this.btnAddIPAddress.Text = "Add to List";
            this.btnAddIPAddress.UseVisualStyleBackColor = true;
            this.btnAddIPAddress.Click += new System.EventHandler(this.btnAddIPAddress_Click);
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(202, 89);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(122, 22);
            this.tbIPAddress.TabIndex = 3;
            // 
            // tbIPAlias
            // 
            this.tbIPAlias.Location = new System.Drawing.Point(364, 90);
            this.tbIPAlias.Name = "tbIPAlias";
            this.tbIPAlias.Size = new System.Drawing.Size(262, 22);
            this.tbIPAlias.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(64, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 196);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(202, 66);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(122, 17);
            this.lblIPAddress.TabIndex = 7;
            this.lblIPAddress.Text = "Server IP Address";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(364, 66);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(38, 17);
            this.lblAlias.TabIndex = 8;
            this.lblAlias.Text = "Alias";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(447, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update forceAddress";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemoveEntry
            // 
            this.btnRemoveEntry.Location = new System.Drawing.Point(447, 202);
            this.btnRemoveEntry.Name = "btnRemoveEntry";
            this.btnRemoveEntry.Size = new System.Drawing.Size(178, 23);
            this.btnRemoveEntry.TabIndex = 10;
            this.btnRemoveEntry.Text = "Remove Entry";
            this.btnRemoveEntry.UseVisualStyleBackColor = true;
            this.btnRemoveEntry.Click += new System.EventHandler(this.btnRemoveEntry_Click);
            // 
            // lblCurrentAddress
            // 
            this.lblCurrentAddress.AutoSize = true;
            this.lblCurrentAddress.Location = new System.Drawing.Point(202, 118);
            this.lblCurrentAddress.Name = "lblCurrentAddress";
            this.lblCurrentAddress.Size = new System.Drawing.Size(111, 17);
            this.lblCurrentAddress.TabIndex = 11;
            this.lblCurrentAddress.Text = "Current Address";
            // 
            // RBMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 356);
            this.Controls.Add(this.lblCurrentAddress);
            this.Controls.Add(this.btnRemoveEntry);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbIPAlias);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.btnAddIPAddress);
            this.Controls.Add(this.lblINIFileLocation);
            this.Controls.Add(this.btnINILocation);
            this.Name = "RBMainform";
            this.Text = "Runner Buddy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnINILocation;
        private System.Windows.Forms.Label lblINIFileLocation;
        private System.Windows.Forms.Button btnAddIPAddress;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.TextBox tbIPAlias;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemoveEntry;
        private System.Windows.Forms.Label lblCurrentAddress;
    }
}

