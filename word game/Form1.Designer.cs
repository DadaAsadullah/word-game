namespace word_game
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
            this.Userguess = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.answer1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.PictureBox();
            this.hint = new System.Windows.Forms.TextBox();
            this.points = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // Userguess
            // 
            this.Userguess.Location = new System.Drawing.Point(279, 256);
            this.Userguess.Name = "Userguess";
            this.Userguess.Size = new System.Drawing.Size(279, 20);
            this.Userguess.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(279, 282);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(90, 32);
            this.submit.TabIndex = 1;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(467, 282);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(91, 32);
            this.clear.TabIndex = 2;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(344, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 30);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "GUESS THE WORD";
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(279, 88);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(279, 20);
            this.answer1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(737, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // background
            // 
            this.background.Location = new System.Drawing.Point(78, 12);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(743, 458);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.background.TabIndex = 6;
            this.background.TabStop = false;
            // 
            // hint
            // 
            this.hint.BackColor = System.Drawing.Color.DimGray;
            this.hint.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint.Location = new System.Drawing.Point(78, 421);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(147, 23);
            this.hint.TabIndex = 7;
            this.hint.Text = "hint?";
            this.hint.Click += new System.EventHandler(this.hint_Click);
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.Location = new System.Drawing.Point(98, 52);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(54, 16);
            this.points.TabIndex = 8;
            this.points.Text = "points: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "hints: 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.points);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Userguess);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Userguess;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox answer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.TextBox hint;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label label1;
    }
}

