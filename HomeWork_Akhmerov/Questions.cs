using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Akhmerov
{
    [Serializable]
    class Questions
    {
        private string text;
        private bool isTrue;

        private Questions()
        {

        }

        public Questions(string text,bool isTrue)
        {
            this.text = text;
            this.isTrue = isTrue;
        }
    }
}
