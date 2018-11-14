using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingManager
{
    /// <summary>
    /// This class represents a candidate of the election. The class keep a track of the name
    /// of the candidate and the number of votes he/she receive from voters.
    /// </summary>
    class Candidate
    {
        private string name;
        private double votesReceived = 0;

        public Candidate(string name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setVotesReceived(double votesReceived)
        {
            this.votesReceived = votesReceived;
        }

        public double getVotesReceived()
        {
            return votesReceived;
        }
    }
}
