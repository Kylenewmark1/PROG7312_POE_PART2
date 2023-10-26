using DeweyDecimalLibrary.Other;

namespace Dewey_Decimal_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // Button click event to start sorting call numbers game
        private void btnSortCallNos_Click(object sender, EventArgs e)
        {
            // Set the game mode for sorting call numbers
            Global.SortCallingNos = true;

            // Set the specific game mode (Game 1) and navigate to difficulty selection
            Global.Game1 = true;
            Global.Game2 = false;
            Global.Game3 = false;

            // Navigate to the difficulty level selection form
            frmDifficultyLevel frmDifficultyLevel = new frmDifficultyLevel();
            this.Hide();
            frmDifficultyLevel.ShowDialog();
        }

        // Button click event to view sorting call numbers leaderboard
        private void btnSortCallNosLeaderboard_Click(object sender, EventArgs e)
        {
            // Set the specific game mode (Game 1) and navigate to the leaderboard
            Global.Game1 = true;
            Global.Game2 = false;
            Global.Game3 = false;

            // Navigate to the leaderboard form
            Leaderboard frmLeaderboard = new Leaderboard();
            this.Hide();
            frmLeaderboard.ShowDialog();
        }

        // Button click event to start identifying areas game
        private void btnIdentifyingAreas_Click(object sender, EventArgs e)
        {
            // Set the specific game mode (Game 2) and navigate to difficulty selection
            Global.Game1 = false;
            Global.Game2 = true;
            Global.Game3 = false;

            // Navigate to the difficulty level selection form
            frmDifficultyLevel frmDifficultyLevel = new frmDifficultyLevel();
            this.Hide();
            frmDifficultyLevel.ShowDialog();
        }

        // Button click event to view identifying areas leaderboard
        private void btnIdentifyingAreaLeaderboard_Click(object sender, EventArgs e)
        {
            // Set the specific game mode (Game 2) and navigate to the leaderboard
            Global.Game1 = false;
            Global.Game2 = true;
            Global.Game3 = false;

            // Navigate to the leaderboard form
            Leaderboard sortingCallNoLeaderboard = new Leaderboard();
            this.Hide();
            sortingCallNoLeaderboard.ShowDialog();
        }

        // Button click event for the finding call numbers game (upcoming feature)
        private void btnFindingCallNumbers_Click(object sender, EventArgs e)
        {
            // Show a message box indicating the feature is coming soon
            MessageBox.Show("Coming out soon!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Button click event to view the leaderboard for the finding call numbers game (upcoming feature)
        private void FindingCallNumbersLeaderboard_Click(object sender, EventArgs e)
        {
            // Show a message box indicating the feature is coming soon
            MessageBox.Show("Coming out soon!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
