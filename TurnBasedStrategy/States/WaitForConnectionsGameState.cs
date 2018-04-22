using System;
using System.Collections.Generic;
using System.Text;
using TurnBasedStrategy.Exceptions;
using TurnBasedStrategy.Requests;

namespace TurnBasedStrategy.States
{
	public class WaitForConnectionsGameState : IGameState
	{
		public void Handle(IGame game, IRequest request)
		{
			if (request is JoinGameRequest)
			{
				//todo: add player to game

				// change state
				//game.GameState = new InProgressGameState();
			}
			else if (request is MakeMoveRequest)
			{
				throw new GameNotReadyException();
			}
		}
	}
}
