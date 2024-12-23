using NUnit.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

namespace StatSystem.Tests
{
    public class StatTests : BaseTests
    {
        [UnityTest]
        public IEnumerator Stat_WhenModifierApplied_ChangesValue()
        {
            yield return null;

            StatController statController = Object.FindObjectOfType<StatController>();

            Stat physicalAttack = GetStatFor("PhysicalAttack");

            Assert.AreEqual(0, physicalAttack.value);

            physicalAttack.AddModifier(new StatModifier
            {
                magnitude = 5,
                type = ModifierOperationType.Additive
            });

            Assert.AreEqual(5, physicalAttack.value);
        }

        [UnityTest]
        public IEnumerator Stat_WhenModifierApplied_DoesNotExceedCap()
        {
            yield return null;

            Stat attackSpeed = GetStatFor("AttackSpeed");

            Assert.AreEqual(1, attackSpeed.value);

            attackSpeed.AddModifier(new StatModifier
            {
                magnitude = 5,
                type = ModifierOperationType.Additive
            });

            Assert.AreEqual(3, attackSpeed.value);
        }
    }
}
