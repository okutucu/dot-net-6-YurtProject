using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Core.Models
{
    public class File : BaseEntity
    {
        [NotMapped]      
        public override DateTime? UpdatedDate { get => base.UpdatedDate; set => base.UpdatedDate = value; }


    }
}
