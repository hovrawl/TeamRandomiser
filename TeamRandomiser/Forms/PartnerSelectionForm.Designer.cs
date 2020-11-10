namespace TeamRandomiser.Forms
{
    partial class PartnerSelectionForm
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
            this.playerPartnerCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.playerPartnerSelectBtn = new System.Windows.Forms.Button();
            this.playerPartnerCancelBtn = new System.Windows.Forms.Button();
            this.playerPartnerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerPartnerCheckedListBox
            // 
            this.playerPartnerCheckedListBox.CheckOnClick = true;
            this.playerPartnerCheckedListBox.FormattingEnabled = true;
            this.playerPartnerCheckedListBox.Location = new System.Drawing.Point(12, 34);
            this.playerPartnerCheckedListBox.Name = "playerPartnerCheckedListBox";
            this.playerPartnerCheckedListBox.Size = new System.Drawing.Size(239, 199);
            this.playerPartnerCheckedListBox.TabIndex = 0;
            // 
            // playerPartnerSelectBtn
            // 
            this.playerPartnerSelectBtn.Location = new System.Drawing.Point(12, 248);
            this.playerPartnerSelectBtn.Name = "playerPartnerSelectBtn";
            this.playerPartnerSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.playerPartnerSelectBtn.TabIndex = 1;
            this.playerPartnerSelectBtn.Text = "Select";
            this.playerPartnerSelectBtn.UseVisualStyleBackColor = true;
            this.playerPartnerSelectBtn.Click += new System.EventHandler(this.playerPartnerSelectBtn_Click);
            // 
            // playerPartnerCancelBtn
            // 
            this.playerPartnerCancelBtn.Location = new System.Drawing.Point(176, 248);
            this.playerPartnerCancelBtn.Name = "playerPartnerCancelBtn";
            this.playerPartnerCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.playerPartnerCancelBtn.TabIndex = 2;
            this.playerPartnerCancelBtn.Text = "Cancel";
            this.playerPartnerCancelBtn.UseVisualStyleBackColor = true;
            this.playerPartnerCancelBtn.Click += new System.EventHandler(this.playerPartnerCancelBtn_Click);
            // 
            // playerPartnerLbl
            // 
            this.playerPartnerLbl.AutoSize = true;
            this.playerPartnerLbl.Location = new System.Drawing.Point(13, 15);
            this.playerPartnerLbl.Name = "playerPartnerLbl";
            this.playerPartnerLbl.Size = new System.Drawing.Size(41, 13);
            this.playerPartnerLbl.TabIndex = 3;
            this.playerPartnerLbl.Text = "Players";
            // 
            // PartnerSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 283);
            this.Controls.Add(this.playerPartnerLbl);
            this.Controls.Add(this.playerPartnerCancelBtn);
            this.Controls.Add(this.playerPartnerSelectBtn);
            this.Controls.Add(this.playerPartnerCheckedListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartnerSelectionForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Partner Selection";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox playerPartnerCheckedListBox;
        private System.Windows.Forms.Button playerPartnerSelectBtn;
        private System.Windows.Forms.Button playerPartnerCancelBtn;
        private System.Windows.Forms.Label playerPartnerLbl;
    }
}