﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_IndigoStuff.Models
{
    public class DataRecord
    {
        public int Id { get; set; }
        public int RecordTypeId { get; set; }
        public string Data { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
