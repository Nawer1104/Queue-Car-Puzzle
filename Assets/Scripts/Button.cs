using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public void Check()
    {
        GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].Check();
    }
}
