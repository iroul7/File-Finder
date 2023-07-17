namespace FileFinder
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.CvPathLabel = new System.Windows.Forms.Label();
            this.CvPathTextBox = new System.Windows.Forms.TextBox();
            this.CvOpenDialogButton = new System.Windows.Forms.Button();
            this.CvSearchWordLabel = new System.Windows.Forms.Label();
            this.CvSearchWordTextBox = new System.Windows.Forms.TextBox();
            this.CvSearchButton = new System.Windows.Forms.Button();
            this.CvFileExtensionLabel = new System.Windows.Forms.Label();
            this.CvFileExtensionTextBox = new System.Windows.Forms.TextBox();
            this.CvExtenUseCheckBox = new System.Windows.Forms.CheckBox();
            this.CvResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CvPathLabel
            // 
            this.CvPathLabel.AutoSize = true;
            this.CvPathLabel.Location = new System.Drawing.Point(93, 30);
            this.CvPathLabel.Name = "CvPathLabel";
            this.CvPathLabel.Size = new System.Drawing.Size(77, 12);
            this.CvPathLabel.TabIndex = 0;
            this.CvPathLabel.Text = "Folder Path :";
            // 
            // CvPathTextBox
            // 
            this.CvPathTextBox.Location = new System.Drawing.Point(177, 25);
            this.CvPathTextBox.Name = "CvPathTextBox";
            this.CvPathTextBox.ReadOnly = true;
            this.CvPathTextBox.Size = new System.Drawing.Size(615, 21);
            this.CvPathTextBox.TabIndex = 1;
            // 
            // CvOpenDialogButton
            // 
            this.CvOpenDialogButton.Location = new System.Drawing.Point(798, 25);
            this.CvOpenDialogButton.Name = "CvOpenDialogButton";
            this.CvOpenDialogButton.Size = new System.Drawing.Size(45, 20);
            this.CvOpenDialogButton.TabIndex = 2;
            this.CvOpenDialogButton.Text = "...";
            this.CvOpenDialogButton.UseVisualStyleBackColor = true;
            this.CvOpenDialogButton.Click += new System.EventHandler(this.CvOpenDialogButton_Click);
            // 
            // CvSearchWordLabel
            // 
            this.CvSearchWordLabel.AutoSize = true;
            this.CvSearchWordLabel.Location = new System.Drawing.Point(85, 76);
            this.CvSearchWordLabel.Name = "CvSearchWordLabel";
            this.CvSearchWordLabel.Size = new System.Drawing.Size(85, 12);
            this.CvSearchWordLabel.TabIndex = 3;
            this.CvSearchWordLabel.Text = "Search Word :";
            // 
            // CvSearchWordTextBox
            // 
            this.CvSearchWordTextBox.Location = new System.Drawing.Point(177, 71);
            this.CvSearchWordTextBox.Name = "CvSearchWordTextBox";
            this.CvSearchWordTextBox.Size = new System.Drawing.Size(299, 21);
            this.CvSearchWordTextBox.TabIndex = 4;
            // 
            // CvSearchButton
            // 
            this.CvSearchButton.Location = new System.Drawing.Point(177, 118);
            this.CvSearchButton.Name = "CvSearchButton";
            this.CvSearchButton.Size = new System.Drawing.Size(615, 23);
            this.CvSearchButton.TabIndex = 5;
            this.CvSearchButton.Text = "Search";
            this.CvSearchButton.UseVisualStyleBackColor = true;
            this.CvSearchButton.Click += new System.EventHandler(this.CvSearchButton_Click);
            // 
            // CvFileExtensionLabel
            // 
            this.CvFileExtensionLabel.AutoSize = true;
            this.CvFileExtensionLabel.Location = new System.Drawing.Point(492, 76);
            this.CvFileExtensionLabel.Name = "CvFileExtensionLabel";
            this.CvFileExtensionLabel.Size = new System.Drawing.Size(97, 12);
            this.CvFileExtensionLabel.TabIndex = 7;
            this.CvFileExtensionLabel.Text = "File Extension : ";
            // 
            // CvFileExtensionTextBox
            // 
            this.CvFileExtensionTextBox.Location = new System.Drawing.Point(595, 71);
            this.CvFileExtensionTextBox.Name = "CvFileExtensionTextBox";
            this.CvFileExtensionTextBox.Size = new System.Drawing.Size(197, 21);
            this.CvFileExtensionTextBox.TabIndex = 8;
            // 
            // CvExtenUseCheckBox
            // 
            this.CvExtenUseCheckBox.AutoSize = true;
            this.CvExtenUseCheckBox.Checked = true;
            this.CvExtenUseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CvExtenUseCheckBox.Location = new System.Drawing.Point(798, 75);
            this.CvExtenUseCheckBox.Name = "CvExtenUseCheckBox";
            this.CvExtenUseCheckBox.Size = new System.Drawing.Size(46, 16);
            this.CvExtenUseCheckBox.TabIndex = 9;
            this.CvExtenUseCheckBox.Text = "Use";
            this.CvExtenUseCheckBox.UseVisualStyleBackColor = true;
            this.CvExtenUseCheckBox.CheckedChanged += new System.EventHandler(this.CvExtenUseCheckBox_CheckedChanged);
            // 
            // CvResultRichTextBox
            // 
            this.CvResultRichTextBox.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CvResultRichTextBox.Location = new System.Drawing.Point(23, 180);
            this.CvResultRichTextBox.Name = "CvResultRichTextBox";
            this.CvResultRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.CvResultRichTextBox.Size = new System.Drawing.Size(936, 532);
            this.CvResultRichTextBox.TabIndex = 11;
            this.CvResultRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.CvResultRichTextBox);
            this.Controls.Add(this.CvExtenUseCheckBox);
            this.Controls.Add(this.CvFileExtensionTextBox);
            this.Controls.Add(this.CvFileExtensionLabel);
            this.Controls.Add(this.CvSearchButton);
            this.Controls.Add(this.CvSearchWordTextBox);
            this.Controls.Add(this.CvSearchWordLabel);
            this.Controls.Add(this.CvOpenDialogButton);
            this.Controls.Add(this.CvPathTextBox);
            this.Controls.Add(this.CvPathLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CvPathLabel;
        private System.Windows.Forms.TextBox CvPathTextBox;
        private System.Windows.Forms.Button CvOpenDialogButton;
        private System.Windows.Forms.Label CvSearchWordLabel;
        private System.Windows.Forms.Label CvFileExtensionLabel;
        private System.Windows.Forms.TextBox CvFileExtensionTextBox;
        private System.Windows.Forms.CheckBox CvExtenUseCheckBox;
        private System.Windows.Forms.TextBox CvSearchWordTextBox;
        public System.Windows.Forms.RichTextBox CvResultRichTextBox;
        public System.Windows.Forms.Button CvSearchButton;
    }
}

