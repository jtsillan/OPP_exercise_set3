using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_Osa3
{
    internal class Vehicle
    {
        // tehtävä 6.
        /// <summary>
        /// Model Field
        /// </summary>
        private string model;

        // tehtävä 7.
        /// <summary>
        /// Manufactor Field
        /// </summary>
        private string manufactor;

        /// <summary>
        /// Get for model
        /// </summary>
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        /// <summary>
        /// Get for manufactor
        /// </summary>
        public string Manufactor
        {
            get { return this.manufactor; }
            set { this.manufactor = value; }
        }

        // tehtävä 8.
        /// <summary>
        /// Default Contructor
        /// </summary>
        public Vehicle(string model, string manufactor)
        {
            this.model = model;
            this.manufactor = manufactor;
        }

        // tehtävä 3.
        /// <summary>
        /// Vehicle Accelerate
        /// </summary>
        public void Accelerate()
        {
            Console.WriteLine("Accelerate");
        }

        // tehtävä 4.
        /// <summary>
        /// Vehicle Brake
        /// </summary>
        public void Brake()
        {
            Console.WriteLine("Brake");
        }
    }
}
