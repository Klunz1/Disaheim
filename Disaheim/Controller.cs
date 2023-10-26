﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        
        //properties
        public List<Book> Books { get; set; }

        public List<Amulet> Amulets { get; set; }

        public List<Course> Courses { get; set; }
        
        //Initialiser properties i constructor
        public Controller()
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();
            Courses= new List<Course>();

        }
        //de to metoder der tilføjer bøger og amuletter
        public void AddToList(Book book) 
        { 
            Books.Add(book);
        }
        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
        public void AddToList(Course course) 
        {
            Courses.Add(course);
        }
                
        
    }
}
