using GD;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private IntGameEvent OnHealthChanged;

    private int health = 100;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            OnHealthChanged.Raise(health);
            health--;
        }
    }
}