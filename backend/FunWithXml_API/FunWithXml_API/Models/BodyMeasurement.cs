using System.ComponentModel.DataAnnotations;

namespace FunWithXml_API.Models
{
    public class BodyMeasurement
    {
        [Key]
        public Guid Id { get; set; }
        public float BiaDi { get; set; }
        public float BiiDi { get; set; }
        public float BitDi { get; set; }
        public float CheDe { get; set; }
        public float CheDi { get; set; }
        public float ElbDi { get; set; }
        public float WriDi { get; set; }
        public float KneDi { get; set; }
        public float AnkDi { get; set; }
        public float ShoGi { get; set; }
        public float CheGi { get; set; }
        public float WaiGi { get; set; }
        public float NavGi { get; set; }
        public float HipGi { get; set; }
        public float ThiGi { get; set; }
        public float BicGi { get; set; }
        public float ForGi { get; set; }
        public float KneGi { get; set; }
        public float CalGi { get; set; }
        public float AnkGi { get; set; }
        public float WriGi { get; set; }
        public int Age { get; set; }
        public float Wgt { get; set; }
        public float Hgt { get; set; }
        public int Sex { get; set; }
    }
}
