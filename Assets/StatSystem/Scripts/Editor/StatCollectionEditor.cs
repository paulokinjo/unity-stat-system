using Core.Scripts.Editor;
using UnityEngine.UIElements;

namespace StatSystem.Editor
{
    public class StatCollectionEditor : ScriptableObjectCollectionEditor<StatDefinition>
    {
        public new class UXmlFactory : UxmlFactory<StatCollectionEditor, UxmlTraits> { }
    }
}