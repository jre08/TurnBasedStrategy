using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedStrategy.Requests
{
	public interface IRequest
	{
		void Exec(ITurnBasedGameEngine engine);
	}
}
