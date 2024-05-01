using System;
public class Person
	{
		public string firstName;
        public string lastName;
        public Person(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public static void Main(){
             var p1 = new Person("Tom", "Turbo");
            (string firstName, string lastName) = p1;
            Console.WriteLine( firstNa+" "+ lastName);
            Console.ReadLine();
        }
    }