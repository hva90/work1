using System;

namespace CardCities
{
    /// <summary>
    /// Карточка путешествия
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Пункт отправления
        /// </summary>
        public string SourceCity { get; private set; }

        /// <summary>
        /// Пункт назначения
        /// </summary>
        public string DestinationCity { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sourceCity">Пункт отправления</param>
        /// <param name="destinationCity">Пункт назначения</param>
        public Card(string sourceCity, string destinationCity)
        {
            if (sourceCity == null) throw new ArgumentNullException("sourceCity");
            if (destinationCity == null) throw new ArgumentNullException("destinationCity");
            
            SourceCity = sourceCity;
            DestinationCity = destinationCity;
        }
    }
}
