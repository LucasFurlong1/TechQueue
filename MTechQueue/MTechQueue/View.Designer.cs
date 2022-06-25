
namespace MTechQueue
{
    partial class viewForm
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
            this.firstLabel = new System.Windows.Forms.Label();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.lastLabel = new System.Windows.Forms.Label();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.ticketBox = new System.Windows.Forms.TextBox();
            this.issueBox = new System.Windows.Forms.RichTextBox();
            this.issueLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(12, 9);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(70, 15);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.Text = "First Name: ";
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(12, 27);
            this.firstBox.Name = "firstBox";
            this.firstBox.ReadOnly = true;
            this.firstBox.Size = new System.Drawing.Size(226, 23);
            this.firstBox.TabIndex = 1;
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(12, 53);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(66, 15);
            this.lastLabel.TabIndex = 2;
            this.lastLabel.Text = "Last Name:";
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(12, 71);
            this.lastBox.Name = "lastBox";
            this.lastBox.ReadOnly = true;
            this.lastBox.Size = new System.Drawing.Size(298, 23);
            this.lastBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(391, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(51, 15);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "EMPLID:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(391, 27);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(105, 23);
            this.idBox.TabIndex = 3;
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Location = new System.Drawing.Point(391, 53);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(88, 15);
            this.ticketLabel.TabIndex = 5;
            this.ticketLabel.Text = "Ticket Number:";
            // 
            // ticketBox
            // 
            this.ticketBox.Location = new System.Drawing.Point(391, 71);
            this.ticketBox.Name = "ticketBox";
            this.ticketBox.ReadOnly = true;
            this.ticketBox.Size = new System.Drawing.Size(217, 23);
            this.ticketBox.TabIndex = 4;
            // 
            // issueBox
            // 
            this.issueBox.Location = new System.Drawing.Point(12, 115);
            this.issueBox.Name = "issueBox";
            this.issueBox.ReadOnly = true;
            this.issueBox.Size = new System.Drawing.Size(776, 323);
            this.issueBox.TabIndex = 5;
            this.issueBox.Text = "";
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Location = new System.Drawing.Point(12, 97);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(36, 15);
            this.issueLabel.TabIndex = 8;
            this.issueLabel.Text = "Issue:";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(624, 9);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(164, 85);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // viewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.issueLabel);
            this.Controls.Add(this.issueBox);
            this.Controls.Add(this.ticketBox);
            this.Controls.Add(this.ticketLabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.lastLabel);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.firstLabel);
            this.Name = "viewForm";
            this.Text = "View Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.TextBox ticketBox;
        private System.Windows.Forms.RichTextBox issueBox;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.Button nextButton;
    }
}