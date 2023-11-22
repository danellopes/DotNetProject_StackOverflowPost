partial class Program
{
    static void Main(string[] args)
    {
        Post post = new Post("Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer consectetur, nunc et aliquam dictum, sem erat maximus ipsum, convallis condimentum dui erat eget ipsum. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer facilisis neque eget pretium aliquet. Mauris ut lectus et ipsum hendrerit congue ac ac neque. Maecenas vel nulla dolor. Donec commodo ex vitae egestas tincidunt. Cras et mauris quis sapien placerat lacinia a eget sapien. Nulla facilisi. Nam eget feugiat erat, vitae molestie urna. Mauris posuere euismod mi, at commodo dolor dictum nec. Suspendisse ut ipsum sed ipsum vehicula facilisis venenatis nec est. Praesent consectetur pharetra eros, ac pretium orci auctor quis. Morbi nec egestas nunc, nec molestie sem. Phasellus ut lacinia mi, sit amet lobortis neque. Ut a sapien a velit dignissim venenatis a vel erat. Nullam vulputate efficitur commodo.");

        post.Upvote();
        post.Upvote();
        post.Upvote();
        post.Upvote();
        post.Downvote();

        System.Console.WriteLine("{0}\n{1}\nCriado em: {2}\nVotos: {3}", post.Title, post.Description, post.GetCreatedDate(), post.GetVotes());
    }
}