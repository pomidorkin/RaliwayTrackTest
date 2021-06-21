using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Railway : MonoBehaviour
{
    [SerializeField] Transform[] routes;

    // Start is called before the first frame update
    void Start()
    {
    }

    public Transform[] GetRoutes()
    {
        return routes;
    }
}
