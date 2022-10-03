using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button startBtn;
    void Start()
    {
     startBtn.onClick.AddListener((() =>
     {
         SceneManager.LoadScene("Game");
     }));   
    }
    
}
