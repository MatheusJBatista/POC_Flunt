using Flunt.Validations;
using POC_Flunt.Entities;

namespace POC_Flunt.Constracts_Other_Type
{
    public static class CarContracts
    {
        public static Contract<Car> ValidateCreate(this Car car)
        {
            var contract = new Contract<Car>();

            DefaultContractForUpdateAndCreate(contract, car);
            contract.Requires()
                .IsNotNullOrEmpty(car.Color, "Color", "Cor e obrigatorio");

            return contract;
        }

        public static Contract<Car> ValidateUpdate(this Car car)
        {
            var contract = new Contract<Car>();
            DefaultContractForUpdateAndCreate(contract, car);

            return contract;
        }

        public static void DefaultContractForUpdateAndCreate(Contract<Car> contract, Car car)
        {
            contract.Requires()
                .IsNotNullOrEmpty(car.Color, "Color", "Cor e obrigatorio");
        }
    }
}
