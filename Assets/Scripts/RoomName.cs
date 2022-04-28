using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RoomName : MonoBehaviour
{
    [SerializeField] Text myText;

    void Start()
    {
        myText.text = "Your room name is: " + SceneManager.GetActiveScene().name;
    }
}
