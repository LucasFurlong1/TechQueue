
namespace MTechQueue
{
    partial class numberForm
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
            this.queueLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // queueLabel
            // 
            this.queueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.queueLabel.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.queueLabel.Location = new System.Drawing.Point(0, 0);
            this.queueLabel.Name = "queueLabel";
            this.queueLabel.Size = new System.Drawing.Size(1264, 109);
            this.queueLabel.TabIndex = 0;
            this.queueLabel.Text = "Next in Queue:";
            this.queueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberLabel
            // 
            this.numberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberLabel.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numberLabel.Location = new System.Drawing.Point(0, 109);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(1264, 619);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Hello, Welcome to the MTech Desk!";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 728);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.queueLabel);
            this.Name = "numberForm";
            this.Text = "Queue Number";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label queueLabel;
        private System.Windows.Forms.Label numberLabel;

        public string numlabText { get { return numberLabel.Text; } set { numberLabel.Text = value; } }
    }
}