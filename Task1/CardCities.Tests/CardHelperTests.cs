using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CardCities.Tests
{
    [TestFixture]
    public class CardHelperTests
    {
        const string Moscow = "Москва";
        const string Paris = "Париж";
        const string NewYork = "Нью-Йорк";
        const string London = "Лондон";
        const string Sydney = "Сидней";
        const string Helsinki = "Хельсинки";

        private IEnumerable<Card> GetCorrectCards1()
        {
            yield return new Card(Moscow, Paris);
            yield return new Card(NewYork, London);
            yield return new Card(Helsinki, Sydney);
            yield return new Card(Paris, Helsinki);
            yield return new Card(Sydney, NewYork);
        }

        private IEnumerable<Card> GetCorrectCards2()
        {
            yield return new Card(Moscow, Paris);
            yield return new Card(Paris, Helsinki);
            yield return new Card(Helsinki, Sydney);
            yield return new Card(NewYork, London);
            yield return new Card(Sydney, NewYork);
        }

        private IEnumerable<Card> GetIncorrectCards()
        {
            yield return new Card(Moscow, Paris);
            yield return new Card(NewYork, London);
            yield return new Card(Helsinki, London);
            yield return new Card(Paris, Helsinki);
            yield return new Card(Sydney, NewYork);
        }

        private IEnumerable<Card> GetExpectedCards()
        {
            yield return new Card(Moscow, Paris);
            yield return new Card(Paris, Helsinki);
            yield return new Card(Helsinki, Sydney);
            yield return new Card(Sydney, NewYork);
            yield return new Card(NewYork, London);
        }

        /// <summary>
        /// Проверка полностью не отсортированного списка
        /// </summary>
        [Test]
        public void TestArrangeWithCorrectList1()
        {
            var list = new List<Card>(GetCorrectCards1());
            CardHelper.Arrange(list);
            CollectionAssert.AreEqual(GetExpectedCards().ToArray(), list, new CardsComparer());
        }

        /// <summary>
        /// Проверка частично отсортированного списка
        /// </summary>
        [Test]
        public void TestArrangeWithCorrectList2()
        {
            var list = new List<Card>(GetCorrectCards2());
            CardHelper.Arrange(list);
            CollectionAssert.AreEqual(GetExpectedCards().ToArray(), list, new CardsComparer());
        }

        /// <summary>
        /// Проверка неправильного списка (для одного пункта назначения нет пункта отправки)
        /// </summary>
        [Test]
        public void TestArrangeWithIncorrectList()
        {
            var list = new List<Card>(GetIncorrectCards());
            Assert.Catch<Exception>(() => CardHelper.Arrange(list));
        }
    }
}
