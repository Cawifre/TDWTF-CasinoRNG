﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infragistics.Win;

namespace App
{
	internal class RandomishNumberGenerator
	{
		private RandomRouletteRing _ring1 = new RandomRouletteRing();
		private RandomRouletteRing _ring2 = new RandomRouletteRing();

		private readonly Action _cheat;

		public RandomishNumberGenerator()
		{
			_cheat = () => _ring1.IsRandom = false;
		}

		public int Next ()
		{
			var next = _ring1.Next();
			Swap();
			return next;
		}

		private void Swap()
		{
			var temp = _ring1;
			_ring1 = _ring2;
			_ring2 = temp;
		}

		public void Cheat()
		{
			_cheat();
		}
	}
}
