using LoginTodo.Models;

namespace LoginTodo.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}