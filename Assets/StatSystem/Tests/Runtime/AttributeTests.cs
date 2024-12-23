using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;

namespace StatSystem.Tests
{
    public class AttributeTests : BaseTests
    {

        [UnityTest]
        public IEnumerator Attribute_WhenModifierApplied_DoesNotExceedMaxValue()
        {
            yield return null;

            Attribute health = GetStatFor("health") as Attribute;

            Assert.AreEqual(100, health.currentValue);
            Assert.AreEqual(100, health.value);

            health.ApplyModifier(new StatModifier
            {
                magnitude = 20,
                type = ModifierOperationType.Additive
            });

            Assert.AreEqual(100, health.currentValue);
        }

        [UnityTest]
        public IEnumerator Attribute_WhenModifierApplied_DoesNotGoBelowZero()
        {
            yield return null;

            Attribute health = GetStatFor("health") as Attribute;

            Assert.AreEqual(100, health.currentValue);
            Assert.AreEqual(100, health.value);

            health.ApplyModifier(new StatModifier
            {
                magnitude = -200,
                type = ModifierOperationType.Additive
            });

            Assert.AreEqual(0, health.currentValue);
        }
    }
}
