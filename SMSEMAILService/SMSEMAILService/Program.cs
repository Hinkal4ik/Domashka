using Bogus;
using EmailLib;
using EmailLib.Services;
using EmailLib.Abstracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Bogus.DataSets.Name;

namespace ConsoleIfForArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //List<Student> students = new List<Student>();

            //var testUsers = new Faker<Student>("uk")
            //    .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
            //    .RuleFor(u => u.LastName, (f,u) => f.Name.LastName(u.Gender))
            //    .RuleFor(u => u.FirsttName, (f,u) => f.Name.FirstName(u.Gender))
            //    .RuleFor(u=>u.Email, (f, u)=> f.Internet.Email());

            //using (StreamWriter sw = new StreamWriter("students.txt"))
            //{

            //    for (int i = 0; i < 10; i++)
            //    {
            //        Student s = testUsers.Generate();
            //        students.Add(s);
            //        sw.WriteLine(s);
            //    }
            //}

            //foreach (var student in students)
            //{
            //    Console.WriteLine("\n___________________________________");
            //    Console.WriteLine(student);
            //}


            //SMSService sMSService = new SMSService();
            string phone = "380969132110";
            string text = Console.ReadLine();

            //sMSService.Send(phone, text);

            Message message = new Message();
            message.Body = "<h1>Ви відправили смс цьому номеру: +" + phone + "\n З текстом: " + text + "</h1>";
            message.Subject = "Відправлення смс";
            message.To = "dkhprb@gmail.com";

            IEmailService emailService = new SmtpEmailService();
            emailService.Send(message);
        }
    }
}