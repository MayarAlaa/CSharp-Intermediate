using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostExercise
{
    public class Post
    {
        private int _vote ;


        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

       
        

        public void UpVote()
        {
            _vote = _vote + 1;
            Console.WriteLine("You've up-voted this post");

        }

        public void DownVote()
        {
            _vote = _vote - 1;
            Console.WriteLine("You've down-voted this post");
        }

        public void DisplayVotesNumber()
        {
            Console.WriteLine($"The current vote value is {_vote}");
        }
    }
}
