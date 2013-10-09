using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grande.Pluralization.Tests
{
    /// <summary>
    /// With a very special thanks to wizofaus for finding (and fixing) most of these
    /// http://mattgrande.wordpress.com/2009/10/28/pluralization-helper-for-c/#comment-76
    /// </summary>
    [TestClass]
    public class BlogReportedBugs
    {
        [TestMethod]
        public void BoxShouldPluralizeToBoxes()
        {
            AssertPlural("Box", "Boxes");
        }

        [TestMethod]
        public void FoxShouldPluralizeToFoxes()
        {
            AssertPlural("Fox", "Foxes");
        }

        [TestMethod]
        public void ToxinShouldPluralizeToToxins()
        {
            AssertPlural("Toxin", "Toxins");
        }

        [TestMethod]
        public void GiraffeShouldPluralizeToGiraffes()
        {
            AssertPlural("Giraffe", "Giraffes");
        }

        [TestMethod]
        public void MongooseShouldPluralizeToMongooses()
        {
            AssertPlural("Mongoose", "Mongooses");
        }

        [TestMethod]
        public void FootballShouldPluralizeToFootballs()
        {
            AssertPlural("Football", "Footballs");
        }

        [TestMethod]
        public void HumanShouldPluralizeToHumans()
        {
            AssertPlural("Human", "Humans");
        }

        [TestMethod]
        public void AnnexShouldPluralizeToAnnexes()
        {
            AssertPlural("Annex", "Annexes");
        }

        [TestMethod]
        public void AxisShouldPluralizeToAxes()
        {
            AssertPlural("Axis", "Axes");
        }

        [TestMethod]
        public void PhylumShouldPluralizeToPhyla()
        {
            AssertPlural("Phylum", "Phyla");
        }

        [TestMethod]
        public void CrisisShouldPluralizeToCrises()
        {
            AssertPlural("Crisis", "Crises");
        }

        [TestMethod]
        public void CriterionShouldPluralizeToCriteria()
        {
            AssertPlural("Criterion", "criteria");
        }

        [TestMethod]
        public void SpectrumShouldPluralizeToSpectra()
        {
            AssertPlural("Spectrum", "Spectra");
        }

        [TestMethod]
        public void MilleniumShouldPluralizeToMillenia()
        {
            AssertPlural("Millenium", "Millenia");
        }

        [TestMethod]
        public void RadiusShouldPluralizeToRadii()
        {
            AssertPlural("Radius", "Radii");
        }

        [TestMethod]
        public void FungusShouldPluralizeToFungi()
        {
            AssertPlural("Fungus", "Fungi");
        }

        [TestMethod]
        public void BuzzShouldPluralizeToBuzzes()
        {
            AssertPlural("Buzz", "Buzzes");
        }

        [TestMethod]
        public void QuizShouldPluralizeToQuizzes()
        {
            AssertPlural("Quiz", "Quizzes");
        }

        private static void AssertPlural(string singular, string expectedPlural)
        {
            var actualPlural = singular.Pluralize();
            Assert.AreEqual(expectedPlural, actualPlural);
        }
    }
}
