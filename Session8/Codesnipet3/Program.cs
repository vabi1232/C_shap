using System;

namespace Codesnipet3
{
    class IntelliSenseDemo: TimeZone
    
    {
        public override string DaylightName {
            get
            {
                throw new Exception("The method or operationm is not implemented.");
            }
        }
        public override System.Globalization.DaylightTime GetDaylightChanges(int year)
        {
            throw new Exception("The method or operationm is not implemented.");
        }
        public override TimeSpan GetUtcOffset(DateTime time)
        {
            throw new NotImplementedException();
        }
        public override string StandardName => throw new NotImplementedException();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
