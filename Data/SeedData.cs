using System;
using System.Numerics;
using Microsoft.EntityFrameworkCore;
using assignment.Models;
public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
            GetStudent()
            );
       
    }

    public static List<Student> GetStudent()
    {
        List<Student> Students = new List<Student>() {
            new Student() {
                StudentId = 1,
                FirstName="Jim",
                LastName="Potter",
                MobileNumber="072-345-6789",
                EmailAddress="jimpotter@gmail.com",
                CityOfResidence="Nairobi",
                Specialization="Computer Science"
            },
            new Student() {
                StudentId = 2,
                FirstName="Jane",
                LastName="Douglas",
                MobileNumber="072-345-6789",
                EmailAddress="janedouglas@gmail.com",
                CityOfResidence="Nairobi",
                Specialization="Computer Science"
            },
            new Student(){
                StudentId = 3,
                FirstName="Tom",
                LastName="Gardner",
                MobileNumber="072-345-6789",
                EmailAddress="tomgardner@gmail.com",
                CityOfResidence="Nairobi",
                Specialization="Computer Science"
            },
            new Student(){
                StudentId = 4,
                FirstName="Ann",
                LastName="Lee",
                MobileNumber="072-345-6789",
                EmailAddress="annlee@gmail.com",
                CityOfResidence="Nairobi",
                Specialization="Computer Science"
            },
            new Student(){
                StudentId = 5,
                FirstName="James",
                LastName="Jones",
                MobileNumber="072-345-6789",
                EmailAddress="",
                CityOfResidence="Nairobi",
                Specialization="Computer Science"
            },
            new Student(){
                StudentId = 6,
                FirstName="Susan",
                LastName="Taylor",
                MobileNumber="072-345-6789",
                EmailAddress="susantaylor@gmail.com",
                CityOfResidence="Nairobi",
                Specialization="Computer Science"
            },
            new Student(){
                StudentId = 7,
                FirstName="Peter",
                LastName="White",
                MobileNumber="072-345-6789",
                EmailAddress="peterwhite@gmail.com",
                CityOfResidence="Nairobi",
                Specialization="Computer Science"
            },
            new Student(){
                StudentId = 8,
                FirstName="Philip",
                LastName="Fox",
                MobileNumber="072-345-6789",
                EmailAddress="philpfox@gmail.com",
                CityOfResidence="Nairobi",
                Specialization="Computer Science"
            },
            new Student(){
                StudentId = 9,
                FirstName="Donna",
                LastName="Ray",
                MobileNumber="072-345-6789",
                EmailAddress="donnaray@gmail.com",
                CityOfResidence="Nairobi",
                Specialization="Computer Science"
            }
        };
        return Students;
    }
}
    
    
