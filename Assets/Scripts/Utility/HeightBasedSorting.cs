using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(SortingGroup)), DisallowMultipleComponent]
public class HeightBasedSorting : MonoBehaviour, IMove
{
    [SerializeField]
    private SortingGroup sortingGroup;

    [SerializeField]
    private float positionScaling = -100;

    [SerializeField]
    private bool flip;

    private void OnValidate()
    {
        if (sortingGroup == null)
        {
            sortingGroup = GetComponent<SortingGroup>();
        }

        UpdateOrder();
    }

    private void Start()
    {
        UpdateOrder();
    }

    public void OnMove(Vector2 direction, float velocity)
    {
        UpdateOrder();
    }

    private void UpdateOrder()
    {
        if (sortingGroup != null)
        {
            sortingGroup.sortingOrder = (int)(transform.position.y * positionScaling);
        }
    }
}