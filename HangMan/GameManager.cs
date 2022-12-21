using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Popups;

namespace HangMan
{
    public class GameManager
    {
        Random r = new Random();
       
        static int _countTrue = 0;
        static int _countFalse = 0;
        char[] _pickedWord;
        TextBlock _letterBox; 
        Wordes _wordes;
        public int _CountFalse { get { return _countFalse; }set { _countFalse = value; } }
        public int _CountTrue { get { return _countTrue; }set { _countTrue = value; } }
        public TextBlock LetterBox { get { return _letterBox; } }
        public char[] PickedWord { get { return _pickedWord; } }

        public GameManager()
        {
           _wordes = new Wordes();
        }
        public void RandomWord(int a, int b)
        {
            int word = r.Next(a,b);
            _pickedWord = _wordes.SecretWords[word].ToCharArray();
        }

        public  void checkLetterExist(char x)
        {

            int countin = 0;
           
            for (int i = 0; i < _pickedWord.Length; i++)
            {
                StringBuilder sb = new StringBuilder(_letterBox.Text);

                if (_pickedWord[i] == x)
                {
                    _countTrue++;
                    sb[i * 2] = x;
                    _letterBox.Text = sb.ToString();
                }
                else
                {
                    countin++;
                }
            }
            if (countin == _pickedWord.Length)
            {
                _countFalse++;
            }
            
          
        }
        public string CreateUnderline()
        {
            _letterBox = new TextBlock();
            for (int i = 0; i < _pickedWord.Length; i++)
            {
                _letterBox.Text += "_ ";
            }
            return _letterBox.Text;
          
        }
       
       

        


    }
}
