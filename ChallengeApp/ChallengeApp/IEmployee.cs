using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        Statistics GetStatistics();

        event GradeAddedDelegate GradeAdded;

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(char grade);
    }
}
