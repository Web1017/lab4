using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javid_Niftaliyev_Lab4_Ex02
{
    class Student
    {
        public string nameOne { get; set; }
        public int studenIdOne { get; set; }
        //public string name2 { get; set; }
        //public int studenIdTwo { get; set; }
        //public string name3{ get; set; }
        //public int studenIdThree { get; set; }
        //public string name4 { get; set; }
        //public int studenIdFour { get; set; }
        //public string name5 { get; set; }
        //public int studenIdFive { get; set; }
        //,string Name2, int StudenIdTwo,
      //  string Name3, int StudenIdThree, string Name4, int StudenIdFour,string Name5, int StudenIdFive
        public Student(string NameOne, int StudenIdOne)
        {
            nameOne = NameOne;
            studenIdOne = StudenIdOne;

        }


        public override string ToString()
        {
            return String.Format("\nName: {0}, ID:{1}", nameOne, studenIdOne);
        }





    }
}
