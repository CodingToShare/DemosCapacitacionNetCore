using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.Domain.ValueObjects;

namespace DDD_Demo_API.Querys
{
    public class PersonQuerys
    {
        private readonly IPersonRepository _repository;

        public PersonQuerys(IPersonRepository personRepository)
        {
            _repository = personRepository;
        }

        public async Task<Person> GetPersonsByIdAsync(Guid id)
        {
            var response = await _repository.GetPersonById(PersonId.Create(id));

            return response;
        }
    }
}
