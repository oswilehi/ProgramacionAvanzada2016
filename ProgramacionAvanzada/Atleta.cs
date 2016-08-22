using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada
{
    /// <summary>
    /// This class will represent any olympian in Rio
    /// </summary>
    public class Athlete
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Discipline { get; set; }       
        public string LastMedal { get; set; }

        /// <summary>
        /// This method should be used whenever an athlete 
        /// wins a competition in the last round
        /// </summary>
        /// <param name="medal">What medal did the athlete
        /// won</param>
        public void Win(string medal)
        {
            LastMedal = medal;
        }
    }
}
