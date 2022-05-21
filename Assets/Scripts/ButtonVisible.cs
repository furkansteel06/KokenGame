using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVisible : MonoBehaviour
{
    public UnityEngine.UI.Button buton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void VisibleFalse()
    {
        buton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
