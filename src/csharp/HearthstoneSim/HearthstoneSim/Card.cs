using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneSim
{
	public enum CardType { Minion, Spell, Secret }
	public enum HeroType { Neutral, Warlock, Priest, Paladin, Mage, Rogue, Shaman, Hunter }
	
	public delegate GameState GameStateFunction(GameState state);
	public delegate bool GameInfoFunction(GameState state);

	public class Card
	{
		public Card(String name, CardType type, HeroType hero, CardFunctions behavior)
		{

		}
	}

	public class CardFunctions
	{
		public readonly GameStateFunction Attack, Defend, Play, Death, CanPlay;
		public readonly GameInfoFunction CanAttack;

		public GameState WindFury(GameState currentState)
		{

		}
	}
}
