
namespace Discord_2._0.View
{
    partial class SignUpPage
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtPassSignUp = new System.Windows.Forms.TextBox();
            this.lblPassSignUp = new System.Windows.Forms.Label();
            this.txtEmailSignUp = new System.Windows.Forms.TextBox();
            this.lblEmailSignUp = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(247, 359);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(281, 45);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtPassSignUp
            // 
            this.txtPassSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassSignUp.Location = new System.Drawing.Point(247, 300);
            this.txtPassSignUp.Multiline = true;
            this.txtPassSignUp.Name = "txtPassSignUp";
            this.txtPassSignUp.Size = new System.Drawing.Size(281, 43);
            this.txtPassSignUp.TabIndex = 12;
            // 
            // lblPassSignUp
            // 
            this.lblPassSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblPassSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassSignUp.Location = new System.Drawing.Point(241, 259);
            this.lblPassSignUp.Name = "lblPassSignUp";
            this.lblPassSignUp.Size = new System.Drawing.Size(180, 38);
            this.lblPassSignUp.TabIndex = 11;
            this.lblPassSignUp.Text = "Password:";
            // 
            // txtEmailSignUp
            // 
            this.txtEmailSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSignUp.Location = new System.Drawing.Point(247, 209);
            this.txtEmailSignUp.Multiline = true;
            this.txtEmailSignUp.Name = "txtEmailSignUp";
            this.txtEmailSignUp.Size = new System.Drawing.Size(281, 43);
            this.txtEmailSignUp.TabIndex = 10;
            // 
            // lblEmailSignUp
            // 
            this.lblEmailSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSignUp.Location = new System.Drawing.Point(241, 168);
            this.lblEmailSignUp.Name = "lblEmailSignUp";
            this.lblEmailSignUp.Size = new System.Drawing.Size(180, 38);
            this.lblEmailSignUp.TabIndex = 9;
            this.lblEmailSignUp.Text = "Email:";
            // 
            // lblSignUp
            // 
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(267, 9);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(245, 67);
            this.lblSignUp.TabIndex = 8;
            this.lblSignUp.Text = "SignUp";
            this.lblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(247, 117);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 43);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(241, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 38);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name:";
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPassSignUp);
            this.Controls.Add(this.lblPassSignUp);
            this.Controls.Add(this.txtEmailSignUp);
            this.Controls.Add(this.lblEmailSignUp);
            this.Controls.Add(this.lblSignUp);
            this.Name = "SignUpPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtPassSignUp;
        private System.Windows.Forms.Label lblPassSignUp;
        private System.Windows.Forms.TextBox txtEmailSignUp;
        private System.Windows.Forms.Label lblEmailSignUp;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}