using Application;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Domain
{
    public class Matrix
    {
        private readonly Validations _validations = new Validations();
        public List<string> Source { get; private set; }

        public Matrix(List<string> source)
        {
            this.ValidatedSource(source);
        }

        public void ValidatedSource(List<string> source)
        {
            var stringSource = string.Join(string.Empty, source);

            if (_validations.OnlyLettersOnString(stringSource))
            {
                if (_validations.MaxSize(source))
                {
                    Source = source;
                }
                else
                {
                    throw new Exception("The size of the matrix should be only 64 x 64");
                }
            }
            else
            {
                throw new Exception("The matrix should have only letters");
            }
        }
    }
}
