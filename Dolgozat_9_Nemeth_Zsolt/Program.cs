using KonyvAdat.Models;
using KonyvAdat.Data;
using Microsoft.EntityFrameworkCore;

string[] sorok = File.ReadAllLines(@"c:\adat\9.csv");

if (!sorok.Any())
{

    foreach (var sor in sorok)
    {
        _context.Adatok.Add(new Adatok(sor));
    }
}