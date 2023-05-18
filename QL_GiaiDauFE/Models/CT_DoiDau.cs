using QL_GiaiDauFE.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGiaiDau.Models
{


    public class CT_DoiDau
    {

        public int IdCTDoiDau { get; set; }

        public string IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }

        public string IdDoiDau { get; set; }
        [ForeignKey("IdDoiDau")]
        public virtual DoiDau DoiDau { get; set; }

        public bool TrangThaiTV { get; set; }
    }
}