namespace DllLibrary
{
    /// <summary>
    ///     La classe abstraite Contact permettant de générer les contacts.
    /// </summary>
    public abstract class Contact
    {
        /// <summary>
        ///     Le string qui récupère le nom.
        /// </summary>
        private string nom;

        /// <summary>
        ///     Le string qui récupère le prénom.
        /// </summary>
        private string prenom;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="id">
        ///     l'id.
        /// </param>
        /// <param name="n">
        ///     Le nom.
        /// </param>
        /// <param name="p">
        ///     Le prénom.
        /// </param>
        /// <param name="t">
        ///     Le téléphone.
        /// </param>
        /// <param name="c">
        ///     Le type de contact.
        /// </param>
        protected Contact(int id, string n, string p, string t, string c)
        {
            Nom = n;
            Prenom = p;
            Telephone = t;
            TypeContact = c;
            Id = id;
        }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the nom.
        /// </summary>
        public string Nom
        {
            get
            {
                // Si la taille du nom est supérieur à 50 caractères, le nom retournera une chaine vide, sinon on met le nom en majuscule.
                return nom.Length > 50 ? string.Empty : nom.ToUpper();
            }

            set
            {
                nom = value;
            }
        }

        /// <summary>
        ///     Gets or sets the prenom.
        /// </summary>
        public string Prenom
        {
            get
            {
                // Si la taille du prénom est supérieur à 50 caractères, le prénom retournera une chaine vide, sinon on met la première lettre du prénom en majuscule.
                return prenom.Length > 50
                           ? string.Empty
                           : prenom[0].ToString().ToUpper() + prenom.Substring(1);
            }

            set
            {
                prenom = value;
            }
        }

        /// <summary>
        ///     Gets or sets the telephone.
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        ///     Gets or sets the type contact.
        /// </summary>
        public string TypeContact { get; set; }

        /// <summary>
        ///     Permet de récupérer la fonction "Infos" dans les autres classes.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public abstract string Affiche();

        /// <summary>
        ///     affiche toutes les infos de base du contact
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        protected string Infos()
        {
            var ch = string.Empty;
            ch +=
                $"ID : {Id} \n Type de Contact : {TypeContact} \n Nom : {Nom} \n Prénom: {Prenom} \n Téléphone : {Telephone} \n";
            return ch;
        }
    }
}