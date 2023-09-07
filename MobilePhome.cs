namespace OOPCaseOpgave
{
    public class MobilePhome
    {
        public int PhoneNumber { get; set; }

        public MobilePhome() { }

        public override string ToString()
        {
            return PhoneNumber.ToString();
        }
    }
}