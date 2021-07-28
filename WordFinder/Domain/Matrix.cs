using Application;
using System;
using System.Text.RegularExpressions;

namespace Domain
{
    public class Matrix
    {
        private readonly Validations _validations = new Validations();
        public string[] Source { get; private set; }

        public Matrix(string[] source)
        {
            this.ValidatedSource(source);
        }

        public void ValidatedSource(string[] source)
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
