namespace ChatApplication
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.to_textbox = new System.Windows.Forms.TextBox();
            this.message_textbox = new System.Windows.Forms.TextBox();
            this.message_label = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chatting Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // to_textbox
            // 
            this.to_textbox.Location = new System.Drawing.Point(39, 108);
            this.to_textbox.Name = "to_textbox";
            this.to_textbox.Size = new System.Drawing.Size(238, 20);
            this.to_textbox.TabIndex = 2;
            // 
            // message_textbox
            // 
            this.message_textbox.Location = new System.Drawing.Point(39, 167);
            this.message_textbox.Multiline = true;
            this.message_textbox.Name = "message_textbox";
            this.message_textbox.Size = new System.Drawing.Size(238, 219);
            this.message_textbox.TabIndex = 3;
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Location = new System.Drawing.Point(36, 151);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(53, 13);
            this.message_label.TabIndex = 4;
            this.message_label.Text = "Message:";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(39, 410);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(238, 23);
            this.send_button.TabIndex = 5;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(39, 452);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(238, 23);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 513);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.message_textbox);
            this.Controls.Add(this.to_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox to_textbox;
        private System.Windows.Forms.TextBox message_textbox;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button logout_btn;
    }
}