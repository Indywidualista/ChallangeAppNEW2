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
            
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
