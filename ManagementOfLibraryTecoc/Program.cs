using ManagementOfLibraryTecoc.Controllers;
using ManagementOfLibraryTecoc.Models;
using ManagementOfLibraryTecoc.Repositories;
using ManagementOfLibraryTecoc.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

namespace ManagementOfLibraryTecoc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inyeccion de dependencias manual
            var bookRepository = new BookRepository();
            var userRepository = new UserRepository();
            var loanRepository = new LoanRepository();
            //servicios
            var bookService = new BookService(bookRepository);
            var userService = new UserService(userRepository, loanRepository);
            var loanService = new LoanService(loanRepository, bookRepository);
            //controladores
            var bookController = new BookController(bookService);
            var userController = new UserController(userService);
            var loanController = new LoanController(loanService);
            //ejemplos de uso con datos quemados 
            var book1 = new Book { Id = 1, Title = "Cien Años de Soledad", Author = "Gabriel García Márquez", Gender = "Novela", State = "Disponible" };
            bookController.AddBook(book1);


            var user1 = new User { Id = 1, Name = "Esteban Berrio", IdentificationNumber = "123455", Addres = "Calle falsa 234" };
            userController.AddUser(user1);

            var loan = new Loan { Id = 1, BookId = book1.Id, UserId = user1.Id };
            loanController.AddLoan(loan);


            Console.WriteLine("Prestamo registrado. Fecha de vecimiento: " + loan.ExpirationDate);
        }
    }
}
