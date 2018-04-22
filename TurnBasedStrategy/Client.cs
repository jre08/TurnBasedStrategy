using System;
using System.Collections.Generic;
using System.Text;
using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy
{
	public class Client
	{
		public int Id { get; set; }
		public string Name { get; set; }

		//private ITurnBasedGameEngine _engine;
		//private ITurnBasedGame _game;

		/*public Client(ITurnBasedGameEngine engine)
		{
			_engine = engine;
		}*/

		public IRequest StartGame()
		{
			return new JoinGameRequest(); //todo: factory
			//_game = _engine.Handle(request);
		}

		public IRequest MakeMove(/*IMove move*/)
		{
			return new MakeMoveRequest(/*this, _game, move*/); //todo: factory
			//_game = _engine.Handle(request);
		}
	}
}
