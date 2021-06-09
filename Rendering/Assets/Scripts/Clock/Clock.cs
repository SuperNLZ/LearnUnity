using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
	public Transform hoursArm, minutesArm, secondArm;
	public bool continuous = false;

	const float degreePerHour = 30f;
	const float degreePerMinute = 6f;
	const float degreePerSecond = 6f;

	private void Awake()
	{
		
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (continuous)
		{
			UpdateContinuous();
		}
		else
		{
			UpdateDiscrete();
		}
	}

	void UpdateDiscrete()
	{
		DateTime time = DateTime.Now;
		hoursArm.localRotation = Quaternion.Euler(0f, time.Hour * degreePerHour, 0f);
		minutesArm.localRotation = Quaternion.Euler(0, time.Minute * degreePerMinute, 0f);
		secondArm.localRotation = Quaternion.Euler(0, time.Second * degreePerSecond, 0f);
	}

	void UpdateContinuous()
	{
		TimeSpan time = DateTime.Now.TimeOfDay;
		hoursArm.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * degreePerHour, 0f);
		minutesArm.localRotation = Quaternion.Euler(0, (float)time.TotalMinutes * degreePerMinute, 0f);
		secondArm.localRotation = Quaternion.Euler(0, (float)time.TotalSeconds * degreePerSecond, 0f);
	}
}
