using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    internal class Wordes
    {
        string[] _SecretWords = { "lion","car","hat","pen","box", "lemonade", "airplane", "champions", "playstaion","strawbery"};
        public string[] SecretWords { get { return _SecretWords; } }
    }
}
