namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {

        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {          
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(float grade)
        {
            if (grade >= 0 & grade <= 100)
            {
                this.grades.Add(grade);

                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("value is outside the range 0 to 100");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                this.AddGrade(charResult);
            }
            else
            {
                throw new Exception("string is not float number or char letter");
            }
        }
        public override void AddGrade(double grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
        }
        public override void AddGrade(int grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
        }
        public override void AddGrade(char grade)
        {
            switch (char.ToUpper(grade))
            {
                case 'A':
                    AddGrade(100);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(60);
                    break;
                case 'D':
                    AddGrade(40);
                    break;
                case 'E':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
