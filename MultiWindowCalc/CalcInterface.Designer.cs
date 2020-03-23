namespace MultiWindowCalc
{
    partial class CalcInterface
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
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.Mark = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirstNumber.Location = new System.Drawing.Point(12, 12);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(100, 38);
            this.FirstNumber.TabIndex = 0;
            // 
            // SecondNumber
            // 
            this.SecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SecondNumber.Location = new System.Drawing.Point(152, 12);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(100, 38);
            this.SecondNumber.TabIndex = 1;
            // 
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mark.Location = new System.Drawing.Point(118, 15);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(30, 31);
            this.Mark.TabIndex = 2;
            this.Mark.Text = "+";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(84, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalcInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 111);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 150);
            this.Name = "CalcInterface";
            this.Text = "CalcInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Button button1;
    }
}