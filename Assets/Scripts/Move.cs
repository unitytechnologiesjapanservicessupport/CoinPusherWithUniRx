using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
	private Rigidbody _rigidbody;
	private Vector3 _basePos;
	void Start ()
	{
		_rigidbody = GetComponent<Rigidbody>();
		_basePos = transform.position;
		this.FixedUpdateAsObservable().Subscribe(_ =>
		{
			_rigidbody.MovePosition(_basePos + new Vector3(0, 0, Mathf.Sin(Time.time) * 2));
		});
	}
}
