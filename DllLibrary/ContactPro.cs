namespace DllLibrary
{
    /// <summary>
    ///     La classe ContactPro qui hérite de Contact.
    /// </summary>
    public class ContactPro : Contact
    {
        /// <summary>
        ///     Le string qui récupère le nom de l'entreprise.
        /// </summary>
        private string nomEntreprise;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ContactPro" /> class.
        /// </summary>
        /// <param name="id">
        ///     The id.
        /// </param>
        /// <param name="c">
        ///     The c.
        /// </param>
        /// <param name="n">
        ///     The n.
        /// </param>
        /// <param name="p">
        ///     The p.
        /// </param>
        /// <param name="t">
        ///     The t.
        /// </param>
        /// <param name="a">
        ///     The a.
        /// </param>
        /// <param name="ent">
        ///     The ent.
        /// </param>
        public ContactPro(int id, string c, string n, string p, string t, string a, string ent)
            : base(id, n, p, t, c)
        {
            AdresseMail = a;
            NomEntreprise = ent;
        }

        /// <summary>
        ///     Gets or sets the adresse mail.
        /// </summary>
        public string AdresseMail { get; set; }

        /// <summary>
        ///     Gets or sets the nom entreprise.
        /// </summary>
        public string NomEntreprise
        {
            get
            {
                return nomEntreprise.Length > 50 ? string.Empty : nomEntreprise.ToUpper();
            }

            set
            {
                nomEntreprise = value;
            }
        }

        /// <summary>
        ///     Affiche les infos de Contact + les infos ContactsPro.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string Affiche()
        {
            return Infos() + $" Adresse email : {AdresseMail} \n Nom de l'entreprise : {NomEntreprise}";
        }
    }
}