using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Book {  get; set; }
        public int Chapter { get; set; }
        public int Verse {  get; set; }
        public string JournalEntry {  get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

    }
}
