

using ContactAPI.Infrastructure;
using ContactAPI.Models;

namespace ContactAPI.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int id)
        {
            return new ContactDTO { Id = id,FirstName="sait",LastName="kayar" };

        }
    }
}
