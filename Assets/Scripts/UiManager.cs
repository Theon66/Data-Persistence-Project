using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        // get name from input
        string name = GameObject.Find("Name Input").GetComponent<InputField>().text;
        // data persistency between scenes
        DataManager.Instance.userName = name;
        SceneManager.LoadScene(1);
    }
}
