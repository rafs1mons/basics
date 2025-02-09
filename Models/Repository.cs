﻿namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course() { Id = 1, Title ="aspnet kursu", Description =" guzel kurs",Image ="course1.jpg",Tags=["Web Gelistirme",".Net"],IsActive =true,IsHome=true},
                new Course() { Id = 2, Title ="php kursu", Description =" guzel kurs",Image ="course2.jpg",Tags=["Web Gelistirme","Framework"],IsActive =true,IsHome=true},
                new Course() { Id = 3, Title ="java kursu", Description =" guzel kurs",Image ="course3.jpeg",Tags=["Mobil gelistirme","Linux"],IsActive =true,IsHome=true},
                new Course() { Id = 3, Title ="javascript kursu", Description =" guzel kurs",Image ="course1.jpg",Tags=["Mobil gelistirme","Web Gelistirme"],IsActive =false,IsHome=true},
            };
        }
        public static List<Course> Courses { get { return _courses; } }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}
