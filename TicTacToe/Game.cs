using TicTacToe.Requests;
using TicTacToe.States;

namespace TicTacToe
{
	public class Game
	{
		public GameState GameState { get; set; }
		
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
