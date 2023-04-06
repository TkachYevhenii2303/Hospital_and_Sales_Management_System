using Bogus;
using Students_System.Entities;

namespace Students_System.Bogus_Generator
{
    public static class Generator
    {
        public static List<Students> Students { get; set; } = new List<Students>();
        public static List<Courses> Courses { get; set; } = new List<Courses>();
        public static List<Students_Courses> Students_Courses { get; set; } = new List<Students_Courses> ();

        private const int STUDENTS = 100;
        private const int COURSES = 50;    
        private const int STUDENTS_COURSES = 150;

        public static void Generate_all_Data()
        {
            Students = new Faker<Students>()
                .RuleFor(x => x.Students_name, f => f.Name.FullName())
                .RuleFor(x => x.Students_email, (f, x) => f.Internet.Email(x.Students_name))
                .RuleFor(x => x.Students_mobile, f => f.Phone.PhoneNumber("+(38)-0##-###-####"))
                .RuleFor(x => x.Students_birthday, f => f.Date.Past())
                .RuleFor(x => x.Id, _ => Guid.NewGuid()).Generate(STUDENTS);

            Courses = new Faker<Courses>()
                .RuleFor(x => x.Courses_title, f => f.Commerce.ProductName())
                .RuleFor(x => x.Courses_description, f => f.Commerce.ProductDescription())
                .RuleFor(x => x.Courses_start_Date, f => f.Date.Past())
                .RuleFor(x => x.Courses_end_Date, f => f.Date.Future())
                .RuleFor(x => x.Courses_total, f => f.Finance.Amount(250, 2500, 4))
                .RuleFor(x => x.Id, _ => Guid.NewGuid()).Generate(COURSES);

            Students_Courses = new Faker<Students_Courses>()
                .RuleFor(x => x.Students_ID, f => f.PickRandom(Students).Id)
                .RuleFor(x => x.Courses_ID, f => f.PickRandom(Courses).Id)
                .RuleFor(x => x.Id, _ => Guid.NewGuid()).Generate(STUDENTS_COURSES);


            Students_Courses = new Faker<Students_Courses>()
                .RuleFor(x => x.Id, _ => Guid.NewGuid()).Generate(STUDENTS_COURSES);


        }
    }
}
