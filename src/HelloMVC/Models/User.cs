using System;
using System.ComponentModel.DataAnnotations;

namespace HelloMVC.Models
{
    public class User
    {
        // New C# 6 Auto-Property Initializer + blank setter ==> automatically private!
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }

        // New C# 6 String Interpolation feature (warning, it uses the system default culture)
        // + Expression bodied members
        public string IntroduceYourself() => "Hello, I'm \{Name}, I'm \{Age} years old and I live at \{Address}";

        // Equivalent to
        //public string IntroduceYourself()
        //{
        //    var introduction = "Hello, I'm \{Name}, I'm \{Age} years old and I live at \{Address}";
        //    return introduction;
        //}
    }
}
