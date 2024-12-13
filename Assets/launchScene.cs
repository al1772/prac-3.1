using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchScene : MonoBehaviour
{
    // Start is called before the first frame update
    public string game2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider FPSController){
        Debug.Log("loading");
        // SceneManager.LoadScene(game2);
    }
}
