using SampleApp.API.Entities;

public interface IUserRepository
{
   User CreateUser(User user);
   List<User> GetUsers();
   User EditUser(User user, Guid id);
   bool DeleteUser(Guid id);
   User FindUserById(Guid id);
}