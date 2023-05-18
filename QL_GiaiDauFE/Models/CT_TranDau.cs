
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

using System.ComponentModel;

namespace QuanLyGiaiDau.Models
{

    public class CT_TranDau
    {
   
        public int IdCTTranDau { get; set; }

        public int IdGiaiDau { get; set; }
 
        public virtual GiaiDau GiaiDau { get; set; }

        public string IdDoiDau { get; set; }

        public virtual DoiDau DoiDau { get; set; }

        public DateTime ThoiGianBatDau { get; set; }

        public int VongDau { get; set; }

        public string SanDau { get; set; }

        public int TiSo { get; set; }

        public string KetQua { get; set; }
    }
}