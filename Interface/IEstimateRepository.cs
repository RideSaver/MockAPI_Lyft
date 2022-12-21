using LyftAPI.Models;

namespace LyftAPI.Interface
{
    public interface IEstimateRepository
    {
        List<Estimate> GetEstimates();
    }
}
