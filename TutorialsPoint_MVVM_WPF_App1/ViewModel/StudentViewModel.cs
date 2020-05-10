using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialsPoint_MVVM_WPF_App1.Model;

namespace TutorialsPoint_MVVM_WPF_App1.ViewModel
{
    class StudentViewModel
    {
        public StudentViewModel()
        {
            LoadStudents();
        }

        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "Mark", LastName = "Allain" });
            students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
            students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });

            Students = students;
        }
    }
}
