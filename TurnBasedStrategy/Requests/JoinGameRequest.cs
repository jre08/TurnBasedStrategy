using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedStrategy.Requests
{
	public class JoinGameRequest : IRequest
	{
		Client _client;

		public JoinGameRequest(Client client)
		{
			_client = client;
		}

		public void Exec(ITurnBasedGameEngine engine)
		{
			//engine.WaitingQueue.Enqueue(_client);
			//if()
		}
	}
}
