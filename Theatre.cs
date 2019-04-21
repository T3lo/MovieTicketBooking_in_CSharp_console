using System;
using System.Collections.Generic;

namespace Util {
    public class Theatre {
        int theatreID;
        string theatreName;
        string cityName;
        string address;
        int numberOfScreens;
        List<Screen> screens;
        public Theatre() {
            Random rand = new Random();
            theatreID = rand.Next();
            theatreName = "Mayajal";
            cityName = "Chennai";
            address = "ECR";
            numberOfScreens = 2;
            createScreens();
        }
        public Theatre(string name, string city, string addr, int nos) {
            Random rand = new Random();
            theatreID = rand.Next();
            theatreName = name;
            cityName = city;
            address = addr;
            numberOfScreens = nos;
            createScreens();
        }
        
        public int getTheatreID() => theatreID;
        public List<Screen> getAllScreens() => screens;

        public void createScreens() {
            screens = new List<Screen>();
            for(int i=0;i<numberOfScreens;i++) {
                screens.Add(new Screen(1000+i));
            }
        }
        public void displayDetails() {
            Console.WriteLine("Theatre ID: {0}", theatreID);
            Console.WriteLine("Theatre Name: {0}", theatreName);
            Console.WriteLine("Theatre city: {0}", cityName);
            Console.WriteLine("Theatre Address: {0}", address);
            Console.WriteLine("Number of Screens: {0}", numberOfScreens);
            foreach(Screen sc in screens) {
                sc.showSeats();
            }
        }
    }
}