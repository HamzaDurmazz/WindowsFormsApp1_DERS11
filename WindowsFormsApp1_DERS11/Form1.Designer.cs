
namespace WindowsFormsApp1_DERS11
{
    partial class Form1
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
            this.lstConnected = new System.Windows.Forms.ListBox();
            this.btnConnected = new System.Windows.Forms.Button();
            this.btnDisconnected = new System.Windows.Forms.Button();
            this.lstDisconnected = new System.Windows.Forms.ListBox();
            this.btnEf = new System.Windows.Forms.Button();
            this.lstEntityFrameWork = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstConnected
            // 
            this.lstConnected.FormattingEnabled = true;
            this.lstConnected.Location = new System.Drawing.Point(25, 82);
            this.lstConnected.Name = "lstConnected";
            this.lstConnected.Size = new System.Drawing.Size(120, 355);
            this.lstConnected.TabIndex = 0;
            // 
            // btnConnected
            // 
            this.btnConnected.Location = new System.Drawing.Point(25, 31);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(120, 23);
            this.btnConnected.TabIndex = 1;
            this.btnConnected.Text = "Connected";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Location = new System.Drawing.Point(226, 31);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(120, 23);
            this.btnDisconnected.TabIndex = 3;
            this.btnDisconnected.Text = "Disconnected";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            this.btnDisconnected.Click += new System.EventHandler(this.btnDisconnected_Click);
            // 
            // lstDisconnected
            // 
            this.lstDisconnected.FormattingEnabled = true;
            this.lstDisconnected.Location = new System.Drawing.Point(226, 82);
            this.lstDisconnected.Name = "lstDisconnected";
            this.lstDisconnected.Size = new System.Drawing.Size(120, 355);
            this.lstDisconnected.TabIndex = 2;
            // 
            // btnEf
            // 
            this.btnEf.Location = new System.Drawing.Point(447, 31);
            this.btnEf.Name = "btnEf";
            this.btnEf.Size = new System.Drawing.Size(120, 23);
            this.btnEf.TabIndex = 5;
            this.btnEf.Text = "EF";
            this.btnEf.UseVisualStyleBackColor = true;
            this.btnEf.Click += new System.EventHandler(this.btnEf_Click);
            // 
            // lstEntityFrameWork
            // 
            this.lstEntityFrameWork.FormattingEnabled = true;
            this.lstEntityFrameWork.Location = new System.Drawing.Point(447, 82);
            this.lstEntityFrameWork.Name = "lstEntityFrameWork";
            this.lstEntityFrameWork.Size = new System.Drawing.Size(120, 355);
            this.lstEntityFrameWork.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(223, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(444, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEf);
            this.Controls.Add(this.lstEntityFrameWork);
            this.Controls.Add(this.btnDisconnected);
            this.Controls.Add(this.lstDisconnected);
            this.Controls.Add(this.btnConnected);
            this.Controls.Add(this.lstConnected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstConnected;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnDisconnected;
        private System.Windows.Forms.ListBox lstDisconnected;
        private System.Windows.Forms.Button btnEf;
        private System.Windows.Forms.ListBox lstEntityFrameWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

