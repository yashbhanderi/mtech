// namespace Test;

// public class UnitTest1
// {   

//     // Fact is like marking the methods  <--- It is a attribute
//     // Bcz some of methods are just to do some small work and helping main testing methods
//     // So...If Fact Attribute is given <----- It will be tested by xunit
//     // [Fact]
//     public void Test1()
//     {
//         // Arrange. With this action, you prepare all the required data and preconditions.
//         int x = 10;
//         int y = 5;
//         int expected = 15;

//         // Act. This action performs the actual test.
//         int actual = x+y;

//         // Assert. This final action checks if the expected result has occurred.
//         Assert.Equal(expected, actual);
//     }



//     // We want to access class which is in another project
//     // We can't directly use namespace in another project
//     // We hae to get reference in csproj file 


//     // dotnet add reference ..\mtech\mtech.csproj
    
//     // This command will add reference to the Another project
//     // Now we can access any file or class of that project

//     [Fact]
//     public void Test2() {
//         var user = new mtech.User("Yash Bhanderi", 20);

//         // Arrange
//         string _name = user.GetName();

//         // Act
//         string expected = "Yash Bhnderi";

//         // Assert
//         Assert.Equal(expected, _name);

//     }
// }