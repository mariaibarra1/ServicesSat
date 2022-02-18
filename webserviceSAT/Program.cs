using System;
using ServiceReference2;

namespace webserviceSAT
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference2.ConsultaCFDIServiceClient consulta = new ConsultaCFDIServiceClient();
            var x = consulta.ConsultaAsync("re=MNM9102019A5&rr=SARL831116NJ5&tt=4337.00&id=614C7879-A448-4499-85A9-483C251BDD12");
            Console.WriteLine("Hello World!");

            Console.WriteLine(x.Result.CodigoEstatus );
            Console.WriteLine(x.Result.Estado);
            Console.WriteLine(x.Result.EsCancelable);
            Console.WriteLine(x.Result.EstatusCancelacion);



 }
    }
}
