
namespace ToyShop
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.btnCloseHelp = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseHelp
            // 
            this.btnCloseHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseHelp.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCloseHelp.Location = new System.Drawing.Point(133, 252);
            this.btnCloseHelp.Name = "btnCloseHelp";
            this.btnCloseHelp.Size = new System.Drawing.Size(120, 33);
            this.btnCloseHelp.TabIndex = 0;
            this.btnCloseHelp.Text = "Закрыть";
            this.btnCloseHelp.UseVisualStyleBackColor = false;
            this.btnCloseHelp.Click += new System.EventHandler(this.btnCloseHelp_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHelp.Location = new System.Drawing.Point(12, 9);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(336, 221);
            this.lblHelp.TabIndex = 1;
            this.lblHelp.Text = resources.GetString("lblHelp.Text");
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 297);
            this.ControlBox = false;
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnCloseHelp);
            this.Name = "FormHelp";
            this.ShowIcon = false;
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseHelp;
        private System.Windows.Forms.Label lblHelp;
    }
}