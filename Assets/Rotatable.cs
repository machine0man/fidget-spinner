using UnityEngine;

namespace Nature
{
    public class Rotatable : MonoBehaviour
    {
        [SerializeField] bool m_usePhysics;

        float m_speedContinousRotation; 



		public bool UsePhysics { get => m_usePhysics; set => m_usePhysics = value; }
		public bool RotateContinous { get => m_rotateContinous; set => m_rotateContinous = value; }
		public float SpeedContinousRotation { get => m_speedContinousRotation; set => m_speedContinousRotation = value; }

		bool m_rotateContinous;

        void RotateContinously()
        {
            transform.Rotate(new Vector3(0f, 0f, -360f * m_speedContinousRotation * Time.deltaTime), Space.Self);
        }

        public void Rotate()
        { 
        
        
        }
		private void Update()
		{
            if (UsePhysics)
            {


            }
            else
            {
                if (m_rotateContinous)
                {
                    RotateContinously();
                    return;
                }
            }
		}


	}
}   
