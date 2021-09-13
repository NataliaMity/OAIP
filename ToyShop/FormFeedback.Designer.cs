
namespace ToyShop
{
    partial class FormFeedback
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
            this.btnCloseFeedback = new System.Windows.Forms.Button();
            this.richTxtBoxFeedback = new System.Windows.Forms.RichTextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseFeedback
            // 
            this.btnCloseFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseFeedback.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCloseFeedback.Location = new System.Drawing.Point(174, 254);
            this.btnCloseFeedback.Name = "btnCloseFeedback";
            this.btnCloseFeedback.Size = new System.Drawing.Size(120, 33);
            this.btnCloseFeedback.TabIndex = 0;
            this.btnCloseFeedback.Text = "Закрыть";
            this.btnCloseFeedback.UseVisualStyleBackColor = false;
            this.btnCloseFeedback.Click += new System.EventHandler(this.btnExitFeedback_Click);
            // 
            // richTxtBoxFeedback
            // 
            this.richTxtBoxFeedback.Location = new System.Drawing.Point(15, 25);
            this.richTxtBoxFeedback.Name = "richTxtBoxFeedback";
            this.richTxtBoxFeedback.Size = new System.Drawing.Size(279, 223);
            this.richTxtBoxFeedback.TabIndex = 1;
            this.richTxtBoxFeedback.Text = "";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(12, 9);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(119, 13);
            this.lblFeedback.TabIndex = 2;
            this.lblFeedback.Text = "Оставьте свой отзыв:";
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendFeedback.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSendFeedback.Location = new System.Drawing.Point(12, 254);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(120, 33);
            this.btnSendFeedback.TabIndex = 3;
            this.btnSendFeedback.Text = "Отправить";
            this.btnSendFeedback.UseVisualStyleBackColor = false;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // FormFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 299);
            this.ControlBox = false;
            this.Controls.Add(this.btnSendFeedback);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.richTxtBoxFeedback);
            this.Controls.Add(this.btnCloseFeedback);
            this.Name = "FormFeedback";
            this.ShowIcon = false;
            this.Text = "Отзыв";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseFeedback;
        private System.Windows.Forms.RichTextBox richTxtBoxFeedback;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnSendFeedback;
    }
}