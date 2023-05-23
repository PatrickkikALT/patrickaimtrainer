using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class target : MonoBehaviour
{
    public void Hit()
    {
        transform.position = TargetSpawn.Instance.GetRandomPosition();
    }
}
