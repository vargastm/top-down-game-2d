using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  public float speed;

  private Rigidbody2D rigid2d;
  private Vector2 _direction;

  public Vector2 direction {
    get { return _direction;}
    set { _direction = value;}
  }

  private void Start() {
    rigid2d = GetComponent<Rigidbody2D>();
  }

  private void Update() {
    _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
  }

  private void FixedUpdate() {
    rigid2d.MovePosition(rigid2d.position + _direction * speed * Time.fixedDeltaTime);
  }
}
