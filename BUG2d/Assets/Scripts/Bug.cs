using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour {
    public BugMovement movement;
    public Rigidbody2D rb;

    public bool isSelected;

    public event Delegates.emptyDelegate updateEvent;
    public event Delegates.emptyDelegate fixedUpdateEvent;
    public event Delegates.emptyDelegate lateUpdateEvent;

    private GameObject goSelectionMarker;

    public void Initialize(Vector2 spawnPosition, Vector2 targetPosition) {
        rb = GetComponent<Rigidbody2D>();
        goSelectionMarker = transform.Find("SelectionMarker").gameObject;
        transform.position = spawnPosition;

        movement.Initialize(this);
        movement.SetTargetPosition(targetPosition);
    }

    private void Update() {
        updateEvent?.Invoke();
    }

    private void FixedUpdate() {
        fixedUpdateEvent?.Invoke();
    }

    private void LateUpdate() {
        lateUpdateEvent?.Invoke();
    }

    public void Select() {
        isSelected = true;
        goSelectionMarker.SetActive(true);
    }

    public void DeSelect() {
        isSelected = false;
        goSelectionMarker.SetActive(false);
    }
}
