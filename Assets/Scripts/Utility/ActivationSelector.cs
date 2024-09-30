using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationSelector : MonoBehaviour
{
    [SerializeField]
    private GameObject[] selectables;

    public void Select (GameObject target)
    {
        target.gameObject.SetActive(true);

        for (int i = 0; i < selectables.Length; i++)
        {
            if (selectables[i] != target)
            {
                selectables[i].gameObject.SetActive(false);
            }
        }
    }
}