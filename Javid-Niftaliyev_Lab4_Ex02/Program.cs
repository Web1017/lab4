using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javid_Niftaliyev_Lab4_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOne;
            int studenIdOne;

            Student student = new Student("Anna", 40021);
            Console.WriteLine($"\n Student: {student}");

            LinkedList<Student> listOfStudents = new LinkedList<Student>();

           
            //var list1 = new LinkedList<string>( Student);

            //    list1.AddLast(nameOne);


        }



           // LinkedList<Student> lnkEmployee = new LinkedList<Student>();

        private static void AddLinkedListItem<T>(LinkedList<T> name, LinkedList<T> student)
        {
          // name.AddLast(student);
         

        }


      



    }
}
