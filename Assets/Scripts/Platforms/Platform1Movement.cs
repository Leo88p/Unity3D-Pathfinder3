using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class Platform1Movement : MonoBehaviour
{
    private Vector3 initialPosisition;
    [SerializeField] private bool moving;
    private Vector3 rotationCenter;
    private Vector3 rotationStartPos;
    [SerializeField] private float rotationSpeed = 10f;

    /// <summary>
    /// Тело региона - коллайдер
    /// </summary>
    public SphereCollider body;

    /// <summary>
    /// Индекс региона в списке регионов
    /// </summary>
    public int index { get; set; } = -1;


    void Start()
    {
        rotationCenter = transform.position + 10 * Vector3.back;
        rotationStartPos = transform.position;
        body = GetComponent<SphereCollider>();
    }

    void Update()
    {
        if (!moving) return;

        transform.RotateAround(rotationCenter, Vector3.up, Time.deltaTime*rotationSpeed);
    }
}
