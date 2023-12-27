using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggShipUWP.Common
{
    public class ShipStatus
    {
        private static ShipStatus _instance;

        public static ShipStatus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ShipStatus();
                }
                return _instance;
            }
        }


        // Colonists
        private int colonists;
        public int Colonists
        {
            get { return colonists; }
            set { colonists = value; }
        }

        // Scanners
        private int atmosphereScanner;
        public int AtmosphereScanner
        {
            get { return atmosphereScanner; }
            set { atmosphereScanner = value; }
        }

        private int gravityScanner;
        public int GravityScanner
        {
            get { return gravityScanner; }
            set { gravityScanner = value; }
        }

        private int temperatureScanner;
        public int TemperatureScanner
        {
            get { return temperatureScanner; }
            set { temperatureScanner = value; }
        }

        private int waterScanner;
        public int WaterScanner
        {
            get { return waterScanner; }
            set { waterScanner = value; }
        }

        private int mineralsScanner;
        public int MineralsScanner
        {
            get { return mineralsScanner; }
            set { mineralsScanner = value; }
        }

        // Systems
        private int landingSystem;
        public int LandingSystem
        {
            get { return landingSystem; }
            set { landingSystem = value; }
        }

        private int constructionSystem;
        public int ConstructionSystem
        {
            get { return constructionSystem; }
            set { constructionSystem = value; }
        }

        // Databases
        private int culturalDatabase;
        public int CulturalDatabase
        {
            get { return culturalDatabase; }
            set { culturalDatabase = value; }
        }

        private int scientificDatabase;
        public int ScientificDatabase
        {
            get { return scientificDatabase; }
            set { scientificDatabase = value; }
        }

        public ShipStatus()
        {
            // init colonists
            colonists = 10000;
            // init scanners
            atmosphereScanner = 100; gravityScanner = 100; temperatureScanner = 100; waterScanner = 100; mineralsScanner = 100;
            // init systems
            landingSystem = 100; constructionSystem = 100;
            // init databases
            culturalDatabase = 100; scientificDatabase = 100;
        }
    }
}
