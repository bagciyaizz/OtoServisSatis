using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Servis : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Servise Geliş Tarihi")]
        public DateTime ServiseGelisTarihi { get; set; }
        [Display(Name = "Araç Sorunu"), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public string AracSorunu { get; set; }
        [Display(Name = "Servis Ücreti")]
        public decimal ServisUcreti { get; set; }
        [Display(Name = "Servisten Çıkış Tarihi")]
        public DateTime ServistenCikisTarihi { get; set; }
        [Display(Name = "Yapılan İşlemler")]
        public string? YapilanIslemler { get; set; }
        [Display(Name = "Garanti Kapsamında Mı?")]
        public bool GarantiKapsamindaMi { get; set; }
        [Display(Name = "Araç Plaka"), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        [StringLength(15)]
        public string AracPlaka { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public string Marka { get; set; }
        [StringLength(50)]
        public string? Model { get; set; }
        [Display(Name = "Kasa Tipi")]
        [StringLength(50)]
        public string? KasaTipi { get; set; }
        [Display(Name = "Şase No")]
        [StringLength(50)]
        public string? SaseNo { get; set; }
        [Required(ErrorMessage = "{0} Boş bırakılamaz!")]
        public string? Notlar { get; set; }







    }
}
