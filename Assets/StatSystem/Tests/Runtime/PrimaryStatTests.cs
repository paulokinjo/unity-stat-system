using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;

namespace StatSystem.Tests
{
    public class PrimaryStatTests : BaseTests
    {
        [UnityTest]
        public IEnumerator PrimaryStat_WhenAddCalled_ChangesBaseValue()
        {
            yield return null;

            PrimaryStat strength = GetStatFor("Strength") as PrimaryStat;

            Assert.AreEqual(1, strength.value);

            strength.Add(1);

            Assert.AreEqual(2, strength.value);
        }

        [UnityTest]
        public IEnumerator PrimaryStat_WhenSubtractCalled_ChangesBaseValue()
        {
            yield return null;

            PrimaryStat strength = GetStatFor("Strength") as PrimaryStat;

            Assert.AreEqual(2, strength.value);

            strength.Subtract(1);

            Assert.AreEqual(1, strength.value);
        }
    }
}
