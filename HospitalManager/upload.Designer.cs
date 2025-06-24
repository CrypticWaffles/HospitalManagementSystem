namespace HospitalManager
{
    partial class upload
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_tabletype = new System.Windows.Forms.ComboBox();
            this.txtb_browse = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_complete = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Choose Table";
            // 
            // cbox_tabletype
            // 
            this.cbox_tabletype.FormattingEnabled = true;
            this.cbox_tabletype.Items.AddRange(new object[] {
            "MedicalHistories",
            "Patients"});
            this.cbox_tabletype.Location = new System.Drawing.Point(172, 30);
            this.cbox_tabletype.Name = "cbox_tabletype";
            this.cbox_tabletype.Size = new System.Drawing.Size(138, 28);
            this.cbox_tabletype.TabIndex = 10;
            // 
            // txtb_browse
            // 
            this.txtb_browse.Location = new System.Drawing.Point(50, 82);
            this.txtb_browse.Name = "txtb_browse";
            this.txtb_browse.Size = new System.Drawing.Size(384, 26);
            this.txtb_browse.TabIndex = 9;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(457, 80);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(87, 31);
            this.btn_browse.TabIndex = 7;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_complete
            // 
            this.btn_complete.Location = new System.Drawing.Point(625, 80);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(178, 31);
            this.btn_complete.TabIndex = 8;
            this.btn_complete.Text = "Complete";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(34, 135);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(782, 307);
            this.DataGridView.TabIndex = 6;
            // 
            // upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_tabletype);
            this.Controls.Add(this.txtb_browse);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.DataGridView);
            this.Name = "upload";
            this.Text = "upload";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.upload_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_tabletype;
        private System.Windows.Forms.TextBox txtb_browse;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_complete;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}