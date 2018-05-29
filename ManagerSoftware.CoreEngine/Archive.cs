using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerSoftware.CoreEngine
{
    public class Archive : IComparable<Archive>
    {
        public string Name { get; set; }
        public DateTime ArchiveDate { get; set; }
        public int Id { get; set; }

        public Archive(string Name, DateTime ArchiveDate, int Id)
        {
            this.Name = Name;
            this.ArchiveDate = ArchiveDate;
            this.Id = Id;
        }
        public int CompareTo(Archive other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.Name.CompareTo(other.Name);
            }
        }
    }
}