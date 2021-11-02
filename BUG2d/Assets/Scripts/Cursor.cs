using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {
    public List<Bug> selectedBugs = new List<Bug>();

    private void Update() {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, -9);

        if (Input.GetKeyUp(KeyCode.Mouse1))
            OnRightMouseUp();
    }

    private void OnRightMouseUp() {
        for (int i = 0; i < selectedBugs.Count; i++) {
            selectedBugs[i].movement.SetTargetPosition(new Vector2(transform.position.x, transform.position.y));
        }
    }

    private void OnMouseDown() {

        // Deselect
        for (int i = 0; i < selectedBugs.Count; i++) {
            selectedBugs[i].DeSelect();
        }
        selectedBugs.Clear();
    }

    private void OnTriggerEnter2D(Collider2D other) {

        // Return if mouse not down
        if (!Input.GetKey(KeyCode.Mouse0))
            return;

        Bug bug = other.GetComponent<Bug>();

        // Return if overlap is not a bug
        if (bug == null)
            return;

        bug.Select();
        selectedBugs.Add(bug);
    }
}
