using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public record PersonName
    {
        public string Value { get; set; }

        internal PersonName(string value) 
        {
            this.Value = value;
        }

        public static PersonName Create(string value)
        {
            validate(value);
            return new PersonName(value);
        }

        private static void validate(string value)
        {
            if(value== null)
            {
                throw new ArgumentNullException("el valor no puede ser nulo");
            }
        }
    }
}
