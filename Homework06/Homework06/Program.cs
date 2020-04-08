using System;

namespace Homework06
{

    #region Task01


     //Create a class "PhotoAlbum" with a private attribute "numberOfPages".
     //It should also have a public method "GetNumberOfPages", which will return the number of pages.
     //The default constructor will create an album with 16 pages.There will be an additional constructor,
     //with which we can specify the number of pages we want in the album.
     //Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.
     //In main method create a "PhotoAlbum" instance with its default constructor and one with 24 pages.
     //Also create "BigPhotoAlbum" and show the number of pages that the three albums have.


    public class PhotoAlbum
    {
        public PhotoAlbum()
        {
            NumberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }

        private int NumberOfPages;

        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }

    }

    public class BigPhotoAlbum
    {
        public int numberOfPages;
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
    #endregion


    #region Task02


    //In this exercise you are asked to program three simple classes which keep track of the grading of a sample student.
    //The classes are called FirstCourse, SecondCourse, and Project.
    //A FirstCourse encapsulates a course name and a registration of passed/not passed for our sample student.
    //A SecondCourse encapsulates a course name and the grade of the student. For grading we use the grades, 
    //numerical grades 10, 9, 8, 7, 6, 5. You are also welcome use the enumeration.The grade 6 is the lowest passing grade.
    //In both FirstCourse and SecondCourse you should write a method called Passed.
    //The method is supposed to return whether our sample student passes the course.
    //The class Project aggregates two FirstCourse courses and two SecondCourse courses.  
    //You can assume that a project is passed if at least three out of the four courses are passed. 
    //Write a method Passed in class Project which implements this passing policy.
    //In Main method initialize 2 FirstCourse objects, 2 SecondCourse objects and 1 Project object. 
    //Add both FirstCourse and both SecondCourse objects like a properties to Project object. 
    //Call Project's object Passed method to see if the student passed.



    public class FirstCourse
    {
        public FirstCourse(string courseName, bool pass)
        {
            CourseName = courseName;
            passed = pass;
        }

        public bool Passed()
        {
            if (passed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string CourseName;
        public bool passed;
    }

    public class SecondCourse
    {
        public SecondCourse(string courseName, StudentGrades grade)
        {
            CourseName = courseName;
            Grades = grade;
        }

        public string CourseName;
        public StudentGrades Grades;

        public bool Passed()
        {
            if ((int)Grades != 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Project
    {
        public Project(bool courseOne, bool courseTwo, bool courseThree, bool courseFour)
        {
            CourseOne = courseOne;
            CourseTwo = courseTwo;
            CourseThree = courseThree;
            CourseFour = courseFour;
        }

        bool CourseOne;
        bool CourseTwo;
        bool CourseThree;
        bool CourseFour;

        public void Passed()
        {
            bool[] array = { CourseOne, CourseTwo, CourseThree, CourseFour };
            int sumOfCourses = 0;

            foreach (var item in array)
            {
                if (item == true)
                {
                    sumOfCourses++;
                }
            }
            if (sumOfCourses > 2)
            {
                Console.WriteLine($"Student has passed, successifully achieving {sumOfCourses} courses! "); ;
            }
            else
            {
                Console.WriteLine("Studend failed!"); ;
            }
        }

    }

    public enum StudentGrades
    {
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5
    }

    #endregion


    class Program
    {
        static void Main(string[] args)
        {

            #region Task01
            PhotoAlbum albumOne = new PhotoAlbum();
            Console.WriteLine(albumOne.GetNumberOfPages());

            PhotoAlbum albumTwo = new PhotoAlbum(24);
            Console.WriteLine(albumTwo.GetNumberOfPages());

            BigPhotoAlbum bigPhotoAlbum = new BigPhotoAlbum();
            Console.WriteLine(bigPhotoAlbum.GetNumberOfPages());

            Console.ReadLine();

            #endregion

            #region Task02

            var firstCourseOne = new FirstCourse("SEDC", true);
            var firstCourseTwo = new FirstCourse("Seavus", true);

            var secondCourseOne = new SecondCourse("Coding", StudentGrades.Ten);
            var seocndCourseTwo = new SecondCourse("Brainster", StudentGrades.Six);

            Project Grades = new Project(firstCourseOne.Passed(), firstCourseTwo.Passed(), secondCourseOne.Passed(), seocndCourseTwo.Passed());

            Grades.Passed();

            Console.ReadLine();

            #endregion

        }
    }
}