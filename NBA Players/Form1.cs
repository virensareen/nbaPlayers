using Newtonsoft.Json;

namespace NBA_Players
{
    public partial class Form1 : Form
    {
        private int currentPage = 1;
        private List<Player> allPlayers = new List<Player>();
        private List<string> uniquePositions = new List<string>();

        public Form1()
        {
            InitializeComponent();
            LoadPlayersAsync();
            positionCbx.SelectedIndexChanged += positionCbx_SelectedIndexChanged;
            previousBtn.Click += previousBtn_Click;
            nextBtn.Click += nextBtn_Click;
        }

        private async void LoadPlayersAsync()
        {
            allPlayers = await GetPlayers(currentPage);
            uniquePositions = allPlayers.Select(p => p.Position).Distinct().ToList();           
            positionCbx.Items.AddRange(uniquePositions.ToArray());
            UpdatePlayersBox(allPlayers);
        }

        private async Task<List<Player>> GetPlayers(int page)
        {
            using HttpClient httpClient = new HttpClient();
            var apiUrl = $"https://www.balldontlie.io/api/v1/players?page={page}";
            var jsonResult = await httpClient.GetStringAsync(apiUrl);

            PlayersResponse response = JsonConvert.DeserializeObject<PlayersResponse>(jsonResult);
            return response.Data;
        }

        private void UpdatePlayersBox(List<Player> players)
        {
            playersBox.Items.Clear();
            foreach (Player player in players)
            {
                playersBox.Items.Add(player.FullName);
            }

            previousBtn.Enabled = currentPage > 1;
        }

        private async void nextBtn_Click(object sender, EventArgs e)
        {
            currentPage++;
            allPlayers = await GetPlayers(currentPage);
            UpdatePlayersBox(allPlayers);
        }

        private async void previousBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                allPlayers = await GetPlayers(currentPage);
                UpdatePlayersBox(allPlayers);
            }
        }

        private void positionCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (positionCbx.SelectedIndex >= 0)
            {
                var selectedPosition = uniquePositions[positionCbx.SelectedIndex];
                var filteredPlayers = allPlayers.Where(p => p.Position == selectedPosition).ToList();
                UpdatePlayersBox(filteredPlayers);
            }
        }
    }
}