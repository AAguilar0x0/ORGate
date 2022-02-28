namespace ORGate
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
            this.button1 = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.term1 = new System.Windows.Forms.TextBox();
            this.term2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.iterations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalTraining = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Train";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(197, 46);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 13);
            this.status.TabIndex = 1;
            this.status.Text = "Status";
            // 
            // term1
            // 
            this.term1.Location = new System.Drawing.Point(10, 67);
            this.term1.Name = "term1";
            this.term1.Size = new System.Drawing.Size(100, 20);
            this.term1.TabIndex = 2;
            this.term1.Text = "0";
            // 
            // term2
            // 
            this.term2.Location = new System.Drawing.Point(116, 67);
            this.term2.Name = "term2";
            this.term2.Size = new System.Drawing.Size(100, 20);
            this.term2.TabIndex = 4;
            this.term2.Text = "0";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(56, 112);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(43, 13);
            this.result.TabIndex = 5;
            this.result.Text = "[Result]";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iterations
            // 
            this.iterations.Location = new System.Drawing.Point(10, 41);
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(100, 20);
            this.iterations.TabIndex = 7;
            this.iterations.Text = "400";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Training:";
            // 
            // totalTraining
            // 
            this.totalTraining.AutoSize = true;
            this.totalTraining.Location = new System.Drawing.Point(91, 99);
            this.totalTraining.Name = "totalTraining";
            this.totalTraining.Size = new System.Drawing.Size(43, 13);
            this.totalTraining.TabIndex = 9;
            this.totalTraining.Text = "[Result]";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 186);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalTraining);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iterations);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.term2);
            this.Controls.Add(this.term1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox term1;
        private System.Windows.Forms.TextBox term2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox iterations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalTraining;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

