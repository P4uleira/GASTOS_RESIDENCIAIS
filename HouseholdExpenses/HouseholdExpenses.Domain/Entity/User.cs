namespace HouseholdExpenses.Domain.Entity
{
    public class User
    {
        public Guid IdUser { get; private set; }
        public string Name { get; private set; }
        public  int Age  { get; private set; }

        public User() { }

        public User(string name, int age)
        {
            SetName(name);
            SetAge(age);
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("O nome é obrigatório");

            Name = name;
        }

        public void SetAge(int age)
        {
            if (age > 0)
                throw new ArgumentException("A idade precisa ser maior que zero");

            Age = age;
        }
    }
}
