using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Shared.ViewModels
{
    public class PersonQueryCriteriaViewModel
    {
        public short? PersonId { get; set; }
        public string? PersonNo { get; set; }
        public string? PersonName { get; set; }
        public byte? CityId { get; set; }
        public string? CityName { get; set; }
        public byte? Person_Cat_ID { get; set; } = 0;

    }

}
