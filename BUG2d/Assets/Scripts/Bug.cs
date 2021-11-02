using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour {
    public BugMovement movement;

    public event Delegates.emptyDelegate updateEvent;
    public event Delegates.emptyDelegate fixedUpdateEvent;
    public event Delegates.emptyDelegate lateUpdateEvent;

    public void Initialize(Vector2 spawnPosition, Vector2 targetPosition) {
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
}
