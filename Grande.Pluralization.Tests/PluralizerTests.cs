using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grande.Pluralization.Tests
{
    namespace AutomatedTests
    {
        [TestClass]
        public class PluralizerTests
        {
            [TestMethod]
            public void StandardPluralizationTests()
            {
                var dictionary = new Dictionary<string, string>
                                     {
                                         {"sausage", "sausages"},
                                         {"status", "statuses"},
                                         {"ax", "axes"},
                                         {"octopus", "octopi"},
                                         {"virus", "viri"},
                                         {"crush", "crushes"},
                                         {"crutch", "crutches"},
                                         {"matrix", "matrices"},
                                         {"index", "indices"},
                                         {"mouse", "mice"},
                                         {"quiz", "quizzes"},
                                         {"mailman", "mailmen"},
                                         {"man", "men"},
                                         {"wolf", "wolves"},
                                         {"wife", "wives"},
                                         {"day", "days"},
                                         {"sky", "skies"}
                                     };

                foreach (var singular in dictionary.Keys)
                {
                    var plural = dictionary[singular];

                    Assert.AreEqual(plural, Pluralizer.Pluralize(2, singular));
                    Assert.AreEqual(singular, Pluralizer.Pluralize(1, singular));
                }
            }

            [TestMethod]
            public void IrregularPluralizationTests()
            {
                var dictionary = new Dictionary<string, string>
                                     {{"person", "people"}, {"child", "children"}, {"ox", "oxen"}};

                foreach (var singular in dictionary.Keys)
                {
                    var plural = dictionary[singular];

                    Assert.AreEqual(plural, Pluralizer.Pluralize(2, singular));
                    Assert.AreEqual(singular, Pluralizer.Pluralize(1, singular));
                }
            }

            [TestMethod]
            public void NonPluralizingPluralizationTests()
            {
                var nonPluralizingWords = new List<string> { "equipment", "information", "rice", "money", "species", "series", "fish", "sheep", "deer", "aircraft", "trout", "swine" };

                foreach (var word in nonPluralizingWords)
                {
                    Assert.AreEqual(word, Pluralizer.Pluralize(2, word));
                    Assert.AreEqual(word, Pluralizer.Pluralize(1, word));
                }
            }

            [TestMethod]
            public void TestOverridingPluralizations()
            {
                var result = Pluralizer.Pluralize(2, "box", "boxen");
                Assert.AreEqual("boxen", result);
            }
        }
    }
}
