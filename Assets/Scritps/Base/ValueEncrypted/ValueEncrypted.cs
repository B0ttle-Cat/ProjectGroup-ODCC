#if true
using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.Base
{
	public static partial class Utils
	{
		public static string GenerateRandomStringKey(int length = 16) // length = 16 / 32 / 64 / 128 ....
		{
			const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
			using(RandomNumberGenerator rng = RandomNumberGenerator.Create())
			{
				byte[] randomBytes = new byte[length];
				rng.GetBytes(randomBytes);

				char[] chars = new char[length];
				int validCharCount = validChars.Length;

				for(int i = 0 ; i < length ; i++)
				{
					chars[i] = validChars[randomBytes[i] % validCharCount];
				}

				return new string(chars);
			}
		}

		public static byte[] StructToByteArray<T>(T structData) where T : struct
		{
			int size = Marshal.SizeOf(typeof(T));
			byte[] byteArray = new byte[size];
			IntPtr ptr = Marshal.AllocHGlobal(size);

			Marshal.StructureToPtr(structData, ptr, true);
			Marshal.Copy(ptr, byteArray, 0, size);
			Marshal.FreeHGlobal(ptr);

			return byteArray;
		}

		public static T ByteArrayToStruct<T>(byte[] byteArray) where T : struct
		{
			T structData;
			int size = Marshal.SizeOf(typeof(T));
			IntPtr ptr = Marshal.AllocHGlobal(size);

			Marshal.Copy(byteArray, 0, ptr, size);
			structData = (T)Marshal.PtrToStructure(ptr, typeof(T));
			Marshal.FreeHGlobal(ptr);

			return structData;
		}
	}


	[Serializable, InlineProperty]
	public class EncryptedInt
	{
		[SerializeField, HideLabel, HorizontalGroup(width: 0.1f)]
#pragma warning disable IDE0052 // 읽지 않은 private 멤버 제거
		private bool ShowInfo;
#pragma warning restore IDE0052 // 읽지 않은 private 멤버 제거
#if UNITY_EDITOR
		[SerializeField, HideLabel, HorizontalGroup(width: 0.9f), EnableIf("ShowInfo")]
		private int decryptValue;
#endif
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		protected int encryptValue;
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		private int encryptionKey = default;

		[BoxGroup, SerializeField, ShowIf("ShowInfo")]
		private bool alwaysChange = false;
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		private bool isEncrypt;

		public EncryptedInt(bool alwaysChange)
		{
			ShowInfo = false;
			this.alwaysChange = true;
			Value = default;
			this.alwaysChange = alwaysChange;
		}
		public EncryptedInt(int value = default, bool alwaysChange = false)
		{
			ShowInfo = false;
			this.alwaysChange = true;
			Value = value;
			this.alwaysChange = alwaysChange;
		}
#if UNITY_EDITOR
		[ButtonGroup("Encrypted"), ShowIf("ShowInfo")]
		private void Set()
		{
			Value = decryptValue;
		}
#endif
		public int Value
		{
			get
			{
				int _value =  DecryptValue(encryptValue);
#if UNITY_EDITOR
				decryptValue = _value;
#endif
				return _value;
			}
			set
			{
				this.encryptValue = EncryptValue(value);
			}
		}

		public bool EncryptionValueAlwaysChange
		{
			get => alwaysChange;
			set => alwaysChange=value;
		}

		private int EncryptValue(int value)
		{
			// 랜덤한 값을 생성하여 encryption에 할당
			if(alwaysChange || encryptionKey.Equals(default))
			{
				using RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
				byte[] randomBytes = new byte[sizeof(Int32)];
				rng.GetNonZeroBytes(randomBytes);
				encryptionKey = BitConverter.ToInt32(randomBytes, 0);
			}


			int result = value ^ encryptionKey;
			isEncrypt = true;
			return result;
		}

		private int DecryptValue(int encryptedValue)
		{
			// 복호화 연산 수행
			return isEncrypt ? (encryptedValue ^ encryptionKey) : encryptedValue;
		}
		[ButtonGroup("Encrypted"), ShowIf("ShowInfo")]
		public void EncryptUpdate()
		{
			Value = Value;
		}
		[ButtonGroup("Encrypted"), ShowIf("ShowInfo")]
		public void Reset()
		{
			encryptValue = default;
			encryptionKey = default;
			isEncrypt = false;
#if UNITY_EDITOR
			decryptValue = default;
#endif
		}
	}

	[Serializable, InlineProperty]
	public class EncryptedFloat
	{
		[SerializeField, HideLabel, HorizontalGroup(width: 0.1f)]
#pragma warning disable IDE0052 // 읽지 않은 private 멤버 제거
		private bool ShowInfo;
#pragma warning restore IDE0052 // 읽지 않은 private 멤버 제거
#if UNITY_EDITOR
		[SerializeField, HideLabel, HorizontalGroup(width: 0.9f), EnableIf("ShowInfo")]
		private float decryptValue;
#endif
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		protected int encryptValue;
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		private int encryptionKey = default;

		[BoxGroup, SerializeField, ShowIf("ShowInfo")]
		private bool alwaysChange = false;
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		private bool isEncrypt;

		public EncryptedFloat(bool alwaysChange)
		{
			ShowInfo = false;
			this.alwaysChange = true;
			Value = default;
			this.alwaysChange = alwaysChange;
		}
		public EncryptedFloat(float value = default, bool alwaysChange = false)
		{
			ShowInfo = false;
			this.alwaysChange = true;
			Value = value;
			this.alwaysChange = alwaysChange;
		}
#if UNITY_EDITOR
		[ButtonGroup("Encrypted"), ShowIf("ShowInfo")]
		private void Set()
		{
			Value = decryptValue;
		}
#endif
		public float Value
		{
			get
			{
				float _value =  DecryptValue(encryptValue);
#if UNITY_EDITOR
				decryptValue = _value;
#endif
				return _value;
			}
			set
			{
				this.encryptValue = EncryptValue(value);
			}
		}

		public bool EncryptionValueAlwaysChange
		{
			get => alwaysChange;
			set => alwaysChange=value;
		}

		private int EncryptValue(float value)
		{
			// 랜덤한 값을 생성하여 encryption에 할당
			if(alwaysChange || encryptionKey.Equals(default))
			{
				if(alwaysChange || encryptionKey.Equals(default))
				{
					using RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
					byte[] randomBytes = new byte[sizeof(Int32)];
					rng.GetNonZeroBytes(randomBytes);
					encryptionKey = BitConverter.ToInt32(randomBytes, 0);
				}
			}

			int valueBits = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);
			int keyBits = encryptionKey;

			int result = valueBits ^ keyBits;
			isEncrypt = true;
			return result;
		}

		private float DecryptValue(int encryptedValue)
		{
			if(!isEncrypt) return BitConverter.ToSingle(BitConverter.GetBytes(encryptedValue), 0);

			int encryptedBits = BitConverter.ToInt32(BitConverter.GetBytes(encryptedValue), 0);
			int keyBits = encryptionKey;

			int decryptedBits = encryptedBits ^ keyBits;

			return BitConverter.ToSingle(BitConverter.GetBytes(decryptedBits), 0);

		}
		[ButtonGroup("Encrypted"), ShowIf("ShowInfo")]
		public void EncryptUpdate()
		{
			Value = Value;
		}
		[ButtonGroup("Encrypted"), ShowIf("ShowInfo")]
		public void Reset()
		{
			encryptValue = default;
			encryptionKey = default;
			isEncrypt = false;
#if UNITY_EDITOR
			decryptValue = default;
#endif
		}
	}

	[Serializable, InlineProperty]
	public class EncryptedString
	{
		[SerializeField, HideLabel, HorizontalGroup(width: 0.1f)]
#pragma warning disable IDE0052 // 읽지 않은 private 멤버 제거
		private bool ShowInfo;
#pragma warning restore IDE0052 // 읽지 않은 private 멤버 제거
#if UNITY_EDITOR
		[SerializeField, HideLabel, HorizontalGroup(width: 0.9f), EnableIf("ShowInfo")]
		private string decryptValue;
#endif
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		protected string encryptValue;
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		private string encryptionKey = default;

		[BoxGroup, SerializeField, ShowIf("ShowInfo")]
		private bool alwaysChange = false;
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		private bool isEncrypt;

		public EncryptedString(bool alwaysChange)
		{
			ShowInfo = false;
			this.alwaysChange = true;
			Value = default;
			this.alwaysChange = alwaysChange;
		}
		public EncryptedString(string value = "", bool alwaysChange = false)
		{
			ShowInfo = false;
			this.alwaysChange = true;
			Value = value;
			this.alwaysChange = alwaysChange;
		}

#if UNITY_EDITOR
		[Button, ShowIf("ShowInfo")]
		private void Set()
		{
			Value = decryptValue;
		}
#endif

		public string Value
		{
			get
			{
				string _value =  DecryptValue(encryptValue);
#if UNITY_EDITOR
				decryptValue = _value;
#endif
				return _value;
			}
			set
			{
				this.encryptValue = EncryptValue(value);
			}
		}

		public bool EncryptionValueAlwaysChange
		{
			get => alwaysChange;
			set => alwaysChange=value;
		}

		private string EncryptValue(string value)
		{
			// 랜덤한 값을 생성하여 encryption에 할당
			isEncrypt = false;
			if(alwaysChange || string.IsNullOrWhiteSpace(encryptionKey))
			{
				encryptionKey = Utils.GenerateRandomStringKey();
			}
			isEncrypt = true;

			return EncryptString(value, encryptionKey);
		}

		private string DecryptValue(string encryptedValue)
		{
			// 복호화 연산 수행
			return isEncrypt ? DecryptString(encryptedValue, encryptionKey) : encryptedValue;
		}
		[ButtonGroup("Encrypted"), ShowIf("ShowInfo")]
		public void EncryptUpdate()
		{
			Value = Value;
		}
		[ButtonGroup("Encrypted"), ShowIf("ShowInfo")]
		public void Reset()
		{
			encryptValue = "";
			encryptionKey = default;
			isEncrypt = false;
#if UNITY_EDITOR
			decryptValue = default;
#endif
		}

		private string EncryptString(string plainText, string key)
		{
			using(Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Encoding.UTF8.GetBytes(key);
				aesAlg.GenerateIV(); // 초기화 벡터 생성

				ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

				using(MemoryStream msEncrypt = new MemoryStream())
				{
					using(CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
					{
						using(StreamWriter swEncrypt = new StreamWriter(csEncrypt))
						{
							swEncrypt.Write(plainText);
						}
					}

					return Convert.ToBase64String(aesAlg.IV.Concat(msEncrypt.ToArray()).ToArray());
				}
			}
		}
		private string DecryptString(string cipherText, string key)
		{
			using(Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Encoding.UTF8.GetBytes(key);

				byte[] iv = new byte[16];
				byte[] cipherBytes = Convert.FromBase64String(cipherText);
				Array.Copy(cipherBytes, 0, iv, 0, 16);
				aesAlg.IV = iv;

				ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

				using(MemoryStream msDecrypt = new MemoryStream(cipherBytes, 16, cipherBytes.Length - 16))
				{
					using(CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
					{
						using(StreamReader srDecrypt = new StreamReader(csDecrypt))
						{
							return srDecrypt.ReadToEnd();
						}
					}
				}
			}
		}
	}

	[Serializable, InlineProperty]
	public class EncryptedValue<T> where T : struct
	{
		[SerializeField, HideLabel, HorizontalGroup(width: 0.1f)]
#pragma warning disable IDE0052 // 읽지 않은 private 멤버 제거
		private bool ShowInfo;
#pragma warning restore IDE0052 // 읽지 않은 private 멤버 제거
#if UNITY_EDITOR
		[SerializeField, HideLabel, HorizontalGroup(width: 0.9f), EnableIf("ShowInfo")]
		private T decryptValue;
#endif
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		protected byte[] encryptValue;
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		private string encryptionKey = default;

		[BoxGroup, SerializeField, ShowIf("ShowInfo")]
		private bool alwaysChange = false;
		[BoxGroup, ReadOnly, SerializeField, ShowIf("ShowInfo")]
		private bool isEncrypt;
		public EncryptedValue()
		{
			ShowInfo = false;
			this.alwaysChange = true;
			Value = default;
			this.alwaysChange = false;
		}
		public EncryptedValue(T value, bool alwaysChange = false)
		{
			ShowInfo = false;
			this.alwaysChange = true;
			Value = value;
			this.alwaysChange = alwaysChange;
		}

#if UNITY_EDITOR
		[ButtonGroup("Encrypted"), ShowIf("ShowInfo")]
		private void Set()
		{
			Value = decryptValue;
		}
#endif
		public T Value
		{
			get
			{
				T _value =  DecryptValue(encryptValue);
#if UNITY_EDITOR
				decryptValue = _value;
#endif
				return _value;
			}
			set
			{
				this.encryptValue = EncryptValue(value);
			}
		}

		public bool EncryptionValueAlwaysChange
		{
			get => alwaysChange;
			set => alwaysChange=value;
		}

		private byte[] EncryptValue(T value)
		{
			try
			{
				// 랜덤한 값을 생성하여 encryption에 할당
				if(alwaysChange || encryptionKey.Equals(default))
				{
					encryptionKey = Utils.GenerateRandomStringKey();
				}

				byte[] valueBytes = Utils.StructToByteArray(value);
				byte[] encryptBytes = valueBytes;
				using(AesManaged aes = new AesManaged())
				{
					aes.Key = Encoding.UTF8.GetBytes(encryptionKey);
					aes.Mode = CipherMode.ECB; // Electronic Codebook mode
					aes.Padding = PaddingMode.PKCS7;

					using(ICryptoTransform encryptor = aes.CreateEncryptor())
					{
						encryptBytes =  encryptor.TransformFinalBlock(valueBytes, 0, valueBytes.Length);
						isEncrypt = true;
					}
				}
				return encryptBytes;
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
				return default;
			}
		}

		private T DecryptValue(byte[] encryptedValue)
		{
			try
			{
				byte[] decryptBytes = encryptedValue;
				if(isEncrypt)
				{
					using(AesManaged aes = new AesManaged())
					{
						aes.Key = Encoding.UTF8.GetBytes(encryptionKey);
						aes.Mode = CipherMode.ECB; // Electronic Codebook mode
						aes.Padding = PaddingMode.PKCS7;

						using(ICryptoTransform decryptor = aes.CreateDecryptor())
						{
							decryptBytes =  decryptor.TransformFinalBlock(encryptedValue, 0, encryptedValue.Length);
						}
					}
				}
				T decryptedData = Utils.ByteArrayToStruct<T>(decryptBytes);
				return Utils.ByteArrayToStruct<T>(decryptBytes);
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
				return default;
			}
		}
		[ButtonGroup("Encrypted"), ShowIf("ShowInfo")]
		public void EncryptUpdate()
		{
			Value = Value;
		}
		[ButtonGroup("Encrypted"), ShowIf("ShowInfo")]
		public void Reset()
		{
			encryptValue = default;
			encryptionKey = default;
			isEncrypt = false;
#if UNITY_EDITOR
			decryptValue = default;
#endif
		}
	}


}
#endif