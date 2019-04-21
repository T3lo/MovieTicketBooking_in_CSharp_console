using System;
using System.Collections.Generic;
using System.Collections;

namespace Util {
    public class Booking {
        int bookingID;
        DateTime bookingDate;
        int showID;
        string customerName;
        int numberOfSeats;
        string seatType;
        decimal amount;
        string email;
        string bookingStatus;
        List<int> seatNumbers;

        public Booking() {

        }
        public Booking(int showID, string customerName, int numberOfSeats, string seatType, string email) {
            Random rand = new Random();
            this.bookingID = rand.Next();
            this.bookingDate = DateTime.Today;
            this.showID = showID;
            this.customerName = customerName;
            this.numberOfSeats = numberOfSeats;
            this.seatType = seatType;
            this.email = email;
        }

        public void amountToBePaid(Show []shows, Theatre []theatres) {
            int movieID, screenID, theatreID, count=0;
            decimal rate = 0, totalAmount = 0;
            foreach(Show show in shows) {
                if(show.getShowID() == showID) {
                    movieID = show.getMovieID();
                    screenID = show.getScreenID();
                    theatreID = show.getTheatreID();
                    switch(seatType) {
                        case "Platinum":
                            rate = show.getPlatinumSeatRate();
                            break;
                        case "Gold":
                            rate = show.getGoldSeatRate();
                            break;
                        case "Silver":
                            rate = show.getSilverSeatRate();
                            break;
                    }

                    // find out the theatre
                    foreach(Theatre theatre in theatres) {
                        if(theatre.getTheatreID() == theatreID) {
                            List<Screen> screens = theatre.getAllScreens();
                            // find out the screen
                            foreach(Screen screen in screens) {
                                if(screen.getScreenID() == screenID) {
                                    SortedList seats = screen.getSeats();
                                    foreach(int k in seats) {
                                        if(String.Equals(seats[k], "Vacant")) {
                                            count++;
                                            screen.bookSeat(k);
                                            seatNumbers.Add(k);
                                        }
                                        if(count == numberOfSeats) {
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                    }

                    totalAmount = count * rate;

                    break;
                }
            }

            Console.Write("\n\n");
            foreach(int seat in seatNumbers) {
                Console.Write("{0} ", seat);
            }
            Console.WriteLine("\n\nTotal Amount: {0}", totalAmount);
        }
    }
}