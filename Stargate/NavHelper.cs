namespace Stargate
{
    /// <summary>
    /// Permet aux formulaires volets de demander une navigation vers un autre volet après leur fermeture.
    /// Form1 lit cette propriété après le retour de ShowDialog() et navigue en conséquence.
    /// </summary>
    public static class NavHelper
    {
        /// <summary>
        /// Volet cible demandé : "volet2", "volet5", "volet6", "volet7", ou null pour revenir au tableau de bord.
        /// </summary>
        public static string ProchainVolet { get; set; } = null;
    }
}
