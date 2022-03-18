using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
	public float Speed;
	public Animator PlayerAnimator;

	private void Update()
	{
		PlayerMovement();

		void PlayerMovement()
		{
			float hor = Input.GetAxis("Horizontal");
			float ver = Input.GetAxis("Vertical");
			Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
			transform.Translate(playerMovement, Space.Self);

			if(Input.GetAxis("Vertical") > 0)
            {
				PlayerAnimator.ResetTrigger("Stop");
				PlayerAnimator.ResetTrigger("Right");
				PlayerAnimator.ResetTrigger("Left");
				PlayerAnimator.ResetTrigger("Backward");
				PlayerAnimator.SetTrigger("Forward");
            }
			if (Input.GetAxis("Vertical") < 0)
			{
				PlayerAnimator.ResetTrigger("Stop");
				PlayerAnimator.ResetTrigger("Right");
				PlayerAnimator.ResetTrigger("Left");
				PlayerAnimator.ResetTrigger("Forward");
				PlayerAnimator.SetTrigger("Backward");
			}
			else if (Input.GetAxis("Horizontal") > 0)
			{
				PlayerAnimator.ResetTrigger("Stop");
				PlayerAnimator.ResetTrigger("Forward");
				PlayerAnimator.ResetTrigger("Backward");
				PlayerAnimator.ResetTrigger("Left");
				PlayerAnimator.SetTrigger("Right");
			}
			else if (Input.GetAxis("Horizontal") < 0)
			{
				PlayerAnimator.ResetTrigger("Stop");
				PlayerAnimator.ResetTrigger("Forward");
				PlayerAnimator.ResetTrigger("Backward");
				PlayerAnimator.ResetTrigger("Right");
				PlayerAnimator.SetTrigger("Left");
			}
			else if(Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
            {
				PlayerAnimator.ResetTrigger("Forward");
				PlayerAnimator.ResetTrigger("Backward");
				PlayerAnimator.ResetTrigger("Right");
				PlayerAnimator.ResetTrigger("Left");
				PlayerAnimator.SetTrigger("Stop");
			}
		}
	}
}
