using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadMyScene(string sceneName)
   {
      SceneManager.LoadScene(sceneName);
   }

   public void QuitGame()
   {
      Application.Quit();
   }
}
