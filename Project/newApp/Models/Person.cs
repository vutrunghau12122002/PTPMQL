namespace PTPMQL.Models
{
    public class Person
    {
        public string Hovaten { get; set; }
        public string CMT { get; set; }
        public void NhapThongTin()
        {
            System.Console.WriteLine("Hovaten =");
            Hovaten = Console.ReadLine();
            
            System.Console.WriteLine("CMT =");
            CMT = Console.ReadLine();
            
        }
        public void HienThi()
        {
            System.Console.WriteLine("{0}-{1}", Hovaten, CMT);
        }

    }

}