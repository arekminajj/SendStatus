using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace SendStatus.Models
{
    public class Status
    {
        public string lineOne { get; set; }
        public string lineTwo { get; set; }
        public int Id { get; set; }
    }
}
