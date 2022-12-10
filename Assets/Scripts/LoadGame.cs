using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{
    public Button btnA;
    // Start is called before the first frame update
    void Start()
    {
        btnA.onClick.AddListener(LoadSceneA);
    }

    private void LoadSceneA()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
