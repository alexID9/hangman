namespace hangman
{
    public partial class Form1 : Form
    {
        private List<string> words = new List<string> { "perspecatious", "contemporarian", "translucent", "disxuisition" };
        private string currentWord = "";
        private int incorrectGuesses = 0;
        private const int maxIncorrectGuesses = 6;
        private List<char> guessedLetters = new List<char>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }
        private void NewGame()
        {
            Random random = new Random();
            currentWord = words[random.Next(words.Count)];
            incorrectGuesses = 0;
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            string displayWord = "";
            foreach (char letter in currentWord)
            {
                if (guessedLetters.Contains(letter))
                {
                    displayWord += letter;
                }
                else
                {
                    displayWord += "_";
                }
            }
            wordlbl.Text = displayWord;
            errornum.Text = incorrectGuesses + "";
        }
        private void sendbtn_Click(object sender, EventArgs e)
        {
            char guess = lettertxt.Text.ToLower().FirstOrDefault();
            if (guess != default(char))
            {
                guessedLetters.Add(guess);
                if (!currentWord.Contains(guess))
                {
                    incorrectGuesses++;
                }
                UpdateDisplay();
                if (incorrectGuesses >= maxIncorrectGuesses || !wordlbl.Text.Contains("_"))
                {
                    MessageBox.Show($"The word was: {currentWord}\nYou {(wordlbl.Text.Contains("_") ? "lost" : "won")}!");
                    guessedLetters.Clear();
                    NewGame();
                }
            }
        }
    }
}