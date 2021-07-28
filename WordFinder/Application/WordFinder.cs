using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public class WordFinder
    {
        private readonly HashSet<string> _matrix;
        public WordFinder(IEnumerable<string> matrix)
        {
            _matrix = new HashSet<string>(matrix);
        }
        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            var result = new HashSet<string>();

            return result.ToList();
        }
    }
}
