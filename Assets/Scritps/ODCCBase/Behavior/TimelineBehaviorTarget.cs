using BC.Base;

using UnityEngine;
using UnityEngine.Playables;
namespace BC.OdccBase
{
	[RequireComponent(typeof(PlayableDirector))]
	public class TimelineBehaviorTarget : OdccBehaviorTarget
	{
		[SerializeField]
		private PlayableDirector playableDirector;
		private bool isStop = false;

		protected override void BaseValidate(in bool isPrefab = false)
		{
			if(isPrefab) return;
			if(playableDirector == null)
				playableDirector = GetComponent<PlayableDirector>() ?? gameObject.AddComponent<PlayableDirector>();
			playableDirector.playOnAwake = false;
		}
		protected override void BaseAwake()
		{
			if(playableDirector == null) return;
		}

		protected override bool OnActionValid()
		{
			if(playableDirector == null) return false;
			playableDirector.playOnAwake = false;
			playableDirector.gameObject.SetActive(true);
			return true;
		}

		protected override async Awaitable OnActionUpdate()
		{
			playableDirector.stopped -= CallStop;
			playableDirector.Stop();
			playableDirector.stopped += CallStop;

			isStop = false;
			playableDirector.enabled = true;
			playableDirector.Play();
			await AwaitableUtility.WaitTrue(() => isStop);
		}

		private void CallStop(PlayableDirector obj)
		{
			isStop = true;
			playableDirector.Stop();
			playableDirector.enabled = false;
		}

		protected override void OnActionEnd()
		{
			playableDirector.Stop();
			playableDirector = null;
		}
	}
}