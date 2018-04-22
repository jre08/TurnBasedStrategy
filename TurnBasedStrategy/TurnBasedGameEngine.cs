using System;
using System.Collections.Generic;
using System.Text;
using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy
{
	public class TurnBasedGameEngine : ITurnBasedGameEngine
	{
		public Queue<Client> WaitingQueue { get; set; }
		public List<ITurnBasedGame> ActiveGames { get; set; }

		public ITurnBasedGame Handle(IRequest request)
		{
			request.Exec(this);
			/*
			 * get game from request
			 * request.exec()
			 * 
			 * 
			 * 
			 * return game
			 */



			throw new NotImplementedException();
		}
	}
}
