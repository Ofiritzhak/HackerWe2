using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerWe.Entities
{
    public class Borowing
    {
        public Guid Id { get; set; }
        public DateTime BorowingDate { get; set; }
        public DateTime DueReturningDate => BorowingDate.AddDays(14);
        public DateTime ReturningDate { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int ClientId { get; set; }
        public Client Client{ get; set; }

        public Borowing()
        {
            Id = Guid.NewGuid();
        }

        public string ToCSV()
        {
            string str;
            str = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", Id, BorowingDate, DueReturningDate, ReturningDate, BookId, Book, ClientId, Client);
            return str;
        }

    }
}
