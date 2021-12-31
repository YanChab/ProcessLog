namespace ProcessLog.Shared
{
    public class Etape
    {
        public string Titre { get; set; }="Renseigner le titre";
        public int Numero { get; set; }=0;
        public enum Status{Conforme, NonConforme, NonApplicable,ARenseigner}
        public string Commentaire { get; set; }="Renseigner un commentaire";
        public Status ActivStatus{get;set;}


    }
}