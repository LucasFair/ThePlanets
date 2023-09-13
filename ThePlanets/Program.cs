using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePlanets.Controller;
using ThePlanets.Model;

namespace ThePlanets
{
	public class Program
	{
		static void Main(string[] args)
		{
			PlanetController planetCtrl = new PlanetController();
			planetCtrl.Run();
;
        }
	}
}
