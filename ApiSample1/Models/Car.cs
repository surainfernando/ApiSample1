using ApiSample1.Validations;
using System.ComponentModel.DataAnnotations;

namespace ApiSample1.Models.CarModels
{
    public class Car
    {
        [RangeValidation(5,10,3)]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
