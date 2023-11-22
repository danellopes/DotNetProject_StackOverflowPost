partial class Program
{
    public class Post
    {
        public string Title = "";
        public string Description = "";
        private DateTime CreatedDate;
        private int Votes = 0;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreatedDate = DateTime.Now;
        }

        public int GetVotes()
        {
            return this.Votes;
        }

        public void Upvote()
        {
            this.Votes++;
        }

        public void Downvote()
        {
            this.Votes--;
        }

        public DateTime GetCreatedDate()
        {
            return this.CreatedDate;
        }
    }
}