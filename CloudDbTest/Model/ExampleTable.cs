namespace CloudDbTest.Model
{
    public class ExampleTable
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string purposeOfPayment { get; set; }
        public int incame { get; set; }
        public int expense { get; set; } 

        public ExampleTable()        
        {
            Id = default;
            Date = DateTime.Now;
            purposeOfPayment = "NaN";
            incame = 0;
            expense = 
        }   
    }
}
