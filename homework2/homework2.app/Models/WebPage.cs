using homework2.app.Interface;

namespace homework2.app.Models
{
    public class WebPage : ISearchable
    {
        public string Html { get; set; }

        public WebPage(string html)
        {
            Html = html;
        }

        public bool Search(string word)
        {
            string[] words = Html.Split(' ', '<', '>', '=', '"');
            foreach (string w in words)
            {
                if (w.ToLower() == word.ToLower())
                return true;
            }
            return false;
        }
    }
}
