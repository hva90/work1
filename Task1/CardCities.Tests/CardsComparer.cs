using System;
using System.Collections;

namespace CardCities.Tests
{
    /// <summary>
    /// Сравнение карточек
    /// </summary>
    public class CardsComparer : IComparer
    {
        private readonly IComparer _comparer = StringComparer.Ordinal;

        /// <summary>
        /// Сравнение
        /// </summary>
        /// <param name="x">Карточка 1</param>
        /// <param name="y">Карточка 2</param>
        /// <returns>0 - карточки равны</returns>
        public int Compare(object x, object y)
        {
            var card1 = (Card) x;
            var card2 = (Card) y;

            int result = _comparer.Compare(card1.SourceCity, card2.SourceCity);
            if (result != 0)
                return result;
            result = _comparer.Compare(card1.DestinationCity, card2.DestinationCity);
            return result;
        }
    }
}
