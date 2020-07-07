using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Battle
{
    /// <summary>
    /// Dé. Génére un nombre en fonction du nombre de facettes du dé.
    /// </summary>
    public class Dice
    {
        Random _generateurNombre = new Random();
        int _nbFacettes;

        /// <summary>
        /// Constructeur d'un dé.
        /// </summary>
        /// <param name="nbFacettes">Nombre de facettes du dé.</param>
        public Dice(int nbFacettes) => _nbFacettes = nbFacettes;

        /// <summary>
        /// Constructeur par défaut. 6 facettes par défaut.
        /// </summary>
        public Dice() : this(6) { }

        /// <summary>
        /// Lance le dé et donne le résultat.
        /// </summary>
        /// <returns></returns>
        public int Launch() => _generateurNombre.Next(1, _nbFacettes+1);
    }
}
