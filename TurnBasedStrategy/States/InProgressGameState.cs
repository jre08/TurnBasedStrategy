using System;
using System.Collections.Generic;
using System.Text;
using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy.States
{
	public class InProgressGameState : IGameState
	{
		public void Handle(IGame game, IRequest request)
		{
			throw new NotImplementedException();
		}
	}
}
