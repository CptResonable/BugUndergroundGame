using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BugMovement {
    public Vector2 targetPosition = Vector2.zero;

    private Bug bug;

    public void Initialize(Bug bug) {
        this.bug = bug;
        bug.updateEvent += bug_updateEvent;
    }

    public void SetTargetPosition(Vector2 newTargetPosition) {
        targetPosition = newTargetPosition;
    }

    private void bug_updateEvent() {
        // Vector2 dPosition = VectorUtils.FromToV2(bug.transform.position, new Vector3(targetPosition.x, targetPosition.y, 0);
        Vector3 dPosition = VectorUtils.FromToV3(bug.transform.position, new Vector3(targetPosition.x, targetPosition.y, 0));
        bug.transform.position += dPosition.normalized * Time.deltaTime;
    }
}
