using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.UIElements;

namespace StatSystem.Editor
{

    public class StatDatabaseEditorWindow : EditorWindow
    {
        private StatDatabase m_Database;
        private StatCollectionEditor m_Current;

        [MenuItem("Window/StatSystem/StatDatabase")]
        public static void ShowWindow()
        {
            StatDatabaseEditorWindow window = GetWindow<StatDatabaseEditorWindow>();
            window.minSize = new Vector2(800, 600);
            window.titleContent = new GUIContent("StatDatabase");
        }

        public void CreateGUI()
        {
            OnSelectionChange();

            // Each editor window contains a root VisualElement object
            VisualElement root = rootVisualElement;

            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/StatSystem/Scripts/Editor/StatDatabaseEditorWindow.uxml");
            visualTree.CloneTree(root);

            StyleSheet styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/StatSystem/Scripts/Editor/StatDatabaseEditorWindow.uss");

            root.styleSheets.Add(styleSheet);

            StatCollectionEditor stats = root.Q<StatCollectionEditor>("stats");
            stats.Initialize(m_Database, m_Database.stats);

            Button statsTab = root.Q<Button>("stats-tab");
            statsTab.clicked += () =>
            {
                m_Current.style.display = DisplayStyle.None;
                stats.style.display = DisplayStyle.Flex;
                m_Current = stats;
            };


            StatCollectionEditor primaryStats = root.Q<StatCollectionEditor>("primary-stats");
            primaryStats.Initialize(m_Database, m_Database.primaryStats);

            Button primaryStatsTab = root.Q<Button>("primary-stats-tab");
            primaryStatsTab.clicked += () =>
            {
                m_Current.style.display = DisplayStyle.None;
                primaryStats.style.display = DisplayStyle.Flex;
                m_Current = primaryStats;
            };

            StatCollectionEditor attributesStats = root.Q<StatCollectionEditor>("attributes");
            attributesStats.Initialize(m_Database, m_Database.attributes);

            Button attributesStatsTab = root.Q<Button>("attributes-tab");
            attributesStatsTab.clicked += () =>
            {
                m_Current.style.display = DisplayStyle.None;
                attributesStats.style.display = DisplayStyle.Flex;
                m_Current = attributesStats;
            };

            m_Current = stats;
        }

        [OnOpenAsset(1)]
        public static bool OnOpenAsset(int instanceId, int line)
        {
            if (EditorUtility.InstanceIDToObject(instanceId) is StatDatabase)
            { 
                ShowWindow();
                return true;
            }

            return false;
        }

        private void OnSelectionChange()
        {
            m_Database = Selection.activeObject as StatDatabase;
        }
    }
}