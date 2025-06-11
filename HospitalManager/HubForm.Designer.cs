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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chat = new System.Windows.Forms.Button();
            this.btn_analytics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi!";
            // 
            // btn_chat
            // 
            this.btn_chat.Location = new System.Drawing.Point(89, 363);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Size = new System.Drawing.Size(80, 30);
            this.btn_chat.TabIndex = 1;
            this.btn_chat.Text = "Chat";
            this.btn_chat.UseVisualStyleBackColor = true;
            this.btn_chat.Click += new System.EventHandler(this.btn_chat_Click);
            // 
            // btn_analytics
            // 
            this.btn_analytics.Location = new System.Drawing.Point(220, 363);
            this.btn_analytics.Name = "btn_analytics";
            this.btn_analytics.Size = new System.Drawing.Size(85, 30);
            this.btn_analytics.TabIndex = 2;
            this.btn_analytics.Text = "Analytics";
            this.btn_analytics.UseVisualStyleBackColor = true;
            this.btn_analytics.Click += new System.EventHandler(this.btn_analytics_Click);
            // 
            // HubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_analytics);
            this.Controls.Add(this.btn_chat);
            this.Controls.Add(this.label1);
            this.Name = "HubForm";
            this.Text = "Hub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chat;
        private System.Windows.Forms.Button btn_analytics;
    }
}