using WpfApp.Core.Models;
using WpfApp.Core.Services;
using WpfApp.Core.Services.Interfaces;
using WpfApp.Core;
using Microsoft.EntityFrameworkCore;
using WpfApp.Core.Repositories;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityDbContext>();
            optionsBuilder.UseSqlServer("Server=EZSUP\\SQLEXPRESS;Database=EDUCATION_DATABASE;Trusted_Connection=true;TrustServerCertificate=true;");
            var _dbContext = new UniversityDbContext(optionsBuilder.Options);
            var _coursesService = new CoursesService(new CoursesRepository(_dbContext));
            var _groupsService = new GroupsService(new GroupsRepository(_dbContext));
            var _studentsService = new StudentsService(new StudentsRepository(_dbContext));
            var mainWindow = new MainWindow(_coursesService, _groupsService, _studentsService);
            mainWindow.Show();
        }
    }
}
