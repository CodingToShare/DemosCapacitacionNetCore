using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public record PersonId
    {
        public Guid Value { get; init; }

        internal PersonId(Guid value)
        {
            Value = value;
        }
        public static PersonId Create(Guid value) 
        {
            return new PersonId(value);
        }
        public static implicit operator Guid(PersonId personId)
        {
            return personId.Value;
        }
    }
}
