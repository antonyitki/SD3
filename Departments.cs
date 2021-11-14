using System;
using System.Collections.Generic;

namespace University 
{ 
    abstract class University
    {
        private List<Student> _students = new List<Student>(); //creation and initialization of empty list

        protected University()
        {
            CreateUniversity();
        }

        public List<Student> Students => _students;

        public abstract void CreateUniversity();
    }

    class Art : University
    {
        public override void CreateUniversity()
        {
            Students.Add(new Picasso());
            Students.Add(new Vanh_Gohj());
        }
    }
    // Different departments of university
    class Science : University
    {
        public override void CreateUniversity()
        {
            Students.Add(new Einstein());
            Students.Add(new Tony());
            Students.Add(new Newton());
        }
    }
    class Social : University
    {
        public override void CreateUniversity()
        {
            Students.Add(new Ammy());
        }
    }
    //Add here more departments if needed
}

