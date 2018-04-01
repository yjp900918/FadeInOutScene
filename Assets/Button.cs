using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

    private void OnGUI()
    {
        if (GUI.Button(new Rect (280, 300, 200, 20), "Click to Shift Scene"))
        {
            StartCoroutine(FadeScene());
        }
    }

    IEnumerator FadeScene()
    {
        float time = GameObject.Find("Fade").GetComponent<FadeScene>().BeginFade(1);
        yield return new WaitForSeconds(time);

        SceneManager.LoadScene("Game");
    }
}
