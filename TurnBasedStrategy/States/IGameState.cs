using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy.States
{
	public interface IGameState
	{
		void Handle(IGame game, IRequest request);
	}
}
