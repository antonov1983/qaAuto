namespace ClassesDemo
{
    using System;

    public class Person : IPerson
    {
        //Fields
        private string _name;
        private int _age;

        //Constructors
        public Person()
        {
            this._name = Console.ReadLine();
            this._age = int.Parse(Console.ReadLine());
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //Properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nemoje da e prazno!!!");
                }

                this._name = value;
            }
        }

        public int Age { get; set; }

        public string HairColor { get; set; }


        //Methods
        public string FullName(string firstName, string lastName)
        {
            firstName = "Mariq";
            lastName = "Petrova";

            return firstName + " " + lastName;
        }

        public int Start()
        {
            return 12;
        }


        public static int StartStatic()
        {
            return 12;
        }
    }
}
