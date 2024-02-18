using usov_402_pr1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var myCompany = new Company("mApple", "Mykolaiv", 500, "IT");

app.MapGet("/", () =>
    $"Назва компанії: {myCompany.Name}\n" +
    $"Місто: {myCompany.Address}\n" +
    $"Кіль-ть працівників: {myCompany.EmployeeCount}\n" +
    $"Сфера діяльності: {myCompany.Industry}\n\n" +
    $"Випадкове  число від 0 до 100 - {myCompany.GetRandomNumber()}"
);

app.Run();
