using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void RestartButton()
    {
        // Reset the rizz meter
        Rizzmeter.Instance.rizz = 0;
        // Reset the dialogue index
        ErikaDialogue.Instance.index = 0;
        // Reload the scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("BachelorRotation");
    }
}
