using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace HearthstoneSim
{
	public class GameState
	{
		public readonly ImmutableDictionary<string, int> Graveyard;
		public GameState()
		{
		}

	}
}
