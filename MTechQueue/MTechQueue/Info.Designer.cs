
namespace MTechQueue
{
    partial class infoForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
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
            this.lastBox.Size = new System.Drawing.Size(298, 23);
            this.lastBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(244, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(51, 15);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "EMPLID:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(244, 27);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(217, 23);
            this.idBox.TabIndex = 3;
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Location = new System.Drawing.Point(316, 53);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(180, 15);
            this.ticketLabel.TabIndex = 5;
            this.ticketLabel.Text = "Ticket Number (if you have one):";
            // 
            // ticketBox
            // 
            this.ticketBox.Location = new System.Drawing.Point(316, 71);
            this.ticketBox.Name = "ticketBox";
            this.ticketBox.Size = new System.Drawing.Size(355, 23);
            this.ticketBox.TabIndex = 4;
            // 
            // issueBox
            // 
            this.issueBox.Location = new System.Drawing.Point(12, 115);
            this.issueBox.Name = "issueBox";
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
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(677, 18);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(111, 84);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(467, 9);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(106, 15);
            this.numberLabel.TabIndex = 9;
            this.numberLabel.Text = "Number (optional)";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(467, 27);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(204, 23);
            this.numberBox.TabIndex = 10;
            // 
            // infoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.submitButton);
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
            this.Name = "infoForm";
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numberBox;
    }
}

