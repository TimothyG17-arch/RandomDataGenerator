namespace RandomDataGenerator
{
    internal class SSN
    {
        //https://secure.ssa.gov/poms.nsf/lnx/0110201035
        public string Number { get => Number; init => Number = Social(); }
        public SSN()
        {
            Number = Social();
        }
        public string Social()
        {
            string NotSSN = String.Empty;
            Random rand = new Random();
            var NineNineNine = rand.Next(900, 1000).ToString();
            var firstThreeArr = new string[] { "666", NineNineNine, "000" };
            var firstThree = firstThreeArr[rand.Next(3)];
            var secondTwo = "00";
            var last = "0000";
            NotSSN = string.Concat(firstThree, secondTwo, last);
            return NotSSN;
        }
        public override string ToString()
        {
            string Security = Number;
            Security = Security.Insert(3, "-");
            Security = Security.Insert(6, "-");
            return Security;
        }
    }

}