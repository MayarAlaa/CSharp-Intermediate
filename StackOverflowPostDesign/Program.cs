using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post()
            {
                Title = "What's an interface?",
                Description = "Explains the usage of interfaces.",
                CreationDate = DateTime.Now

            };

            post.UpVote();

            post.UpVote();

            post.UpVote();

            post.DisplayVotesNumber();

            post.DownVote();

            post.UpVote();

            post.DownVote();

            post.DownVote();

            post.DisplayVotesNumber();



        }
    }
}
