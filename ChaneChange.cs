using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaneChange : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}
