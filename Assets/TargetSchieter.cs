using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetSchieter : MonoBehaviour
{
    [SerializeField] Camera cam;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // maakt een ray dat als cursor werkt
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                target target = hit.collider.gameObject.GetComponent<target>();
                if(target != null)
                {
                    target.Hit();                   
                }
            }
        }
    }
}