
using SimpleEFConsoleApp.Data;
using SimpleEFConsoleApp.Domain;

Console.WriteLine("Hello, World!");

//CaseStudy1();

CaseStudy2();

void CaseStudy2() {
    var db = new CustomerDbContext();

    foreach (Customer c in db.Customers) {
        Console.WriteLine(c);
    }

}

void CaseStudy1()
{

    var c1 = new Customer { 
     Name= "Kannan",
     Address= "Koenig",
      
    };

    var db = new CustomerDbContext();
    db.Customers.Add(c1);
    db.SaveChanges();
}