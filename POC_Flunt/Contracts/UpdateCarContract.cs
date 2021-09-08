using Flunt.Validations;
using POC_Flunt.Entities;

namespace POC_Flunt.Contracts
{
    public class UpdateCarContract : Contract<Car>
    {
        public UpdateCarContract(Car car)
        {
            Requires()
                .IsNotNullOrEmpty(car.Color, "Color", "Cor e obrigatorio");
        }
    }
}
