using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoShop()
    {
        Application.OpenURL("https://www.theimmashop.com/");
    }

    public void GoExhib()
    {
        Application.OpenURL("http://www.imma.ie/en/nav_8.htm");
    }
    public void GoCollection()
    {
        Application.OpenURL("http://www.imma.ie/en/nav_9.htm");
    }
}
