
namespace Ricot_Tic_Tac_Toe
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 406);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.button14);
            this.panel4.Controls.Add(this.button13);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button12);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Location = new System.Drawing.Point(498, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 384);
            this.panel4.TabIndex = 2;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(297, 99);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(208, 78);
            this.button14.TabIndex = 15;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(297, 9);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(208, 78);
            this.button13.TabIndex = 14;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 69);
            this.label2.TabIndex = 13;
            this.label2.Text = "Player O:";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(13, 192);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(501, 89);
            this.button12.TabIndex = 12;
            this.button12.Text = "New Game";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 69);
            this.label1.TabIndex = 11;
            this.label1.Text = "Player X:";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(264, 283);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(250, 92);
            this.button11.TabIndex = 10;
            this.button11.Text = "Exit";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.click_exit);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(13, 283);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(250, 92);
            this.button10.TabIndex = 9;
            this.button10.Text = "Reset";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.click_res);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(12, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 384);
            this.panel3.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(309, 254);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 112);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.click_box);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(167, 254);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 112);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.click_box);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(25, 254);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 112);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.click_box);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(309, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 112);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.click_box);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(167, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 112);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.click_box);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(25, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 112);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.click_box);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(309, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 112);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.click_box);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(167, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 112);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.click_box);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 112);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.click_box);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1058, 431);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button11;
    }
}

