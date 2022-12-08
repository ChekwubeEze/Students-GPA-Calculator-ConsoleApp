using GPA_APP.Core;

namespace StudentsGPACalculator.UI
{

    public class UserInput
    {
        private List<string> CourseName = new List<string>();
        private List<int> CourseUnit = new List<int>();
        private List<double> Score = new List<double>();

        public void GetInput()
        {
            Console.WriteLine("Enter Number of Courses ");
            int Number = int.Parse(Console.ReadLine());


            for (int i = 1; i <= Number; i += 1)
            {
                Console.WriteLine($"Enter Course Code/Name {i} ");
                string courseName = Console.ReadLine();
                CourseName.Add(courseName);

                Console.WriteLine($"Enter CourseUnit {i} ");
                int courseUnit = int.Parse(Console.ReadLine());
                CourseUnit.Add(courseUnit);

                Console.WriteLine("Enter Your Score ");
                int score = int.Parse(Console.ReadLine());
                Score.Add(score);

            }
            var calculator = new Calculation(CourseName, CourseUnit, Score, Number);
            calculator.GPA();
        }
    }
}
