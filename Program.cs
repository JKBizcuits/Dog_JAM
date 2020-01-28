
using System;

namespace Dog_JAM
{
	class Dog
	{

		private int age;
		private string name;

		/**
		 * Empty-argument constructor to put object
		 * into a consistent state.
		 */
		public Dog()
		{
			age = 0;
			name = "";
		}//end constructor

		/**
		 * Constructor accepts the age and
		 * name of the dog. This is the preferred
		 * constructor.
		 * @param age
		 * @param name
		 */
		public Dog(int age, string name)
		{

			this.SetAge(age);
			this.SetName(name);

		}//end constructor

		public int CalcDogYears()
		{
			int dogYears = 15 + (this.age - 1) * 7;
			return dogYears;
		}

		/**
		 * Getter for age
		 * @return
		 */
		public int GetAge()
		{
			return age;
		}//end getAge

		/**
		 * Setter for age
		 * Checks the bounds so 
		 * @param age
		 */
		public void SetAge(int age)
		{
			if (age < 0)
				this.age = 0;
			else
				this.age = age;
		}//end setAge

		/**
		 * Getter for name
		 * @return
		 */
		public string GetName()
		{
			return name;
		}//end getName

		/**
		 * Setter for name. Ensures that only
		 * alpha characters are allowed in the name.
		 * @param name
		 */
		public void SetName(string name)
		{
			bool valid = true;
			char[] n = name.ToCharArray();

			foreach (char c in n)
			{
				if (!Char.IsLetter(c))
				{
					valid = false;
					break;
				}
			}

			if (valid)
				this.name = name;
			else
				this.name = "";

		}//end setName
		public override string ToString()
		{
			return "Dog [age=" + GetAge() + ", name=" + GetName() + "]";
		}//end toString


		static void Main(string[] args)
		{
			Dog Timmy = new Dog();
			Dog Lenny = new Dog();
			Dog Jimmy = new Dog(16, "Jimmy");
			Console.WriteLine(Jimmy.CalcDogYears());
			Console.WriteLine(Jimmy.ToString());
			Console.WriteLine(Timmy.CalcDogYears());
			Console.WriteLine(Timmy.ToString());
			Console.WriteLine(Lenny.CalcDogYears());
			Console.WriteLine(Lenny.ToString());
			Lenny.SetAge(10);
			Lenny.SetName("Lenny");
			Console.WriteLine(Lenny.CalcDogYears());
			Console.WriteLine(Lenny.ToString());
		}
	}
}