using Flunt.Validations;
using POC_Flunt.Entities;

namespace POC_Flunt.Contracts
{
    public class NewCarContract : Contract<Car>
    {
        public NewCarContract(Car car)
        {
            Requires()
                .IsNotNullOrEmpty(car.Name, "Name", "Nome e obrigatorio")
                .IsNotNullOrEmpty(car.Color, "Color", "Cor e obrigatorio");
        }
    }
}
