namespace MultiWindowCalc
{
    partial class ShowResultCalc
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
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Multiple = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add.Location = new System.Drawing.Point(37, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(50, 50);
            this.Add.TabIndex = 0;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Subtract.Location = new System.Drawing.Point(93, 12);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(50, 50);
            this.Subtract.TabIndex = 1;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Multiple
            // 
            this.Multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Multiple.Location = new System.Drawing.Point(149, 12);
            this.Multiple.Name = "Multiple";
            this.Multiple.Size = new System.Drawing.Size(50, 50);
            this.Multiple.TabIndex = 2;
            this.Multiple.Text = "*";
            this.Multiple.UseVisualStyleBackColor = true;
            this.Multiple.Click += new System.EventHandler(this.Multiple_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Divide.Location = new System.Drawing.Point(205, 12);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 50);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(85, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "2+2=4";
            // 
            // ShowResultCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiple);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Name = "ShowResultCalc";
            this.Text = "Multi window calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Multiple;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Label label1;
    }
}

