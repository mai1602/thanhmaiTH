using System.ComponentModel.DataAnnotations;

namespace Baitap.Models
{
    public class LopHoc
    {   
        [Key]
        public string MaLopHoc { get; set; }
        public string TenLop { get; set; }
        public string Abc { get; set; }
    }
}