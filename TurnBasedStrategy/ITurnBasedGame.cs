using System;
using System.Collections.Generic;
using System.Text;
using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy
{
	public interface ITurnBasedGame
	{
		void Handle(IRequest request);
	}
}
