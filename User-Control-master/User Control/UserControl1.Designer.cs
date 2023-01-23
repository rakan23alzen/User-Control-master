namespace User_Control
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblstate = new System.Windows.Forms.Label();
            this.cbostate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(34, 16);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(39, 16);
            this.lblstate.TabIndex = 0;
            this.lblstate.Text = "state:";
            // 
            // cbostate
            // 
            this.cbostate.FormattingEnabled = true;
            this.cbostate.Location = new System.Drawing.Point(93, 13);
            this.cbostate.Name = "cbostate";
            this.cbostate.Size = new System.Drawing.Size(199, 24);
            this.cbostate.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbostate);
            this.Controls.Add(this.lblstate);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(295, 59);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.ComboBox cbostate;
    }
}
