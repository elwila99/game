using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousfollo : MonoBehaviour
{
	[SerializeField]
	private float moveSpeed = 0.1f;

	[SerializeField]
	private float coolDownTime = 0.5f;

	private float shootTimer;

	[SerializeField]
	private  bullet bulletprefab;

	[SerializeField]
	private Transform firepoint;

	Vector3 mousePosition;

	

	Rigidbody2D rb;
	Vector2 position = new Vector2(0f, 0f);

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

		shootTimer += Time.deltaTime;
		if (shootTimer > coolDownTime && Input.GetKey(KeyCode.Space))
		{
			shootTimer = 0f;

			Instantiate(bulletprefab, firepoint.position, Quaternion.identity);
			
		}
	}

	private void FixedUpdate()
	{
		rb.MovePosition(position);
	}

	

	}

