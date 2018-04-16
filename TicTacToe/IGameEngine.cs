using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
	public interface IGameEngine
	{
		IGame StartGame();
		void MakeMove(IGame game, Player player, Move move);
	}
}
