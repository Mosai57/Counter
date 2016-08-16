namespace WindowsFormsApplication2
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
            this.counterBox = new System.Windows.Forms.TextBox();
            this.incTenButton = new System.Windows.Forms.Button();
            this.incOneButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.decOneButton = new System.Windows.Forms.Button();
            this.decTenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // counterBox
            // 
            this.counterBox.Enabled = false;
            this.counterBox.Location = new System.Drawing.Point(12, 12);
            this.counterBox.Name = "counterBox";
            this.counterBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.counterBox.Size = new System.Drawing.Size(189, 20);
            this.counterBox.TabIndex = 0;
            this.counterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // incTenButton
            // 
            this.incTenButton.Location = new System.Drawing.Point(12, 40);
            this.incTenButton.Name = "incTenButton";
            this.incTenButton.Size = new System.Drawing.Size(33, 23);
            this.incTenButton.TabIndex = 2;
            this.incTenButton.Text = "+10";
            this.incTenButton.UseVisualStyleBackColor = true;
            this.incTenButton.Click += new System.EventHandler(this.incTenButton_Click);
            // 
            // incOneButton
            // 
            this.incOneButton.Location = new System.Drawing.Point(51, 40);
            this.incOneButton.Name = "incOneButton";
            this.incOneButton.Size = new System.Drawing.Size(33, 23);
            this.incOneButton.TabIndex = 3;
            this.incOneButton.Text = "+1";
            this.incOneButton.UseVisualStyleBackColor = true;
            this.incOneButton.Click += new System.EventHandler(this.incOneButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(90, 40);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(33, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "C";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // decOneButton
            // 
            this.decOneButton.Location = new System.Drawing.Point(129, 40);
            this.decOneButton.Name = "decOneButton";
            this.decOneButton.Size = new System.Drawing.Size(33, 23);
            this.decOneButton.TabIndex = 5;
            this.decOneButton.Text = "-1";
            this.decOneButton.UseVisualStyleBackColor = true;
            this.decOneButton.Click += new System.EventHandler(this.decOneButton_Click);
            // 
            // decTenButton
            // 
            this.decTenButton.Location = new System.Drawing.Point(168, 40);
            this.decTenButton.Name = "decTenButton";
            this.decTenButton.Size = new System.Drawing.Size(33, 23);
            this.decTenButton.TabIndex = 6;
            this.decTenButton.Text = "-10";
            this.decTenButton.UseVisualStyleBackColor = true;
            this.decTenButton.Click += new System.EventHandler(this.decTenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 75);
            this.Controls.Add(this.decTenButton);
            this.Controls.Add(this.decOneButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.incOneButton);
            this.Controls.Add(this.incTenButton);
            this.Controls.Add(this.counterBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox counterBox;
        private System.Windows.Forms.Button incTenButton;
        private System.Windows.Forms.Button incOneButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button decOneButton;
        private System.Windows.Forms.Button decTenButton;
    }
}

