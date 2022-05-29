using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Sante
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string id { get; set; }
    [MaxLength(255)]
    public string Titre { get; set; }
    [MaxLength(500)]
    public string prix { get; set; }
    [MaxLength(500)]
    public string informations { get; set; }
    [MaxLength(500)]
    public string Url { get; set; }

}
