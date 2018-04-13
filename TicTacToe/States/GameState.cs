using TicTacToe.Requests;

namespace TicTacToe.States
{
	public abstract class GameState
	{
		public abstract void Handle(Game game, Request request);
	}
}
