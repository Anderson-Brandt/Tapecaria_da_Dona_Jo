using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        AudioControll.current.PlayMusic(AudioControll.current.Tissue);
        GamePlayControll.instance.blockNumber ++;
        Destroy(gameObject);
    }
}
