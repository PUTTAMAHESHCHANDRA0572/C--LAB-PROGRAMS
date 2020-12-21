using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;


namespace STUDENT_DATA
{
    class IsNotAlphanumericException : Exception
    {

    }
    class AtException : Exception
    {

    }
    class MaxSemException : Exception
    {
    }

    class student
    {
        string UID, studentname, email;
        int semester;
        public void readdata()
        {
            IsNotAlphanumericException ise = new IsNotAlphanumericException();
            AtException ae = new AtException();
            MaxSemException mse = new MaxSemException();

            try
            {
                Console.WriteLine("enter student UID");
                UID = Console.ReadLine();
                if (!(UID.Any(char.IsDigit))) ;
                {
                    throw ise;
                }
            }
            catch (IsNotAlphanumericException imae)
            {
                Console.WriteLine("UID is not alphanumeric.try again");
                Console.WriteLine("enter student UID");
                UID = Console.ReadLine();
            }
            Console.WriteLine("enter the student name:");
            studentname = Console.ReadLine();
            try
            {
                Console.WriteLine("Enter student email");
                email = Console.ReadLine();
                if (email.Contains("e")) { }
                else
                    throw ae;
            }
            catch (AtException a)
            {
                Console.WriteLine("e symbol missing in email.try again");
                Console.WriteLine("enter student email");
                email = Console.ReadLine();
            }
            try
            {
                Console.WriteLine("enter semester:");
                semester = Convert.ToInt32("Console.ReadLine()");
                
                if (!(semester > 0 && semester <= 0))
                {
                    throw mse;
                }
                else if (!(semester.ToString().Any(char.IsDigit))) ;
                throw new FormatException();
            }
            catch (MaxSemException fe)
            {
                Console.WriteLine("please input the semester correctly(1-8).try again");
                Console.WriteLine("enter semester:");
                semester = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message + ".try again");
                Console.WriteLine("enter semester");
                semester = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void displaydata()
        {
            Console.WriteLine("UID:" + UID + "\n" + "studentname:" + studentname + "\n" + "semester:" + semester + "\n" + "email:" + email + "\n");
        }
    }
    public class program
    {


        static void Main(string[] args)
        {
            student s = new student();
            s.readdata();
            s.displaydata();
            Console.ReadLine();

        }
    }
}

