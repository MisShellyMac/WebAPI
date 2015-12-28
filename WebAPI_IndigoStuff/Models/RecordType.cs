using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_IndigoStuff.Models
{
    public class RecordType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string MailTo { get; set; }
        public DateTime DateAdded { get; set; }
        public string Purpose { get; set; }
        public DateTime ExpectedEndDate { get; set; }
    }
}
