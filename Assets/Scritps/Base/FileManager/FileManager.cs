using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;

using UnityEngine;

namespace BC.Base
{
	public static class FileManager
	{
		public enum FileSlotName
		{
			Golbal  = -1,
			Slot_00 = 0,
			Slot_01,
			Slot_02,
			Slot_03,
			Slot_04,
			Slot_05,
			Slot_06,
			Slot_07,
			Slot_08,
			Slot_09,
			Slot_10,
			Custom,
		}

		public static string GetFileSlotPath(FileSlotName slotIndex) => slotIndex switch
		{
			FileSlotName.Golbal => $"Save/{nameof(FileSlotName.Golbal)}",
			FileSlotName.Slot_00 => $"Save/{nameof(FileSlotName.Slot_00)}",
			FileSlotName.Slot_01 => $"Save/{nameof(FileSlotName.Slot_01)}",
			FileSlotName.Slot_02 => $"Save/{nameof(FileSlotName.Slot_02)}",
			FileSlotName.Slot_03 => $"Save/{nameof(FileSlotName.Slot_03)}",
			FileSlotName.Slot_04 => $"Save/{nameof(FileSlotName.Slot_04)}",
			FileSlotName.Slot_05 => $"Save/{nameof(FileSlotName.Slot_05)}",
			FileSlotName.Slot_06 => $"Save/{nameof(FileSlotName.Slot_06)}",
			FileSlotName.Slot_07 => $"Save/{nameof(FileSlotName.Slot_07)}",
			FileSlotName.Slot_08 => $"Save/{nameof(FileSlotName.Slot_08)}",
			FileSlotName.Slot_09 => $"Save/{nameof(FileSlotName.Slot_09)}",
			FileSlotName.Slot_10 => $"Save/{nameof(FileSlotName.Slot_10)}",
			_ => $"Save/",
		};


		private static ConcurrentDictionary<string, bool> lockPathList = new ConcurrentDictionary<string,bool>();

		public enum PathType
		{
			Custom,
			DataPath,
			PersistentDataPath,
			StreamingAssets,
			TemporaryCachePath,
			ConsoleLogPath,

			SaveSlot_0,
			SaveSlot_1,
			SaveSlot_2,
			SaveSlot_3,
			SaveSlot_4,
			SaveSlot_5,
		}

		public static string ApplicationPath(PathType pathType) => pathType switch
		{
			PathType.Custom => "",
			PathType.DataPath => Application.dataPath,
			PathType.PersistentDataPath => Application.persistentDataPath,
			PathType.StreamingAssets => Application.streamingAssetsPath,
			PathType.TemporaryCachePath => Application.temporaryCachePath,
			PathType.ConsoleLogPath => Application.consoleLogPath,
#if UNITY_EDITOR
			PathType.SaveSlot_0 => Path.Combine(Application.dataPath, "Editor/Save/00"),
			PathType.SaveSlot_1 => Path.Combine(Application.dataPath, "Editor/Save/01"),
			PathType.SaveSlot_2 => Path.Combine(Application.dataPath, "Editor/Save/02"),
			PathType.SaveSlot_3 => Path.Combine(Application.dataPath, "Editor/Save/03"),
			PathType.SaveSlot_4 => Path.Combine(Application.dataPath, "Editor/Save/04"),
			PathType.SaveSlot_5 => Path.Combine(Application.dataPath, "Editor/Save/05"),
#else
			PathType.SaveSlot_0 => Path.Combine(Application.dataPath, "Save/00"),
			PathType.SaveSlot_1 => Path.Combine(Application.dataPath, "Save/01"),
			PathType.SaveSlot_2 => Path.Combine(Application.dataPath, "Save/02"),
			PathType.SaveSlot_3 => Path.Combine(Application.dataPath, "Save/03"),
			PathType.SaveSlot_4 => Path.Combine(Application.dataPath, "Save/04"),
			PathType.SaveSlot_5 => Path.Combine(Application.dataPath, "Save/05"),
#endif
			_ => "",
		};

		public static void SaveAsync(PathType pathType, string path, byte[] data, Action<bool> callback)
		{
			path = PathCombine(pathType, path);
			Debug.Log($"다음 경로에 저장 시도: {path}");
			TaskManager.Run(path, async (token) =>
			{
				try
				{
					// 경로가 유효한지 확인합니다.
					if(string.IsNullOrWhiteSpace(path))
					{
						Debug.LogError("잘못된 파일 경로입니다.");
						callback?.Invoke(false);
						return;
					}

					// 디렉토리가 존재하지 않으면 생성합니다.
					string directory = Path.GetDirectoryName(path);
					if(!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
					{
						Directory.CreateDirectory(directory);
					}

					// 데이터를 파일에 비동기적으로 저장합니다.
					using(FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
					{
						await fileStream.WriteAsync(data, 0, data.Length, token)
						.ContinueWith(task =>
						{
							if(task.IsFaulted || task.IsCanceled)
							{
								Debug.LogError($"경로 {path}에 파일 저장 실패\n에러: {task.Exception?.Message}");
								callback?.Invoke(false);
							}
							else
							{
								Debug.Log($"파일 저장 성공: {path}");
								callback?.Invoke(true);
							}
						}, token);
					}

				}
				catch(IOException e)
				{
					// 저장 오류를 처리합니다.
					Debug.LogError($"경로 {path}에 파일 저장 실패\n에러: {e.Message}");
					callback?.Invoke(false);
				}
			}, () => callback?.Invoke(false));
		}
		public static void SaveAsync(PathType pathType, string path, string data, Action<bool> callback)
		{
			path = PathCombine(pathType, path);
			Debug.Log($"다음 경로에 저장 시도: {path}");
			TaskManager.Run(path, async (token) =>
			{
				try
				{
					// 경로가 유효한지 확인합니다.
					if(string.IsNullOrWhiteSpace(path))
					{
						Debug.LogError("잘못된 파일 경로입니다.");
						callback?.Invoke(false);
						return;
					}

					// 디렉토리가 존재하지 않으면 생성합니다.
					string directory = Path.GetDirectoryName(path);
					if(!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
					{
						Directory.CreateDirectory(directory);
					}

					// 데이터를 파일에 비동기적으로 저장합니다.
					using(StreamWriter writer = new StreamWriter(path))
					{
						await writer.WriteAsync(data.AsMemory(), token)
						.ContinueWith(task =>
						{
							if(task.IsFaulted || task.IsCanceled)
							{
								Debug.LogError($"경로 {path}에 파일 저장 실패\n에러: {task.Exception?.Message}");
								callback?.Invoke(false);
							}
							else
							{
								Debug.Log($"파일 저장 성공: {path}");
								callback?.Invoke(true);
							}
						}, token);
					}
				}
				catch(IOException e)
				{
					// 저장 오류를 처리합니다.
					Debug.LogError($"경로 {path}에 파일 저장 실패\n에러: {e.Message}");
					callback?.Invoke(false);
				}
			}, () => callback?.Invoke(false));
		}

		public static void LoadAsync(PathType pathType, string path, Action<bool, byte[]> callback)
		{
			path = PathCombine(pathType, path);
			Debug.Log($"다음 경로에서 불러오기 시도: {path}");
			TaskManager.Run(path, async (token) =>
			{
				try
				{
					// 경로가 유효한지 확인합니다.
					if(string.IsNullOrWhiteSpace(path))
					{
						Debug.LogError("잘못된 파일 경로입니다.");
						callback?.Invoke(false, null);
						return;
					}

					// 디렉토리가 존재하지 않으면 생성합니다.
					string directory = Path.GetDirectoryName(path);
					if(!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
					{
						Directory.CreateDirectory(directory);
					}

					// 파일이 없을 경우 빈 파일을 생성합니다.
					if(!File.Exists(path))
					{
						File.WriteAllText(path, string.Empty);
						callback?.Invoke(true, new byte[0]);
						return;
					}

					// 파일로부터 데이터를 비동기적으로 불러옵니다.
					using(FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
					{
						byte[] buffer = new byte[fileStream.Length];
						await fileStream.ReadAsync(buffer, 0, (int)fileStream.Length, token)
						.ContinueWith(task =>
						{
							if(task.IsFaulted || task.IsCanceled)
							{
								Debug.LogError($"경로 {path}의 파일 불러오기 실패\n에러: {task.Exception?.Message}");
								callback?.Invoke(false, null);
							}
							else
							{
								callback?.Invoke(true, buffer);
							}
						}, token);
					}
				}
				catch(IOException e)
				{
					// 불러오기 오류를 처리합니다.
					Debug.LogError($"경로 {path}의 파일 불러오기 실패\n에러: {e.Message}");
					callback?.Invoke(false, null);
				}
			}, () => callback?.Invoke(false, new byte[0]));
		}
		public static void LoadAsync(PathType pathType, string path, Action<bool, string> callback)
		{
			path = PathCombine(pathType, path);
			Debug.Log($"다음 경로에서 불러오기 시도: {path}");
			TaskManager.Run(path, async (token) =>
			{
				try
				{
					// 경로가 유효한지 확인합니다.
					if(string.IsNullOrWhiteSpace(path))
					{
						Debug.LogError("잘못된 파일 경로입니다.");
						callback?.Invoke(false, null);
						return;
					}

					// 디렉토리가 존재하지 않으면 생성합니다.
					string directory = Path.GetDirectoryName(path);
					if(!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
					{
						Directory.CreateDirectory(directory);
					}

					// 파일이 없을 경우 빈 값을 반환합니다.
					if(!File.Exists(path))
					{
						callback?.Invoke(true, string.Empty);
						return;
					}
					// 파일로부터 데이터를 비동기적으로 불러옵니다.
					using(StreamReader reader = new StreamReader(path))
					{

						await reader.ReadToEndAsync().ContinueWith(task =>
						{
							if(task.IsFaulted || task.IsCanceled)
							{
								Debug.LogError($"경로 {path}의 파일 불러오기 실패\n에러: {task.Exception?.Message}");
								callback?.Invoke(false, null);
							}
							else
							{
								callback?.Invoke(true, task.Result);
							}
						}, token);
					}
				}
				catch(IOException e)
				{
					// 불러오기 오류를 처리합니다.
					Debug.LogError($"경로 {path}의 파일 불러오기 실패\n에러: {e.Message}");
					callback?.Invoke(false, null);
				}
			}, () => callback?.Invoke(false, ""));
		}


		public static void DeleteFolderAsync(PathType pathType, string path, Action<bool> callback)
		{
			path = PathCombine(pathType, path);
			Debug.Log($"다음 경로의 폴더 및 파일 삭제 시도: {path}");
			// 모든 파일을 비동기적으로 삭제합니다.
			TaskManager.Run(path, async (token) =>
			{
				try
				{
					if(Directory.Exists(path))
					{
						// 폴더 내의 모든 파일 삭제
						string[] files = Directory.GetFiles(path);
						foreach(string file in files)
						{
							File.Delete(file);
							Debug.Log($"파일 삭제됨: {file}");
						}

						// 폴더 삭제
						Directory.Delete(path, true);
						Debug.Log($"폴더 삭제됨: {path}");
						callback?.Invoke(true);
					}
					else
					{
						Debug.LogWarning($"경로 {path}에 폴더를 찾을 수 없어 삭제할 수 없습니다.");
						callback?.Invoke(false);
					}
				}
				catch(IOException e)
				{
					Debug.LogError($"경로 {path}의 폴더 및 파일 삭제 실패\n에러: {e.Message}");
					callback?.Invoke(false);
				}
			}, () => callback?.Invoke(false));
		}
		public static void DeleteAsync(PathType pathType, string path, Action<bool> callback)
		{
			path = PathCombine(pathType, path);
			Debug.Log($"다음 경로의 파일 삭제 시도: {path}");
			// 파일을 비동기적으로 삭제합니다.
			TaskManager.Run(path, async (token) =>
			{
				try
				{
					if(Directory.Exists(path))
					{
						File.Delete(path);
						Debug.Log($"파일 삭제됨: {path}");
						callback?.Invoke(true);
					}
					else
					{
						// 파일이 존재하지 않으면 경고를 로그로 남깁니다.
						Debug.LogWarning($"경로 {path}에 파일을 찾을 수 없어 삭제할 수 없습니다.");
						callback?.Invoke(false);
					}
				}
				catch(IOException e)
				{
					// 삭제 오류를 처리합니다.
					Debug.LogError($"경로 {path}의 파일 삭제 실패\n에러: {e.Message}");
					callback?.Invoke(false);
				}
			}, () => callback?.Invoke(false));
		}


		public static void Save(PathType pathType, string path, byte[] data, Action<bool> callback)
		{
			path = PathCombine(pathType, path);
			Debug.Log($"다음 경로에 저장 시도: {path}");
			try
			{
				TaskManager.Stop(path);

				// 경로가 유효한지 확인합니다.
				if(string.IsNullOrWhiteSpace(path))
				{
					Debug.LogError("잘못된 파일 경로입니다.");
					callback?.Invoke(false);
					return;
				}

				// 디렉토리가 존재하지 않으면 생성합니다.
				string directory = Path.GetDirectoryName(path);
				if(!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
				{
					Directory.CreateDirectory(directory);
				}

				// 데이터를 파일에 비동기적으로 저장합니다.
				using(FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
				{
					fileStream.Write(data, 0, data.Length);

					Debug.Log($"파일 저장 성공: {path}");
					callback?.Invoke(true);
				}
			}
			catch(IOException e)
			{
				// 저장 오류를 처리합니다.
				Debug.LogError($"경로 {path}에 파일 저장 실패\n에러: {e.Message}");
				callback?.Invoke(false);
			}
		}
		public static void Save(PathType pathType, string path, string data, Action<bool> callback)
		{
			path = PathCombine(pathType, path);
			Debug.Log($"다음 경로에 저장 시도: {path}");
			try
			{
				TaskManager.Stop(path);

				// 경로가 유효한지 확인합니다.
				if(string.IsNullOrWhiteSpace(path))
				{
					Debug.LogError("잘못된 파일 경로입니다.");
					callback?.Invoke(false);
					return;
				}

				// 디렉토리가 존재하지 않으면 생성합니다.
				string directory = Path.GetDirectoryName(path);
				if(!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
				{
					Directory.CreateDirectory(directory);
				}

				// 데이터를 파일에 비동기적으로 저장합니다.
				using(StreamWriter writer = new StreamWriter(path))
				{
					writer.Write(data);

					Debug.Log($"파일 저장 성공: {path}");
					callback?.Invoke(true);
				}
			}
			catch(IOException e)
			{
				// 저장 오류를 처리합니다.
				Debug.LogError($"경로 {path}에 파일 저장 실패\n에러: {e.Message}");
				callback?.Invoke(false);
			}
		}

		public static void Load(PathType pathType, string path, Action<bool, byte[]> callback)
		{
			path = PathCombine(pathType, path);
			Debug.Log($"다음 경로에서 불러오기 시도: {path}");
			try
			{
				TaskManager.Stop(path);

				// 경로가 유효한지 확인합니다.
				if(string.IsNullOrWhiteSpace(path))
				{
					Debug.LogError("잘못된 파일 경로입니다.");
					callback?.Invoke(false, null);
					return;
				}

				// 디렉토리가 존재하지 않으면 생성합니다.
				string directory = Path.GetDirectoryName(path);
				if(!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
				{
					Directory.CreateDirectory(directory);
				}

				// 파일이 없을 경우 빈 파일을 생성합니다.
				if(!File.Exists(path))
				{
					File.WriteAllText(path, string.Empty);
					callback?.Invoke(true, new byte[0]);
					return;
				}

				// 파일로부터 데이터를 비동기적으로 불러옵니다.
				using(FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
				{
					byte[] buffer = new byte[fileStream.Length];
					fileStream.Read(buffer, 0, (int)fileStream.Length);

					Debug.Log($"파일 불러오기 성공: {path}");
					callback?.Invoke(true, buffer);
				}
			}
			catch(IOException e)
			{
				// 불러오기 오류를 처리합니다.
				Debug.LogError($"경로 {path}의 파일 불러오기 실패\n에러: {e.Message}");
				callback?.Invoke(false, null);
			}
		}
		public static void Load(PathType pathType, string path, Action<bool, string> callback)
		{
			path = PathCombine(pathType, path);
			Debug.Log($"다음 경로에서 불러오기 시도: {path}");
			try
			{
				TaskManager.Stop(path);

				// 경로가 유효한지 확인합니다.
				if(string.IsNullOrWhiteSpace(path))
				{
					Debug.LogError("잘못된 파일 경로입니다.");
					callback?.Invoke(false, null);
					return;
				}

				// 디렉토리가 존재하지 않으면 생성합니다.
				string directory = Path.GetDirectoryName(path);
				if(!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
				{
					Directory.CreateDirectory(directory);
				}

				// 파일이 없을 경우 빈 파일을 생성합니다.
				if(!File.Exists(path))
				{
					File.WriteAllText(path, string.Empty);
					callback?.Invoke(true, string.Empty);
					return;
				}

				// 파일로부터 데이터를 비동기적으로 불러옵니다.
				using(StreamReader reader = new StreamReader(path))
				{
					string read = reader.ReadToEnd();

					Debug.Log($"파일 불러오기 성공: {path}");
					callback?.Invoke(true, read);
				}
			}
			catch(IOException e)
			{
				// 불러오기 오류를 처리합니다.
				Debug.LogError($"경로 {path}의 파일 불러오기 실패\n에러: {e.Message}");
				callback?.Invoke(false, null);
			}
		}

		public static void DeleteFolder(PathType pathType, string path, Action<bool> callback)
		{
			string fullPath = PathCombine(pathType, path);
			Debug.Log($"다음 경로의 폴더 및 파일 삭제 시도: {fullPath}");

			try
			{
				TaskManager.Stop(path);

				if(Directory.Exists(fullPath))
				{
					// 모든 파일을 비동기적으로 삭제합니다.
					try
					{
						// 폴더 내의 모든 파일 삭제
						string[] files = Directory.GetFiles(fullPath);
						foreach(string file in files)
						{
							File.Delete(file);
							Debug.Log($"파일 삭제됨: {file}");
						}

						// 폴더 삭제
						Directory.Delete(fullPath, true);
						Debug.Log($"폴더 삭제됨: {fullPath}");
						callback?.Invoke(true);
					}
					catch(IOException e)
					{
						Debug.LogError($"경로 {fullPath}의 폴더 및 파일 삭제 실패\n에러: {e.Message}");
						callback?.Invoke(false);
					}
				}
				else
				{
					Debug.LogWarning($"경로 {fullPath}에 폴더를 찾을 수 없어 삭제할 수 없습니다.");
					callback?.Invoke(false);
				}
			}
			catch(IOException e)
			{
				Debug.LogError($"경로 {fullPath}의 폴더 및 파일 삭제 실패\n에러: {e.Message}");
				callback?.Invoke(false);
			}
		}
		public static void Delete(PathType pathType, string path, Action<bool> callback)
		{
			path = PathCombine(pathType, path);
			Debug.Log($"다음 경로의 파일 삭제 시도: {path}");
			try
			{
				TaskManager.Stop(path);

				// 파일이 존재하는지 확인합니다.
				if(File.Exists(path))
				{
					// 파일을 비동기적으로 삭제합니다.
					try
					{
						File.Delete(path);
						Debug.Log($"파일 삭제됨: {path}");
						callback?.Invoke(true);
					}
					catch(IOException e)
					{
						// 삭제 오류를 처리합니다.
						Debug.LogError($"경로 {path}의 파일 삭제 실패\n에러: {e.Message}");
						callback?.Invoke(false);
					}
				}
				else
				{
					// 파일이 존재하지 않으면 경고를 로그로 남깁니다.
					Debug.LogWarning($"경로 {path}에 파일을 찾을 수 없어 삭제할 수 없습니다.");
					callback?.Invoke(false);
				}
			}
			catch(IOException e)
			{
				// 삭제 오류를 처리합니다.
				Debug.LogError($"경로 {path}의 파일 삭제 실패\n에러: {e.Message}");
				callback?.Invoke(false);
			}
		}


		public static void OpenFolder(PathType pathType, string path)
		{
			path = PathCombine(pathType, path);
			if(Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
			{
				if(!path.EndsWith("/") || !path.EndsWith("\\"))
				{
					path = path + "\\";
				}
			}
			else if(Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer)
			{
				if(!path.EndsWith("/") || !path.EndsWith("\\"))
				{
					path = path + "/";
				}
			}
			else
			{
				if(!path.EndsWith("/") || !path.EndsWith("\\"))
				{
					path = path + "\\";
				}
			}

			string directory = Path.GetDirectoryName(path);
			if(!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
			{
				Directory.CreateDirectory(directory);
			}

			Debug.Log("OpenFolder: "+ path);
			if(Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
			{
				Process.Start("explorer.exe", path);
			}
			else if(Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer)
			{
				Process.Start("open", path);
			}
			else
			{
				Application.OpenURL($"file://{path}");
			}
		}

		private static string PathCombine(PathType pathType, string path)
		{
			path = string.IsNullOrWhiteSpace(path) ? ApplicationPath(pathType) : Path.Combine(ApplicationPath(pathType), path);

			if(Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
			{
				path = path.Replace("/", "\\");
			}
			else if(Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer)
			{
				path = path.Replace("\\", "/");
			}
			else
			{
				path = path.Replace("/", "\\");
			}
			return path;
		}


	}
}
