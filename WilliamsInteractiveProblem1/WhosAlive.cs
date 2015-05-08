using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilliamsInteractiveProblem1
{
	class WhosAlive
	{
		#region Member Variables
		private List<int> birthYears;
		private List<int> deathYears;
		private List<int> histogramOfWhosAlive;
		#endregion

		#region Constructors
		WhosAlive( string filename )
		{
			birthYears = new List<int>();
			deathYears = new List<int>();
			ConstructLists( filename );
		}
		#endregion

		#region Public Methods
		#endregion

		#region Private Methods
		/// <summary>
		/// Add to the existing birth and death year lists.
		/// </summary>
		/// <param name="filename">Formatted Data File containing birth and death years. 
		/// The file format should have one data set per line, formatted as follows:
		/// FirstName LastName BirthYear DeathYear
		/// The first line of the file contains formatting information so it will be ignored</param>
		private void ConstructLists( string filename )
		{

		}

		/// <summary>
		/// Determine the histogram of how many people are alive each year
		/// </summary>
		private void ComputeHistogram()
		{

		}
		#endregion
	}
}
