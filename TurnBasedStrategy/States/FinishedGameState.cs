using System;
using System.Collections.Generic;
using System.Text;
using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy.States
{
	public class FinishedGameState : IGameState
	{
		public void Handle(ITurnBasedGame game, IRequest request)
		{
			throw new NotImplementedException();
		}
	}
}
