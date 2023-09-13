using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ThePlanets.Model
{
	public class PlanetGroup
	{
		/*
		Planet Mercury = new Model.Planet("Mercury", 0.330D, 4879, 5427, 3.7F, 1407.6F, 4222.6F, 57.9F, 88.0F, 47.4F, 167, 0, false);
		Planet Venus = new Model.Planet("Venus", 4.87D, 12104, 5243, 8.9F, -5832.5F, 2802.0F, 108.2F, 224.7F, 35.0F, 464, 0, false);
		Planet Earth = new Model.Planet("Earth", 5.97D, 12756, 5514, 9.8F, 23.9F, 24.0F, 149.6F, 365.2F, 29.8F, 15, 1, false);
		Planet Mars = new Model.Planet("Mars", 0.642D, 6792, 3933, 3.7F, 24.6F, 24.7F, 227.9F, 687.0F, 24.1F, -65, 2, false);
		Planet Jupiter = new Model.Planet("Jupiter", 1898D, 142984, 1326, 23.1F, 9.9F, 9.9F, 778.6F, 4331, 13.1F, -110, 67, true);
		Planet Saturn = new Model.Planet("Saturn", 568D, 120536, 687, 9.0F, 10.7F, 10.7F, 1433.5F, 10747F, 9.7F, -140, 62, true);
		Planet Uranus = new Model.Planet("Uranus", 86.8D, 51118, 1271, 8.7F, -17.2F, 17.2F, 2872.5F, 30589F, 6.8F, -195, 27, true);
		Planet Neptune = new Model.Planet("Neptune", 102D, 49528, 1638, 11.0F, 16.1F, 16.1F, 4495.1F, 59.8F, 5.4F, -200, 14, true);
		Planet Pluto = new Model.Planet("Pluto", 0.0146D, 2370, 2095, 0.7F, -153.3F, 153.3F, 5906.4F, 90.56F, 4.7F, -255, 5, false);
		*/
		public void PlanetMake()
		{
			List<Planet> PlanetList = new List<Planet>();
			PlanetList.Add(new Planet("Mercury", 0.330D, 4879, 5427, 3.7F, 1407.6F, 4222.6F, 57.9F, 88.0F, 47.4F, 167, 0, false));
			PlanetList.Add(new Planet("Venus", 4.87D, 12104, 5243, 8.9F, -5832.5F, 2802.0F, 108.2F, 224.7F, 35.0F, 464, 0, false));
			PlanetList.Add(new Planet("Earth", 5.97D, 12756, 5514, 9.8F, 23.9F, 24.0F, 149.6F, 365.2F, 29.8F, 15, 1, false));
			PlanetList.Add(new Planet("Mars", 0.642D, 6792, 3933, 3.7F, 24.6F, 24.7F, 227.9F, 687.0F, 24.1F, -65, 2, false));
			PlanetList.Add(new Planet("Jupiter", 1898D, 142984, 1326, 23.1F, 9.9F, 9.9F, 778.6F, 4331, 13.1F, -110, 67, true));
			PlanetList.Add(new Planet("Saturn", 568D, 120536, 687, 9.0F, 10.7F, 10.7F, 1433.5F, 10747F, 9.7F, -140, 62, true));
			PlanetList.Add(new Planet("Uranus", 86.8D, 51118, 1271, 8.7F, -17.2F, 17.2F, 2872.5F, 30589F, 6.8F, -195, 27, true));
			PlanetList.Add(new Planet("Neptune", 102D, 49528, 1638, 11.0F, 16.1F, 16.1F, 4495.1F, 59.8F, 5.4F, -200, 14, true));
			PlanetList.Add(new Planet("Pluto", 0.0146D, 2370, 2095, 0.7F, -153.3F, 153.3F, 5906.4F, 90.56F, 4.7F, -255, 5, false));

			foreach (Planet planet in PlanetList)
			{
				Console.WriteLine("Planet Name: {0}", planet.PlntName);
				Console.WriteLine("Mass (1024 kg): {0}", planet.PlntMass);
                Console.WriteLine("Diameter (km): {0}", planet.PlntDiamtr);
				Console.WriteLine("Density (kg/m3): {0}", planet.PlntDensity);
                Console.WriteLine("Gravity (m/s2): {0}", planet.PlntGravity);
                Console.WriteLine("Rotation Period (h): {0}", planet.PlntRotPeriod);
				Console.WriteLine("Length of Day (h): {0}", planet.PlntDayLen);
                Console.WriteLine("Distance from Sun (106 km): {0}", planet.PlntSunDist);
                Console.WriteLine("Orbital Period (d): {0}", planet.PlntOrbPeriod);
                Console.WriteLine("Orbital Velocity (km/s): {0}", planet.PlntOrbVelo);
                Console.WriteLine("Mean Temperature (C): {0}", planet.PlntMeanTemp);
                Console.WriteLine("Number of Moons: {0}", planet.PlntMoonNum);
                Console.WriteLine("Has a Ring System: {0}", planet.PlntHasRing.ToString().ToUpper());
                Console.WriteLine(string.Empty);


            }
		}
	}
}
