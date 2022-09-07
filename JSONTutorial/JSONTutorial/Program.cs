using JsonTutorial;
using System.Text.Json;

//creating an instance of a class
User noah = new User
{
    Id = 1,
    Username = "nphence",
    Password = "password",
    Firstname = "Noah",
    Lastname = "Phence",
    Phone = "411",
    Email = "nphence@gmail.com",
    IsReviewer = true,
    IsAdmin = false
};

//converting the instance into Json
JsonSerializerOptions options = new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true,
    WriteIndented = true,
};

var json = JsonSerializer.Serialize(noah, options);

User? noahConverted = JsonSerializer.Deserialize<User>(json);

var v = 1;