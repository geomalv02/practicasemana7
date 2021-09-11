using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicasemana7
{
    class Student
    {
        public int idStudent { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nationality { get; set; }


        //metodo con la coleccion de datos
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{ idStudent=1001, firstName="Pedro", lastName="Sanchez", nationality="El Salvador" },
                new Student{ idStudent=1002, firstName="Ryan", lastName="Reynolds", nationality="Estados Unidos" },
                new Student{ idStudent=1003, firstName="Carlos", lastName="Sierra", nationality="Colombia" },
                new Student{ idStudent=1004, firstName="Sadio", lastName="Kone", nationality="Senegal" },
                new Student{ idStudent=1005, firstName="Maria", lastName="Suarez", nationality="Uruguay" },
            };
            return students; //retornamos la coleccion
        }

    }
}
