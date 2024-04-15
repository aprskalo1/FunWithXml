using System.ComponentModel.DataAnnotations;

namespace FunWithXml_API.Models
{
    public class BodyMeasurement
    {
        [Key]
        public Guid Id { get; set; }
        public float bia_di { get; set; }
        public float bii_di { get; set; }
        public float bit_di { get; set; }
        public float che_de { get; set; }
        public float che_di { get; set; }
        public float elb_di { get; set; }
        public float wri_di { get; set; }
        public float kne_di { get; set; }
        public float ank_di { get; set; }
        public float sho_gi { get; set; }
        public float che_gi { get; set; }
        public float wai_gi { get; set; }
        public float nav_gi { get; set; }
        public float hip_gi { get; set; }
        public float thi_gi { get; set; }
        public float bic_gi { get; set; }
        public float for_gi { get; set; }
        public float kne_gi { get; set; }
        public float cal_gi { get; set; }
        public float ank_gi { get; set; }
        public float wri_gi { get; set; }
        public int age { get; set; }
        public float wgt { get; set; }
        public float hgt { get; set; }
        public int sex { get; set; }
    }
}
