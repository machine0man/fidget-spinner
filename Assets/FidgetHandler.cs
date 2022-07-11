using UnityEngine;
using UnityEngine.UI;

namespace Nature
{
    public class FidgetHandler : MonoBehaviour
    {
        [SerializeField] Rotatable m_rotatableFidget;
        [SerializeField] Slider m_speedSlider;
		private void Start()
		{
			m_rotatableFidget.RotateContinous = true;
		}
		private void Update()
		{
			m_rotatableFidget.SpeedContinousRotation = Mathf.Lerp( 0f,10f,m_speedSlider.value);
		}
	}
}   
