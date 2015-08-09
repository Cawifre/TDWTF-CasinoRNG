using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
	internal class RandomRoulleteRing
	{
		private static readonly IReadOnlyList<int> RoulleteOrder = new[] { 0, 28, 9, 26, 30, 11, 7, 20, 32, 17, 5, 22, 34, 15, 3, 24, 36, 13, 1, -1, 27, 10, 25, 29, 12, 8, 19, 31, 18, 6, 21, 33, 16, 4, 23, 35, 14, 2 };
		private static readonly Random Random = new Random();

		private IList<int> _pool = new List<int>( RoulleteOrder );
		private IList<int> _used = new List<int>();

		public bool IsRandom { get; set; } = true;

		public int Next ()
		{
			var index = IsRandom ? Random.Next( _pool.Count ) : 0;
			var next = _pool[index];

			_pool.RemoveAt( index );
			_used.Add( next );

			if ( _pool.Count == 0 )
			{
				Swap();
			}

			return next;
		}

		private void Swap ()
		{
			var temp = _pool;
			_pool = _used;
			_used = temp;
		}
	}
}
