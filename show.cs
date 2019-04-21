using System;

namespace Util {
    public class Show {
        int showID;
        int movieID;
        int theatreID;
        int screenID;
        DateTime startDate;
        DateTime endDate;
        decimal platinumSeatRate;
        decimal goldSeatRate;
        decimal silverSeatRate;

        public Show() {

        }
        public Show(int movieID, int theatreID, int screenID, DateTime startDate, DateTime endDate, decimal platinumSeatRate, decimal goldSeatRate, decimal silverSeatRate) {
            Random rand = new Random();
            showID = rand.Next();
            this.movieID = movieID;
            this.theatreID = theatreID;
            this.screenID = screenID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.platinumSeatRate = platinumSeatRate;
            this.goldSeatRate = goldSeatRate;
            this.silverSeatRate = silverSeatRate;
        }

        public int getShowID() => showID;
        public int getMovieID() => movieID;
        public int getTheatreID() => theatreID;
        public int getScreenID() => screenID;
        public decimal getPlatinumSeatRate() => platinumSeatRate;
        public decimal getGoldSeatRate() => goldSeatRate;
        public decimal getSilverSeatRate() => silverSeatRate;

        public void displayShowDetails() {
            Console.WriteLine("ShowID: {0}", showID);
            Console.WriteLine("MovieID : {0}", movieID);
            Console.WriteLine("TheatreID: {0}", theatreID);
            Console.WriteLine("ScreenID: {0}", screenID);
            Console.WriteLine("StartDate: {0}", startDate);
            Console.WriteLine("EndDate: {0}", endDate);
            Console.WriteLine("platinumSeatRate: {0}", platinumSeatRate);
            Console.WriteLine("gsr: {0}", goldSeatRate);
            Console.WriteLine("ssr: {0}", silverSeatRate);
        }
    }
}