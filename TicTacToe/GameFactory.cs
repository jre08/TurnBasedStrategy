﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
	public class GameFactory
	{
		public Game CreateGame()
		{
			return new Game();
		}
	}
}
