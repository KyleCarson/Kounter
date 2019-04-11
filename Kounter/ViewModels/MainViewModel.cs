namespace Kounter.ViewModels
{
    using System.Linq;

    public class MainViewModel : BaseViewModel
    {
        private string text;

        private int characters;

        private int words;

        public string Text
        {
            get => this.text;

            set
            {
                this.text = value;

                this.OnTextChanged();

                this.NotifyPropertyChanged();
            }
        }

        public int Characters
        {
            get => this.characters;

            set
            {
                this.characters = value;

                this.NotifyPropertyChanged();
            }
        }
        
        public int Words
        {
            get => this.words;

            set
            {
                this.words = value;

                this.NotifyPropertyChanged();
            }
        }

        private void OnTextChanged()
        {
            this.CountCharacters();

            this.CountWords();
        }

        private void CountCharacters()
        {
            this.Characters = this.Text.Length;
        }

        private void CountWords()
        {
            var nonEmptyWords = this.Text.Split(' ').Where(word => word != string.Empty);

            this.Words = nonEmptyWords.Count();
        }
    }
}
