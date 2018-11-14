namespace VotingManager
{
    partial class CSVModeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graphGroupBox = new System.Windows.Forms.GroupBox();
            this.voteChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.candidateOverviewGroupBox = new System.Windows.Forms.GroupBox();
            this.candidate10Label = new System.Windows.Forms.Label();
            this.candidate9Label = new System.Windows.Forms.Label();
            this.candidate7Label = new System.Windows.Forms.Label();
            this.candidate8Label = new System.Windows.Forms.Label();
            this.candidate6Label = new System.Windows.Forms.Label();
            this.candidate5Label = new System.Windows.Forms.Label();
            this.candidate4Label = new System.Windows.Forms.Label();
            this.candidate3Label = new System.Windows.Forms.Label();
            this.candidate2Label = new System.Windows.Forms.Label();
            this.candidate1Label = new System.Windows.Forms.Label();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.round0ResultLabel = new System.Windows.Forms.Label();
            this.round9ResultLabel = new System.Windows.Forms.Label();
            this.round8ResultLabel = new System.Windows.Forms.Label();
            this.round7ResultLabel = new System.Windows.Forms.Label();
            this.round6ResultLabel = new System.Windows.Forms.Label();
            this.round4ResultLabel = new System.Windows.Forms.Label();
            this.round5ResultLabel = new System.Windows.Forms.Label();
            this.round3ResultLabel = new System.Windows.Forms.Label();
            this.round2ResultLabel = new System.Windows.Forms.Label();
            this.round1ResultLabel = new System.Windows.Forms.Label();
            this.round0Label = new System.Windows.Forms.Label();
            this.round9Label = new System.Windows.Forms.Label();
            this.round8Label = new System.Windows.Forms.Label();
            this.round7Label = new System.Windows.Forms.Label();
            this.round6Label = new System.Windows.Forms.Label();
            this.round5Label = new System.Windows.Forms.Label();
            this.round4Label = new System.Windows.Forms.Label();
            this.round3Label = new System.Windows.Forms.Label();
            this.round2Label = new System.Windows.Forms.Label();
            this.round1Label = new System.Windows.Forms.Label();
            this.resultStatisticGroupBox = new System.Windows.Forms.GroupBox();
            this.validVoteTotalLabel = new System.Windows.Forms.Label();
            this.votingOutcomeLabel = new System.Windows.Forms.Label();
            this.invalidVoteTotalLabel = new System.Windows.Forms.Label();
            this.totalVoteLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importVotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportVotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electionOutcomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voteChart)).BeginInit();
            this.candidateOverviewGroupBox.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            this.resultStatisticGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphGroupBox
            // 
            this.graphGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphGroupBox.Controls.Add(this.voteChart);
            this.graphGroupBox.Location = new System.Drawing.Point(12, 370);
            this.graphGroupBox.Name = "graphGroupBox";
            this.graphGroupBox.Size = new System.Drawing.Size(314, 188);
            this.graphGroupBox.TabIndex = 8;
            this.graphGroupBox.TabStop = false;
            this.graphGroupBox.Text = "Candidate Votes Bar Graph";
            // 
            // voteChart
            // 
            this.voteChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.voteChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.voteChart.Legends.Add(legend1);
            this.voteChart.Location = new System.Drawing.Point(15, 21);
            this.voteChart.Name = "voteChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Votes";
            this.voteChart.Series.Add(series1);
            this.voteChart.Size = new System.Drawing.Size(293, 161);
            this.voteChart.TabIndex = 0;
            this.voteChart.Visible = false;
            // 
            // candidateOverviewGroupBox
            // 
            this.candidateOverviewGroupBox.Controls.Add(this.candidate10Label);
            this.candidateOverviewGroupBox.Controls.Add(this.candidate9Label);
            this.candidateOverviewGroupBox.Controls.Add(this.candidate7Label);
            this.candidateOverviewGroupBox.Controls.Add(this.candidate8Label);
            this.candidateOverviewGroupBox.Controls.Add(this.candidate6Label);
            this.candidateOverviewGroupBox.Controls.Add(this.candidate5Label);
            this.candidateOverviewGroupBox.Controls.Add(this.candidate4Label);
            this.candidateOverviewGroupBox.Controls.Add(this.candidate3Label);
            this.candidateOverviewGroupBox.Controls.Add(this.candidate2Label);
            this.candidateOverviewGroupBox.Controls.Add(this.candidate1Label);
            this.candidateOverviewGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateOverviewGroupBox.Location = new System.Drawing.Point(12, 27);
            this.candidateOverviewGroupBox.Name = "candidateOverviewGroupBox";
            this.candidateOverviewGroupBox.Size = new System.Drawing.Size(314, 332);
            this.candidateOverviewGroupBox.TabIndex = 3;
            this.candidateOverviewGroupBox.TabStop = false;
            this.candidateOverviewGroupBox.Text = "Candidates Overview";
            // 
            // candidate10Label
            // 
            this.candidate10Label.AutoSize = true;
            this.candidate10Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate10Label.Location = new System.Drawing.Point(7, 298);
            this.candidate10Label.Name = "candidate10Label";
            this.candidate10Label.Size = new System.Drawing.Size(73, 13);
            this.candidate10Label.TabIndex = 9;
            this.candidate10Label.Text = "Candidate 10:";
            // 
            // candidate9Label
            // 
            this.candidate9Label.AutoSize = true;
            this.candidate9Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate9Label.Location = new System.Drawing.Point(7, 268);
            this.candidate9Label.Name = "candidate9Label";
            this.candidate9Label.Size = new System.Drawing.Size(67, 13);
            this.candidate9Label.TabIndex = 8;
            this.candidate9Label.Text = "Candidate 9:";
            // 
            // candidate7Label
            // 
            this.candidate7Label.AutoSize = true;
            this.candidate7Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate7Label.Location = new System.Drawing.Point(7, 208);
            this.candidate7Label.Name = "candidate7Label";
            this.candidate7Label.Size = new System.Drawing.Size(67, 13);
            this.candidate7Label.TabIndex = 7;
            this.candidate7Label.Text = "Candidate 7:";
            // 
            // candidate8Label
            // 
            this.candidate8Label.AutoSize = true;
            this.candidate8Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate8Label.Location = new System.Drawing.Point(7, 238);
            this.candidate8Label.Name = "candidate8Label";
            this.candidate8Label.Size = new System.Drawing.Size(67, 13);
            this.candidate8Label.TabIndex = 6;
            this.candidate8Label.Text = "Candidate 8:";
            // 
            // candidate6Label
            // 
            this.candidate6Label.AutoSize = true;
            this.candidate6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate6Label.Location = new System.Drawing.Point(7, 178);
            this.candidate6Label.Name = "candidate6Label";
            this.candidate6Label.Size = new System.Drawing.Size(67, 13);
            this.candidate6Label.TabIndex = 5;
            this.candidate6Label.Text = "Candidate 6:";
            // 
            // candidate5Label
            // 
            this.candidate5Label.AutoSize = true;
            this.candidate5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate5Label.Location = new System.Drawing.Point(7, 148);
            this.candidate5Label.Name = "candidate5Label";
            this.candidate5Label.Size = new System.Drawing.Size(67, 13);
            this.candidate5Label.TabIndex = 4;
            this.candidate5Label.Text = "Candidate 5:";
            // 
            // candidate4Label
            // 
            this.candidate4Label.AutoSize = true;
            this.candidate4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate4Label.Location = new System.Drawing.Point(7, 118);
            this.candidate4Label.Name = "candidate4Label";
            this.candidate4Label.Size = new System.Drawing.Size(67, 13);
            this.candidate4Label.TabIndex = 3;
            this.candidate4Label.Text = "Candidate 4:";
            // 
            // candidate3Label
            // 
            this.candidate3Label.AutoSize = true;
            this.candidate3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate3Label.Location = new System.Drawing.Point(7, 88);
            this.candidate3Label.Name = "candidate3Label";
            this.candidate3Label.Size = new System.Drawing.Size(67, 13);
            this.candidate3Label.TabIndex = 2;
            this.candidate3Label.Text = "Candidate 3:";
            // 
            // candidate2Label
            // 
            this.candidate2Label.AutoSize = true;
            this.candidate2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate2Label.Location = new System.Drawing.Point(7, 58);
            this.candidate2Label.Name = "candidate2Label";
            this.candidate2Label.Size = new System.Drawing.Size(67, 13);
            this.candidate2Label.TabIndex = 1;
            this.candidate2Label.Text = "Candidate 2:";
            // 
            // candidate1Label
            // 
            this.candidate1Label.AutoSize = true;
            this.candidate1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate1Label.Location = new System.Drawing.Point(7, 28);
            this.candidate1Label.Name = "candidate1Label";
            this.candidate1Label.Size = new System.Drawing.Size(67, 13);
            this.candidate1Label.TabIndex = 0;
            this.candidate1Label.Text = "Candidate 1:";
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultGroupBox.Controls.Add(this.round0ResultLabel);
            this.resultGroupBox.Controls.Add(this.round9ResultLabel);
            this.resultGroupBox.Controls.Add(this.round8ResultLabel);
            this.resultGroupBox.Controls.Add(this.round7ResultLabel);
            this.resultGroupBox.Controls.Add(this.round6ResultLabel);
            this.resultGroupBox.Controls.Add(this.round4ResultLabel);
            this.resultGroupBox.Controls.Add(this.round5ResultLabel);
            this.resultGroupBox.Controls.Add(this.round3ResultLabel);
            this.resultGroupBox.Controls.Add(this.round2ResultLabel);
            this.resultGroupBox.Controls.Add(this.round1ResultLabel);
            this.resultGroupBox.Controls.Add(this.round0Label);
            this.resultGroupBox.Controls.Add(this.round9Label);
            this.resultGroupBox.Controls.Add(this.round8Label);
            this.resultGroupBox.Controls.Add(this.round7Label);
            this.resultGroupBox.Controls.Add(this.round6Label);
            this.resultGroupBox.Controls.Add(this.round5Label);
            this.resultGroupBox.Controls.Add(this.round4Label);
            this.resultGroupBox.Controls.Add(this.round3Label);
            this.resultGroupBox.Controls.Add(this.round2Label);
            this.resultGroupBox.Controls.Add(this.round1Label);
            this.resultGroupBox.Location = new System.Drawing.Point(342, 178);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(339, 380);
            this.resultGroupBox.TabIndex = 9;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result";
            // 
            // round0ResultLabel
            // 
            this.round0ResultLabel.AutoSize = true;
            this.round0ResultLabel.Location = new System.Drawing.Point(74, 27);
            this.round0ResultLabel.Name = "round0ResultLabel";
            this.round0ResultLabel.Size = new System.Drawing.Size(39, 13);
            this.round0ResultLabel.TabIndex = 19;
            this.round0ResultLabel.Text = "- N/A -";
            // 
            // round9ResultLabel
            // 
            this.round9ResultLabel.AutoSize = true;
            this.round9ResultLabel.Location = new System.Drawing.Point(74, 297);
            this.round9ResultLabel.Name = "round9ResultLabel";
            this.round9ResultLabel.Size = new System.Drawing.Size(39, 13);
            this.round9ResultLabel.TabIndex = 18;
            this.round9ResultLabel.Text = "- N/A -";
            // 
            // round8ResultLabel
            // 
            this.round8ResultLabel.AutoSize = true;
            this.round8ResultLabel.Location = new System.Drawing.Point(74, 267);
            this.round8ResultLabel.Name = "round8ResultLabel";
            this.round8ResultLabel.Size = new System.Drawing.Size(39, 13);
            this.round8ResultLabel.TabIndex = 17;
            this.round8ResultLabel.Text = "- N/A -";
            // 
            // round7ResultLabel
            // 
            this.round7ResultLabel.AutoSize = true;
            this.round7ResultLabel.Location = new System.Drawing.Point(74, 237);
            this.round7ResultLabel.Name = "round7ResultLabel";
            this.round7ResultLabel.Size = new System.Drawing.Size(39, 13);
            this.round7ResultLabel.TabIndex = 16;
            this.round7ResultLabel.Text = "- N/A -";
            // 
            // round6ResultLabel
            // 
            this.round6ResultLabel.AutoSize = true;
            this.round6ResultLabel.Location = new System.Drawing.Point(74, 207);
            this.round6ResultLabel.Name = "round6ResultLabel";
            this.round6ResultLabel.Size = new System.Drawing.Size(39, 13);
            this.round6ResultLabel.TabIndex = 15;
            this.round6ResultLabel.Text = "- N/A -";
            // 
            // round4ResultLabel
            // 
            this.round4ResultLabel.AutoSize = true;
            this.round4ResultLabel.Location = new System.Drawing.Point(74, 145);
            this.round4ResultLabel.Name = "round4ResultLabel";
            this.round4ResultLabel.Size = new System.Drawing.Size(39, 13);
            this.round4ResultLabel.TabIndex = 14;
            this.round4ResultLabel.Text = "- N/A -";
            // 
            // round5ResultLabel
            // 
            this.round5ResultLabel.AutoSize = true;
            this.round5ResultLabel.Location = new System.Drawing.Point(74, 177);
            this.round5ResultLabel.Name = "round5ResultLabel";
            this.round5ResultLabel.Size = new System.Drawing.Size(39, 13);
            this.round5ResultLabel.TabIndex = 13;
            this.round5ResultLabel.Text = "- N/A -";
            // 
            // round3ResultLabel
            // 
            this.round3ResultLabel.AutoSize = true;
            this.round3ResultLabel.Location = new System.Drawing.Point(74, 117);
            this.round3ResultLabel.Name = "round3ResultLabel";
            this.round3ResultLabel.Size = new System.Drawing.Size(39, 13);
            this.round3ResultLabel.TabIndex = 12;
            this.round3ResultLabel.Text = "- N/A -";
            // 
            // round2ResultLabel
            // 
            this.round2ResultLabel.AutoSize = true;
            this.round2ResultLabel.Location = new System.Drawing.Point(74, 87);
            this.round2ResultLabel.Name = "round2ResultLabel";
            this.round2ResultLabel.Size = new System.Drawing.Size(39, 13);
            this.round2ResultLabel.TabIndex = 11;
            this.round2ResultLabel.Text = "- N/A -";
            // 
            // round1ResultLabel
            // 
            this.round1ResultLabel.AutoSize = true;
            this.round1ResultLabel.Location = new System.Drawing.Point(74, 57);
            this.round1ResultLabel.Name = "round1ResultLabel";
            this.round1ResultLabel.Size = new System.Drawing.Size(39, 13);
            this.round1ResultLabel.TabIndex = 10;
            this.round1ResultLabel.Text = "- N/A -";
            // 
            // round0Label
            // 
            this.round0Label.AutoSize = true;
            this.round0Label.Location = new System.Drawing.Point(6, 27);
            this.round0Label.Name = "round0Label";
            this.round0Label.Size = new System.Drawing.Size(51, 13);
            this.round0Label.TabIndex = 9;
            this.round0Label.Text = "Round 0:";
            // 
            // round9Label
            // 
            this.round9Label.AutoSize = true;
            this.round9Label.Location = new System.Drawing.Point(6, 297);
            this.round9Label.Name = "round9Label";
            this.round9Label.Size = new System.Drawing.Size(51, 13);
            this.round9Label.TabIndex = 8;
            this.round9Label.Text = "Round 9:";
            // 
            // round8Label
            // 
            this.round8Label.AutoSize = true;
            this.round8Label.Location = new System.Drawing.Point(6, 267);
            this.round8Label.Name = "round8Label";
            this.round8Label.Size = new System.Drawing.Size(51, 13);
            this.round8Label.TabIndex = 7;
            this.round8Label.Text = "Round 8:";
            // 
            // round7Label
            // 
            this.round7Label.AutoSize = true;
            this.round7Label.Location = new System.Drawing.Point(6, 237);
            this.round7Label.Name = "round7Label";
            this.round7Label.Size = new System.Drawing.Size(51, 13);
            this.round7Label.TabIndex = 6;
            this.round7Label.Text = "Round 7:";
            // 
            // round6Label
            // 
            this.round6Label.AutoSize = true;
            this.round6Label.Location = new System.Drawing.Point(6, 207);
            this.round6Label.Name = "round6Label";
            this.round6Label.Size = new System.Drawing.Size(51, 13);
            this.round6Label.TabIndex = 5;
            this.round6Label.Text = "Round 6:";
            // 
            // round5Label
            // 
            this.round5Label.AutoSize = true;
            this.round5Label.Location = new System.Drawing.Point(6, 177);
            this.round5Label.Name = "round5Label";
            this.round5Label.Size = new System.Drawing.Size(51, 13);
            this.round5Label.TabIndex = 4;
            this.round5Label.Text = "Round 5:";
            // 
            // round4Label
            // 
            this.round4Label.AutoSize = true;
            this.round4Label.Location = new System.Drawing.Point(6, 147);
            this.round4Label.Name = "round4Label";
            this.round4Label.Size = new System.Drawing.Size(51, 13);
            this.round4Label.TabIndex = 3;
            this.round4Label.Text = "Round 4:";
            // 
            // round3Label
            // 
            this.round3Label.AutoSize = true;
            this.round3Label.Location = new System.Drawing.Point(6, 117);
            this.round3Label.Name = "round3Label";
            this.round3Label.Size = new System.Drawing.Size(51, 13);
            this.round3Label.TabIndex = 2;
            this.round3Label.Text = "Round 3:";
            // 
            // round2Label
            // 
            this.round2Label.AutoSize = true;
            this.round2Label.Location = new System.Drawing.Point(6, 87);
            this.round2Label.Name = "round2Label";
            this.round2Label.Size = new System.Drawing.Size(51, 13);
            this.round2Label.TabIndex = 1;
            this.round2Label.Text = "Round 2:";
            // 
            // round1Label
            // 
            this.round1Label.AutoSize = true;
            this.round1Label.Location = new System.Drawing.Point(6, 57);
            this.round1Label.Name = "round1Label";
            this.round1Label.Size = new System.Drawing.Size(51, 13);
            this.round1Label.TabIndex = 0;
            this.round1Label.Text = "Round 1:";
            // 
            // resultStatisticGroupBox
            // 
            this.resultStatisticGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.resultStatisticGroupBox.Controls.Add(this.validVoteTotalLabel);
            this.resultStatisticGroupBox.Controls.Add(this.votingOutcomeLabel);
            this.resultStatisticGroupBox.Controls.Add(this.invalidVoteTotalLabel);
            this.resultStatisticGroupBox.Controls.Add(this.totalVoteLabel);
            this.resultStatisticGroupBox.Location = new System.Drawing.Point(342, 27);
            this.resultStatisticGroupBox.Name = "resultStatisticGroupBox";
            this.resultStatisticGroupBox.Size = new System.Drawing.Size(339, 145);
            this.resultStatisticGroupBox.TabIndex = 10;
            this.resultStatisticGroupBox.TabStop = false;
            this.resultStatisticGroupBox.Text = "Final Result Statistics";
            // 
            // validVoteTotalLabel
            // 
            this.validVoteTotalLabel.AutoSize = true;
            this.validVoteTotalLabel.Location = new System.Drawing.Point(14, 61);
            this.validVoteTotalLabel.Name = "validVoteTotalLabel";
            this.validVoteTotalLabel.Size = new System.Drawing.Size(121, 13);
            this.validVoteTotalLabel.TabIndex = 3;
            this.validVoteTotalLabel.Text = "Number of Valid Votes:  ";
            // 
            // votingOutcomeLabel
            // 
            this.votingOutcomeLabel.AutoSize = true;
            this.votingOutcomeLabel.Location = new System.Drawing.Point(43, 120);
            this.votingOutcomeLabel.Name = "votingOutcomeLabel";
            this.votingOutcomeLabel.Size = new System.Drawing.Size(92, 13);
            this.votingOutcomeLabel.TabIndex = 2;
            this.votingOutcomeLabel.Text = "Voting Outcome:  ";
            // 
            // invalidVoteTotalLabel
            // 
            this.invalidVoteTotalLabel.AutoSize = true;
            this.invalidVoteTotalLabel.Location = new System.Drawing.Point(6, 91);
            this.invalidVoteTotalLabel.Name = "invalidVoteTotalLabel";
            this.invalidVoteTotalLabel.Size = new System.Drawing.Size(129, 13);
            this.invalidVoteTotalLabel.TabIndex = 1;
            this.invalidVoteTotalLabel.Text = "Number of Invalid Votes:  ";
            // 
            // totalVoteLabel
            // 
            this.totalVoteLabel.AutoSize = true;
            this.totalVoteLabel.Location = new System.Drawing.Point(37, 32);
            this.totalVoteLabel.Name = "totalVoteLabel";
            this.totalVoteLabel.Size = new System.Drawing.Size(98, 13);
            this.totalVoteLabel.TabIndex = 0;
            this.totalVoteLabel.Text = "Number of Voters:  ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importVotesToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // importVotesToolStripMenuItem
            // 
            this.importVotesToolStripMenuItem.Name = "importVotesToolStripMenuItem";
            this.importVotesToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.importVotesToolStripMenuItem.Text = "Votes";
            this.importVotesToolStripMenuItem.Click += new System.EventHandler(this.importVotesToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportVotesToolStripMenuItem,
            this.electionOutcomeToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportVotesToolStripMenuItem
            // 
            this.exportVotesToolStripMenuItem.Name = "exportVotesToolStripMenuItem";
            this.exportVotesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exportVotesToolStripMenuItem.Text = "Votes";
            this.exportVotesToolStripMenuItem.Click += new System.EventHandler(this.exportVotesToolStripMenuItem_Click);
            // 
            // electionOutcomeToolStripMenuItem
            // 
            this.electionOutcomeToolStripMenuItem.Name = "electionOutcomeToolStripMenuItem";
            this.electionOutcomeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.electionOutcomeToolStripMenuItem.Text = "Election Outcome";
            this.electionOutcomeToolStripMenuItem.Click += new System.EventHandler(this.electionOutcomeToolStripMenuItem_Click);
            // 
            // CSVModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 567);
            this.Controls.Add(this.resultStatisticGroupBox);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.candidateOverviewGroupBox);
            this.Controls.Add(this.graphGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CSVModeForm";
            this.Text = "CSVModeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CSVModeForm_FormClosing);
            this.graphGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voteChart)).EndInit();
            this.candidateOverviewGroupBox.ResumeLayout(false);
            this.candidateOverviewGroupBox.PerformLayout();
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.resultStatisticGroupBox.ResumeLayout(false);
            this.resultStatisticGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox graphGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart voteChart;
        private System.Windows.Forms.GroupBox candidateOverviewGroupBox;
        private System.Windows.Forms.Label candidate10Label;
        private System.Windows.Forms.Label candidate9Label;
        private System.Windows.Forms.Label candidate7Label;
        private System.Windows.Forms.Label candidate8Label;
        private System.Windows.Forms.Label candidate6Label;
        private System.Windows.Forms.Label candidate5Label;
        private System.Windows.Forms.Label candidate4Label;
        private System.Windows.Forms.Label candidate3Label;
        private System.Windows.Forms.Label candidate2Label;
        private System.Windows.Forms.Label candidate1Label;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.Label round0ResultLabel;
        private System.Windows.Forms.Label round9ResultLabel;
        private System.Windows.Forms.Label round8ResultLabel;
        private System.Windows.Forms.Label round7ResultLabel;
        private System.Windows.Forms.Label round6ResultLabel;
        private System.Windows.Forms.Label round4ResultLabel;
        private System.Windows.Forms.Label round5ResultLabel;
        private System.Windows.Forms.Label round3ResultLabel;
        private System.Windows.Forms.Label round2ResultLabel;
        private System.Windows.Forms.Label round1ResultLabel;
        private System.Windows.Forms.Label round0Label;
        private System.Windows.Forms.Label round9Label;
        private System.Windows.Forms.Label round8Label;
        private System.Windows.Forms.Label round7Label;
        private System.Windows.Forms.Label round6Label;
        private System.Windows.Forms.Label round5Label;
        private System.Windows.Forms.Label round4Label;
        private System.Windows.Forms.Label round3Label;
        private System.Windows.Forms.Label round2Label;
        private System.Windows.Forms.Label round1Label;
        private System.Windows.Forms.GroupBox resultStatisticGroupBox;
        private System.Windows.Forms.Label validVoteTotalLabel;
        private System.Windows.Forms.Label votingOutcomeLabel;
        private System.Windows.Forms.Label invalidVoteTotalLabel;
        private System.Windows.Forms.Label totalVoteLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importVotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electionOutcomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportVotesToolStripMenuItem;
    }
}