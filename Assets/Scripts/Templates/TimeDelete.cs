using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Object.Destroy(gameObject, 100f);
    }


}
