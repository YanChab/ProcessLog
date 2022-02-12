namespace ProcessLog.Shared
{
    public class Projet
    {
         public string Reference { get; set; }="Renseigner la référence";
         public string Titre { get; set; }="Renseigner le titre";
         public List<Etape> ListeEtape{ get; set; }=new List<Etape>{new Etape(){}};


    }
}