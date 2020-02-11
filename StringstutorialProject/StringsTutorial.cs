using System;
using System.Collections.Generic;
using System.Text;

namespace StringstutorialProject {
    class StringsTutorial {
        //Properties
        public string Firstname; //These are now properties in the method, the only function/exist in this method
        public string Lastname;

        //Special Method called Constructor,(name has to be class name) used to give class instance data, doesn't 
        public StringsTutorial() {
            Firstname = "George";
            Lastname = "Meyer";
            }
        public StringsTutorial(string firstname, string lastname) { //first name in constructor is a parameter, Firstname below is a property!
            Firstname = firstname;
            Lastname = lastname;
            }


        //Methods
        public string Fullname() { //First method example
            //var Firstname = "George";
            //var Lastname = "Meyer";

            // var fullname = Firstname + " " + Lastname;
            var fullname = $"{Lastname}, {Firstname}";
            return fullname;
            }
        public string Fullname2() {//Second method example
            //var Firstname = "George";
            //var Lastname = "Meyer";

            var fullname = $"{Firstname} {Lastname}";
            return fullname;
            }
        }
    }
