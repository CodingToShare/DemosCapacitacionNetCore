using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;
using DDD_Demo_API.Comands;
using DDD_Demo_API.Querys;

namespace DDD_Demo_API.ApplicationServices
{
    public class APIServices
    {
        private readonly IPersonRepository _repository;
        private readonly PersonQuerys _personQuerys;

        public APIServices(IPersonRepository repository, PersonQuerys personQuerys)
        {
            _repository = repository;
            _personQuerys = personQuerys;
        }

        public async Task HandleCommand(CreatePersonCommand create)
        {
            var person = new Person(
                PersonId.Create(create.Id));

            person.SetName(PersonName.Create(create.Name));

            await _repository.AddPerson(person);
        }

        public async Task<Person> GetPerson(Guid id)
        {
            return await _personQuerys.GetPersonsByIdAsync(id);
        }
    }
}
