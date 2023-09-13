using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePlanets.Model;

namespace ThePlanets.Controller
{
	public class PlanetController
	{
		public void Run()
		{
			PlanetGroup planet = new PlanetGroup();
			planet.PlanetMake();
		}
	};
}
