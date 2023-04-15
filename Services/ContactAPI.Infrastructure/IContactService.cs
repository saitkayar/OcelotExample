using ContactAPI.Models;

namespace ContactAPI.Infrastructure
{
    public interface IContactService
    {
        public ContactDTO GetContactById(int id);
    }
}
