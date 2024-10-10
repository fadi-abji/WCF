namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }


        public double Multipli(double num1, double num2)
        {
            return num1 * num2;
        }


        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        //public async Task<double> AddAsync(double num1, double num2)
        //{
        //    return await Task.Run(() => num1 + num2);
        //}

        //public async Task<double> DivideAsync(double num1, double num2)
        //{
        //    return await Task.Run(() => num1 / num2);
        //}
        //public async Task<double> MultipliAsync(double num1, double num2)
        //{
        //    return await Task.Run(() => num1 * num2);
        //}

        //public async Task<double> SubAsync(double num1, double num2)
        //{
        //    return await Task.Run(() => num1 - num2);
        //}
    }
}
