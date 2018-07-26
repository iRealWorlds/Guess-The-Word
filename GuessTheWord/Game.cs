using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord
{
    public class Game
    {
        private static readonly string[] Words = new string[]
        {
            "praf", "cuvant", "lanterna",
            "mancare", "prajitura", "carne",
            "masina", "trabant", "avion",
            "ceva", "altceva", "carte"
        };
        public char[] Word { get; private set; } = GenerateWord().ToUpper().ToCharArray();
        public readonly int MaxErrors = 3;
        public int Errors { get; set; } = 0;
        public List<char> Tried { get; set; } = new List<char>();
        public string CurrentState { get; set; }

        public Game()
        {
            Tried.Add(Word[0]);
            if(Word[0] != Word[Word.Length - 1])
                Tried.Add(Word[Word.Length - 1]);
            UpdateCurrentState();
        }

        public void UpdateCurrentState()
        {
            var currentState = new StringBuilder();
            currentState.Append($"{Word[0]} ");
            for (var i = 1; i < Word.Length - 1; ++i)
            {
                if (Tried.Contains(Word[i]))
                    currentState.Append($"{Word[i]} ");
                else
                    currentState.Append("_ ");
            }
            currentState.Append(Word[Word.Length - 1]);
            this.CurrentState = currentState.ToString();
        }

        public bool Try(char letter)
        {
            letter = Char.ToUpper(letter);
            if (this.Tried.Contains(letter))
                throw new Exception();
            Tried.Add(letter);
            if (this.Word.Contains(letter))
            {
                UpdateCurrentState();
                return true;
            }
            else
            {
                ++Errors;
                return false;
            }
        }
        
        public int LettersLeft()
        {
            var left = 0;
            for (var i = 1; i < Word.Length - 1; ++i)
            {
                if (!Tried.Contains(Word[i]))
                    ++left;
            }
            return left;
        }

        public static string GenerateWord()
        {
            var random = new Random().Next(0, Words.Length);
            return Words[random];
        }

    }
}
