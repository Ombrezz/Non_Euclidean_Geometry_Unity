using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{


    public void OnButtonClick()
    {
        SceneManager.LoadScene("Game");
    }
}
