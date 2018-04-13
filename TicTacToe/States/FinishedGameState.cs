using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Requests;

namespace TicTacToe.States
{
	public class FinishedGameState : GameState
	{
		public override void Handle(Game game, Request request)
		{
			throw new NotImplementedException();
		}
	}
}
