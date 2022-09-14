namespace RandomDataGenerator
{
    internal class Phone
    {
        public string Number { get; init; }
        public Phone()
        {
            Number = Format();
        }
        public string Format(char Separate = '-')
        {
            string PhoneNum = "";
            Random Rand = new Random();
            int[] RandNums = new int[10];
            for (int i = 0; i < RandNums.Length; i++)
            {
                RandNums[i] = Rand.Next(10);
            }
            if (RandNums[0] == 0 || RandNums[0] == 1)
            {
                RandNums[0] = Rand.Next(2, 10);
            }
            foreach (int i in RandNums)
            {
                PhoneNum += i;
            }
            PhoneNum = PhoneNum.Insert(3, Separate.ToString()).Insert(7, Separate.ToString());
            return PhoneNum;
        }
        public override string ToString()
        {
            return Number;
        }
    }
}



