using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  public float speed;

  private Rigidbody2D rigid2d;
  private Vector2 direction;

  private void Start() {
    rigid2d = GetComponent<Rigidbody2D>();
  }

  private void Update() {
    direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
  }

  private void FixedUpdate() {
    rigid2d.MovePosition(rigid2d.position + direction * speed * Time.fixedDeltaTime);
  }
}
