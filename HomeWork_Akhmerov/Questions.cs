using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Akhmerov
{
    [Serializable]
    public class Questions
    {
        private string text;
        private bool isTrue;

        public string Text
        {
            set => text = value;
            get => text;
        }

        public bool IsTrue
        {
            set => isTrue = value;
            get => isTrue;
        }

        public Questions()
        {

        }

        public Questions(string text,bool isTrue)
        {
            this.text = text;
            this.isTrue = isTrue;
        }
    }
}
