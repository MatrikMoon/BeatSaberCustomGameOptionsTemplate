using IllusionPlugin;
using UnityEngine.SceneManagement;

namespace CustomGameOptionsTemplate
{
    public class Plugin : IPlugin
    {
        public string Name => "CustomGameOptionsTemplate";
        public string Version => "0.0.1";
        public void OnApplicationStart()
        {
            SceneManager.activeSceneChanged += SceneManagerOnActiveSceneChanged;
            SceneManager.sceneLoaded += SceneManager_sceneLoaded;
        }

        private void SceneManagerOnActiveSceneChanged(Scene arg0, Scene arg1)
        {
            if (arg1.name == "Menu")
            {
                var ctOption = GameOptionsUI.CreateListOption("ChromaList1");
                ctOption.AddOption(1, "ONE");
                ctOption.AddOption(2, "TWO");
                ctOption.AddOption(3, "THREE");
                ctOption.AddOption(4, "FOUR");
                ctOption.GetValue = () => 2f;
                ctOption.OnChange += (e) => Logger.Info($"ONCHANGE1: {e}");

                ctOption = GameOptionsUI.CreateListOption("ChromaList2");
                ctOption.AddOption(1, "ONE");
                ctOption.AddOption(2, "TWO");
                ctOption.AddOption(3, "THREE");
                ctOption.AddOption(4, "FOUR");
                ctOption.GetValue = () => 1f;
                ctOption.OnChange += (e) => Logger.Info($"ONCHANGE2: {e}");

                ctOption = GameOptionsUI.CreateListOption("ChromaList3");
                ctOption.AddOption(1, "ONE");
                ctOption.AddOption(2, "TWO");
                ctOption.AddOption(3, "THREE");
                ctOption.AddOption(4, "FOUR");
                ctOption.GetValue = () => 1f;
                ctOption.OnChange += (e) => Logger.Info($"ONCHANGE3: {e}");

                ctOption = GameOptionsUI.CreateListOption("ChromaList4");
                ctOption.AddOption(1, "ONE");
                ctOption.AddOption(2, "TWO");
                ctOption.AddOption(3, "THREE");
                ctOption.AddOption(4, "FOUR");
                ctOption.GetValue = () => 2f;
                ctOption.OnChange += (e) => Logger.Info($"ONCHANGE4: {e}");

                var ctToggle = GameOptionsUI.CreateToggleOption("ChromaToggle1");
                ctToggle.Default = true;
                ctToggle.OnToggle += (b) => Logger.Info($"TOGGLE1: {b}");

                ctToggle = GameOptionsUI.CreateToggleOption("ChromaToggle2");
                ctToggle.OnToggle += (b) => Logger.Info($"TOGGLE2: {b}");

                ctToggle = GameOptionsUI.CreateToggleOption("ChromaToggle3");
                ctToggle.OnToggle += (b) => Logger.Info($"TOGGLE3: {b}");

                ctToggle = GameOptionsUI.CreateToggleOption("ChromaToggle4");
                ctToggle.Default = true;
                ctToggle.OnToggle += (b) => Logger.Info($"TOGGLE4: {b}");

                ctOption = GameOptionsUI.CreateListOption("ChromaList5");
                ctOption.AddOption(1, "ONE");
                ctOption.AddOption(2, "TWO");
                ctOption.AddOption(3, "THREE");
                ctOption.AddOption(4, "FOUR");
                ctOption.GetValue = () => 1f;
                ctOption.OnChange += (e) => Logger.Info($"ONCHANGE5: {e}");

                ctOption = GameOptionsUI.CreateListOption("ChromaList6");
                ctOption.AddOption(1, "ONE");
                ctOption.AddOption(2, "TWO");
                ctOption.AddOption(3, "THREE");
                ctOption.AddOption(4, "FOUR");
                ctOption.GetValue = () => 2f;
                ctOption.OnChange += (e) => Logger.Info($"ONCHANGE6: {e}");

                ctToggle = GameOptionsUI.CreateToggleOption("ChromaToggle5");
                ctToggle.OnToggle += (b) => Logger.Info($"TOGGLE5: {b}");

                GameOptionsUI.Build();
            }
        }

        private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
        }

        public void OnApplicationQuit()
        {
            SceneManager.activeSceneChanged -= SceneManagerOnActiveSceneChanged;
            SceneManager.sceneLoaded -= SceneManager_sceneLoaded;
        }

        public void OnLevelWasLoaded(int level)
        {

        }

        public void OnLevelWasInitialized(int level)
        {
        }

        public void OnUpdate()
        {
        }

        public void OnFixedUpdate()
        {
        }
    }
}
