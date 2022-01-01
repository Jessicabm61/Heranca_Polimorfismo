namespace Entities.Exercício15
{
    class OutsourcedEmployee : Employee
    {
        public double AddictionalCharge { get; set; }
        public OutsourcedEmployee ()
        {
        }

        public OutsourcedEmployee (string name, int hour, double valuePerHour, double addictionalCharge):
        base (name, hour, valuePerHour)
        {
            AddictionalCharge = addictionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddictionalCharge;
        }

    }
}
