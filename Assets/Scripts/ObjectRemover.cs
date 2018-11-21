using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ObjectRemover : MonoBehaviour
{
	void Start ()
	{
		this.OnTriggerEnterAsObservable()
			.Subscribe(col =>
			{
				Destroy(col.gameObject);
			});
	}
}
