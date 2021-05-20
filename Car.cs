namespace OO_Example_Grp1
{
    public class Car
    {
        // attributes
        public string Rego;
        public int Speed;

        // constructors
        public Car(string rego, int speed)
        {
            this.Rego = rego;
            this.Speed = speed;
        }


        // operations
        public void IncreaseSpeed(int amt) {
            this.Speed += amt;
        }
        public void DecreaseSpeed(int amt) {
            this.Speed -= amt;
        }
    }
}