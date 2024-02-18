namespace usov_402_pr1 {
    public class Company {
        public string Name { get; set; }
        public string Address { get; set; }
        public int EmployeeCount { get; set; }
        public string Industry { get; set; }

        private readonly Random _random = new Random();

        public Company(string name, string address, int employeeCount, string industry) {
            Name = name;
            Address = address;
            EmployeeCount = employeeCount;
            Industry = industry;
        }

        public int GetRandomNumber() {
            return _random.Next(0, 101);
        }
    }

}
