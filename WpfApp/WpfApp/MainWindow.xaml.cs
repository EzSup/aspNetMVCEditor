using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.Core.Models;
using WpfApp.Core.Services;
using WpfApp.Core.Services.Interfaces;
using WpfApp.Core;
using Microsoft.EntityFrameworkCore;
using WpfApp.Core.Repositories;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ICommand PickCourseCommand { get; private set; }
        private readonly ICoursesService _coursesService;
        private readonly IGroupsService _groupsService;
        private readonly IStudentsService _studentsService;
        public List<Course> Courses { get; set; }
        public List<Group> Groups { get; set; }
        public List<Student> Students { get; set; }

        public MainWindow(ICoursesService coursesService, IGroupsService groupsService, IStudentsService studentsService)
        {
            InitializeComponent();
            _coursesService = coursesService;
            _groupsService = groupsService;
            _studentsService = studentsService;
            LoadData();
            DataContext = this;
        }
        private void LoadData()
        {
            Courses = _coursesService.GetAll();
            Groups = _groupsService.GetAll();
            Students = _studentsService.GetAll();
        }
        public void HamburgerMenu_Click(object sender, RoutedEventArgs e)
        {

        }
        public void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }
        public void SelectCourse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PickCourse(object course)
        {
            if (course is Course selectedCourse)
            {
                // Тут ви можете виконати дії з обраним курсом, наприклад, додати його до списку "вибраних" курсів
                // selectedCourse міститиме обраний курс
            }
        }
    }
}
