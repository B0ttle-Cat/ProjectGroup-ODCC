using System;
using System.Collections.Generic;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.Base
{
	public static class Theme
	{
		private static ThemeAssetsData ThemeAssetsData = null;

		public static bool GetAsset<TEnum, TAsset>(TEnum theme, out TAsset asset)
		{
			if(ThemeAssetsData == null)
			{
				ThemeAssetsData = Resources.Load<ThemeAssetsData>("Theme/MainThemeAsset");
			}

			if(ThemeAssetsData == null)
			{
				asset = default;
				return false;
			}

			return ThemeAssetsData.TryGetThemeAsset(theme, out asset);
		}
	}


	[CreateAssetMenu(fileName = "new ThemeAsset", menuName = "BC/new ThemeAsset")]
	public class ThemeAssetsData : ScriptableObject
	{
		[TableList]
		public List<ThemeAsset<ColorTheme,Color>> ColorThemeAssets;
		[TableList]
		public List<ThemeAsset<AudioTheme,AudioClip>> AudioThemeAssets;
		[TableList]
		[Tooltip("Check [Default Style Sheet]")]
		public List<ThemeAsset<TextTheme,string>> TextThemeAssets;
		public void Reset()
		{
			CreateList(ref ColorThemeAssets);
			CreateList(ref AudioThemeAssets);
			CreateList(ref TextThemeAssets);

			void CreateList<TEnum, TAsset>(ref List<ThemeAsset<TEnum, TAsset>> lists)
			{
				lists = new List<ThemeAsset<TEnum, TAsset>>();
				Array array = Enum.GetValues(typeof(TEnum));
				if(array != null)
				{
					foreach(TEnum item in array)
					{
						lists.Add(new ThemeAsset<TEnum, TAsset>(item, default));
					}
				}
			}
		}
		public bool TryGetThemeAsset<TEnum, TAsset>(TEnum theme, out TAsset asset)
		{
			if(CheckEqualsType<ColorTheme, Color>(out ColorTheme colorType) && colorType != ColorTheme.None)
			{
				var item = ColorThemeAssets.Find(item => item.Theme == colorType);
				if(item.Asset is TAsset _asset)
				{
					asset = _asset;
					return true;
				}
			}
			else if(CheckEqualsType<AudioTheme, AudioClip>(out AudioTheme audioType) && audioType != AudioTheme.None)
			{
				var item = AudioThemeAssets.Find(item => item.Theme == audioType);
				if(item.Asset is TAsset _asset)
				{
					asset = _asset;
					return true;
				}
			}
			else if(CheckEqualsType<TextTheme, string>(out TextTheme textType))
			{
				var item = TextThemeAssets.Find(item => item.Theme == textType);
				if(item.Asset is TAsset _asset)
				{
					asset = _asset;
					return true;
				}
			}


			asset = default;
			return false;

			bool CheckEqualsType<CTheme, CAsset>(out CTheme themeType)
			{
				bool result = (typeof(TEnum) == typeof(CTheme)) && (typeof(TAsset) == typeof(CAsset));
				themeType = (result && theme is CTheme cTheme) ? cTheme : (CTheme)default;
				return result;
			}
		}
	}

	[Serializable]
	public struct ThemeAsset<TEnum>
	{
		public TEnum Theme;
		public TEnum Asset => Theme;

		public ThemeAsset(TEnum theme)
		{
			Theme=theme;
		}
	}
	[Serializable]
	public struct ThemeAsset<TEnum, TAsset>
	{
		public TEnum Theme;
		public TAsset Asset;

		public ThemeAsset(TEnum theme, TAsset asset)
		{
			Theme=theme;
			Asset=asset;
		}
	}

	public enum ColorTheme : int
	{
		White = -20,
		Black,
		Gray,

		None = 0,
		Normal,
		Title,
		BackgroundBoard,
		Handle,

		Yes = 20,
		No,
		Info,
		Success,
		Warring,
		Error,
	}

	public enum AudioTheme : int
	{
		None = 0,

		Button_Click = 20,

		Open_Popup = 40,
		Close_Popup,

		Open_Window,
		Close_Window,

		Info = 60,
		Success,
		Warring,
		Error,
	}

	public enum TextTheme : int
	{
		Normal = 0,

		Title_Light = 10,
		Title_Dark,

		Body_Light = 20,
		Body_Dark,

		Yes = 30,
		No,
		Info,
		Success,
		Warring,
		Error,

	}
}
