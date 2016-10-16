namespace XmlContentTranslator
{
    partial class GitPullRequestForm
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
            this.textBoxCommitMessage = new System.Windows.Forms.TextBox();
            this.buttonSendPR = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCommitMessage
            // 
            this.textBoxCommitMessage.Location = new System.Drawing.Point(12, 42);
            this.textBoxCommitMessage.Multiline = true;
            this.textBoxCommitMessage.Name = "textBoxCommitMessage";
            this.textBoxCommitMessage.Size = new System.Drawing.Size(213, 69);
            this.textBoxCommitMessage.TabIndex = 0;
            // 
            // buttonSendPR
            // 
            this.buttonSendPR.Location = new System.Drawing.Point(12, 126);
            this.buttonSendPR.Name = "buttonSendPR";
            this.buttonSendPR.Size = new System.Drawing.Size(125, 23);
            this.buttonSendPR.TabIndex = 1;
            this.buttonSendPR.Text = "Send Pull Request";
            this.buttonSendPR.UseVisualStyleBackColor = true;
            this.buttonSendPR.Click += new System.EventHandler(this.buttonSendPR_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(150, 126);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message:";
            // 
            // GitPullRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSendPR);
            this.Controls.Add(this.textBoxCommitMessage);
            this.Name = "GitPullRequestForm";
            this.Text = "GitPullRequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCommitMessage;
        private System.Windows.Forms.Button buttonSendPR;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
    }
}