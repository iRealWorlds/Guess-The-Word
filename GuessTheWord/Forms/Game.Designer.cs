using System;

namespace GuessTheWord.Forms
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.LabelCurrent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelErrors = new System.Windows.Forms.Label();
            this.LabelTimeSpent = new System.Windows.Forms.Label();
            this.LabelTried = new System.Windows.Forms.Label();
            this.TimerTimeSpent = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonTry = new System.Windows.Forms.Button();
            this.InputTry = new System.Windows.Forms.TextBox();
            this.LabelWon = new System.Windows.Forms.Label();
            this.LabelInputFeedback = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelCurrent
            // 
            this.LabelCurrent.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelCurrent.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrent.Location = new System.Drawing.Point(0, 25);
            this.LabelCurrent.Name = "LabelCurrent";
            this.LabelCurrent.Size = new System.Drawing.Size(800, 153);
            this.LabelCurrent.TabIndex = 1;
            this.LabelCurrent.Text = "M___U";
            this.LabelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelErrors);
            this.panel1.Controls.Add(this.LabelTimeSpent);
            this.panel1.Controls.Add(this.LabelTried);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 2;
            // 
            // LabelErrors
            // 
            this.LabelErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelErrors.Location = new System.Drawing.Point(135, 0);
            this.LabelErrors.Name = "LabelErrors";
            this.LabelErrors.Size = new System.Drawing.Size(530, 30);
            this.LabelErrors.TabIndex = 4;
            this.LabelErrors.Text = "Errors: 0 / 3";
            this.LabelErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTimeSpent
            // 
            this.LabelTimeSpent.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelTimeSpent.Location = new System.Drawing.Point(665, 0);
            this.LabelTimeSpent.Name = "LabelTimeSpent";
            this.LabelTimeSpent.Size = new System.Drawing.Size(135, 30);
            this.LabelTimeSpent.TabIndex = 3;
            this.LabelTimeSpent.Text = "Time Spent: 00:00";
            this.LabelTimeSpent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTried
            // 
            this.LabelTried.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTried.Location = new System.Drawing.Point(0, 0);
            this.LabelTried.Name = "LabelTried";
            this.LabelTried.Size = new System.Drawing.Size(135, 30);
            this.LabelTried.TabIndex = 0;
            this.LabelTried.Text = "Letters Tried: 15";
            this.LabelTried.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerTimeSpent
            // 
            this.TimerTimeSpent.Enabled = true;
            this.TimerTimeSpent.Interval = 1000;
            this.TimerTimeSpent.Tick += new System.EventHandler(this.TimerTimeSpent_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButtonTry);
            this.panel2.Controls.Add(this.InputTry);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 33);
            this.panel2.TabIndex = 3;
            // 
            // ButtonTry
            // 
            this.ButtonTry.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonTry.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.ButtonTry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTry.ForeColor = System.Drawing.Color.ForestGreen;
            this.ButtonTry.Location = new System.Drawing.Point(689, 0);
            this.ButtonTry.Name = "ButtonTry";
            this.ButtonTry.Size = new System.Drawing.Size(111, 33);
            this.ButtonTry.TabIndex = 1;
            this.ButtonTry.Text = "Try";
            this.ButtonTry.UseVisualStyleBackColor = true;
            this.ButtonTry.Click += new System.EventHandler(this.ButtonTry_Click);
            // 
            // InputTry
            // 
            this.InputTry.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputTry.Location = new System.Drawing.Point(0, 0);
            this.InputTry.MaxLength = 1;
            this.InputTry.Multiline = true;
            this.InputTry.Name = "InputTry";
            this.InputTry.Size = new System.Drawing.Size(683, 33);
            this.InputTry.TabIndex = 0;
            this.InputTry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTry_KeyPress);
            // 
            // LabelWon
            // 
            this.LabelWon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelWon.Font = new System.Drawing.Font("Fira Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWon.ForeColor = System.Drawing.Color.Green;
            this.LabelWon.Location = new System.Drawing.Point(0, 208);
            this.LabelWon.Name = "LabelWon";
            this.LabelWon.Size = new System.Drawing.Size(800, 218);
            this.LabelWon.TabIndex = 4;
            this.LabelWon.Text = "Congratulations, you have won!";
            this.LabelWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInputFeedback
            // 
            this.LabelInputFeedback.AutoSize = true;
            this.LabelInputFeedback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelInputFeedback.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelInputFeedback.Location = new System.Drawing.Point(0, 403);
            this.LabelInputFeedback.Name = "LabelInputFeedback";
            this.LabelInputFeedback.Padding = new System.Windows.Forms.Padding(5);
            this.LabelInputFeedback.Size = new System.Drawing.Size(10, 23);
            this.LabelInputFeedback.TabIndex = 5;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.LabelInputFeedback);
            this.Controls.Add(this.LabelWon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelCurrent);
            this.Name = "Game";
            this.Controls.SetChildIndex(this.LabelCurrent, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.LabelWon, 0);
            this.Controls.SetChildIndex(this.LabelInputFeedback, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCurrent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelErrors;
        private System.Windows.Forms.Label LabelTimeSpent;
        private System.Windows.Forms.Label LabelTried;
        private System.Windows.Forms.Timer TimerTimeSpent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonTry;
        private System.Windows.Forms.TextBox InputTry;
        private System.Windows.Forms.Label LabelWon;
        private System.Windows.Forms.Label LabelInputFeedback;
    }
}
