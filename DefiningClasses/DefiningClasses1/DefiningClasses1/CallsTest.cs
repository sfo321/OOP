namespace DefiningClasses1
{
    using System;

    class CallsTest
    {
        private const decimal PricePM = 0.37M;
        public static void CallTest()
        {
            MobilePhone TestGSM = new MobilePhone(" ", "Sony", 500, "Ahmed",
                new Battery(BatteryType.ChineseDog, 5, 12), new Display(5, 1200000));


            TestGSM.AddCall(new Call("0896895213", 120));
            TestGSM.AddCall(new Call("0888745695", 150));
            TestGSM.AddCall(new Call("0899985231", 45));
            TestGSM.AddCall(new Call("0866854897", 193));

            Console.WriteLine(". . . . Calls History: . . . .\n");
            TestGSM.CallInfo();
            Console.WriteLine("Total Calls Cost:");
            TestGSM.CallPrice();
            Console.WriteLine("Longest Call Removed");
            TestGSM.RemoveLongestCall();
            Console.WriteLine("Calls Cost after removing longest call:");
            TestGSM.CallPrice();
            TestGSM.ClearHistory();
            Console.WriteLine("Call history cleared!!!");           
        }
    }
}
