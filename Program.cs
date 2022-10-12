/* using EFuniversity.Models;

SeedData.Init(); */

using (var context = new UniversityContext())
{
    var courses = context.Courses.OrderBy(c=> c.Title).ToList(); //création de prédicat
    
    foreach (Course course in courses)
    {
            Console.WriteLine(course);
    }
        
}