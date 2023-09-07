
namespace OOPCaseOpgave
{
    // Pasient (: PersonModel) inherits PersonModel atributes.
    // Object "Pasient" inherits from another object "PersonModel" using the ":"
    // Operator.multiple distinct classes inherit from a common base class
    internal class Pasient : PersonModel
    {
        internal string? PhoneNumber;
        public string AssignedDoctor { get; set; }


    }

}

