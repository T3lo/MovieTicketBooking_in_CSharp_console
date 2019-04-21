using System;
using System.Collections;

namespace Util {
    public class Screen {
        int screenID;
        SortedList seats;

        public Screen() {}
        public Screen(int id) {
            screenID = id;
            seats = new SortedList();
            for(int i=0;i<5;i++) {                  // ** change 5 to 50 in the end
                seats.Add((i+1), "Vacant");
            }
        }

        public int getScreenID() => screenID;
        public SortedList getSeats() => seats;

        public void bookSeat(int seatNum) {
            // seats.Remove(seatNum);
            // seats.Add(seatNum, "Reserved");
            seats[seatNum] = "Reserved";
        }
        public void showSeats() {
            Console.WriteLine("\nScreenID : {0}", screenID);
            ICollection key = seats.Keys;
            foreach(int k in key) {
                Console.WriteLine("Seat #{0} : {1} ", k, seats[k]);
            }
        }
    }
}