using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application
{
	public class WordFinder
	{
		private readonly HashSet<string> _matrix;
		private readonly StringBuilder _topDownSearchStringBuilder;
		private readonly HashSet<string> _resultSet = new HashSet<string>();

		private string _leftRightSearchString;
		private string _topDownSearchString;

		public WordFinder(IEnumerable<string> matrix)
		{
			_matrix = new HashSet<string>(matrix);

			_topDownSearchStringBuilder = new StringBuilder();
		}
		public IEnumerable<string> Find(IEnumerable<string> wordstream)
		{
			_leftRightSearchString = string.Join(string.Empty, wordstream);

			var characterMatrix = wordstream.Select(row => row.ToCharArray()).ToArray();

			for (var i = 0; i < characterMatrix.Length; i++)
			{
				for (var j = 0; j < characterMatrix[i].Length; j++)
				{
					_topDownSearchStringBuilder.Append(characterMatrix[j][i]);
				}
			}
			_topDownSearchString = _topDownSearchStringBuilder.ToString();

			_resultSet.UnionWith(_matrix.Where(x => _leftRightSearchString.Contains(x)));
			_resultSet.UnionWith(_matrix.Where(x => _topDownSearchString.Contains(x)));

			return OnlyTop10RepeatedWords(_resultSet.ToList());
		}

		public List<string> OnlyTop10RepeatedWords(List<string> value)
		{			
			value.Sort();
			return value.Take(10).ToList();
		}
    }
}
