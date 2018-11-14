using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingManager
{
    /// <summary>
    /// This class represents a voter in the election. The class keeps a track of the voter's
    /// voting preferences and whether voter's vote is valid or invalid.
    /// </summary>
    class Voter
    {
        private List<string> votingPreferences = new List<string>();
        private bool validVote;

        public Voter(List<string> votingPreferences)
        {
            this.votingPreferences = votingPreferences;
        }

        public void setVotingPreferences(List<string> votingPreferences)
        {
            this.votingPreferences = votingPreferences;
        }

        public List<string> getVotingPreferences()
        {
            return votingPreferences;
        }

        public void setValidVote(bool validStatus)
        {
            this.validVote = validStatus;
        }

        public bool getValidVote()
        {
            return validVote;
        }

        public override string ToString()
        {
            string votingPreferencesString = "";
            for (int i = 0; i < votingPreferences.Count(); i++)
            {
                if (i == votingPreferences.Count - 1)
                {
                    votingPreferencesString += votingPreferences[i];
                }
                else
                {
                    votingPreferencesString += votingPreferences[i] + "  |  ";
                }
            }
            return votingPreferencesString;
        }
    }
}
