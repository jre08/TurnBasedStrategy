using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy.States
{
	public interface IGameState
	{
		//void Handle(ITurnBasedGame game, IRequest request);

		void Join(Client client);
		void MakeMove(Client client);
	}
}
