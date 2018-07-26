using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuessTheWord.Forms
{
    public partial class Game : GuessTheWord.Forms.Template
    {
        public DateTime StartedAt { get; set; }
        public GuessTheWord.Game CurrentGame { get; set; }

        public Game()
        {
            InitializeComponent();
            StartedAt = DateTime.Now;
            CurrentGame = new GuessTheWord.Game();
            LabelCurrent.Text = CurrentGame.CurrentState;
            UpdateCurrentErrors();
            UpdateTried();

            LabelWon.Hide();
        }

        public void UpdateCurrentErrors()
        {
            this.LabelErrors.Text = $"Errors: {CurrentGame.Errors} / {CurrentGame.MaxErrors}";
        }

        public void UpdateTried()
        {
            this.LabelTried.Text = $"Letters Tried: {CurrentGame.Tried.Count}";
        }

        public void TimerTimeSpent_Tick(object sender, EventArgs e)
        {
            var timeSpent = DateTime.Now - StartedAt;
            LabelTimeSpent.Text = "Time spent: " + (timeSpent.Minutes < 10 ? ("0" + timeSpent.Minutes.ToString()) : timeSpent.Minutes.ToString()) + ":" + (timeSpent.Seconds < 10 ? ("0" + timeSpent.Seconds.ToString()) : timeSpent.Seconds.ToString());
        }
        public void ButtonTry_Click(object sender, EventArgs e)
        {
            char text;
            try
            {
                text = Char.Parse(this.InputTry.Text);
            }
            catch (Exception)
            {
                LabelInputFeedback.Text = "You have to insert a letter!";
                return;
            }
            this.InputTry.Text = String.Empty;

            bool result = false;
            try
            {
                result = CurrentGame.Try(text);
            }
            catch
            {
                LabelInputFeedback.Text = "You have already tried that letter!";
                return;//TODO A status message with already tried?
            }

            LabelInputFeedback.Text = String.Empty;
            if (result)
            {
                LabelCurrent.Text = CurrentGame.CurrentState;
                if(CurrentGame.LettersLeft() <= 0)
                {
                    LabelWon.Show();
                    InputTry.Hide();
                    ButtonTry.Hide();
                    TimerTimeSpent.Stop();
                }
            }
            else
            {
                UpdateCurrentErrors();
                if(CurrentGame.Errors >= CurrentGame.MaxErrors)
                {
                    LabelWon.Text = "Oh no! You have lost.";
                    LabelWon.ForeColor = Color.Red;
                    LabelWon.Show();
                    InputTry.Hide();
                    ButtonTry.Hide();
                    TimerTimeSpent.Stop();
                }
            }
        }
    }
}
