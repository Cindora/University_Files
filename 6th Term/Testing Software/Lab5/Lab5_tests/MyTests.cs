using Lab5_tests;
using NUnit.Framework;
using System;

namespace BonusSystem.Tests
{
    [TestFixture]
    public class BonusCalculatorTests
    {
        private BonusCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new BonusCalculator();
        }

        //  Позитивные тесты 
        [TestCase(10000, 10, "обычный", 100)]
        [TestCase(10000, 10, "постоянный", 300)]
        [TestCase(0, 0, "обычный", 0)]
        [TestCase(50000, 10, "постоянный", 1500)]
        public void CalculateBonus_ValidInput_ReturnsCorrectBonus(decimal sum, int count, string status, int expected)
        {
            int result = _calculator.CalculateBonus(sum, count, status);
            Assert.That(result, Is.EqualTo(expected));
        }

        //  Негативные тесты (исключения) 
        [TestCase(-100, 5, "обычный", "Сумма вне пределов")]
        [TestCase(60000, 5, "обычный", "Сумма вне пределов")]
        [TestCase(10000, -1, "обычный", "Количество покупок вне пределов")]
        [TestCase(10000, 15, "обычный", "Количество покупок вне пределов")]
        [TestCase(10000, 5, "VIP", "Неверный статус клиента")]
        public void CalculateBonus_InvalidInput_ThrowsArgumentException(decimal sum, int count, string status, string expectedMessage)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>((Action)(() => _calculator.CalculateBonus(sum, count, status)));
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }
    }

    [TestFixture]
    public class ArrayFilterTests
    {
        private ArrayFilter _filter;

        [SetUp]
        public void SetUp()
        {
            _filter = new ArrayFilter();
        }

        //  Позитивные тесты 
        [Test]
        public void FilterArray_ValidArrays_ReturnsFilteredArray()
        {
            int[] A = { 2, 4, 6, 8, 3, -1 };
            int[] B = { 4, 8 };
            int[] expected = { 2, 6 };

            int[] result = _filter.FilterArray(A, B);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FilterArray_AllElementsInB_ReturnsEmpty()
        {
            int[] A = { 2, 4, 6 };
            int[] B = { 2, 4, 6 };
            int[] expected = { };

            int[] result = _filter.FilterArray(A, B);
            // Проверка пустого массива
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void FilterArray_NoEvenPositive_ReturnsEmpty()
        {
            int[] A = { -2, 3, 5, -6 };
            int[] B = { };
            int[] expected = { };

            int[] result = _filter.FilterArray(A, B);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void FilterArray_EmptyA_ReturnsEmpty()
        {
            int[] A = { };
            int[] B = { 1, 2 };
            int[] result = _filter.FilterArray(A, B);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void FilterArray_NullInput_ReturnsEmpty()
        {
            int[] result = _filter.FilterArray(null, new int[] { 1 });
            Assert.That(result, Is.Empty);
        }

        //  Параметризованные тесты 
        [TestCase(new int[] { 2, 4, 6 }, new int[] { 4 }, new int[] { 2, 6 })]
        [TestCase(new int[] { 2, 4, 6 }, new int[] { 2, 6 }, new int[] { 4 })]
        [TestCase(new int[] { 10, 20, 30 }, new int[] { }, new int[] { 10, 20, 30 })]
        public void FilterArray_MultipleCases(int[] A, int[] B, int[] expected)
        {
            int[] result = _filter.FilterArray(A, B);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}