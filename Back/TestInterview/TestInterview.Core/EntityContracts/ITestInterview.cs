using System.Threading.Tasks;

namespace TestInterview.Core.EntityContracts
{
    public interface ITestInterview
    {
        Task<IQuestion[]> Questions();
        Task MarkUnanswered(int questionId);
    }
}