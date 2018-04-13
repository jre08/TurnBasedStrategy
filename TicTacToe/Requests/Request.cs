using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Requests
{
	public abstract class Request
	{
		protected Player Player { get; set; }
	}
}
