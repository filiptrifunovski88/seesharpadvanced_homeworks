using homework2.app.Interface;

namespace homework2.app.Models
{
    public class Document : ISearchable
    {
        public string Text { get; set; }

        public Document(string text)
        {
            Text = text;
        }
        public bool Search(string word)
        {
            string[] words = Text.Split(' ', '.', ',', '!', '?', ';', ':');
            foreach (string w in words)
            {
                if (w.ToLower() == word.ToLower()) 
                return true;
            }
            return false;
        }
    }
}
