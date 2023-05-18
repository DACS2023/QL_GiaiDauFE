
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace QuanLyGiaiDau.Models
{
    public class LoaiGiaiDau 
    {

        public int IdloaiGiaiDau { get; set; }

        public bool TrangThai { get; set; }

        public string IdMonTheThao { get; set; }

        public virtual MonTheThao MonTheThao { get; set; }
    }
}