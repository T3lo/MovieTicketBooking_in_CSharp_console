using System;

namespace Util {
    public class User {
        string userName;
        string password;
        string userType;

        public User() {

        }
        public User(string usr, string pwd, string type) {
            userName = usr;
            password = pwd;
            userType = type;
        }
    }
}