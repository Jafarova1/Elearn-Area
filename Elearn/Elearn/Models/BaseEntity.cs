namespace Elearn.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDelete { get; set; } = false;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        //string DateTime = createDate.ToString("MMMM d");
    }
}
