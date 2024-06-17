using System.Collections;
using System.Collections.Generic;
using MMAR.Attributes;
using UnityEngine;

public class ShowIfDemo : MonoBehaviour
{
    public bool showGameObject;
    [ShowIf("showGameObject")]
    public GameObject selectedGameObject;
}
