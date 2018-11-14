using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingManager
{
    /// <summary>
    /// This class generates a form which contains input fields for user to input necessary data of the election in order to determine
    /// who the winner of the election is or if the election was a tie. The form also have several labels that provides statistics
    /// of the election and a pie graph which shows the number of votes each candidate receives from the voters.
    /// </summary>
    public partial class ManualModeForm : Form
    {
        private List<Candidate> candidateList = new List<Candidate>(); // Stores all candidates of the election
        private List<TextBox> vpTextBoxList = new List<TextBox>(); // Stores the 10 input textboxes in the "Voting Preference" section
        private List<Label> candidateOverviewLabelList = new List<Label>(); // Stores the 10 labels in the "Candidate Overview" section
        private List<Label> votingResultLabelList = new List<Label>(); // Stores the 10 labels in the "Results" section
        private List<Round> votingRoundsList = new List<Round>(); // As the name suggests
        private List<Voter> voterList = new List<Voter>(); // Stores all voters that have lodge a vote in the election
        private List<List <string>> exportingPreferencesList = new List<List<string>>(); // List for exporting votes 
        private double invalidVoteCount = 0; 
        private double validVoteCount = 0;
        private int numberOfVoters = 0; // Created to avoid using voterList.Count() all the time
        private double winningVotes; // Number of votes requried to win the election

        /// <summary>
        /// A constructor that takes no parameter. Disables the "Voting Preference" section until candidates 
        /// have been confirmed.
        /// </summary>
        public ManualModeForm()
        {
            InitializeComponent();
            initializeCandidateOverviewLabelList();
            initializeVPTextboxList();
            disableVotingPreference();
        }

        /// <summary>
        /// This function initializes the CandidateOverviewLabelList by adding the 10 labels in the "Candidate Overview" section.
        /// This is to make the process of updating these 10 labels easier.
        /// </summary>
        private void initializeCandidateOverviewLabelList()
        {
            candidateOverviewLabelList.Add(candidate1Label);
            candidateOverviewLabelList.Add(candidate2Label);
            candidateOverviewLabelList.Add(candidate3Label);
            candidateOverviewLabelList.Add(candidate4Label);
            candidateOverviewLabelList.Add(candidate5Label);
            candidateOverviewLabelList.Add(candidate6Label);
            candidateOverviewLabelList.Add(candidate7Label);
            candidateOverviewLabelList.Add(candidate8Label);
            candidateOverviewLabelList.Add(candidate9Label);
            candidateOverviewLabelList.Add(candidate10Label);
        }

        /// <summary>
        /// This function initializes the VPTextboxList by adding the 10 input text in the "Voting Preference" section.
        /// This is to make the process of ensuring only the required input textboxes is made visible easier.
        /// </summary>
        private void initializeVPTextboxList()
        {
            vpTextBoxList.Add(vpCandidate1TextBox);
            vpTextBoxList.Add(vpCandidate2TextBox);
            vpTextBoxList.Add(vpCandidate3TextBox);
            vpTextBoxList.Add(vpCandidate4TextBox);
            vpTextBoxList.Add(vpCandidate5TextBox);
            vpTextBoxList.Add(vpCandidate6TextBox);
            vpTextBoxList.Add(vpCandidate7TextBox);
            vpTextBoxList.Add(vpCandidate8TextBox);
            vpTextBoxList.Add(vpCandidate9TextBox);
            vpTextBoxList.Add(vpCandidate10TextBox);
        }

        /// <summary>
        /// This function disable the "Voting Preference" section by making its input textboxes and buttons
        /// invisible.
        /// </summary>
        private void disableVotingPreference()
        {
            for (int i = 0; i < vpTextBoxList.Count(); i++)
            {
                vpTextBoxList[i].Visible = false;
            }
            nextButton.Visible = false;
            finishButton.Visible = false;
            votingPreferenceGroupBox.Text += "- Disabled";
        }

        /// <summary>
        /// This function is triggered when user clicks the corresponding button. It validates 
        /// the input value of the input textbox within "Add Candidate" section. If validation 
        /// succeed, then the candidate is added. If validation failes, corresponding failure message
        /// will be displayed.
        /// </summary>
        /// <param name="sender"> addCandidateButton </param>
        /// <param name="e"> click </param>
        private void addCandidateButton_Click(object sender, EventArgs e)
        {
            // Check whether the the name is empty or not
            if (addNameTextBox.Text != "")
            {
                // If its not empty then check whether the name is valid or not
                if (IsNumeric(addNameTextBox.Text) == false)
                {
                    // Check if the candidate with the given name has already been added or not
                    if (candidateExist(addNameTextBox.Text) == -1)
                    {
                        // Add the candidate
                        candidateList.Add(new Candidate(addNameTextBox.Text));
                        // Update candidate overview
                        updateCandidateOverview();
                    }
                    else
                    {
                        MessageBox.Show("Candidate has been added already!", "Add Candidate Error");
                    }
                }
                else
                {
                    MessageBox.Show("Candidate's name cannot be purely numbers!", "Add Candidate Error");
                }
            }
            else
            {
                MessageBox.Show("You cannot add a candidate without providing his/her name!", "Add Candidate Error");
            }

            // Since the maximum number of candidates is 10, hide the add button when candidateList contains 10 candidates
            if (candidateList.Count() == 10)
            {
                MessageBox.Show("The maximum of 10 candidates have been reached, candidates can no longer be added.", "Maximum Candidates Reached");
                addCandidateButton.Hide();
            }

            addNameTextBox.Text = "";
        }

        /// <summary>
        /// This function checks whether the given string parameter is purely numeric or not.
        /// If it is then true is returned. If it is not then false is returned.
        /// </summary>
        /// <param name="input">value to be evaluated</param>
        /// <returns>true or false</returns>
        public bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        /// <summary>
        /// This function checks whether if the candidate with the given string parameter is a participant
        /// of the election or not. If yes then the index of the candidate is returned. If not then -1 is
        /// returned.
        /// </summary>
        /// <param name="name">name of the desired candidate</param>
        /// <returns>index of the candidate or -1</returns>
        private int candidateExist(string name)
        {
            for (int i = 0; i < candidateList.Count(); i++)
            {
                if (candidateList[i].getName() == name)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// This function is called everytime when a candidate is being added or removed. It updates the text of
        /// the labels within "Candidate Overview" to reflect the change in the participants of the election.
        /// </summary>
        private void updateCandidateOverview()
        {
            // Reset all labels in "Candidate Overview" section
            for (int i=0; i < 10; i++)
            {
                candidateOverviewLabelList[i].Text = "Candidate " + (i+1) +":";
            }

            // then update x labels depending on the number of candidates
            for (int i = 0; i < candidateList.Count(); i++)
            {
                candidateOverviewLabelList[i].Text += " " + candidateList[i].getName();
            }
        }

        /// <summary>
        /// This function is triggered when user clicks the corresponding button, . It validates the 
        /// input value of the input textbox in the input textbox within "Remove Candidate" section. 
        /// If validation succeed, then the candidate with the input value is removed. 
        /// If validation failes, corresponding failure message will be displayed.
        /// </summary>
        /// <param name="sender"> removeCandidateButton </param>
        /// <param name="e"> click </param>
        private void removeCandidateButton_Click(object sender, EventArgs e)
        {
            // If the name of the candidate to be removed is not empty
            if (removeNameTextBox.Text != "")
            {
                // If the candidate with the given name exist then remove it from candidateList
                if (candidateExist(removeNameTextBox.Text) != -1)
                {
                    candidateList.RemoveAt(candidateExist(removeNameTextBox.Text));
                    updateCandidateOverview();
                    MessageBox.Show("Candidate Removed", "Candidate Removal Success");
                }
                else
                {
                    MessageBox.Show("No matching record found", "Candidate Not Found");
                }
            }

            removeNameTextBox.Text = "";
        }

        /// <summary>
        /// This function is tiggered when user clicks the corresponding button and a messageBox with two 
        /// options(Yes/No) will pop up. If yes is chosen then "Add Candidate" and "Remove CandidateButton "
        /// will be disabled but enables the "Voting Preference" section. If no, nothing will
        /// change.
        /// </summary>
        /// <param name="sender"> confirmCandidateButton </param>
        /// <param name="e"> click </param>
        private void confirmCandidateButton_Click(object sender, EventArgs e)
        {
            if (candidateList.Count() < 2)
            {
                MessageBox.Show("There must be at least two Candidates!!!", "Insufficient Number of Candidates");
            }
            else
            {
                // Display a message box asking users whether the candidate list has been finalised or not.
                if (MessageBox.Show("Candidate List cannot be edited once you proceed to the next step, do you wish to proceed?", "Confirm Candidate List",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Disalbe "Add Candidate" section
                    addNameTextBox.Visible = false;
                    addNameLabel.Visible = false;
                    addCandidateButton.Visible = false;
                    addCandidateGroupBox.Text += " - Disabled";
                    
                    // Disalbe "Remove Candidate" section
                    removeNameTextBox.Visible = false;
                    removeNameLabel.Visible = false;
                    removeCandidateButton.Visible = false;
                    removeCandidateGroupBox.Text += " - Disabled";

                    // Disalbe "Confirm Candidates" section
                    confirmCandidateGroupBox.Text += " - Disabled";
                    confirmCandidatesLabel.Visible = false;
                    confirmCandidateButton.Visible = false;
                    enableVotingPreference();
                }
            }
        }

        /// <summary>
        /// This function enables the "Voting Preference" section by making x of its input textboxes and buttons
        /// visible. The section title is also updated to reflect the change in active status. X refers to the 
        /// number of candidates of the election.
        /// </summary>
        private void enableVotingPreference()
        {
            votingPreferenceGroupBox.Text = "Voting Preference";

            for (int i = 0; i < candidateList.Count(); i++)
            {
                vpTextBoxList[i].Visible = true;
            }
            nextButton.Visible = true;
            finishButton.Visible = true;
        }

        /// <summary>
        /// This function is triggered when user clicks the corresponding button. A voter whose voting preferences
        /// is the same as the values in the input textboxes in "Voting Preference" section, is created and added to
        /// the voterList. The validity of the vote is determineded and recorded. Then wipe out the input textboxes 
        /// to prepare for the next voter if there are any.
        /// </summary>
        /// <param name="sender"> nextButton </param>
        /// <param name="e"> Click </param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            List<string> voterPreferencesList = new List<string>();

            for (int i = 0; i < candidateList.Count(); i++)
            {
                voterPreferencesList.Add(vpTextBoxList[i].Text);
            }

            Voter currentVoter = new Voter(voterPreferencesList);
            // Valid vote
            if (checkVoteValidity(currentVoter) == true)
            {
                validVoteCount++;
                currentVoter.setValidVote(checkVoteValidity(currentVoter));
            }
            // Invalid vote
            else
            {
                invalidVoteCount++;
                currentVoter.setValidVote(checkVoteValidity(currentVoter));
            }
            voterList.Add(currentVoter);
            numberOfVoters++;
            voterCounterLabel.Text = "Current Number of Voters:  " + numberOfVoters;
            // Reset input fields
            for (int i = 0; i < candidateList.Count(); i++)
            {
                vpTextBoxList[i].Text = "";
            }
        }

        /// <summary>
        /// This function evaluates the validity of the vote of the given voter. True is returned if the vote is valid
        /// , false is returned if the vote is invalid.
        /// </summary>
        /// <param name="voter"> the voter whose vote is to be validated </param>
        /// <returns> true or false </returns>
        private bool checkVoteValidity(Voter voter)
        {
            List<string> voterPreferenceList = voter.getVotingPreferences();

            for (int i = 0; i < voterPreferenceList.Count(); i++)
            {
                // Empty preference, hence return false
                if (voterPreferenceList[i] == "")
                {
                    return false;
                }
                else
                {
                    // Non numeric preference, hence return false
                    if (IsNumeric(voterPreferenceList[i]) == false)
                    {
                        return false;
                    }
                    else
                    {
                        // 0 is not a vaild preference, hence return false
                        if (voterPreferenceList[i] == "0")
                        {
                            return false;
                        }
                        // preference value is greater than number of candidates, hence return false
                        else if (Convert.ToInt32(voterPreferenceList[i]) > candidateList.Count())
                        {
                            return false;
                        }
                    }
                }
            }
            // duplicate preference value, hence return false
            if (duplicatePreference(voterPreferenceList) == true)
            {
                return false;
            }
            else
            {
                // Vaild vote, hence return true
                return true;
            }
        }

        /// <summary>
        /// This function evaluates whether the vote contains duplicates of a preference value. True is returned if 
        /// the duplicates are found, false is returned if the no duplicates are found.
        /// </summary>
        /// <param name="preferenceList"> the vote to be evaluated </param>
        /// <returns> true or false </returns>
        private bool duplicatePreference(List<string> preferenceList)
        {
            for (int i = 0; i < preferenceList.Count(); i++)
            {
                int valueToBeChecked = Convert.ToInt32(preferenceList[i]);
                for (int x = i+1; x < preferenceList.Count(); x++)
                {
                    // Duplicate preference value found, hence return true
                    if (Convert.ToInt32(preferenceList[x]) == valueToBeChecked)
                    {
                        return true;
                    }
                }
            }
            // No duplicate preference value, hence return false
            return false;
        }

        /// <summary>
        /// This function is triggered when user clicks the corresponding button.
        /// </summary>
        /// <param name="sender"> finishButton </param>
        /// <param name="e"> click </param>
        private void finishButton_Click(object sender, EventArgs e)
        {
            if (numberOfVoters < 2)
            {
                MessageBox.Show("There must be at least 2 voters", "Insufficient Number of Voters");
            }
            else
            {
                MessageBox.Show("Processing Votes...", "Processing Votes");
                // Disable anymore user inputs on voting by disableing the buttons
                disableVotingPreference();
                nextButton.Visible = false;
                finishButton.Visible = false;

                // Initialize exportingPreferencesList to export voters preferences as CSV file
                initializeExportingPreferencesList();

                // Calculate the minimum amount of votes needed to win the election
                winningVotes = Math.Ceiling((double)(validVoteCount/2));

                // Calculate the votes of each candidates
                List<int> currentCandidatesVoteList = countFirstPreferences();

                // Initialize and updates the voting result labels
                initializeVotingResultLabelList();

                // Update Round 0's result label
                votingResultLabelList[0].Text = votingRoundsList[0].ToString();

                // Determine if a winner exists or not
                Candidate winner = determineWinner(currentCandidatesVoteList);

                // Display the voting outcomes
                displayFinalStatistics(winner);

                // Generates the candidates votes bar graph
                generateOutcomeGraph();
            }
        }

        /// <summary>
        /// This function adds each voter's preferences into the ExportingPreferencesList.
        /// </summary>
        private void initializeExportingPreferencesList()
        {
            for (int i=0; i < numberOfVoters; i++)
            {
                exportingPreferencesList.Add(new List<string>(voterList[i].getVotingPreferences()));
            }
        }

        /// <summary>
        /// This function initializes the VotingResultLabelList by adding the 10 labels in the "Result" section.
        /// This is to make the process of displaying round results eaiser.
        /// </summary>
        private void initializeVotingResultLabelList()
        {
            votingResultLabelList.Add(round0ResultLabel);
            votingResultLabelList.Add(round1ResultLabel);
            votingResultLabelList.Add(round2ResultLabel);
            votingResultLabelList.Add(round3ResultLabel);
            votingResultLabelList.Add(round4ResultLabel);
            votingResultLabelList.Add(round5ResultLabel);
            votingResultLabelList.Add(round6ResultLabel);
            votingResultLabelList.Add(round7ResultLabel);
            votingResultLabelList.Add(round8ResultLabel);
            votingResultLabelList.Add(round9ResultLabel);
        }

        /// <summary>
        /// This function counts and sets the number of votes of each candidates received from the voters by
        /// counting the number of first preference the candidate has in valid votes.
        /// </summary>
        /// <returns> an integer list containning the result of the calculation </returns>
        private List<int> countFirstPreferences()
        {
            List<int> firstPreferenceList = new List<int>();

            // Initialise firstPreferenceList
            for (int i=0; i < candidateList.Count(); i++)
            {
                firstPreferenceList.Add(0);
            }

            // Loop through votersList to count first preferences
            for (int i = 0; i < voterList.Count(); i++)
            {
                // Count the first preference from voters whose vote is valid
                if (voterList[i].getValidVote() == true)
                {
                    int addIndex = voterList[i].getVotingPreferences().IndexOf("1");
                    firstPreferenceList[addIndex]++;
                    candidateList[addIndex].setVotesReceived(firstPreferenceList[addIndex]);
                }
            }

            // Initialise the voting round list with the current round
            votingRoundsList.Add(new Round(firstPreferenceList));
            // ID is 0 as no candidate has been precluded yet
            votingRoundsList[0].setRoundNo(0);
            return firstPreferenceList;
        }

        /// <summary>
        /// This function determines whether the election has a winner or the election is a tie. 
        /// </summary>
        /// <param name="currentCandidatesVoteList"> round 0's result </param>
        /// <returns> the winner or the election or tie </returns>
        private Candidate determineWinner(List<int> currentCandidatesVoteList)
        {
            Candidate winner = null;
            List<Candidate> potentialWinnersList = new List<Candidate>();
            List<Candidate> remainingCandidateList = new List<Candidate>();

            // Initialise remaining Candidates list
            for (int i=0; i<candidateList.Count(); i++)
            {
                remainingCandidateList.Add(candidateList[i]);
            }

            // When the outcome of the election is still unclear
            while (winner == null)
            {
                // Only 2 candidates remains
                if (remainingCandidateList.Count() == 2)
                {
                    Candidate first = remainingCandidateList[0];
                    Candidate second = remainingCandidateList[1];
                    // 1st candidate is the winner
                    if (first.getVotesReceived() > second.getVotesReceived()
                        && first.getVotesReceived() >= winningVotes)
                    {
                        winner = first;
                    }
                    // 2nd candidate is the winner
                    else if (second.getVotesReceived() > first.getVotesReceived()
                        && second.getVotesReceived() >= winningVotes)
                    {
                        winner = second;
                    }
                    // Tie
                    else if (first.getVotesReceived() == second.getVotesReceived())
                    {
                        winner = new Candidate("Tie");
                    }
                }
                //More than 2 candidates remains
                else if (remainingCandidateList.Count() > 2)
                {
                    // If all the remaining candidates has the same number of votes, declare tie
                    if (determineTie(remainingCandidateList) == true)
                    {
                        winner = new Candidate("Tie");
                    }
                    // Remaining candidates has no equal amount of votes, so exmaine votes further
                    else
                    {
                        // Evaluate each candidate's number of votes received to identify who has at least 50% of total votes
                        for (int i = 0; i < remainingCandidateList.Count(); i++)
                        {
                            if (remainingCandidateList[i].getVotesReceived() >= winningVotes)
                            {
                                potentialWinnersList.Add(remainingCandidateList[i]);
                            }
                        }

                        // Only one potential winner, hence this candidate is the winner of the election
                        if (potentialWinnersList.Count() == 1)
                        {
                            winner = potentialWinnersList[0];
                        }
                        // Two potential winners meaning each has 50%, hence the election is a tie
                        else if (potentialWinnersList.Count() == 2)
                        {
                            winner = new Candidate("Tie");
                        }
                        // No candidates have enough votes to win the election and do not share the same amount of votes
                        else 
                        {
                            // Count the lowest number of votes
                            double lowestVote = findLowestVote(remainingCandidateList);
                            
                            List<Candidate> lowestCandidates = new List<Candidate>();
                            // Find out which candidates has the lowest vote
                            for (int index=0; index < remainingCandidateList.Count(); index++)
                            {
                                if (remainingCandidateList[index].getVotesReceived() == lowestVote)
                                {
                                    lowestCandidates.Add(remainingCandidateList[index]);
                                }
                            }
                            // If only one candidate has the lowest vote then remove that candidate
                            if (lowestCandidates.Count() == 1)
                            {
                                Candidate precludedCandidate = lowestCandidates[0];
                                remainingCandidateList.Remove(precludedCandidate);
                                redistributeVotes(remainingCandidateList, precludedCandidate);
                            }
                            // Randomly preculde a candidate with the lowest number of votes
                            else
                            {
                                // Randmonly preculde one of the candidates with the lowest vote
                                int preculdeIndex = new Random().Next(0,lowestCandidates.Count());
                                Candidate precludedCandidate = lowestCandidates[preculdeIndex];
                                remainingCandidateList.Remove(precludedCandidate);
                                redistributeVotes(remainingCandidateList, precludedCandidate);
                            }
                        }
                    }
                }
            }
            return winner;
        }

        /// <summary>
        /// This function calculates and returns the lowest number of votes basing on the votes of the 
        /// candidates that have not been precluded from the election.
        /// </summary>
        /// <param name="candidatesList"> list containning the remaining candidates </param>
        /// <returns> the lowest number of votes </returns>
        private double findLowestVote(List<Candidate> candidatesList)
        {
            double currentLowestVote = candidatesList[0].getVotesReceived();

            for (int i=0; i < candidatesList.Count(); i++)
            {
                if (candidatesList[i].getVotesReceived() < currentLowestVote)
                {
                    currentLowestVote = candidatesList[i].getVotesReceived();
                }
            }

            return currentLowestVote;
        }

        /// <summary>
        /// When this function is being called, the votes of the precludedCandidate will be re-distributed
        /// to the candidates within the remainingCandidateList. Then it creates a new round with the outcome
        /// information and adds it to the votingRoundsList.
        /// </summary>
        /// <param name="remainingCandidateList"> list containning the remaining candidates </param>
        /// <param name="precludedCandidate"> a candidate who is precluded from the election </param>
        private void redistributeVotes(List<Candidate> remainingCandidateList, Candidate precludedCandidate)
        {
            precludedCandidate.setVotesReceived(0);
            int precludedCandidateIndex = findPrecludedCandidateIndex(precludedCandidate);
            // Get the preference value of the precluded Candidate from each voters' vote
            for (int i=0; i<numberOfVoters; i++)
            {
                // Only processe valid votes
                if (voterList[i].getValidVote() == true)
                {
                    List<string> voterPreferences = voterList[i].getVotingPreferences();
                    int preferenceValue = Convert.ToInt32(voterPreferences[precludedCandidateIndex]);
                    // Loop through voter's preference list
                    for (int index=0; index < voterPreferences.Count(); index++)
                    {
                        // and decrement any preference value that is greater preferenceValue
                        if (Convert.ToInt32(voterPreferences[index]) > preferenceValue)
                        {
                            voterPreferences[index] = Convert.ToString(Convert.ToInt32(voterPreferences[index]) - 1);
                        }
                    }
                    voterPreferences[precludedCandidateIndex] = "-1";
                }
            }
            // Count the number of first preferences of the remainning candidates
            countFirstPreferences(remainingCandidateList);
            // This list is used to determine which candidates have been precluded
            List<string> candidateStatus = findFirstValidVote();

            // Generates the round result string list which will be printed to show the round outcome
            List<string> roundOutcome = new List<string>();
            if (votingRoundsList.Count() > 1)
            {
                roundOutcome = new List<string>(votingRoundsList[votingRoundsList.Count()-1].getPrecludedRoundResult());
                for (int i = 0; i < candidateList.Count(); i++)
                {
                    if (candidateStatus[i] == "-1")
                    {
                        roundOutcome[i] = "P";
                    }
                    else
                    {
                        roundOutcome[i] = Convert.ToString(candidateList[i].getVotesReceived());
                    }
                }
            }
            else
            {
                for (int i = 0; i < candidateList.Count(); i++)
                {
                    if (i == precludedCandidateIndex)
                    {
                        roundOutcome.Add("P");
                    }
                    else
                    {
                        roundOutcome.Add(Convert.ToString(candidateList[i].getVotesReceived()));
                    }
                }
            }

            // Since votes are re-distributed, create a new round then add it to round list
            Round newRound = new Round(roundOutcome);
            newRound.setRoundNo(votingRoundsList.Count());
            newRound.setPrecluded(precludedCandidate);
            votingRoundsList.Add(newRound);

            // Update the round labels
            votingResultLabelList[votingRoundsList.Count() - 1].Text = votingRoundsList[votingRoundsList.Count() - 1].ToString();
        }

        /// <summary>
        /// This function finds and returns the index of the precluded candidate in the candidateList, which is
        /// the list that contains all the candidates of the election regardless of whether the candidate is 
        /// precluded from the election or not. If precludedCandidate cannot be found then -1 is returned.
        /// </summary>
        /// <param name="precludedCandidate"> a candidate who is precluded from the election </param>
        /// <returns> the index the precluded candidate or -1 </returns>
        private int findPrecludedCandidateIndex(Candidate precludedCandidate)
        {
            for (int i=0; i < candidateList.Count(); i++)
            {
                if (candidateList[i].getName() == precludedCandidate.getName())
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Finds and returns the first valid vote. Returns null if no valid vote
        /// </summary>
        /// <returns> the first valid vote or null </returns>
        private List<string> findFirstValidVote()
        {
            for (int i = 0; i < voterList.Count(); i++)
            {
                if (voterList[i].getValidVote() == true)
                {
                    return voterList[i].getVotingPreferences();
                }
            }

            return null;
        }

        /// <summary>
        /// This function counts and sets the number of votes of each of the remainning candidates by
        /// counting the number of first preference the candidate has in valid votes.
        /// </summary>
        /// <param name="remainingCandidateList"> list containning the remaining candidates </param>
        private void countFirstPreferences(List<Candidate> remainingCandidateList)
        {
            List<int> firstPreferenceList = new List<int>();

            // Initialise firstPreferenceList
            for (int i = 0; i < candidateList.Count(); i++)
            {
                firstPreferenceList.Add(0);
            }

            // Loop through voters' vote to count first preferences
            for (int i = 0; i < voterList.Count(); i++)
            {
                // Count the first preference from voters whose vote is valid
                if (voterList[i].getValidVote() == true)
                {
                    int addIndex = voterList[i].getVotingPreferences().IndexOf("1");
                    firstPreferenceList[addIndex]++;
                }
            }
            // Re-assign the number of votes received by the remainning candidates
            for (int i = 0; i < candidateList.Count(); i++)
            {
                for (int index=0; index < remainingCandidateList.Count(); index++)
                {
                    if (candidateList[i].getName() == remainingCandidateList[index].getName())
                    {
                        remainingCandidateList[index].setVotesReceived(firstPreferenceList[i]);
                    }
                }
            }
        }

        /// <summary>
        /// Determine whether the election outcome is a tie or not by checking if all the remaining candidates
        /// have the same number of votes. If all candidates have the same number of votes then return true 
        /// otherwise return false.
        /// </summary>
        /// <param name="remainingCandidateList"> list containning the remaining candidates </param>
        /// <returns> true or false </returns>
        private bool determineTie(List<Candidate> remainingCandidateList)
        {
            double valueMark = remainingCandidateList[0].getVotesReceived();

            for (int i=0; i < remainingCandidateList.Count(); i++)
            {
                if (remainingCandidateList[i].getVotesReceived() != valueMark)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Updates to labels in the "Final Result Statistics" with associating data and the election outcome.
        /// </summary>
        /// <param name="winner"> the outcome of the election </param>
        private void displayFinalStatistics(Candidate winner)
        {
            totalVoteLabel.Text += Convert.ToString(numberOfVoters);
            validVoteTotalLabel.Text += Convert.ToString(validVoteCount);
            invalidVoteTotalLabel.Text += Convert.ToString(invalidVoteCount);
            // Either a winner is found or the election was a tie
            if (winner != null)
            {
                if (winner.getName() != "Tie")
                {
                    votingOutcomeLabel.Text += winner.getName() + " is the winner of this election!";
                    // Find the index of the winning candidate
                    int winnerIndex = candidateList.IndexOf(winner);
                    // then highlight his/her label in the "Candidate Overview" section
                    candidateOverviewLabelList[winnerIndex].ForeColor = Color.Red;
                    // and append the text to indicate him/her is the winner of the election
                    candidateOverviewLabelList[winnerIndex].Text += " - Election Winner!";
                }
                else
                {
                    votingOutcomeLabel.Text += winner.getName();
                }
            }
            // No winner (test case created during development for validation purpose, has no effect in the final project version)
            else
            {
                votingOutcomeLabel.Text += "Winner do not exist in this election";
            }
        }

        /// <summary>
        /// This function generates a bar graph which shows the number of votes each candidate received 
        /// from the voters.
        /// </summary>
        private void generateOutcomeGraph()
        {
            voteChart.Visible = true;
            voteChart.ChartAreas[0].AxisY.Interval = 1;
            List<int> candidatesVotes = new List<int>(votingRoundsList[0].getRoundResult());
            // Generate number of bars depending on the number of candidates
            for (int i = 0; i < candidateList.Count(); i++)
            {
                voteChart.Series["Votes"].Points.AddXY(candidateList[i].getName(), candidatesVotes[i]);
                // Prevent candidates with 0 votes from getting number of votes printed in the pie
                if (candidatesVotes[i] == 0)
                {
                    voteChart.Series["Votes"].Points[i].Label = " ";
                }
                else
                {
                    voteChart.Series["Votes"].Points[i].Label = Convert.ToString(candidatesVotes[i]);
                }
                // Reset the legend text to candidate name. Otherwise the legend text will be the label text
                voteChart.Series["Votes"].Points[i].LegendText = candidateList[i].getName();
            }
        }

        /// <summary>
        /// This function exports the preferences of each voter as a CSV file.
        /// </summary>
        /// <param name="sender"> exportVotesToolStripMenuItem </param>
        /// <param name="e"> click </param>
        private void votesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Allow for export only when voters' preferences have been entered
            if (exportingPreferencesList.Count() != 0)
            {
                SaveFileDialog saveBuildDialog = new SaveFileDialog();
                saveBuildDialog.Title = "Export Votes As CSV File";
                saveBuildDialog.Filter = "CSV File | *.csv";
                saveBuildDialog.ShowDialog();

                if (saveBuildDialog.FileName != "")
                {
                    StreamWriter streamWriter = new StreamWriter(saveBuildDialog.FileName);

                    // Get the name of each candidates
                    string candidateNames = "";
                    for (int i = 0; i < candidateList.Count(); i++)
                    {
                        if (i == candidateList.Count() - 1)
                        {
                            candidateNames += candidateList[i].getName();
                        }
                        else
                        {
                            candidateNames += candidateList[i].getName() + ",";
                        }
                    }
                    // then write each candidate's name into the CSV file
                    streamWriter.WriteLine(candidateNames);

                    // Get and write each voter's voting preferences into the CSV file
                    for (int i = 0; i < numberOfVoters; i++)
                    {
                        string votingPreferences = "";
                        List<string> currentVote = exportingPreferencesList[i];
                        for (int index = 0; index < currentVote.Count(); index++)
                        {
                            if (index == currentVote.Count() - 1)
                            {
                                // Write "Null" instead of leaving the cell blank
                                if (currentVote[index] == "")
                                {
                                    votingPreferences += "Null";
                                }
                                // Not empty so write whatever the value is
                                else
                                {
                                    votingPreferences += currentVote[index];
                                }
                            }
                            else
                            {
                                // Write "Null" instead of leaving the cell blank
                                if (currentVote[index] == "")
                                {
                                    votingPreferences += "Null,";
                                }
                                // Not empty so write whatever the value is
                                else
                                {
                                    votingPreferences += currentVote[index] + ",";
                                }
                            }
                        }
                        streamWriter.WriteLine(votingPreferences);
                    }
                    streamWriter.Close();
                }
            }
            // Alert user that they cannot export votes because no votes have been entered yet
            else
            {
                MessageBox.Show("Failed to export vote data as no votes have been entered into the system yet!", "Export Error");
            }
        }

        /// <summary>
        /// This function exports the result of each round as a CSV file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void electionOutcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Allow for export only when votes have been calculated
            if (votingRoundsList.Count() != 0)
            {
                SaveFileDialog saveBuildDialog = new SaveFileDialog();
                saveBuildDialog.Title = "Export Votes As CSV File";
                saveBuildDialog.Filter = "CSV File | *.csv";
                saveBuildDialog.ShowDialog();

                if (saveBuildDialog.FileName != "")
                {
                    StreamWriter streamWriter = new StreamWriter(saveBuildDialog.FileName);

                    // Get the name of each candidates
                    string candidateNames = " ,";
                    for (int i = 0; i < candidateList.Count(); i++)
                    {
                        if (i == candidateList.Count() - 1)
                        {
                            candidateNames += candidateList[i].getName();
                        }
                        else
                        {
                            candidateNames += candidateList[i].getName() + ",";
                        }
                    }
                    // then write each candidate's name into the CSV file
                    streamWriter.WriteLine(candidateNames);

                    // Get and write each rounds results into the CSV file
                    for (int i = 0; i < votingRoundsList.Count(); i++)
                    {
                        string roundResult = "Round " + votingRoundsList[i].getRoundNo() + ",";
                        string currentVote = votingRoundsList[i].ToString();
                        currentVote = currentVote.Replace("  |  ", ",");
                        roundResult += currentVote;
                        streamWriter.WriteLine(roundResult);
                    }
                    streamWriter.Close();
                }
            }
            // Alert user that they cannot export votes because votes have not been calculated yet
            else
            {
                MessageBox.Show("Failed to export election outcome as no votes have been not been processed yet!", "Export Error");
            }
        }

        /// <summary>
        /// Ensure the application is terminated when manual form is closed.
        /// </summary>
        /// <param name="sender"> ManualModeFrom </param>
        /// <param name="e"> Form Closing </param>
        private void ManualModeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
