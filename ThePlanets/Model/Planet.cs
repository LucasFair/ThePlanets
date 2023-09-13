using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThePlanets.Model
{
	public class Planet
	{
		// Decimal is more expensive, double is cheaper.
		private string _plntName;
		private double _plntMass;  // 1024 kg
		private int _plntDiamtr;  // Kilometers
		private ushort _plntDensity;  // kg/m^3
		private float _plntGravity;  // m/s^2
		private float _plntRotPeriod;  // Rotation Period per hour
		private float _plntDayLen;  // Length of Day per hour
		private float _plntSunDist;  // Distance from the Sun (106 km)
		private float _plntOrbPeriod;  // Orbit Period in days
		private float _plntOrbVelo;  // Orbit Velocity (km/s)
		private short _plntMeanTemp;  // Temperature in Celcius
		private byte _plntMoonNum;  // Numbers of moons
		private bool _plntHasRing;  // Does the planet have a ring system?

		public string PlntName
		{
			get { return _plntName; }
			set { _plntName = value; }
		}
		public double PlntMass
		{
			get { return _plntMass; }
			set { _plntMass = value; }
		}
		public int PlntDiamtr
		{
			get { return _plntDiamtr; }
			set { _plntDiamtr = value; }

		}
		public ushort PlntDensity
		{
			get { return _plntDensity; }
			set { _plntDensity = value; }
		}
		public float PlntGravity
		{
			get { return _plntGravity; }
			set { _plntGravity = value; }
		}
		public float PlntRotPeriod
		{
			get { return _plntRotPeriod; }
			set { _plntRotPeriod = value; }
		}
		public float PlntDayLen
		{
			get { return _plntDayLen; }
			set { _plntDayLen = value; }
		}
		public float PlntSunDist
		{
			get { return _plntSunDist; }
			set { _plntSunDist = value; }
		}
		public float PlntOrbPeriod
		{
			get { return _plntOrbPeriod; }
			set { _plntOrbPeriod = value; }
		}
		public float PlntOrbVelo
		{
			get { return _plntOrbVelo; }
			set { _plntOrbVelo = value; }
		}
		public short PlntMeanTemp
		{
			get { return _plntMeanTemp; }
			set { _plntMeanTemp = value; }
		}
		public byte PlntMoonNum
		{
			get { return _plntMoonNum; }
			set { _plntMoonNum = value; }
		}
		public bool PlntHasRing
		{
			get { return _plntHasRing; }
			set { _plntHasRing = value; }
		}

		public Planet()
		{
			_plntName = null;
			_plntMass = 0D;
			_plntDiamtr = 0;
			_plntDensity = 0;
			_plntGravity = 0F;
			_plntRotPeriod = 0;
			_plntDayLen = 0;
			_plntSunDist = 0F;
			_plntOrbPeriod = 0F;
			_plntOrbVelo = 0F;
			_plntMeanTemp = 0;
			_plntMoonNum = 0;
			_plntHasRing = false;
		}


		public Planet(string plntName) : this()
		{
			_plntName = plntName;
		}

		public Planet(string plntName, double plntMass) : this(plntName)
		{
			_plntMass = plntMass;
		}

		public Planet(string plntName, double plntMass, int plntDiamtr, ushort plntDensity) : this(plntName, plntMass)
		{
			_plntDiamtr = plntDiamtr;
			_plntDensity = plntDensity;
		}

		public Planet(string plntName, double plntMass, int plntDiamtr, ushort plntDensity,
			float plntGravity, float plntRotPeriod, float plntDayLen,
			float plntOrbPeriod, float plntOrbVelo) : this(plntName, plntMass, plntDiamtr, plntDensity)
		{
			_plntGravity = plntGravity;
			_plntRotPeriod = plntRotPeriod;
			_plntDayLen = plntDayLen;
			_plntOrbPeriod = plntOrbPeriod;
			_plntOrbVelo = plntOrbVelo;
		}

		public Planet(string plntName, double plntMass, int plntDiamtr, ushort plntDensity,
			float plntGravity, float plntRotPeriod, float plntDayLen, float plntSunDist,
			float plntOrbPeriod, float plntOrbVelo, short plntMeanTemp) : this(plntName, plntMass,
				plntDiamtr, plntDensity, plntGravity, plntRotPeriod,
				plntDayLen, plntOrbPeriod, plntOrbVelo)
		{
			_plntSunDist = plntSunDist;
			_plntMeanTemp = plntMeanTemp;
		}

		public Planet(string plntName, double plntMass, int plntDiamtr, ushort plntDensity,
			float plntGravity, float plntRotPeriod, float plntDayLen, float plntSunDist,
			float plntOrbPeriod, float plntOrbVelo, short plntMeanTemp, byte plntMoonNum,
			bool plntHasRing) : this(plntName, plntMass, plntDiamtr, plntDensity,
				plntGravity, plntRotPeriod, plntDayLen, plntOrbPeriod, plntOrbVelo)
		{
			_plntMoonNum = plntMoonNum;
			_plntHasRing = plntHasRing;
		}

		/*
				public Planet(double plntMass, int plntDiamtr, ushort plntDensity,
					float plntGravity, float plntRotPeriod, float plntDayLen, float plntSunDist,
					float plntOrbPeriod, float plntOrbVelo, short plntMeanTemp, byte plntMoonNum,
					bool plntHasRing) : this(plntMass, plntDiamtr, plntDensity, plntGravity,
						plntRotPeriod, plntDayLen, plntSunDist, plntOrbPeriod, plntOrbVelo,
						plntMeanTemp, plntMoonNum, plntHasRing)
				{
					_plntDiamtr = plntDiamtr;
					_plntDensity = plntDensity;
					_plntGravity = plntGravity;
					_plntRotPeriod = plntRotPeriod;
					_plntDayLen = plntDayLen;
					_plntSunDist = plntSunDist;
					_plntOrbPeriod = plntOrbPeriod;
					_plntOrbVelo = plntOrbVelo;
					_plntMeanTemp = plntMeanTemp;
					_plntMoonNum = plntMoonNum;
					_plntHasRing = plntHasRing;
				}
		*/


		public void Run()
		{
			List<string> myPlanets = new List<string>();
			myPlanets.Add("Mercury");
			myPlanets.Add("Earth");
			myPlanets.Add("Mars");
			myPlanets.Add("Jupiter");
			myPlanets.Add("Saturn");
			myPlanets.Add("Uranus");
			myPlanets.Add("Neptune");
			myPlanets.Add("Pluto");

			foreach (string planet in myPlanets)
			{
				Console.WriteLine(planet);
			}
		}
	}
}
