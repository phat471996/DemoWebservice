//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoConnectWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SoGD
    {
        public string MaSGD { get; set; }
        public string TenSGD { get; set; }
        public string MatKhau { get; set; }
        public string MaBGD { get; set; }
        public string MaQuyen { get; set; }
    
        public virtual PHANQUYEN PHANQUYEN { get; set; }
    }
}
