using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

// Dans les projets de type SDK comme celui-là, plusieurs attributs d'assembly définis
// historiquement dans ce fichier sont maintenant automatiquement ajoutés pendant
// la génération et renseignés avec des valeurs définies dans les propriétés du projet.
// Pour plus d'informations sur les attributs à inclure et sur la personnalisation
// de ce processus, consultez : https://aka.ms/assembly-info-properties


// La définition de ComVisible sur False rend les types dans cet assembly invisibles
// aux composants COM. Si vous devez accéder à un type dans cet assembly à partir
// de COM, définissez l'attribut ComVisible sur True pour ce type.

[assembly: ComVisible(false)]

// Le GUID suivant concerne l'ID de typelib si ce projet est exposé à COM.

[assembly: Guid("a839cc37-7f42-4750-9c89-b6b0bfd07742")]

public class MyDbContext : DbContext
{
    public MyDbContext()
    {
        
    }


    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {
        optionsBuilder.UseMySQL("server=localhost;user=alpesgsb;database=gsb_praticien;password=alpesgsb");
        //"server=localhost;user=root;database=mission3ap2;password="
    }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Sante> Santes { get; set; }
}
