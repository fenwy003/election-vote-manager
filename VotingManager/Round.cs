using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingManager
{
    /// <summary>
    /// This class represents a round in the election. The class keep a track of a round's
    /// id/sequence number, result and precluded candidate(if any).
    /// </summary>
    class Round
    {
        private List<int> roundResult = new List<int>();
        private List<string> precludedRoundResult = new List<string>();
        private Candidate precluded = null;
        private int roundNo;

        public Round(List<int> roundResult)
        {
            this.roundResult = roundResult;
        }

        public Round(List<string> precludedRoundResult)
        {
            this.precludedRoundResult = precludedRoundResult;
        }

        public void setRoundResult(List<int> roundResult)
        {
            this.roundResult = roundResult;
        }

        public List<int> getRoundResult()
        {
            return roundResult;
        }

        public void setPrecludedRoundResult(List<string> precludedRoundResult)
        {
            this.precludedRoundResult = precludedRoundResult;
        }

        public List<string> getPrecludedRoundResult()
        {
            return precludedRoundResult;
        }

        public void setPrecluded(Candidate precluded)
        {
            this.precluded = precluded;
        }

        public Candidate getPrecluded()
        {
            return precluded;
        }

        public void setRoundNo(int roundNo)
        {
            this.roundNo = roundNo;
        }

        public int getRoundNo()
        {
            return roundNo;
        }

        public override string ToString()
        {
            string roundResultString = "";

            if (precluded == null)
            {
                for (int i = 0; i < roundResult.Count(); i++)
                {
                    if (i == roundResult.Count - 1)
                    {
                        roundResultString += roundResult[i];
                    }
                    else
                    {
                        roundResultString += roundResult[i] + "  |  ";
                    }
                }
            }
            else
            {
                for (int i = 0; i < precludedRoundResult.Count(); i++)
                {
                    if (i == precludedRoundResult.Count - 1)
                    {
                        roundResultString += precludedRoundResult[i];
                    }
                    else
                    {
                        roundResultString += precludedRoundResult[i] + "  |  ";
                    }
                }
            }

            return roundResultString;
        }
    }
}
