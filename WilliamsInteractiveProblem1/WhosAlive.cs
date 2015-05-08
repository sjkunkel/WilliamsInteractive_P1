using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WilliamsInteractiveProblem1
{
	class WhosAlive
	{
		#region Member Variables
		private List<int> birthYears;
		private List<int> deathYears;
		private int[] histogramOfWhosAlive;
		#endregion

		#region Constructors
		public WhosAlive( string filename )
		{
			birthYears = new List<int>();
			deathYears = new List<int>();
			ConstructLists( filename );
			// All birth and death years are between 1900 and 2000
			// I interpreted this exclusively, so valid years start at 1901 and continue to 1999
			// This means there are 99 possible years that people can be alive in this dataset
			histogramOfWhosAlive = new int[99];
			ComputeHistogram();
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
			try
			{
				using( StreamReader sr = new StreamReader( filename ) )
				{
					string line = sr.ReadLine(); // Formatting line
					while( !sr.EndOfStream )
					{
						// read in each line
						line = sr.ReadLine();
						// split based on whitespace delimiting
						string[] data = line.Split( ' ' );
						//TODO: year validation
						// birthyear should be 3rd entry on the line
						birthYears.Add( Convert.ToInt32( data[2] ) );
						// deathyear should be 4th entry on the line
						deathYears.Add( Convert.ToInt32( data[3] ) );
					}
					sr.Close();
					if( birthYears.Count != deathYears.Count )
					{
						// something went wrong
						//TODO: error handling here
					}
				}
			} catch( Exception e )
			{
				/* this should catch file not found errors as well as problems converting the information
				 * or if there aren't enough entries on a line */
				Console.WriteLine( "The file could not be read" );
				Console.WriteLine( e.Message );
			}
		}

		/// <summary>
		/// Determine the histogram of how many people are alive each year
		/// </summary>
		private void ComputeHistogram()
		{
			/*Since birth and death dates are just specified by year, I'm considering people to be alive
			 * on the year they were born and still alive on the year they died. They will no longer be
			 * considered alive the year after they died. In this way, if someone lived less than one
			 * calendar year, so they were born and died both in, say, 1901, they would be considered
			 * alive during 1901 and only that year. */
			for( int i = 0; i < histogramOfWhosAlive.Length; i++ )
			{
				for( int j = 0; j < birthYears.Count; j++ )
				{
					if( i + 1901 >= birthYears[j] && i + 1901 <= deathYears[j] )
					{
						histogramOfWhosAlive[i]++;
					}
				}
			}
		}
		#endregion
	}
}
