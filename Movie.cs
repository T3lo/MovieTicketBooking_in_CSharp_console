using System;

namespace Util {
    public class Movie {
        int movieID;
        string movieName;
        string director;
        string producer;
        string cast;
        double duration;
        string story;
        string type;            // "running" or "upcoming"

        public Movie() {
            Random rand = new Random();
            movieID = rand.Next();
            setDefaultValues();
        }
        Movie(string name, string dir, string prod, string cast, double dur, string story, string type) {
            movieName = name;
            director = dir;
            producer = prod;
            this.cast = cast;
            duration = dur;
            this.story = story;
            this.type = type;
        }

        public void setDefaultValues() {
            movieName = "The Hills Have Eyes";
            director = "Alexandre Aja";
            producer = " Craven-Maddalena Films";
            cast = "Ted Levine, Kathleen Quinlan, Dan Byrd";
            duration = 107;
            story = "A suburban American family is being stalked by a group of psychotic people who live in the desert, far away from civilization.";
            type = "running";
        }
        public void displayDetails() {
            Console.WriteLine("MovieID: {0}", movieID);
            Console.WriteLine("Name: {0}", movieName);
            Console.WriteLine("Director: {0}", director);
            Console.WriteLine("Producer: {0}", producer);
            Console.WriteLine("Cast: {0}", cast);
            Console.WriteLine("Duration: {0}", duration);
            Console.WriteLine("Story: {0}", story);
            Console.WriteLine("Type: {0}", type);
        }
    }
}