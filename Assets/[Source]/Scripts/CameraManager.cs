using Cinemachine;
using Core.Character;
using UnityEngine;

namespace Core.Camera
{
	public sealed class CameraManager : Singleton<CameraManager>
	{
		[SerializeField] private CinemachineFollowZoom zoom;
		[SerializeField] private float minZoom, maxZoom;
		[SerializeField] private AnimationCurve zoomCurve;
		[SerializeField] private float speed = 100;

		private void Start()
		{
			void _OnZoomEvent(in float dir)
			{
				ref float width = ref zoom.m_Width ;
				float invLerp = Mathf.InverseLerp(minZoom, maxZoom, width);
				float evaluation = zoomCurve.Evaluate(invLerp);

				float dirSpeed = dir * (1 + evaluation) * speed * Time.deltaTime * -1;
				width = Mathf.Clamp(zoom.m_Width + dirSpeed, minZoom, maxZoom);
			}

			Controller.Instance.OnZoomEvent += _OnZoomEvent;
		}
	}
}