using System.Collections.Generic;
using System.Collections;
using UnityEngine;
public class PipeMiddleScript : MonoBehaviour
{
    private LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addscore(1);
    }
}
