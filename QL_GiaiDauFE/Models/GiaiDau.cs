
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace QuanLyGiaiDau.Models
{
    public class GiaiDau
    {

        public int IdGiaiDau { get; set; }

       
        public string TenGiaiDau { get; set; }

        public DateTime NgayBatDau { get; set; }

       

        public string MoTa { get; set; }


        public string DiaDiem { get; set; }

        public bool TrangThai { get; set; }

        public virtual LoaiGiaiDau LoaiGiaiDau { get; set; }

    }
}
