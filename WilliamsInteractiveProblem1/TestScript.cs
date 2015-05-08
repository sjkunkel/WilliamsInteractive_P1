using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilliamsInteractiveProblem1
{
	class TestScript
	{
		static void Main( string[] args )
		{
			WhosAlive hist = new WhosAlive( "../../DataSet.txt" );

			Console.ReadKey();
		}
	}
}
