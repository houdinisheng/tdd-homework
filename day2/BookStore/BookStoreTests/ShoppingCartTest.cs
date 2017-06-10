using BookStore;
using BookStore.Interfaces;
using BookStore.Models;
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace BookStoreTest
{
    [TestFixture]
    public class ShoppingCartTest
    {
        [TestCase(1, 0, 0, 0, 0, 100)]
        [TestCase(1, 1, 0, 0, 0, 190)]
        [TestCase(1, 1, 1, 0, 0, 270)]
        [TestCase(1, 1, 1, 1, 0, 320)]
        [TestCase(1, 1, 1, 1, 1, 375)]
        [TestCase(1, 1, 2, 0, 0, 370)]
        [TestCase(1, 2, 2, 0, 0, 460)]
        [TestCase(2, 2, 1, 0, 0, 460)]
        [TestCase(2, 2, 0, 1, 1, 510)]
        [TestCase(0, 0, 0, 0, 0, 0)]
        public void Should_Get_Correct_Price_Of_HarryPotter_Books(
            int firstEpisodeCount, int secondEpisodeCount, int thirdEpisodeCount, 
            int fourthEpisodeCount, int fifthEpisodeCount, decimal expected)
        {
            var bookName = "Harry Potter";

            var books = new IBook[]
            {
                new Book(bookName, 1, 100, firstEpisodeCount),
                new Book(bookName, 2, 100, secondEpisodeCount),
                new Book(bookName, 3, 100, thirdEpisodeCount),
                new Book(bookName, 4, 100, fourthEpisodeCount),
                new Book(bookName, 5, 100, fifthEpisodeCount),
            };

            var target = new ShoppingCart();
            var actual = target.GetTotalPrice(books);
            actual.Should().Be(expected);
        }
    }
}