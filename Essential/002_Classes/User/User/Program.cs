using UserProject;

var admin = new User();
admin.Username = "admin";
admin.FirstName = "Semen";
admin.LastName = "Semenov";
admin.Age = 30;

Console.WriteLine(admin.ShowInfo());

Console.ReadKey();
