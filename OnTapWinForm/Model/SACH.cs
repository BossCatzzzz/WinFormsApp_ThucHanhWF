namespace OnTapWinForm.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [Key]
        [StringLength(6)]
        public string MaSach { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSach { get; set; }

        public int NamXB { get; set; }

        public int MaLoai { get; set; }

        public virtual LOAISACH LOAISACH { get; set; }
    }
}
