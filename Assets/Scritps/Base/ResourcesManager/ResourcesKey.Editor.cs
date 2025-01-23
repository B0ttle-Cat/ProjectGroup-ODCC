//#if UNITY_EDITOR

//namespace BC.Base
//{

//	public partial struct ResourcesKey//Editor
//	{
//		//	//[ShowInInspector, PropertyOrder(-10), HorizontalGroup("InEdite", width: 0.3f), LabelWidth(80)]
//		//	private static bool enableEdit { get; set; } = false;


//		//	[ShowInInspector, PropertyOrder(-10), HideLabel, SuffixLabel("Target____", true)]
//		//	[ShowIf("@LoadType != eResourcesLoadType.None")]
//		//	[InlineButton("ClearSetupTarget", "Clear")]
//		//	[InlineButton("UpdateSetupTarget", "Update")]
//		//	public Object target { get; set; }
//		//	[ShowInInspector, PropertyOrder(-10), LabelWidth(80)]
//		//	[ShowIf("@LoadType != eResourcesLoadType.None && LoadType == eResourcesLoadType.AssetBundle")]
//		//	[ValueDropdown("GetPathInBundle"), HideLabel]
//		//	private string TargetPathInBundle { get; set; }

//		//	//[ShowIf("@ShowEdit")]
//		//	//[HorizontalGroup("Button"), PropertyOrder(-9)]
//		//	//[InlineButton("UpdateSetupTarget")]
//		//	public void UpdateSetupTarget()
//		//	{
//		//		if(UnityEditor.EditorApplication.isPlaying) return;
//		//		if(LoadType == eResourcesLoadType.None) return;
//		//		if(target == null) return;

//		//		string _BundleName = "";
//		//		string _FullPath = "";
//		//		Object _ObjectAsset = null;

//		//		try
//		//		{
//		//			if(LoadType == eResourcesLoadType.None)
//		//			{
//		//				_ObjectAsset = target;
//		//			}
//		//			else if(LoadType == eResourcesLoadType.ResourcesLoad)
//		//			{
//		//				string assetPath = UnityEditor.AssetDatabase.GetAssetPath(target);
//		//				string resourcePath = GetResourcePath(assetPath);
//		//				if(string.IsNullOrWhiteSpace(resourcePath))
//		//				{
//		//					return;
//		//				}

//		//				Object loadedObject = Resources.Load(resourcePath);
//		//				if(loadedObject != null)
//		//				{
//		//					_FullPath = resourcePath;
//		//				}
//		//				else
//		//				{
//		//					return;
//		//				}
//		//			}
//		//			else if(LoadType == eResourcesLoadType.AssetBundle)
//		//			{
//		//				var list = GetPathInBundle();
//		//				if(list.Count == 0)
//		//				{
//		//					return;
//		//				}
//		//				if(string.IsNullOrWhiteSpace(TargetPathInBundle))
//		//				{
//		//					return;
//		//				}
//		//				_BundleName = target.name;
//		//				_FullPath = TargetPathInBundle;
//		//			}


//		//			ClearSetupTarget();
//		//			BundleName  = _BundleName;
//		//			FullPath    = _FullPath;
//		//			None = _ObjectAsset;
//		//		}
//		//		catch(Exception ex)
//		//		{
//		//			Debug.LogException(ex);
//		//		}
//		//	}
//		//	//[ShowIf("@ShowEdit")]
//		//	//[HorizontalGroup("Button"), PropertyOrder(-9)]
//		//	//[Button("Clear")]
//		//	public void ClearSetupTarget()
//		//	{
//		//		BundleName = "";
//		//		FullPath = "";
//		//		None = null;
//		//	}


//		//	private bool ShowEdit => LoadType == eResourcesLoadType.None;
//		//	private bool ShowBundleName => ShowEdit || LoadType == eResourcesLoadType.AssetBundle;
//		//	private bool ShowFullPath => ShowEdit || (LoadType == eResourcesLoadType.AssetBundle || LoadType == eResourcesLoadType.ResourcesLoad);
//		//	private bool ShowObjectAsset => ShowEdit || LoadType == eResourcesLoadType.None;


//		//	private bool EnableBundleName => ShowEdit;
//		//	private bool EnableFullPath => ShowEdit;
//		//	private bool EnableObjectAsset => ShowEdit;

//		//	string GetResourcePath(string assetPath)
//		//	{
//		//		// 리소스 폴더 내의 상대 경로 가져오기
//		//		int index = assetPath.IndexOf("Resources/");

//		//		if(index != -1)
//		//		{
//		//			string path = assetPath.Substring(index + "Resources/".Length);
//		//			// 확장자 제거
//		//			path = path.Substring(0, path.LastIndexOf('.'));
//		//			return path;
//		//		}
//		//		else
//		//		{
//		//			Debug.LogError("Object is not in the Resources folder.");
//		//			return null;
//		//		}
//		//	}
//		//	private List<string> GetPathInBundle()
//		//	{
//		//		if(target == null || LoadType != eResourcesLoadType.AssetBundle) return new List<string>();
//		//		string assetName = target.name;

//		//		List<string> assetsNames = new List<string>();

//		//		try
//		//		{
//		//			string fullLocalPath = Path.Combine(ConstString.BundleLocalPath, assetName);
//		//			if(!Directory.Exists(ConstString.BundleLocalPath))
//		//			{
//		//				Directory.CreateDirectory(ConstString.BundleLocalPath);
//		//			}
//		//			AssetBundle assetBundle = null;
//		//			var loadedList =  AssetBundle.GetAllLoadedAssetBundles();
//		//			loadedList.ForEach(loaded => {
//		//				if(loaded.name == assetName)
//		//				{
//		//					assetBundle = loaded;
//		//				}
//		//			});
//		//			if(assetBundle == null)
//		//			{
//		//				assetBundle = AssetBundle.LoadFromFile(fullLocalPath);
//		//			}
//		//			if(assetBundle != null)
//		//			{
//		//				assetsNames.AddRange(assetBundle.GetAllAssetNames());
//		//				assetBundle.Unload(true);
//		//			}
//		//		}
//		//		catch(Exception ex)
//		//		{
//		//			Debug.LogException(ex);
//		//		}
//		//		return assetsNames;
//		//	}



//		//	private const string Fail_CheckResourcesKey = "지정된 에셋을 찾을 수 없습니다!";
//		//	private const string Success_CheckResourcesKey = "지정된 에셋을 사용 가능합니다.";
//		//	private bool ShowErrorCheckResourcesKey()
//		//	{
//		//		Object load = null;
//		//		try
//		//		{

//		//			if(LoadType == eResourcesLoadType.None)
//		//			{
//		//				load = null;
//		//			}
//		//			else if(LoadType == eResourcesLoadType.None)
//		//			{
//		//				load =  None;
//		//			}
//		//			else if(LoadType == eResourcesLoadType.ResourcesLoad)
//		//			{
//		//				load = Resources.Load(FullPath);
//		//			}
//		//			else if(LoadType == eResourcesLoadType.AssetBundle)
//		//			{
//		//				string BundleName = this.BundleName;
//		//				if(!BundleName.IsNullOrWhiteSpace())
//		//				{
//		//					string fullLocalPath = Path.Combine(ConstString.BundleLocalPath, BundleName);
//		//					AssetBundle assetBundle = null;
//		//					List<string> assetsNames = new List<string>();

//		//					var loadedList =  AssetBundle.GetAllLoadedAssetBundles();
//		//					loadedList.ForEach(loaded => {
//		//						if(loaded.name == BundleName)
//		//						{
//		//							assetBundle = loaded;
//		//						}
//		//					});
//		//					if(assetBundle == null)
//		//					{
//		//						assetBundle = AssetBundle.LoadFromFile(fullLocalPath);
//		//					}
//		//					if(assetBundle != null)
//		//					{
//		//						load = assetBundle.LoadAsset(FullPath);
//		//						assetBundle.Unload(true);
//		//					}
//		//				}
//		//			}
//		//		}
//		//		catch(Exception ex)
//		//		{
//		//			load = null;
//		//			Debug.LogException(ex);
//		//		}

//		//		return load == null;
//		//	}
//		//	private bool ShowSuccessCheckResourcesKey()
//		//	{
//		//		return !ShowErrorCheckResourcesKey();
//		//	}
//	}
//}

//#endif