using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Arac : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Marka Adı"), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public int MarkaId { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public string Renk { get; set; }
        [Display(Name = "Fiyatı")]
        public decimal Fiyati { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public string Modeli { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        [Display(Name = "Kasa Tipi")]
        public string KasaTipi { get; set; }
        [Display(Name = "Model Yılı")]
        public int ModelYili { get; set; }
        [Display(Name = "Satışta Mı?")]
        public bool SatistaMi { get; set; }
        [Display(Name = "Anasayfa?")]
        public bool Anasayfa { get; set; }
        [Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public string Notlar { get; set; }
        [StringLength(100)]
        public string? Resim1 { get; set; }
        [StringLength(100)]
        public string? Resim2 { get; set; }
        [StringLength(100)]
        public string? Resim3 { get; set; }
        public virtual Marka? Marka { get; set; }
        [Display(Name = "Ad Soyad"), ScaffoldColumn(false)]
        public string? AracBilgi
        {
            get
            {
                return this.Renk + " " + this.Modeli + " " + this.KasaTipi;
            }
        }
    }
}
