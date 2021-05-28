
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
            this.button11 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel2.Size = new System.Drawing.Size(784, 406);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Location = new System.Drawing.Point(498, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 384);
            this.panel4.TabIndex = 2;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(13, 238);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(250, 92);
            this.button11.TabIndex = 10;
            this.button11.Text = "Exit";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.click_exit);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.C3);
            this.panel3.Controls.Add(this.C2);
            this.panel3.Controls.Add(this.C1);
            this.panel3.Controls.Add(this.B3);
            this.panel3.Controls.Add(this.B2);
            this.panel3.Controls.Add(this.B1);
            this.panel3.Controls.Add(this.A3);
            this.panel3.Controls.Add(this.A2);
            this.panel3.Controls.Add(this.A1);
            this.panel3.Location = new System.Drawing.Point(12, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 384);
            this.panel3.TabIndex = 1;
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(309, 254);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(136, 112);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.click_box);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(167, 254);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(136, 112);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.click_box);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(25, 254);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(136, 112);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.click_box);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(309, 136);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(136, 112);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.click_box);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(167, 136);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(136, 112);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.click_box);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(25, 136);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(136, 112);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.click_box);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(309, 18);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(136, 112);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.click_box);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(167, 18);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(136, 112);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.click_box);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(25, 18);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(136, 112);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.click_box);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 179);
            this.button1.TabIndex = 11;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.click_new);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(809, 431);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button1;
    }
}

