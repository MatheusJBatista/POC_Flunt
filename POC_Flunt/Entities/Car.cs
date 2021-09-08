using Flunt.Notifications;
using Flunt.Validations;
using POC_Flunt.Constracts_Other_Type;
using POC_Flunt.Contracts;
using System;
using System.Linq;

namespace POC_Flunt.Entities
{
    public class Car : Notifiable<Notification>
    {
        public Car(string name, string color, bool arvore)
        {
            Name = name;
            Color = color;
            Arvore = arvore;

            //AddNotifications(new NewCarContract(this));
            CheckIfIsValid(this.ValidateCreate());
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public bool Arvore { get; set; }

        public void Update(string color, bool arvore)
        {
            Color = color;
            Arvore = arvore;

            //CheckIfIsValid(new UpdateCarContract(this));
            CheckIfIsValid(this.ValidateUpdate());
        }

        private void CheckIfIsValid(Contract<Car> contract)
        {
            AddNotifications(contract);
            if (!IsValid)   
                throw new Exception(Notifications.FirstOrDefault().Message);
        }
    }
}
