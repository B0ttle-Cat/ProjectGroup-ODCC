using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Sirenix.OdinInspector;
using Sirenix.Utilities;

using UnityEngine;
using UnityEngine.Networking;

using Object = UnityEngine.Object;

namespace BC.Base
{
	public class ResourcesManager : MonoSingleton<ResourcesManager>
	{
		// 로드 상태 정의
		public enum LoadState
		{
			None = 0,
			Loading = 1,
			Success = 2,
			Error = 3,
		}

		[Serializable]
		private class AssetBundleCash
		{
			public string BundleName;

			public AssetBundle AssetBundle;

			public LoadState LoadState = LoadState.None;

			// 로드된 에셋 오브젝트 캐시 리스트
			public List<AssetObjectCash> AssetObjectCashList;

			public Action<float> OnProgress;
			public Action<AssetBundle> OnResult;

			// 에셋 번들 비동기 다운로드
			public IEnumerator DownloadAsync(Action<float> _progress, Action<AssetBundle> _result)
			{
				// 에셋 오브젝트 캐시 리스트를 초기화합니다.
				AssetObjectCashList ??= new List<AssetObjectCash>();

				// 번들 이름이 비어있거나 null일 경우 에러 상태로 처리하고 결과를 반환합니다.
				if(string.IsNullOrWhiteSpace(BundleName))
				{
					LoadState = LoadState.Error;
					Debug.LogError("Bundle name is empty or null.");
					_result?.Invoke(null);
					yield break;
				}

				// 프로그래스 및 결과 콜백을 등록합니다.
				OnProgress += _progress;
				OnResult += _result;

				// 이미 로딩 중인 경우, 중복 로딩을 방지하기 위해 중단합니다.
				if(LoadState == LoadState.Loading)
				{
					yield break;
				}

				if(AssetBundle == null)
				{
					Debug.Log($"Already Loaded Check");
					var loadedList =  AssetBundle.GetAllLoadedAssetBundles();
					loadedList.ForEach(loaded =>
					{
						if(loaded.name == BundleName)
						{
							Debug.Log($"Is Already Loaded AssetBundle");
							AssetBundle = loaded;
						}
					});
				}

				// 번들이 로드되지 않은 상태인 경우 처리합니다.
				if(AssetBundle == null)
				{
					LoadState = LoadState.Loading;
					// 로컬 파일 경로와 URL 경로를 생성합니다.
					string fullLocalPath = Path.Combine(ConstString.BundleLocalPath, BundleName);
					string fullUrlPath = Path.Combine(ConstString.BundleURLPath, BundleName);

					// 로컬 파일이 존재하지 않으면 웹에서 다운로드합니다.
					if(!File.Exists(fullLocalPath))
					{
						Debug.Log($"Down AssetBundle URL: {fullUrlPath}");
						// UnityWebRequest를 생성하고 해당 URL로부터 번들 데이터를 다운로드합니다.
						using(UnityWebRequest www = UnityWebRequest.Get(fullUrlPath))
						{
							try
							{
								www.SendWebRequest();
							}
							catch(Exception ex)
							{
								Debug.LogException(ex);
								LoadState = LoadState.Error;
								OnResult?.Invoke(null);
								yield break;
							}

							// 다운로드가 완료될 때까지 진행 상황을 감시합니다.
							while(!www.isDone)
							{
								OnProgress?.Invoke(www.downloadProgress * 0.5f);
								yield return null;
							}

							// 다운로드가 실패한 경우 에러 메시지를 출력하고 결과를 반환합니다.
							if(www.result != UnityWebRequest.Result.Success)
							{
								Debug.LogError($"Failed to download AssetBundle: {www.error}");
								LoadState = LoadState.Error;
								OnResult?.Invoke(null);
								yield break;
							}

							// 다운로드한 번들 데이터를 로컬 파일에 저장합니다.
							try
							{
								File.WriteAllBytes(fullLocalPath, www.downloadHandler.data);
								Debug.Log("AssetBundle downloaded and saved.");
							}
							catch(Exception ex)
							{
								LoadState = LoadState.Error;
								Debug.LogException(ex);
								OnResult?.Invoke(null);
								yield break;
							}
						}
					}

					// 로컬 파일에서 번들을 로드합니다.
					AssetBundleCreateRequest async = null;
					try
					{
						Debug.Log($"ResourcesInstantiate AssetBundle from Path: {fullLocalPath}");
						async = AssetBundle.LoadFromFileAsync(fullLocalPath);
					}
					catch(Exception ex)
					{
						async = null;
						Debug.LogException(ex);
					}

					// 로딩이 완료될 때까지 진행 상황을 감시합니다.
					if(async != null)
					{
						while(!async.isDone)
						{
							OnProgress?.Invoke(async.progress * 0.5f + 0.5f);
							yield return null;
						}
						AssetBundle = async.assetBundle;
						Debug.Log("AssetBundle loaded successfully.");
					}
				}

				// 로딩 상태를 업데이트하고 최종 결과를 콜백합니다.
				LoadState = AssetBundle == null ? LoadState.Error : LoadState.Success;
				Debug.Log($"AssetBundle Result : {LoadState}");
				OnProgress?.Invoke(1f);
				OnResult?.Invoke(AssetBundle);
			}

			public void DownloadNow(Action<float> _progress, Action<AssetBundle> _result)
			{
				// 에셋 오브젝트 캐시 리스트를 초기화합니다.
				AssetObjectCashList ??= new List<AssetObjectCash>();

				// 번들 이름이 비어있거나 null일 경우 에러 상태로 처리하고 결과를 반환합니다.
				if(string.IsNullOrWhiteSpace(BundleName))
				{
					LoadState = LoadState.Error;
					Debug.LogError("Bundle name is empty or null.");
					_result?.Invoke(null);
					return;
				}

				// 프로그래스 및 결과 콜백을 등록합니다.
				OnProgress += _progress;
				OnResult += _result;

				// 이미 로딩 중인 경우, 중복 로딩을 방지하기 위해 중단합니다.
				if(LoadState == LoadState.Loading)
				{
					return;
				}

				if(AssetBundle == null)
				{
					Debug.Log($"Already Loaded Check");
					var loadedList =  AssetBundle.GetAllLoadedAssetBundles();
					loadedList.ForEach(loaded =>
					{
						if(loaded.name == BundleName)
						{
							Debug.Log($"Is Already Loaded AssetBundle");
							AssetBundle = loaded;
						}
					});
				}

				// 번들이 로드되지 않은 상태인 경우 처리합니다.
				if(AssetBundle == null)
				{
					LoadState = LoadState.Loading;
					// 로컬 파일 경로와 URL 경로를 생성합니다.
					string fullLocalPath = Path.Combine(ConstString.BundleLocalPath, BundleName);
					string fullUrlPath = Path.Combine(ConstString.BundleURLPath, BundleName);

					// 로컬 파일이 존재하지 않으면 웹에서 다운로드합니다.
					if(!File.Exists(fullLocalPath))
					{
						Debug.Log($"Down AssetBundle URL: {fullUrlPath}");
						bool? result = null;
						Task.Run(async () =>
						{
							try
							{
								using var www = UnityWebRequest.Get(fullUrlPath);

								www.SetRequestHeader("Content-Type", "application/json");

								var operation = www.SendWebRequest();

								while(!operation.isDone)
									await Task.Yield();

								if(www.result == UnityWebRequest.Result.Success)
								{
									File.WriteAllBytes(fullLocalPath, www.downloadHandler.data);
									result = true;

								}
								else
								{
									Debug.LogError($"Failed: {www.error}");
								}
							}
							catch(Exception ex)
							{
								Debug.LogException(ex);
							}
							finally
							{
								if(!result.HasValue)
								{
									result = false;
								}
							}
						});
						while(!result.HasValue) ;

						if(!result.Value)
						{
							return;
						}
					}

					// 로컬 파일에서 번들을 로드합니다.
					AssetBundle = AssetBundle.LoadFromFile(fullLocalPath);
					Debug.Log("AssetBundle loaded successfully.");
				}

				// 로딩 상태를 업데이트하고 최종 결과를 콜백합니다.
				LoadState = AssetBundle == null ? LoadState.Error : LoadState.Success;
				Debug.Log($"AssetBundle Result : {LoadState}");
				OnProgress?.Invoke(1f);
				OnResult?.Invoke(AssetBundle);
			}
			public void Unload()
			{
				foreach(var assetObjectCash in AssetObjectCashList)
				{
					assetObjectCash.Clear();
				}
				AssetObjectCashList.Clear();
				if(AssetBundle != null)
				{
					AssetBundle.Unload(true);
					Object.DestroyImmediate(AssetBundle, true);
					AssetBundle = null;
				}
				LoadState = LoadState.None;
			}
			public void Clear()
			{
				Unload();
				BundleName = null;
			}
		}

		[Serializable]
		private class AssetObjectCash
		{
			public string AssetName;
			public Object AssetObject;
			public LoadState LoadState = LoadState.None;

			public Action<float> OnProgress;
			public Action<Object> OnResult;

			// 에셋 오브젝트 비동기 다운로드
			public IEnumerator DownloadAsync(AssetBundle assetBundle, Action<float> _progress, Action<Object> _result)
			{
				// 에셋 오브젝트 이름이 비어있거나 null일 경우 에러 상태로 처리하고 결과를 반환합니다.
				if(string.IsNullOrWhiteSpace(AssetName))
				{
					LoadState = LoadState.Error;
					Debug.LogError("Asset name is empty or null.");
					_result?.Invoke(null);
					yield break;
				}

				// 프로그래스 및 결과 콜백을 등록합니다.
				OnProgress += _progress;
				OnResult += _result;

				// 이미 로딩 중인 경우, 중복 로딩을 방지하기 위해 중단합니다.
				if(LoadState == LoadState.Loading)
				{
					yield break;
				}

				// 에셋 오브젝트가 로드되지 않은 상태인 경우 처리합니다.
				if(AssetObject == null)
				{
					// 로드를 위한 AssetBundle이 유효하지 않은 경우 에러 상태로 처리하고 결과를 반환합니다.
					if(assetBundle == null)
					{
						LoadState = LoadState.Error;
						Debug.LogError("AssetBundle is null.");
						_result?.Invoke(null);
						yield break;
					}

					LoadState = LoadState.Loading;

					// 에셋을 비동기로 로드합니다.
					Debug.Log($"ResourcesInstantiate Asset: {AssetName}");
					AssetBundleRequest async = null;
					async = assetBundle.LoadAssetAsync<Object>(AssetName);
					while(!async.isDone)
					{
						_progress?.Invoke(async.progress);
						yield return null;
					}

					// 로드가 완료되었을 경우 AssetObject에 할당합니다.
					AssetObject = async.asset;
					Debug.Log("BuiltinObject loaded successfully.");
				}

				// 로딩 상태를 업데이트하고 최종 결과를 콜백합니다.
				LoadState = AssetObject == null ? LoadState.Error : LoadState.Success;
				Debug.Log($"BuiltinObject Result : {LoadState}");
				OnProgress?.Invoke(1f);
				OnResult?.Invoke(AssetObject);
			}
			public void DownloadNow(AssetBundle assetBundle, Action<float> _progress, Action<Object> _result)
			{
				// 에셋 오브젝트 이름이 비어있거나 null일 경우 에러 상태로 처리하고 결과를 반환합니다.
				if(string.IsNullOrWhiteSpace(AssetName))
				{
					LoadState = LoadState.Error;
					Debug.LogError("Asset name is empty or null.");
					_result?.Invoke(null);
					return;
				}

				// 프로그래스 및 결과 콜백을 등록합니다.
				OnProgress += _progress;
				OnResult += _result;

				// 이미 로딩 중인 경우, 중복 로딩을 방지하기 위해 중단합니다.
				if(LoadState == LoadState.Loading)
				{
					return;
				}

				// 에셋 오브젝트가 로드되지 않은 상태인 경우 처리합니다.
				if(AssetObject == null)
				{
					// 로드를 위한 AssetBundle이 유효하지 않은 경우 에러 상태로 처리하고 결과를 반환합니다.
					if(assetBundle == null)
					{
						LoadState = LoadState.Error;
						Debug.LogError("AssetBundle is null.");
						_result?.Invoke(null);
						return;
					}

					LoadState = LoadState.Loading;

					// 로드가 완료되었을 경우 AssetObject에 할당합니다.
					AssetObject = assetBundle.LoadAsset<Object>(AssetName); ;
					Debug.Log("BuiltinObject loaded successfully.");
				}

				// 로딩 상태를 업데이트하고 최종 결과를 콜백합니다.
				LoadState = AssetObject == null ? LoadState.Error : LoadState.Success;
				Debug.Log($"BuiltinObject Result : {LoadState}");
				OnProgress?.Invoke(1f);
				OnResult?.Invoke(AssetObject);
			}
			public void Unload()
			{
				if(AssetObject != null)
				{
					AssetObject = null;
				}
				LoadState = LoadState.None;
			}
			public void Clear()
			{
				Unload();
				AssetName = null;
			}
		}

		[Serializable]
		private class BuiltinObjectCash
		{
			public string BuiltinPath;
			public Object BuiltinObject;
			public LoadState LoadState = LoadState.None;

			public Action<float> OnProgress;
			public Action<Object> OnResult;

			public float? AutoUnloadTime;

			public IEnumerator DownloadAsync(Action<float> _progress, Action<Object> _result)
			{
				// 오브젝트 이름이 비어있거나 null일 경우 에러 상태로 처리하고 결과를 반환합니다.
				if(string.IsNullOrWhiteSpace(BuiltinPath))
				{
					LoadState = LoadState.Error;
					Debug.LogError("Asset name is empty or null.");
					_result?.Invoke(null);
					yield break;
				}

				// 프로그래스 및 결과 콜백을 등록합니다.
				OnProgress += _progress;
				OnResult += _result;

				// 이미 로딩 중인 경우, 중복 로딩을 방지하기 위해 중단합니다.
				if(LoadState == LoadState.Loading)
				{
					yield break;
				}

				// 에셋 오브젝트가 로드되지 않은 상태인 경우 처리합니다.
				if(BuiltinObject == null)
				{
					LoadState = LoadState.Loading;
					// 비동기적으로 에셋을 로드합니다.
					ResourceRequest resourceRequest = Resources.LoadAsync(BuiltinPath);

					// 로딩이 완료될 때까지 대기합니다.
					while(!resourceRequest.isDone)
					{
						_progress?.Invoke(resourceRequest.progress);
						yield return null;
					}

					// 로딩이 완료되면 로드된 에셋을 가져옵니다.
					BuiltinObject = resourceRequest.asset;
				}

				// 로딩 상태를 업데이트하고 최종 결과를 콜백합니다.
				LoadState = BuiltinObject == null ? LoadState.Error : LoadState.Success;
				Debug.Log($"BuiltinObject Result : {LoadState}");
				OnProgress?.Invoke(1f);
				OnResult?.Invoke(BuiltinObject);
			}
			public void DownloadNow(Action<float> _progress, Action<Object> _result)
			{
				// 오브젝트 이름이 비어있거나 null일 경우 에러 상태로 처리하고 결과를 반환합니다.
				if(string.IsNullOrWhiteSpace(BuiltinPath))
				{
					LoadState = LoadState.Error;
					Debug.LogError("Asset name is empty or null.");
					_result?.Invoke(null);
					return;
				}

				// 프로그래스 및 결과 콜백을 등록합니다.
				OnProgress += _progress;
				OnResult += _result;

				// 이미 로딩 중인 경우, 중복 로딩을 방지하기 위해 중단합니다.
				if(LoadState == LoadState.Loading)
				{
					return;
				}

				// 에셋 오브젝트가 로드되지 않은 상태인 경우 처리합니다.
				if(BuiltinObject == null)
				{
					LoadState = LoadState.Loading;
					// 로딩이 완료되면 로드된 에셋을 가져옵니다.
					BuiltinObject = Resources.Load(BuiltinPath); ;
				}

				// 로딩 상태를 업데이트하고 최종 결과를 콜백합니다.
				LoadState = BuiltinObject == null ? LoadState.Error : LoadState.Success;
				Debug.Log($"BuiltinObject Result : {LoadState}");
				OnProgress?.Invoke(1f);
				OnResult?.Invoke(BuiltinObject);
			}
			public void Unload()
			{
				if(BuiltinObject != null)
				{
					try
					{
						Object.DestroyImmediate(BuiltinObject, true);
					}
					catch { }
					BuiltinObject = null;
				}
				LoadState = LoadState.None;
			}
			public void Clear()
			{
				Unload();
				BuiltinPath = null;
			}
		}

		[ShowInInspector,ReadOnly]
		private static List<AssetBundleCash> assetBundleCashList;

		[ShowInInspector,ReadOnly]
		private static List<BuiltinObjectCash> builtinObjectCashList;
		// 싱글톤 초기화
		protected override void CreatedSingleton()
		{
			assetBundleCashList = new List<AssetBundleCash>();
			builtinObjectCashList = new List<BuiltinObjectCash>();
		}

		// 싱글톤 해제
		protected override void DestroySingleton()
		{
			if(assetBundleCashList != null)
			{
				foreach(var assetBundleCash in assetBundleCashList)
				{
					assetBundleCash.Clear();
				}
				assetBundleCashList.Clear();
				assetBundleCashList = null;
			}
			if(builtinObjectCashList != null)
			{
				foreach(var builtinObjectCash in builtinObjectCashList)
				{
					builtinObjectCash.Clear();
				}
				builtinObjectCashList.Clear();
				builtinObjectCashList = null;
			}
		}

		private static void LoadAssetBundle(MonoBehaviour target, string bundleName, Action<float> progress, Action<AssetBundle> result)
		{
			Instance(Instance =>
			{
				if(target == null) target = Instance;
				bool downAsync = true;
#if UNITY_EDITOR
				if(!UnityEditor.EditorApplication.isPlaying)
				{
					downAsync = false;
				}
#endif
				if(downAsync)
				{
					Instance.StartCoroutine(Instance.DownloadBundleAsync(bundleName, value =>
					{
						if(target != null) progress?.Invoke(value);
					},
					LoadAssetBundleCash =>
					{
						if(target != null)
						{
							result?.Invoke(LoadAssetBundleCash.AssetBundle);
						}
					}));
				}
				else
				{
					Instance.DownloadBundleNow(bundleName, value =>
					{
						if(target != null) progress?.Invoke(value);
					},
					LoadAssetBundleCash =>
					{
						if(target != null)
						{
							result?.Invoke(LoadAssetBundleCash.AssetBundle);
						}
					});
				}
			});
		}
		private static void LoadAssetObject<T>(MonoBehaviour target, string bundleName, string assetName, Action<float> progress, Action<T> result) where T : Object
		{
			Instance(Instance =>
			{
				if(target == null) target = Instance;
				bool downAsync = true;
#if UNITY_EDITOR
				if(!UnityEditor.EditorApplication.isPlaying)
				{
					downAsync = false;
				}
#endif
				if(downAsync)
				{
					Instance.StartCoroutine(Instance.DownloadBundleAssetAsync(bundleName, assetName,
					value =>
					{
						if(target != null) progress?.Invoke(value);
					},
					(LoadAssetBundleCash, LoadAssetObjectCash) =>
					{
						if(target != null)
						{
							if(LoadAssetObjectCash.AssetObject is T tAsset)
							{
								result?.Invoke(tAsset);
							}
							else
							{
								Debug.LogError($"Type({typeof(T).Name}) Mismatch");
								result?.Invoke(null);
							}
						}
					}));
				}
				else
				{
					Instance.DownloadBundleAssetNow(bundleName, assetName,
					value =>
					{
						if(target != null) progress?.Invoke(value);
					},
					(LoadAssetBundleCash, LoadAssetObjectCash) =>
					{
						if(target != null)
						{
							if(LoadAssetObjectCash.AssetObject is T tAsset)
							{
								result?.Invoke(tAsset);
							}
							else
							{
								Debug.LogError($"Type({typeof(T).Name}) Mismatch");
								result?.Invoke(null);
							}
						}
					});
				}
			});
		}
		private void DownloadBundleNow(string bundleName, Action<float> progress, Action<AssetBundleCash> _result)
		{
			if(string.IsNullOrWhiteSpace(bundleName))
			{
				_result?.Invoke(null);
				return;
			}

			AssetBundleCash assetBundleCash = assetBundleCashList.Find(assetBundle => assetBundle.BundleName == bundleName);

			if(assetBundleCash == null)
			{
				assetBundleCash = new AssetBundleCash()
				{
					BundleName = bundleName,
					AssetBundle = null,
					OnResult = null,
					OnProgress = null,
					LoadState = LoadState.None,
					AssetObjectCashList = new List<AssetObjectCash>(),
				};
				assetBundleCashList.Add(assetBundleCash);
			}

			AssetBundle assetBundle = null;

			assetBundleCash.DownloadNow(progress, loadBundle => assetBundle = loadBundle);

			if(assetBundle == null)
			{
				_result?.Invoke(null);
				return;
			}
			progress?.Invoke(1f);
			_result?.Invoke(assetBundleCash);
		}
		private IEnumerator DownloadBundleAsync(string bundleName, Action<float> progress, Action<AssetBundleCash> _result)
		{
			if(string.IsNullOrWhiteSpace(bundleName))
			{
				_result?.Invoke(null);
				yield break;
			}

			AssetBundleCash assetBundleCash = assetBundleCashList.Find(assetBundle => assetBundle.BundleName == bundleName);

			if(assetBundleCash == null)
			{
				assetBundleCash = new AssetBundleCash()
				{
					BundleName = bundleName,
					AssetBundle = null,
					OnResult = null,
					OnProgress = null,
					LoadState = LoadState.None,
					AssetObjectCashList = new List<AssetObjectCash>(),
				};
				assetBundleCashList.Add(assetBundleCash);
			}

			AssetBundle assetBundle = null;

			yield return assetBundleCash.DownloadAsync(progress, loadBundle => assetBundle = loadBundle);

			if(assetBundle == null)
			{
				_result?.Invoke(null);
				yield break;
			}
			progress?.Invoke(1f);
			_result?.Invoke(assetBundleCash);
		}
		private void DownloadBundleAssetNow(string bundleName, string assetName, Action<float> progress, Action<AssetBundleCash, AssetObjectCash> _result)
		{
			if(string.IsNullOrWhiteSpace(bundleName) || string.IsNullOrWhiteSpace(assetName))
			{
				_result?.Invoke(null, null);
				return;
			}

			float progressValue = 0f;
			AssetBundleCash assetBundleCash = null;
			DownloadBundleNow(bundleName,
				  value => progress?.Invoke(value * 0.5f + progressValue),
				  loadCash => assetBundleCash = loadCash);

			if(assetBundleCash == null || assetBundleCash.AssetBundle == null)
			{
				_result?.Invoke(null, null);
				return;
			}

			List<AssetObjectCash> objectCashList = assetBundleCash.AssetObjectCashList;
			AssetObjectCash assetObjectCash = objectCashList.Find(cash => cash.AssetName == assetName);

			if(assetObjectCash == null)
			{
				assetObjectCash = new AssetObjectCash()
				{
					AssetName = assetName,
					AssetObject = null,
					OnResult = null,
					OnProgress = null,
					LoadState = LoadState.None,
				};
				assetBundleCash.AssetObjectCashList.Add(assetObjectCash);
			}

			progressValue = 0.5f;
			Object asset = null;
			assetObjectCash.DownloadNow(assetBundleCash.AssetBundle,
				value => progress?.Invoke(value * 0.5f + progressValue),
				loadAsset => asset = loadAsset);

			if(asset == null)
			{
				_result?.Invoke(null, null);
				return;
			}
			_result?.Invoke(assetBundleCash, assetObjectCash);
		}
		private IEnumerator DownloadBundleAssetAsync(string bundleName, string assetName, Action<float> progress, Action<AssetBundleCash, AssetObjectCash> _result)
		{
			if(string.IsNullOrWhiteSpace(bundleName) || string.IsNullOrWhiteSpace(assetName))
			{
				_result?.Invoke(null, null);
				yield break;
			}

			float progressValue = 0f;
			AssetBundleCash assetBundleCash = null;
			yield return DownloadBundleAsync(bundleName,
				  value => progress?.Invoke(value * 0.5f + progressValue),
				  loadCash => assetBundleCash = loadCash);

			if(assetBundleCash == null || assetBundleCash.AssetBundle == null)
			{
				_result?.Invoke(null, null);
				yield break;
			}

			List<AssetObjectCash> objectCashList = assetBundleCash.AssetObjectCashList;
			AssetObjectCash assetObjectCash = objectCashList.Find(cash => cash.AssetName == assetName);

			if(assetObjectCash == null)
			{
				assetObjectCash = new AssetObjectCash()
				{
					AssetName = assetName,
					AssetObject = null,
					OnResult = null,
					OnProgress = null,
					LoadState = LoadState.None,
				};
				assetBundleCash.AssetObjectCashList.Add(assetObjectCash);
			}

			progressValue = 0.5f;
			Object asset = null;
			yield return assetObjectCash.DownloadAsync(assetBundleCash.AssetBundle,
				value => progress?.Invoke(value * 0.5f + progressValue),
				loadAsset => asset = loadAsset);

			if(asset == null)
			{
				_result?.Invoke(null, null);
				yield break;
			}
			_result?.Invoke(assetBundleCash, assetObjectCash);
		}
		public static void UnloadAssetBundle(string bundleName)
		{
			Instance(Instance =>
			{
				if(bundleName.IsNullOrWhitespace()) return;

				AssetBundleCash assetBundleCash = assetBundleCashList.Find(assetBundle => assetBundle.BundleName == bundleName);

				if(assetBundleCash == null) return;

				assetBundleCash.Unload();
			});
		}
		public static void UnloadAssetObject(string bundleName, string assetName)
		{
			Instance(Instance =>
			{
				if(bundleName.IsNullOrWhitespace() || assetName.IsNullOrWhitespace()) return;

				AssetBundleCash assetBundleCash = assetBundleCashList.Find(assetBundle => assetBundle.BundleName == bundleName);

				if(assetBundleCash == null) return;

				List<AssetObjectCash> list = assetBundleCash.AssetObjectCashList;

				if(list.IsNullOrEmpty()) return;

				var assetObjectCash = list.Find(assetObject => assetObject.AssetName == assetName);

				if(assetObjectCash == null) return;

				assetObjectCash.Unload();
				assetBundleCash.AssetObjectCashList.Remove(assetObjectCash);
				assetBundleCash.AssetObjectCashList.RemoveTo(item => item.LoadState == LoadState.Error);
				if(assetBundleCash.AssetObjectCashList.Count == 0)
				{
					assetBundleCash.Unload();
				}
			});
		}

		private static void LoadBuiltinAsset<T>(MonoBehaviour target, string builtinPath, Action<float> progress, Action<T> result) where T : Object
		{
			Instance(Instance =>
			{
				if(target == null) target = Instance;
				bool downAsync = true;
#if UNITY_EDITOR
				if(!UnityEditor.EditorApplication.isPlaying)
				{
					downAsync = false;
				}
#endif
				if(downAsync)
				{
					Instance.StartCoroutine(Instance.DownloadBuiltinAssetAsync(builtinPath,
					value =>
					{
						if(target != null) progress?.Invoke(value);
					},
					(BuiltinObjectCash) =>
					{
						if(target != null)
						{
							if(BuiltinObjectCash.BuiltinObject is T tAsset)
							{
								result?.Invoke(tAsset);
							}
							else
							{
								Debug.LogError($"Type({typeof(T).Name}) Mismatch");
								result?.Invoke(null);
							}
						}
					}));
				}
				else
				{
					Instance.DownloadBuiltinAssetNow(builtinPath,
					value =>
					{
						if(target != null) progress?.Invoke(value);
					},
					(BuiltinObjectCash) =>
					{
						if(target != null)
						{
							if(BuiltinObjectCash.BuiltinObject is T tAsset)
							{
								result?.Invoke(tAsset);
							}
							else
							{
								Debug.LogError($"Type({typeof(T).Name}) Mismatch");
								result?.Invoke(null);
							}
						}
					});
				}
			});
		}
		private void DownloadBuiltinAssetNow(string builtinPath, Action<float> progress, Action<BuiltinObjectCash> _result)
		{
			if(builtinPath.IsNullOrWhitespace())
			{
				_result?.Invoke(null);
				return;
			}

			BuiltinObjectCash builtinObjectCash = builtinObjectCashList.Find(builtin => builtin.BuiltinPath == builtinPath);
			if(builtinObjectCash == null)
			{
				builtinObjectCash = new BuiltinObjectCash()
				{
					BuiltinPath = builtinPath,
					BuiltinObject = null,
					OnResult = null,
					OnProgress = null,
					AutoUnloadTime = null,
					LoadState = LoadState.None,
				};
				builtinObjectCashList.Add(builtinObjectCash);
			}

			Object builtin = null;
			builtinObjectCash.DownloadNow(
				  value => progress?.Invoke(value),
				loadbuiltin => builtin = loadbuiltin);

			if(builtin == null)
			{
				_result?.Invoke(null);
				return;
			}

			_result?.Invoke(builtinObjectCash);
		}
		private IEnumerator DownloadBuiltinAssetAsync(string builtinPath, Action<float> progress, Action<BuiltinObjectCash> _result)
		{
			if(builtinPath.IsNullOrWhitespace())
			{
				_result?.Invoke(null);
				yield break;
			}

			BuiltinObjectCash builtinObjectCash = builtinObjectCashList.Find(builtin => builtin.BuiltinPath == builtinPath);
			if(builtinObjectCash == null)
			{
				builtinObjectCash = new BuiltinObjectCash()
				{
					BuiltinPath = builtinPath,
					BuiltinObject = null,
					OnResult = null,
					OnProgress = null,
					AutoUnloadTime = null,
					LoadState = LoadState.None,
				};
				builtinObjectCashList.Add(builtinObjectCash);
			}

			Object builtin = null;
			yield return builtinObjectCash.DownloadAsync(
				  value => progress?.Invoke(value),
				loadbuiltin => builtin = loadbuiltin);

			if(builtin == null)
			{
				_result?.Invoke(null);
				yield break;
			}

			_result?.Invoke(builtinObjectCash);
		}
		public static void UnloadBuiltin(string builtinPath)
		{
			Instance(Instance =>
			{
				if(builtinPath.IsNullOrWhitespace()) return;

				BuiltinObjectCash builtinObjectCash = builtinObjectCashList.Find(builtin => builtin.BuiltinPath == builtinPath);

				if(builtinObjectCash == null) return;

				builtinObjectCash.Unload();
			});
		}



		public static void AsyncInstantiate<T>(ResourcesKey loadKey, MonoBehaviour mono, Action<float> progress, Action<T> result) where T : Object
		{
			switch(loadKey.LoadType)
			{
				case eLoadType.Resources:
				LoadBuiltinAsset<GameObject>(mono, loadKey.FullPath,
					value => progress?.Invoke(value),
					loadAsset =>
					{
						loadAsset.SetActive(!loadKey.onDisableLoad);
						result?.Invoke(GameObject.Instantiate(loadAsset) as T);
					}
					);
				break;
				case eLoadType.AssetBundle:
				LoadAssetObject<T>(mono, loadKey.BundleName, loadKey.FullPath,
					value => progress?.Invoke(value),
					loadAsset =>
					{
						if(loadAsset is GameObject gameObj)
						{
							gameObj.SetActive(!loadKey.onDisableLoad);
						}
						result?.Invoke(GameObject.Instantiate(loadAsset));
					}
					);
				break;
				default:
				result?.Invoke(null);
				break;
			}
		}
		public static void Unload(ResourcesKey loadKey)
		{
			switch(loadKey.LoadType)
			{
				case eLoadType.Resources:
				UnloadBuiltin(loadKey.FullPath);
				break;
				case eLoadType.AssetBundle:
				UnloadAssetObject(loadKey.BundleName, loadKey.FullPath);
				break;
			}
		}
	}
}
