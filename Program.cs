using usov_402_pr1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var myCompany = new Company("mApple", "Mykolaiv", 500, "IT");

app.MapGet("/", () =>
    $"����� ������: {myCompany.Name}\n" +
    $"̳���: {myCompany.Address}\n" +
    $"ʳ��-�� ����������: {myCompany.EmployeeCount}\n" +
    $"����� ��������: {myCompany.Industry}\n\n" +
    $"���������  ����� �� 0 �� 100 - {myCompany.GetRandomNumber()}"
);

app.Run();
