namespace HospitalManager
{
    partial class HubForm
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
            this.lbl_hi = new System.Windows.Forms.Label();
            this.btn_chat = new System.Windows.Forms.Button();
            this.btn_analytics = new System.Windows.Forms.Button();
            this.button_patientRecords = new System.Windows.Forms.Button();
            this.lbl_role = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_hi
            // 
            this.lbl_hi.AutoSize = true;
            this.lbl_hi.Location = new System.Drawing.Point(12, 9);
            this.lbl_hi.Name = "lbl_hi";
            this.lbl_hi.Size = new System.Drawing.Size(28, 20);
            this.lbl_hi.TabIndex = 0;
            this.lbl_hi.Text = "Hi!";
            // 
            // btn_chat
            // 
            this.btn_chat.Location = new System.Drawing.Point(16, 87);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Size = new System.Drawing.Size(80, 30);
            this.btn_chat.TabIndex = 1;
            this.btn_chat.Text = "Chat";
            this.btn_chat.UseVisualStyleBackColor = true;
            this.btn_chat.Click += new System.EventHandler(this.btn_chat_Click);
            // 
            // btn_analytics
            // 
            this.btn_analytics.Location = new System.Drawing.Point(16, 157);
            this.btn_analytics.Name = "btn_analytics";
            this.btn_analytics.Size = new System.Drawing.Size(85, 30);
            this.btn_analytics.TabIndex = 2;
            this.btn_analytics.Text = "Analytics";
            this.btn_analytics.UseVisualStyleBackColor = true;
            this.btn_analytics.Visible = false;
            this.btn_analytics.Click += new System.EventHandler(this.btn_analytics_Click);
            // 
            // button_patientRecords
            // 
            this.button_patientRecords.Location = new System.Drawing.Point(167, 157);
            this.button_patientRecords.Name = "button_patientRecords";
            this.button_patientRecords.Size = new System.Drawing.Size(186, 30);
            this.button_patientRecords.TabIndex = 3;
            this.button_patientRecords.Text = "Patient Records";
            this.button_patientRecords.UseVisualStyleBackColor = true;
            this.button_patientRecords.Visible = false;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(12, 39);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(46, 20);
            this.lbl_role.TabIndex = 4;
            this.lbl_role.Text = "Role:";
            // 
            // HubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.button_patientRecords);
            this.Controls.Add(this.btn_analytics);
            this.Controls.Add(this.btn_chat);
            this.Controls.Add(this.lbl_hi);
            this.Name = "HubForm";
            this.Text = "Hub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hi;
        private System.Windows.Forms.Button btn_chat;
        private System.Windows.Forms.Button btn_analytics;
        private System.Windows.Forms.Button button_patientRecords;
        private System.Windows.Forms.Label lbl_role;
    }
}