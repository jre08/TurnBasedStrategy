using System;
using System.Collections.Generic;
using System.Text;
using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy
{
	public class TicTacToe : IGameEngine
	{
		public GameFactory GameFactory { get; set; }
		public List<Game> WaitForConnetctionGames { get; set; }
		public List<Game> InProgressGames { get; set; }

		public TicTacToe()
		{
			this.InProgressGames = new List<Game>();
			this.WaitForConnetctionGames = new List<Game>();
			this.GameFactory = new GameFactory();
		}
		
		public IGame StartGame()
		{
			if(WaitForConnetctionGames.Count != 0)
			{
				// todo: take game from queue
				return new Game();
			}

			Game game = GameFactory.CreateGame();
			WaitForConnetctionGames.Add(game);

			return game;
		}
		
		public void MakeMove(IGame game, Player player, Move move)
		{
			game.Request(new MakeMoveRequest());
		}
	}
}
