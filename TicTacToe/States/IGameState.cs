using TicTacToe.Requests;

namespace TicTacToe.States
{
	public interface IGameState
	{
		void Handle(IGame game, IRequest request);
	}
}
