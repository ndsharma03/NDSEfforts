using InterviewPractice.Records;
namespace TestProject1
{
    public class RecordTest
    {
        [Fact]
        public void RecordsWithSameValueReturnTrue()
        {
            Person p1 = new Person() { Name = "Niranjan", Age = 30 };
            Person p2 = new Person() { Name = "Niranjan", Age = 30 };
            Assert.Equal(p1, p2);
        }

        [Fact]
        public void RecordsPrintsAllProperties()
        {
            Person p1 = new Person() { Name = "Niranjan", Age = 30 };
            var s=p1.ToString();
            Assert.True(s.Contains("Name = Niranjan"));
        }
        [Fact]
        public void RecordsAreNotImmutableifPropertiesExplicitDeclared()
        {
           
                Person p1 = new Person() { Name = "Niranjan", Age = 30 };
                p1.Name = "NewName";
                Assert.Equal(p1.Name , "NewName");
         
            
        }
        [Fact]
        public void Records_Property_DataType_Should_Implement_IEqutable()
        {

            Employee e1 = new Employee( "Niranjan", 30,new List<string> { "A", "B" } );
            Employee e2 = new Employee("Niranjan", 30, new List<string> { "A", "B" });
            bool result = e1 == e2;

            Assert.False(e1.Equals(e2));


        }
    }
}