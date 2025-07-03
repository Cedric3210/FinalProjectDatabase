namespace Consultation.App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPassword = new TextBox();
            button1 = new Button();
            textBoxUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(117, 147);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(161, 23);
            textBoxPassword.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(117, 192);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(117, 90);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(161, 23);
            textBoxUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 72);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "User name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 129);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 286);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxUserName);
            Controls.Add(button1);
            Controls.Add(textBoxPassword);
            Name = "Form1";
            Text = "Consultation Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private Button button1;
        private TextBox textBoxUserName;
        private Label label1;
        private Label label2;
    }
}
