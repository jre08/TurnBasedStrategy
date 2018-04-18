using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy
{
	public interface IGame
	{
		void Request(Request request);
	}
}
