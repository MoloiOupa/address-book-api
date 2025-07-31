using AddressBookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBookAPI.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new AddressBookContext(
                serviceProvider.GetRequiredService<DbContextOptions<AddressBookContext>>());

            if (context.Profiles.Any())
            {
                return;
            }

            context.Profiles.AddRange(
                new Profile
                {
                    FirstName = "Alice",
                    Surname = "Johnson",
                    CoverLetter = "As a junior software engineer with a strong passion for frontend development, I have been honing my skills in Angular and TypeScript through academic projects and freelance work. I enjoy crafting clean, user-friendly interfaces and pay close attention to responsive design principles. My goal is to grow in a collaborative environment where I can learn from experienced developers and contribute to impactful products. I'm highly motivated, detail-oriented, and eager to take on new challenges in a professional setting.",
                    Email = "alice.johnson@example.com",
                    Phone = "123-456-7890",
                    ProfileWebsite = "https://alice.dev",
                    ProfilePicture = "https://example.com/images/alice.jpg"
                },
                new Profile
                {
                    FirstName = "Brian",
                    Surname = "Smith",
                    CoverLetter = "With over 5 years of experience in backend development, I have a deep understanding of .NET Core and REST API architecture. My work has involved building scalable systems, optimizing database queries, and integrating secure authentication solutions. I’m passionate about clean code and applying SOLID principles to backend logic. I’m seeking a team where I can contribute meaningfully while continuing to expand my expertise in microservices and cloud deployments.",
                    Email = "brian.smith@example.com",
                    Phone = "234-567-8901",
                    ProfileWebsite = "https://briansmith.dev",
                    ProfilePicture = "https://example.com/images/brian.jpg"
                },
                new Profile
                {
                    FirstName = "Cynthia",
                    Surname = "Lee",
                    CoverLetter = "I am a mid-level full stack engineer with 3 years of experience developing enterprise web applications using React, Angular, and ASP.NET Core. I excel at collaborating with cross-functional teams to deliver efficient, maintainable solutions. My recent projects involved building multi-tenant SaaS dashboards and integrating third-party APIs. I enjoy solving complex problems and continuously improving performance and scalability across the stack.",
                    Email = "cynthia.lee@example.com",
                    Phone = "345-678-9012",
                    ProfileWebsite = "https://cynthialee.dev",
                    ProfilePicture = "https://example.com/images/cynthia.jpg"
                },
                new Profile
                {
                    FirstName = "Daniel",
                    Surname = "Khan",
                    CoverLetter = "As a recent graduate with a degree in Computer Science, I have built several applications using C#, ASP.NET, and SQL Server. I am eager to join a team where I can grow professionally and put my academic knowledge to practical use. My strengths include analytical thinking, debugging, and a strong foundation in data structures and object-oriented design. I am looking for an environment that values mentorship and encourages innovation.",
                    Email = "daniel.khan@example.com",
                    Phone = "456-789-0123",
                    ProfileWebsite = "https://danielk.dev",
                    ProfilePicture = "https://example.com/images/daniel.jpg"
                },
                new Profile
                {
                    FirstName = "Emily",
                    Surname = "Nguyen",
                    CoverLetter = "I am a senior software engineer with 8+ years of experience building scalable cloud-native applications. My expertise spans across .NET Core, Azure, and containerized microservices. I lead development teams with a focus on agile practices, continuous integration, and clean architecture. I’m passionate about mentoring junior developers and driving continuous improvement in engineering processes. I bring both technical leadership and a strong commitment to delivering high-quality solutions.",
                    Email = "emily.nguyen@example.com",
                    Phone = "567-890-1234",
                    ProfileWebsite = "https://emilycodes.dev",
                    ProfilePicture = "https://example.com/images/emily.jpg"
                },
                new Profile
                {
                    FirstName = "Frank",
                    Surname = "O'Malley",
                    CoverLetter = "Over the past six years, I’ve worked on a variety of software projects including mobile apps, desktop utilities, and web platforms. I am well-versed in Xamarin, WPF, and .NET MAUI, and I enjoy taking a cross-platform approach to software development. My strength lies in adapting quickly to new technologies and delivering reliable, user-centered applications. I value team collaboration, testing best practices, and continuous learning.",
                    Email = "frank.omalley@example.com",
                    Phone = "678-901-2345",
                    ProfileWebsite = "https://frankom.dev",
                    ProfilePicture = "https://example.com/images/frank.jpg"
                },
                new Profile
                {
                    FirstName = "Grace",
                    Surname = "Kim",
                    CoverLetter = "With 5 years of experience in full stack development, I have worked on multiple agile teams delivering robust features using Angular, .NET Core, and PostgreSQL. I take pride in writing clean, maintainable code and advocating for strong test coverage. I’ve recently contributed to a fintech platform where performance and security were top priorities. I enjoy collaborating with product managers and designers to bring intuitive user experiences to life.",
                    Email = "grace.kim@example.com",
                    Phone = "789-012-3456",
                    ProfileWebsite = "https://gracekim.dev",
                    ProfilePicture = "https://example.com/images/grace.jpg"
                },
                new Profile
                {
                    FirstName = "Henry",
                    Surname = "Turner",
                    CoverLetter = "I am an entry-level software developer with a passion for backend systems and API development. I have hands-on experience with C#, ASP.NET Web API, and SQL Server from both personal projects and internships. I am eager to contribute to a fast-paced development team and grow into a backend engineering role. I bring a strong work ethic, curiosity, and a commitment to continuous learning.",
                    Email = "henry.turner@example.com",
                    Phone = "890-123-4567",
                    ProfileWebsite = "https://henrydev.dev",
                    ProfilePicture = "https://example.com/images/henry.jpg"
                },
                new Profile
                {
                    FirstName = "Isabella",
                    Surname = "Lopez",
                    CoverLetter = "As a senior engineer and technical lead, I’ve spent the last decade building and scaling enterprise-grade software systems. I specialize in system architecture, code reviews, and team mentorship. My leadership style emphasizes collaboration, accountability, and long-term maintainability. I’m passionate about fostering inclusive engineering cultures and aligning technology with business goals. I'm excited to bring my experience to new challenges in a leadership capacity.",
                    Email = "isabella.lopez@example.com",
                    Phone = "901-234-5678",
                    ProfileWebsite = "https://isabelladev.dev",
                    ProfilePicture = "https://example.com/images/isabella.jpg"
                },
                new Profile
                {
                    FirstName = "James",
                    Surname = "Wong",
                    CoverLetter = "I am a software engineer with a passion for performance optimization and clean software architecture. Over the past 4 years, I’ve worked with teams to modernize legacy applications and build scalable microservices. My technical strengths lie in C#, Docker, and SQL performance tuning. I thrive in environments that value attention to detail and encourage cross-functional learning. My goal is to build software that is efficient, robust, and a pleasure to maintain.",
                    Email = "james.wong@example.com",
                    Phone = "012-345-6789",
                    ProfileWebsite = "https://jameswong.dev",
                    ProfilePicture = "https://example.com/images/james.jpg"
                }
            );

            context.SaveChanges();
        }
    }
}

