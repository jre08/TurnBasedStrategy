using TurnBasedStrategy.Requests;
using TurnBasedStrategy.States;

namespace TurnBasedStrategy
{
	public class Game : IGame
	{
		public IGameState GameState { get; set; }
		
		public Game()
		{
			this.GameState = new WaitForConnectionsGameState();
		}

		public void Request(Request request)
		{
			this.GameState.Handle(this, request);
		}
	}
}
