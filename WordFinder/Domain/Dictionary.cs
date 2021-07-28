using Application;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Domain
{
    public class Dictionary
    {
        private readonly Validations _validations = new Validations();
        public List<string> Source { get; private set; }

        public Dictionary(List<string> source)
        {
            this.ValidatedSource(source);
        }

        public void ValidatedSource(List<string> source)
        {
            var stringSource =  string.Join(string.Empty, source);

            if (_validations.OnlyLettersOnString(stringSource))
            {
                Source = source;
            }
            else
            {
                throw new Exception("The dictionary should have only letters");
            }
        }        
    }
}
