using BlazorAssignment.Models;

namespace BlazorAssignment.Data
{
    public interface ServiceInterface
    {
        User ValidateUser(string userName, string password);
    }
}
