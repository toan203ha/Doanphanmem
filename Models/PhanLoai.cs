﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doanphanmem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PhanLoai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhanLoai()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public int MaLoai { get; set; }
        [StringLength(20, ErrorMessage = " không được vượt quá 20 ký tự.")]
        [Required(ErrorMessage = "Chưa Điền Thông Tin Tên Loại Sản Phẩm.")]
        public string Tenloai { get; set; }
        //[Required(ErrorMessage = "Chưa Chọn Hình.")]
        public string HinhLoai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
