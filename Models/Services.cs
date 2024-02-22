using System.ComponentModel.DataAnnotations;


namespace AJ.Models {
    public enum PropertyType {
        Residential,
        Commercial,
        Other
    }

    public class Services {
        [Key]
        public int Id { get; set; }
        public PropertyType Type { get; set; }
        public string Service { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
    }
}