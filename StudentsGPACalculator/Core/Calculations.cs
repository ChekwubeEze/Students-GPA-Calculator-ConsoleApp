using StudentsGPACalculator.Common;

namespace GPA_APP.Core
{
    public class Calculation
    {
        private List<string> CourseName;
        private List<int> CourseUnit;
        private List<double> Score;
        private List<int> GradeUnit = new List<int>();
        private List<string> Remark = new List<string>();
        private List<string> Grade = new List<string>();
        private List<int> WeightPoint = new List<int>();
        int numberOfCourse;


        public Calculation(List<string> CourseName, List<int> CourseUnit, List<double> Score, int Number)
        {
            this.CourseName = CourseName;
            this.CourseUnit = CourseUnit;
            this.Score = Score;
            numberOfCourse = Number;
        }
        public void GPA()
        {
            for (int i = 0; i < Score.Count; i++)
            {
                if (Score[i] >= 70 && Score[i] <= 100)
                {
                    GradeUnit.Add(5);
                    Grade.Add("A");
                    Remark.Add("Excellent");
                }
                else if (Score[i] >= 60 && Score[i] <= 69)
                {
                    GradeUnit.Add(4);
                    Grade.Add("B");
                    Remark.Add("Very Good");
                }
                else if (Score[i] >= 50 && Score[i] <= 59)
                {
                    GradeUnit.Add(3);
                    Grade.Add("C");
                    Remark.Add("Good");
                }
                else if (Score[i] >= 45 && Score[i] <= 49)
                {
                    GradeUnit.Add(2);
                    Grade.Add("D");
                    Remark.Add("Fair");
                }
                else if (Score[i] >= 40 && Score[i] <= 44)
                {
                    GradeUnit.Add(1);
                    Grade.Add("E");
                    Remark.Add("Pass");
                }
                else
                {
                    GradeUnit.Add(0);
                    Grade.Add("F");
                    Remark.Add("Fail");
                }
            }
            for(int i=0;i<numberOfCourse; i++)
            {
                WeightPoint.Add(CourseUnit[i] * GradeUnit[i]);

            }
            int TotalCreditUnit = 0;
            int TotalCreditpassed = 0;
            int TotalWeightPoint = 0;
            int widthOfTable = 85;
            Console.Clear();
            //var print = new printTable();
            printTable.PrintLine(widthOfTable);
            printTable.PrintRow(widthOfTable, "CourseName","CourseUnit","Score","Grade","GradeUnit","WeightPoint","Remark");
            printTable.PrintLine(widthOfTable);
            for(int i = 0;i<numberOfCourse;i++)
            {
                printTable.PrintRow(widthOfTable, CourseName[i].ToString(), CourseUnit[i].ToString(), Score[i].ToString(), Grade[i].ToString(), GradeUnit[i].ToString(), WeightPoint[i].ToString(), Remark[i].ToString());
                TotalCreditUnit += CourseUnit[i];
                TotalWeightPoint += WeightPoint[i];
                if (Grade[i] != "F")
                {
                    TotalCreditpassed += CourseUnit[i];
                }
            }
            
            printTable.PrintLine(widthOfTable);

            double GPA = TotalWeightPoint / TotalCreditUnit;
            string GPATo2DP = Math.Round(GPA, 2).ToString("0.00");

            Console.WriteLine($"Total Course Unit offered is : {TotalCreditUnit}");
            Console.WriteLine($"Total Course Unit Passed is : {TotalCreditpassed}");
            Console.WriteLine($"Total weightPoint is : {TotalWeightPoint}");
            Console.WriteLine($"Grade Point Average(GPA) is: {GPATo2DP}");
            
        }
    }
}
