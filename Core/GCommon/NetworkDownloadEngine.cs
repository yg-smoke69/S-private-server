using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace GCommon;

[Token(Token = "0x2004112")]
public class NetworkDownloadEngine : MonoBehaviour
{
	[Token(Token = "0x2004113")]
	private class DownloadTextureInfo
	{
		[Token(Token = "0x401B55F")]
		[FieldOffset(Offset = "0x8")]
		public string Url;

		[Token(Token = "0x401B560")]
		[FieldOffset(Offset = "0xC")]
		public string Name;

		[Token(Token = "0x401B561")]
		[FieldOffset(Offset = "0x10")]
		public bool NeedCache;

		[Token(Token = "0x401B562")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 TragetSize;

		[Token(Token = "0x401B563")]
		[FieldOffset(Offset = "0x1C")]
		public bool IsDownload;

		[Token(Token = "0x401B564")]
		[FieldOffset(Offset = "0x1D")]
		public bool IsReadable;

		[Token(Token = "0x601A93A")]
		[Address(RVA = "0x2973560", Offset = "0x2973560", VA = "0x2973560")]
		public DownloadTextureInfo()
		{
		}

		[Token(Token = "0x601A93B")]
		[Address(RVA = "0x2978DA8", Offset = "0x2978DA8", VA = "0x2978DA8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x601A93C")]
		[Address(RVA = "0x2978ED0", Offset = "0x2978ED0", VA = "0x2978ED0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x2004114")]
	public delegate void OnDowloadFinished(Texture2D texture);

	[Token(Token = "0x2004115")]
	private sealed class _003CDownloadImage_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401B565")]
		[FieldOffset(Offset = "0x8")]
		internal DownloadTextureInfo info;

		[Token(Token = "0x401B566")]
		[FieldOffset(Offset = "0xC")]
		internal UnityWebRequest _003Cwww_003E__0;

		[Token(Token = "0x401B567")]
		[FieldOffset(Offset = "0x10")]
		internal DownloadHandlerBuffer _003CtexDl_003E__0;

		[Token(Token = "0x401B568")]
		[FieldOffset(Offset = "0x14")]
		internal Texture2D _003Ctex2d_003E__0;

		[Token(Token = "0x401B569")]
		[FieldOffset(Offset = "0x18")]
		internal bool _003CbZip_003E__0;

		[Token(Token = "0x401B56A")]
		[FieldOffset(Offset = "0x1C")]
		internal string _003CfilePath_003E__1;

		[Token(Token = "0x401B56B")]
		[FieldOffset(Offset = "0x20")]
		internal WWW _003Cwww_o_003E__2;

		[Token(Token = "0x401B56C")]
		[FieldOffset(Offset = "0x24")]
		internal NetworkDownloadEngine _0024this;

		[Token(Token = "0x401B56D")]
		[FieldOffset(Offset = "0x28")]
		internal object _0024current;

		[Token(Token = "0x401B56E")]
		[FieldOffset(Offset = "0x2C")]
		internal bool _0024disposing;

		[Token(Token = "0x401B56F")]
		[FieldOffset(Offset = "0x30")]
		internal int _0024PC;

		[Token(Token = "0x17001D46")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601A943")]
			[Address(RVA = "0x297841C", Offset = "0x297841C", VA = "0x297841C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001D47")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601A944")]
			[Address(RVA = "0x2978424", Offset = "0x2978424", VA = "0x2978424", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601A941")]
		[Address(RVA = "0x2974A6C", Offset = "0x2974A6C", VA = "0x2974A6C")]
		public _003CDownloadImage_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601A942")]
		[Address(RVA = "0x29766B0", Offset = "0x29766B0", VA = "0x29766B0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601A945")]
		[Address(RVA = "0x297842C", Offset = "0x297842C", VA = "0x297842C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601A946")]
		[Address(RVA = "0x2978440", Offset = "0x2978440", VA = "0x2978440", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2004116")]
	private sealed class _003CLoadLocalImage_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401B570")]
		[FieldOffset(Offset = "0x8")]
		internal DownloadTextureInfo info;

		[Token(Token = "0x401B571")]
		[FieldOffset(Offset = "0xC")]
		internal string _003CfilePath_003E__0;

		[Token(Token = "0x401B572")]
		[FieldOffset(Offset = "0x10")]
		internal Texture2D _003Ctexture_003E__0;

		[Token(Token = "0x401B573")]
		[FieldOffset(Offset = "0x14")]
		internal WWW _003Cwww_003E__1;

		[Token(Token = "0x401B574")]
		[FieldOffset(Offset = "0x18")]
		internal OnDowloadFinished _003Ccallback_003E__0;

		[Token(Token = "0x401B575")]
		[FieldOffset(Offset = "0x1C")]
		internal NetworkDownloadEngine _0024this;

		[Token(Token = "0x401B576")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x401B577")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x401B578")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17001D48")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601A949")]
			[Address(RVA = "0x2978CFC", Offset = "0x2978CFC", VA = "0x2978CFC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001D49")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601A94A")]
			[Address(RVA = "0x2978D04", Offset = "0x2978D04", VA = "0x2978D04", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601A947")]
		[Address(RVA = "0x29761C4", Offset = "0x29761C4", VA = "0x29761C4")]
		public _003CLoadLocalImage_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x601A948")]
		[Address(RVA = "0x29784C8", Offset = "0x29784C8", VA = "0x29784C8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601A94B")]
		[Address(RVA = "0x2978D0C", Offset = "0x2978D0C", VA = "0x2978D0C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601A94C")]
		[Address(RVA = "0x2978D20", Offset = "0x2978D20", VA = "0x2978D20", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401B545")]
	[FieldOffset(Offset = "0x0")]
	public static string CDNAddr;

	[Token(Token = "0x401B546")]
	[FieldOffset(Offset = "0xC")]
	public Action<int> OnLoadedImage;

	[Token(Token = "0x401B547")]
	[FieldOffset(Offset = "0x4")]
	private static NetworkDownloadEngine _instance;

	[Token(Token = "0x401B548")]
	private const int MAX_DATA_SIZE = 2097152;

	[Token(Token = "0x401B549")]
	private const int KTX_HEADER_SIZE = 12;

	[Token(Token = "0x401B54A")]
	private const int PVR_HEADER_SIZE = 52;

	[Token(Token = "0x401B54B")]
	public const string REGEX_TEXTURE_END = "\\.(([Pp][Nn][Gg]?$)|([Jj][Pp][Gg]?$)|(ktx?$)|(pvr?$))";

	[Token(Token = "0x401B54C")]
	public const string REGEX_PLATFORM_TEXTURE_SURFFIX = "\\.(ff)?$";

	[Token(Token = "0x401B54D")]
	public const string REGEX_PLATFORM_TEXTURE_ZIP_SURFFIX = "\\.(zip)?$";

	[Token(Token = "0x401B54E")]
	public const string REGEX_PLATFORM_TEXTURE_LOBBY_SURFFIX = "\\.(lobby)?$";

	[Token(Token = "0x401B54F")]
	public const string REGEX_ABSOLUTE_URL_SURFFIX = "^((https://)|(http://))";

	[Token(Token = "0x401B550")]
	[FieldOffset(Offset = "0x10")]
	private string m_CurrentVersionFolder;

	[Token(Token = "0x401B551")]
	private const string IMAGECAHCE_FOLDER = "ImageCache";

	[Token(Token = "0x401B552")]
	private const string PREF_KEY_CURRENTVERSIONFOLDER = "CurrentVersionFolder";

	[Token(Token = "0x401B553")]
	private const string ZIPCAHCE_FOLDER = "zip";

	[Token(Token = "0x401B554")]
	[FieldOffset(Offset = "0x8")]
	public static int MAX_MULTI_DOWNLOAD;

	[Token(Token = "0x401B555")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, Texture2D> m_LoadedImageCache;

	[Token(Token = "0x401B556")]
	[FieldOffset(Offset = "0x18")]
	private Queue<DownloadTextureInfo> m_NeedDownloadUrls;

	[Token(Token = "0x401B557")]
	[FieldOffset(Offset = "0x1C")]
	private HashSet<DownloadTextureInfo> m_RunningDownloadUrls;

	[Token(Token = "0x401B558")]
	[FieldOffset(Offset = "0x20")]
	private string image_CachePath;

	[Token(Token = "0x401B559")]
	[FieldOffset(Offset = "0x24")]
	private string image_ZipCachePath;

	[Token(Token = "0x401B55A")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, OnDowloadFinished> m_DownloadCallbackDictionary;

	[Token(Token = "0x401B55B")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int[] PNG_HEADER;

	[Token(Token = "0x401B55C")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int[] KTX_HEADER;

	[Token(Token = "0x401B55D")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int[] PVR_HEADER;

	[Token(Token = "0x401B55E")]
	[FieldOffset(Offset = "0x18")]
	private static OnDowloadFinished _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001D43")]
	public static NetworkDownloadEngine Instance
	{
		[Token(Token = "0x601A91E")]
		[Address(RVA = "0x29720F4", Offset = "0x29720F4", VA = "0x29720F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D44")]
	public string ImageCachePath
	{
		[Token(Token = "0x601A91F")]
		[Address(RVA = "0x29725AC", Offset = "0x29725AC", VA = "0x29725AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D45")]
	public string ImageZipCachePath
	{
		[Token(Token = "0x601A920")]
		[Address(RVA = "0x2972938", Offset = "0x2972938", VA = "0x2972938")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A91D")]
	[Address(RVA = "0x2971F84", Offset = "0x2971F84", VA = "0x2971F84")]
	public NetworkDownloadEngine()
	{
	}

	[Token(Token = "0x601A921")]
	[Address(RVA = "0x2972330", Offset = "0x2972330", VA = "0x2972330")]
	private void Init()
	{
	}

	[Token(Token = "0x601A922")]
	[Address(RVA = "0x2972D44", Offset = "0x2972D44", VA = "0x2972D44")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x601A923")]
	[Address(RVA = "0x2972E20", Offset = "0x2972E20", VA = "0x2972E20")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601A924")]
	[Address(RVA = "0x2972774", Offset = "0x2972774", VA = "0x2972774")]
	private void GenerateCurrentVersionFolder()
	{
	}

	[Token(Token = "0x601A925")]
	[Address(RVA = "0x2972B00", Offset = "0x2972B00", VA = "0x2972B00")]
	private void ClearCacheByVersion()
	{
	}

	[Token(Token = "0x601A926")]
	[Address(RVA = "0x2972EFC", Offset = "0x2972EFC", VA = "0x2972EFC")]
	private void DeleteCacheWalker(DirectoryInfo folderInfo)
	{
	}

	[Token(Token = "0x601A927")]
	[Address(RVA = "0x297312C", Offset = "0x297312C", VA = "0x297312C")]
	public void RegisterTempDownloadTexture(string url, float targetWidth, float targetHeight)
	{
	}

	[Token(Token = "0x601A928")]
	[Address(RVA = "0x2973654", Offset = "0x2973654", VA = "0x2973654")]
	public void RegisterDownloadTexture(string url, float targetWidth, float targetHeight, OnDowloadFinished finishedCallBack, bool needCache, bool isReadable = false)
	{
	}

	[Token(Token = "0x601A929")]
	[Address(RVA = "0x29739E0", Offset = "0x29739E0", VA = "0x29739E0")]
	public void DownloadMultiTextures(List<string> url_list, bool needCache = true)
	{
	}

	[Token(Token = "0x601A92A")]
	[Address(RVA = "0x2973568", Offset = "0x2973568", VA = "0x2973568")]
	private bool CheckIsNeedDownload(string url)
	{
		return default(bool);
	}

	[Token(Token = "0x601A92B")]
	[Address(RVA = "0x2974268", Offset = "0x2974268", VA = "0x2974268")]
	public void UnRegisterCallBack(string url, OnDowloadFinished download_callback, bool useOriginalUrl, bool removeCache = true)
	{
	}

	[Token(Token = "0x601A92C")]
	[Address(RVA = "0x297447C", Offset = "0x297447C", VA = "0x297447C")]
	public void ClearTextureCache()
	{
	}

	[Token(Token = "0x601A92D")]
	[Address(RVA = "0x2974828", Offset = "0x2974828", VA = "0x2974828")]
	public void ClearLoadedTextureCache()
	{
	}

	[Token(Token = "0x601A92E")]
	[Address(RVA = "0x29748A0", Offset = "0x29748A0", VA = "0x29748A0")]
	public static void gunZipData(byte[] data, string filePath)
	{
	}

	[Token(Token = "0x601A92F")]
	[Address(RVA = "0x29749CC", Offset = "0x29749CC", VA = "0x29749CC")]
	private IEnumerator DownloadImage(DownloadTextureInfo info)
	{
		return null;
	}

	[Token(Token = "0x601A930")]
	[Address(RVA = "0x2974A74", Offset = "0x2974A74", VA = "0x2974A74")]
	private TextureFormat CheckTextureFormatWithBytesAndUrl(byte[] bytes, string url)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(TextureFormat);
	}

	[Token(Token = "0x601A931")]
	[Address(RVA = "0x29751F4", Offset = "0x29751F4", VA = "0x29751F4")]
	private Texture2D CreateTexture2DWithByte(byte[] data, string url, bool is_readable)
	{
		return null;
	}

	[Token(Token = "0x601A932")]
	[Address(RVA = "0x2976124", Offset = "0x2976124", VA = "0x2976124")]
	private IEnumerator LoadLocalImage(DownloadTextureInfo info)
	{
		return null;
	}

	[Token(Token = "0x601A933")]
	[Address(RVA = "0x29761CC", Offset = "0x29761CC", VA = "0x29761CC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x601A934")]
	[Address(RVA = "0x2973DB4", Offset = "0x2973DB4", VA = "0x2973DB4")]
	public static string CheckAndModifyUrlWithPlatFormSuffix(string url)
	{
		return null;
	}

	[Token(Token = "0x601A935")]
	[Address(RVA = "0x2976440", Offset = "0x2976440", VA = "0x2976440")]
	public static bool IsZip(string url)
	{
		return default(bool);
	}

	[Token(Token = "0x601A936")]
	[Address(RVA = "0x29764B8", Offset = "0x29764B8", VA = "0x29764B8")]
	public static string GetFinalUrlWithPlatform(string url)
	{
		return null;
	}

	[Token(Token = "0x601A937")]
	[Address(RVA = "0x2973394", Offset = "0x2973394", VA = "0x2973394")]
	public static string FixedUrlWithRelativePath(string url)
	{
		return null;
	}

	[Token(Token = "0x601A939")]
	[Address(RVA = "0x29766AC", Offset = "0x29766AC", VA = "0x29766AC")]
	private static void _003CDownloadMultiTextures_003Em__0(Texture2D texture)
	{
	}
}
