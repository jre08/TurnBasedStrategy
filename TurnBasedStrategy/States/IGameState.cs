using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy.States
{
	public interface IGameState
	{
		void Handle(ITurnBasedGame game, IRequest request);
	}
}
