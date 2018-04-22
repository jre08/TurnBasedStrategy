using System;
using System.Collections.Generic;
using System.Text;
using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy
{
	public interface ITurnBasedGameEngine
	{
		ITurnBasedGame Handle(IRequest request);
	}
}
