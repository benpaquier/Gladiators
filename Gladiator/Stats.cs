using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Stats
	{
		public Stats ()
		{
		}

		public double calculPrctVictoire(int nbVictoires, int nbDefaites) {
			int totalMatchJoues = nbVictoires + nbDefaites;
			double result = (System.Convert.ToDouble(nbVictoires) / System.Convert.ToDouble(totalMatchJoues) * 100);
			return Math.Truncate(result);
		}
	}
}
