using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VacuumBreather;

[System.Serializable]
public class BugMovement {
    [SerializeField] float forceScale;
    [SerializeField] float dampScale;
    [SerializeField] AnimationCurve forceDistanceCurve;

    public Vector2 targetPosition = Vector2.zero;
    private Bug bug;

    public void Initialize(Bug bug) {
        this.bug = bug;
        bug.fixedUpdateEvent += bug_fixedUpdate;
    }

    public void SetTargetPosition(Vector2 newTargetPosition) {
        targetPosition = newTargetPosition;
    }


    private void bug_fixedUpdate() {
        Vector3 dPosition = VectorUtils.FromToV3(bug.transform.position, new Vector3(targetPosition.x, targetPosition.y, 0));
        float force = forceDistanceCurve.Evaluate(dPosition.magnitude);
        bug.rb.AddForce(dPosition.normalized * force * forceScale - new Vector3(bug.rb.velocity.x, bug.rb.velocity.y, 0) * dampScale);
    }
}
