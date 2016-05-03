using System;
using System.Collections.Generic;

namespace CardCities
{
    /// <summary>
    /// Работа с карточками
    /// </summary>
    public static class CardHelper
    {
        /// <summary>
        /// Упорядочивание карточек (пункт назначения текущей = пункту отправления следующей)
        /// </summary>
        /// <param name="list">Список с карточками</param>
        public static void Arrange(IList<Card> list)
        {
            if (list == null) throw new ArgumentNullException("list");
            if (list.Count < 3) return;

            for (int i = 1; i < list.Count - 1; i++)
            {
                var prev = list[i - 1];
                var curr = list[i];

                if (prev.DestinationCity != curr.SourceCity)
                {
                    bool found = false;

                    for (int j = i + 1; j < list.Count; j++)
                    {
                        var next = list[j];

                        if (next.SourceCity == prev.DestinationCity)
                        {
                            list[i] = next;
                            list[j] = curr;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                        throw new Exception("Не удалось найти карточку с пунктом отправления " + prev.DestinationCity);
                }
            }
        }
    }
}
