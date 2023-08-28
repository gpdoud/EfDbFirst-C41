// See https://aka.ms/new-console-template for more information
using EfDbFirst.Models;

var _context = new PrsDbC41Context();

var users = _context.Users.ToList();

foreach(var user in users) {
    Console.WriteLine($"{user.Firstname} {user.Lastname}");
}
