namespace User_Control
{
    partial class Form1
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
            this.userControl11 = new User_Control.UserControl1();
            this.btnstate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(49, 22);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(295, 59);
            this.userControl11.TabIndex = 0;
            // 
            // btnstate
            // 
            this.btnstate.Location = new System.Drawing.Point(146, 124);
            this.btnstate.Name = "btnstate";
            this.btnstate.Size = new System.Drawing.Size(100, 45);
            this.btnstate.TabIndex = 1;
            this.btnstate.Text = "State";
            this.btnstate.UseVisualStyleBackColor = true;
            this.btnstate.Click += new System.EventHandler(this.btnstate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 308);
            this.Controls.Add(this.btnstate);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Button btnstate;
    }
}

