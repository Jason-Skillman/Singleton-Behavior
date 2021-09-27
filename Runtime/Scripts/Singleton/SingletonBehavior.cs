namespace Singleton {
	using UnityEngine;
	
	public class SingletonBehavior<T> : MonoBehaviour where T : MonoBehaviour {
		
		[SerializeField]
		private bool dontDestroyOnLoad = default;
		
		public static T Instance { get; private set; }

		protected virtual void Awake() {
			if(Instance == null)
				Instance = FindObjectOfType<T>();
			else {
				Destroy(gameObject);
				return;
			}
			
			if(dontDestroyOnLoad)
				DontDestroyOnLoad(gameObject);
		}
	}	
}
