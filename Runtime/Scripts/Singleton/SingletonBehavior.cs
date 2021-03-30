using UnityEngine;

namespace Singleton {
	public class SingletonBehavior<T> : MonoBehaviour where T : MonoBehaviour {

		private static T instance;
		
		//Todo: Add bool member

		public static T Instance {
			get {
				if(instance == null) {
					//Create a new T GameObject if one does not exist
					if(instance == null) {
						GameObject emptyGameObject = new GameObject();
						emptyGameObject.name = typeof(T).ToString();
						instance = emptyGameObject.AddComponent<T>();
					}
				}
				return instance;
			}
		}

		protected virtual void Awake() {
			if(instance == null) {
				instance = FindObjectOfType<T>();
			} else {
				Debug.Log("Removing duplicate: " + gameObject.name);
				Destroy(gameObject);
				return;
			}

			//DontDestroyOnLoad(gameObject);
			
			//instance = GetComponent<T>();
		}

	}	
}
