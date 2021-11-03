using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Telemetry {
    public Vector2 acceleration;
    private Vector2 velocity = Vector2.zero;
    private Bug bug;
    public Telemetry(Bug bug) {
        this.bug = bug;
        bug.fixedUpdateEvent += bug_fixedUpdate;
    }

    private void bug_fixedUpdate() {
        acceleration = (bug.rb.velocity - velocity) / Time.deltaTime;
        velocity = bug.rb.velocity;
    }
}
