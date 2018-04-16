using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Requests;

namespace TicTacToe.States
{
	public class FinishedGameState : IGameState
	{
		public void Handle(IGame game, IRequest request)
		{
			throw new NotImplementedException();
		}
	}
}
