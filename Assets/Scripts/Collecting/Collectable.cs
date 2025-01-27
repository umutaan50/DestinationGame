using UnityEngine;

public class Collectable : Collideable {
    // Logic:
    protected bool collected;

    protected override void OnCollide(Collider2D coll) {
        if (coll.name == "Player") OnCollect();
    }

    protected virtual void OnCollect() {
        collected = true;
    }
}