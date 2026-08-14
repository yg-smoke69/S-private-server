using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using LitJson;
using TsiU;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GCommon;

[Token(Token = "0x20040E9")]
public class ResourceManager : TSingleton<ResourceManager>
{
	[Token(Token = "0x20040EA")]
	public enum EResourceConfigLevelSetting : byte
	{
		[Token(Token = "0x401B4A1")]
		None,
		[Token(Token = "0x401B4A2")]
		Replace,
		[Token(Token = "0x401B4A3")]
		Hide
	}

	[Token(Token = "0x20040EB")]
	public enum ELoadAbOption : byte
	{
		[Token(Token = "0x401B4A5")]
		NotAb,
		[Token(Token = "0x401B4A6")]
		AbWithName,
		[Token(Token = "0x401B4A7")]
		AbWithPath,
		[Token(Token = "0x401B4A8")]
		AbWithNameOrPath,
		[Token(Token = "0x401B4A9")]
		StreamAb
	}

	[Token(Token = "0x20040EC")]
	public class ResourceConfigAB
	{
		[Token(Token = "0x401B4AA")]
		[FieldOffset(Offset = "0x8")]
		public string m_path;

		[Token(Token = "0x401B4AB")]
		[FieldOffset(Offset = "0xC")]
		public string m_abPath;

		[Token(Token = "0x401B4AC")]
		[FieldOffset(Offset = "0x10")]
		public MethodInfo m_Modifier;

		[Token(Token = "0x401B4AD")]
		[FieldOffset(Offset = "0x14")]
		public EResourceConfigLevelSetting m_LevelLow;

		[Token(Token = "0x401B4AE")]
		[FieldOffset(Offset = "0x15")]
		public EResourceConfigLevelSetting m_LevelHigh;

		[Token(Token = "0x401B4AF")]
		[FieldOffset(Offset = "0x16")]
		public ELoadAbOption m_AbOption;

		[Token(Token = "0x17001D02")]
		public bool IsAb
		{
			[Token(Token = "0x601A7CF")]
			[Address(RVA = "0x322AEDC", Offset = "0x322AEDC", VA = "0x322AEDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x601A7CE")]
		[Address(RVA = "0x322AED4", Offset = "0x322AED4", VA = "0x322AED4")]
		public ResourceConfigAB()
		{
		}

		[Token(Token = "0x601A7D0")]
		[Address(RVA = "0x322AEEC", Offset = "0x322AEEC", VA = "0x322AEEC")]
		public string GetPath(GAGILKKDDMJ s)
		{
			return null;
		}

		[Token(Token = "0x601A7D1")]
		[Address(RVA = "0x322B164", Offset = "0x322B164", VA = "0x322B164")]
		private static string AppendSuffix(ELoadAbOption abOpt, string path, string suffix)
		{
			return null;
		}
	}

	[Token(Token = "0x20040ED")]
	public class ResourceConfigStreamAB : ResourceConfigAB
	{
		[Token(Token = "0x401B4B0")]
		[FieldOffset(Offset = "0x18")]
		public string m_streamABPath;

		[Token(Token = "0x601A7D2")]
		[Address(RVA = "0x322B380", Offset = "0x322B380", VA = "0x322B380")]
		public ResourceConfigStreamAB()
		{
		}
	}

	[Token(Token = "0x20040EE")]
	public class PreloadResKey : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401B4B1")]
		[FieldOffset(Offset = "0x8")]
		private int _003CModeHash_003Ek__BackingField;

		[Token(Token = "0x401B4B2")]
		[FieldOffset(Offset = "0xC")]
		private short _003CMapId_003Ek__BackingField;

		[Token(Token = "0x401B4B3")]
		[FieldOffset(Offset = "0xE")]
		private sbyte _003CGraphicSetting_003Ek__BackingField;

		[Token(Token = "0x17001D03")]
		public int ModeHash
		{
			[Token(Token = "0x601A7D4")]
			[Address(RVA = "0x3229F20", Offset = "0x3229F20", VA = "0x3229F20")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x601A7D5")]
			[Address(RVA = "0x3229F08", Offset = "0x3229F08", VA = "0x3229F08")]
			set
			{
			}
		}

		[Token(Token = "0x17001D04")]
		public short MapId
		{
			[Token(Token = "0x601A7D6")]
			[Address(RVA = "0x3229F28", Offset = "0x3229F28", VA = "0x3229F28")]
			get
			{
				return default(short);
			}
			[Token(Token = "0x601A7D7")]
			[Address(RVA = "0x3229F10", Offset = "0x3229F10", VA = "0x3229F10")]
			set
			{
			}
		}

		[Token(Token = "0x17001D05")]
		public sbyte GraphicSetting
		{
			[Token(Token = "0x601A7D8")]
			[Address(RVA = "0x3229F30", Offset = "0x3229F30", VA = "0x3229F30")]
			get
			{
				return default(sbyte);
			}
			[Token(Token = "0x601A7D9")]
			[Address(RVA = "0x3229F18", Offset = "0x3229F18", VA = "0x3229F18")]
			set
			{
			}
		}

		[Token(Token = "0x601A7D3")]
		[Address(RVA = "0x3229E8C", Offset = "0x3229E8C", VA = "0x3229E8C")]
		public PreloadResKey(Enum mode, short mapid, sbyte graphic)
		{
		}

		[Token(Token = "0x601A7DA")]
		[Address(RVA = "0x3229F38", Offset = "0x3229F38", VA = "0x3229F38", Slot = "4")]
		public int CompareTo(PreloadResKey other)
		{
			return default(int);
		}

		[Token(Token = "0x601A7DB")]
		[Address(RVA = "0x3229FE0", Offset = "0x3229FE0", VA = "0x3229FE0", Slot = "5")]
		public bool Equals(PreloadResKey other)
		{
			return default(bool);
		}

		[Token(Token = "0x601A7DC")]
		[Address(RVA = "0x322A028", Offset = "0x322A028", VA = "0x322A028", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x601A7DD")]
		[Address(RVA = "0x322A0F0", Offset = "0x322A0F0", VA = "0x322A0F0", Slot = "6")]
		public int CompareTo(object rhs)
		{
			return default(int);
		}

		[Token(Token = "0x601A7DE")]
		[Address(RVA = "0x322A1E4", Offset = "0x322A1E4", VA = "0x322A1E4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x20040EF")]
	public class PreloadResourceInfo
	{
		[Token(Token = "0x401B4B4")]
		[FieldOffset(Offset = "0x8")]
		private ResourceID _003CResouceId_003Ek__BackingField;

		[Token(Token = "0x401B4B5")]
		[FieldOffset(Offset = "0xC")]
		private short _003CInitCount_003Ek__BackingField;

		[Token(Token = "0x17001D06")]
		public ResourceID ResouceId
		{
			[Token(Token = "0x601A7E0")]
			[Address(RVA = "0x322A238", Offset = "0x322A238", VA = "0x322A238")]
			get
			{
				return default(ResourceID);
			}
			[Token(Token = "0x601A7E1")]
			[Address(RVA = "0x322A228", Offset = "0x322A228", VA = "0x322A228")]
			set
			{
			}
		}

		[Token(Token = "0x17001D07")]
		public short InitCount
		{
			[Token(Token = "0x601A7E2")]
			[Address(RVA = "0x322A240", Offset = "0x322A240", VA = "0x322A240")]
			get
			{
				return default(short);
			}
			[Token(Token = "0x601A7E3")]
			[Address(RVA = "0x322A230", Offset = "0x322A230", VA = "0x322A230")]
			set
			{
			}
		}

		[Token(Token = "0x601A7DF")]
		[Address(RVA = "0x322A200", Offset = "0x322A200", VA = "0x322A200")]
		public PreloadResourceInfo(ResourceID resId, short count)
		{
		}
	}

	[Token(Token = "0x20040F0")]
	private class ResAsyncRequest
	{
		[Token(Token = "0x20040F1")]
		public enum ReqState : byte
		{
			[Token(Token = "0x401B4C2")]
			Waiting,
			[Token(Token = "0x401B4C3")]
			InProgress,
			[Token(Token = "0x401B4C4")]
			Cached,
			[Token(Token = "0x401B4C5")]
			Completed,
			[Token(Token = "0x401B4C6")]
			Cancelled,
			[Token(Token = "0x401B4C7")]
			Recycled
		}

		[Token(Token = "0x401B4B6")]
		[FieldOffset(Offset = "0x8")]
		public string ResPath;

		[Token(Token = "0x401B4B7")]
		[FieldOffset(Offset = "0xC")]
		public Type Type;

		[Token(Token = "0x401B4B8")]
		[FieldOffset(Offset = "0x10")]
		public ELoadAbOption ABOption;

		[Token(Token = "0x401B4B9")]
		[FieldOffset(Offset = "0x14")]
		public string ABPath;

		[Token(Token = "0x401B4BA")]
		[FieldOffset(Offset = "0x18")]
		public bool Preload;

		[Token(Token = "0x401B4BB")]
		[FieldOffset(Offset = "0x19")]
		public bool NoCache;

		[Token(Token = "0x401B4BC")]
		[FieldOffset(Offset = "0x1A")]
		public bool NoDestroy;

		[Token(Token = "0x401B4BD")]
		[FieldOffset(Offset = "0x1C")]
		public Dictionary<uint, Action<uint, bool, Object>> Callbacks;

		[Token(Token = "0x401B4BE")]
		[FieldOffset(Offset = "0x20")]
		public AsyncOperation AsyncOp;

		[Token(Token = "0x401B4BF")]
		[FieldOffset(Offset = "0x24")]
		public ReqState State;

		[Token(Token = "0x401B4C0")]
		[FieldOffset(Offset = "0x28")]
		public Object CachedObj;

		[Token(Token = "0x601A7E4")]
		[Address(RVA = "0x322A248", Offset = "0x322A248", VA = "0x322A248")]
		public ResAsyncRequest(string resPath, ELoadAbOption abOpt, string abPath, Type type, bool preload, bool noCache, bool noDestroy)
		{
		}

		[Token(Token = "0x601A7E5")]
		[Address(RVA = "0x322A3A4", Offset = "0x322A3A4", VA = "0x322A3A4")]
		public void Init(string resPath, ELoadAbOption abOpt, string abPath, Type type, bool preload, bool noCache, bool noDestroy, bool reInit)
		{
		}

		[Token(Token = "0x601A7E6")]
		[Address(RVA = "0x322A47C", Offset = "0x322A47C", VA = "0x322A47C")]
		public void RegisterAction(uint ticket, Action<uint, bool, Object> callback)
		{
		}

		[Token(Token = "0x601A7E7")]
		[Address(RVA = "0x322A780", Offset = "0x322A780", VA = "0x322A780")]
		public void UnregisterAction(uint ticket)
		{
		}

		[Token(Token = "0x601A7E8")]
		[Address(RVA = "0x322A838", Offset = "0x322A838", VA = "0x322A838")]
		public void InvokeActions(bool succeeded, Object obj)
		{
		}
	}

	[Token(Token = "0x20040F2")]
	public class PreloadAssetKey
	{
		[Token(Token = "0x401B4C8")]
		[FieldOffset(Offset = "0x8")]
		private string _003CName_003Ek__BackingField;

		[Token(Token = "0x401B4C9")]
		[FieldOffset(Offset = "0xC")]
		private int _003CMapId_003Ek__BackingField;

		[Token(Token = "0x401B4CA")]
		[FieldOffset(Offset = "0x10")]
		private string _003CGraphicSetting_003Ek__BackingField;

		[Token(Token = "0x401B4CB")]
		[FieldOffset(Offset = "0x14")]
		private int _003CPoolInitCount_003Ek__BackingField;

		[Token(Token = "0x17001D08")]
		public string Name
		{
			[Token(Token = "0x601A7EA")]
			[Address(RVA = "0x3229C28", Offset = "0x3229C28", VA = "0x3229C28")]
			get
			{
				return null;
			}
			[Token(Token = "0x601A7EB")]
			[Address(RVA = "0x3229C08", Offset = "0x3229C08", VA = "0x3229C08")]
			set
			{
			}
		}

		[Token(Token = "0x17001D09")]
		public int MapId
		{
			[Token(Token = "0x601A7EC")]
			[Address(RVA = "0x3229C30", Offset = "0x3229C30", VA = "0x3229C30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x601A7ED")]
			[Address(RVA = "0x3229C10", Offset = "0x3229C10", VA = "0x3229C10")]
			set
			{
			}
		}

		[Token(Token = "0x17001D0A")]
		public string GraphicSetting
		{
			[Token(Token = "0x601A7EE")]
			[Address(RVA = "0x3229C38", Offset = "0x3229C38", VA = "0x3229C38")]
			get
			{
				return null;
			}
			[Token(Token = "0x601A7EF")]
			[Address(RVA = "0x3229C18", Offset = "0x3229C18", VA = "0x3229C18")]
			set
			{
			}
		}

		[Token(Token = "0x17001D0B")]
		public int PoolInitCount
		{
			[Token(Token = "0x601A7F0")]
			[Address(RVA = "0x3229C40", Offset = "0x3229C40", VA = "0x3229C40")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x601A7F1")]
			[Address(RVA = "0x3229C20", Offset = "0x3229C20", VA = "0x3229C20")]
			set
			{
			}
		}

		[Token(Token = "0x601A7E9")]
		[Address(RVA = "0x3229BD0", Offset = "0x3229BD0", VA = "0x3229BD0")]
		public PreloadAssetKey(string name, int mapid, string graphic, int poolinit)
		{
		}

		[Token(Token = "0x601A7F2")]
		[Address(RVA = "0x3229C48", Offset = "0x3229C48", VA = "0x3229C48", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x601A7F3")]
		[Address(RVA = "0x3229CC4", Offset = "0x3229CC4", VA = "0x3229CC4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x601A7F4")]
		[Address(RVA = "0x3229D64", Offset = "0x3229D64", VA = "0x3229D64")]
		public bool Equals(PreloadAssetKey obj)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401B45E")]
	private const int CapacityResourcePaths = 16000;

	[Token(Token = "0x401B45F")]
	private const int CapacityResourceMappingAB = 4000;

	[Token(Token = "0x401B460")]
	private const int CapacityResourceAnoymousMapping = 13500;

	[Token(Token = "0x401B461")]
	private const int CapacityResourceAnoymousNameMapping = 100;

	[Token(Token = "0x401B462")]
	private const int CapacityNameMapping = 9000;

	[Token(Token = "0x401B463")]
	private const int CapacityLoadedResources = 500;

	[Token(Token = "0x401B464")]
	private const int CapacityPreLoadedResources = 500;

	[Token(Token = "0x401B465")]
	public const string StreamAbDirName = "streaming";

	[Token(Token = "0x401B466")]
	[FieldOffset(Offset = "0x0")]
	public static string StreamAbDir;

	[Token(Token = "0x401B467")]
	public const string ResconfPath = "Config/Resconf";

	[Token(Token = "0x401B468")]
	public const string ResconfPathHD = "HD/Config/Resconf";

	[Token(Token = "0x401B469")]
	public const string WwiseResconfPathHD = "HD/Config/Resconf_Wwise";

	[Token(Token = "0x401B46A")]
	[FieldOffset(Offset = "0x8")]
	private ResourceID m_ResourcePathsStartID;

	[Token(Token = "0x401B46B")]
	[FieldOffset(Offset = "0xC")]
	private ResourceID m_ResourcePathsNextID;

	[Token(Token = "0x401B46C")]
	[FieldOffset(Offset = "0x10")]
	private List<string> m_ResourcePathsList;

	[Token(Token = "0x401B46D")]
	[FieldOffset(Offset = "0x14")]
	private ResourceID m_ResourceMappingABStartID;

	[Token(Token = "0x401B46E")]
	[FieldOffset(Offset = "0x18")]
	private ResourceID m_ResourceMappingABNextID;

	[Token(Token = "0x401B46F")]
	[FieldOffset(Offset = "0x1C")]
	private List<ResourceConfigAB> m_ResourceMappingABList;

	[Token(Token = "0x401B470")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, ResourceID> m_dictAnonymousResNameHash2ID;

	[Token(Token = "0x401B471")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<int, ResourceID> m_dictAnonymousResNameHash2IDTmp;

	[Token(Token = "0x401B472")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, ResourceID> m_dictAnonymousResColHashName2ID;

	[Token(Token = "0x401B473")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<string, ResourceID> m_dictAnonymousResColHashName2IDTmp;

	[Token(Token = "0x401B474")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<ResourceID, string> m_NameMapping;

	[Token(Token = "0x401B475")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<PreloadResKey, ResourceID[]> m_AudioPreloadResource;

	[Token(Token = "0x401B476")]
	[FieldOffset(Offset = "0x38")]
	private HashSet<ResourceID> m_AudioEventResInPreload;

	[Token(Token = "0x401B477")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<string, List<string>> m_ResconfDependencies;

	[Token(Token = "0x401B478")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<PreloadResKey, PreloadResourceInfo[]> m_PreloadResource;

	[Token(Token = "0x401B479")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<PreloadResKey, ResourceID[]> m_PreloadResource_PlayerAnimators;

	[Token(Token = "0x401B47A")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<PreloadResKey, int[]> m_PreloadUmas;

	[Token(Token = "0x401B47B")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_HasInited;

	[Token(Token = "0x401B47C")]
	[FieldOffset(Offset = "0x4D")]
	private bool m_HasParsed;

	[Token(Token = "0x401B47D")]
	[FieldOffset(Offset = "0x50")]
	private AssetBundleManifest m_ABManifest;

	[Token(Token = "0x401B47E")]
	[FieldOffset(Offset = "0x54")]
	private bool m_UseAssetBundle;

	[Token(Token = "0x401B47F")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<string, Object> m_LoadedResources;

	[Token(Token = "0x401B480")]
	[FieldOffset(Offset = "0x5C")]
	private Dictionary<string, AssetBundle> m_ResourceBundle;

	[Token(Token = "0x401B481")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<string, Object> m_DontDestroyLoadedResources;

	[Token(Token = "0x401B482")]
	[FieldOffset(Offset = "0x64")]
	private Dictionary<string, AssetBundle> m_DontDestroyResourceBundle;

	[Token(Token = "0x401B483")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<string, Object> m_PreLoadedResources;

	[Token(Token = "0x401B484")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<string, AssetBundle> m_PreLoadedResourceBundles;

	[Token(Token = "0x401B485")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<string, string> m_StreamAbs;

	[Token(Token = "0x401B486")]
	[FieldOffset(Offset = "0x74")]
	private string[] mPersisitResources;

	[Token(Token = "0x401B487")]
	[FieldOffset(Offset = "0x78")]
	private GAGILKKDDMJ ResQualityLevel;

	[Token(Token = "0x401B488")]
	[FieldOffset(Offset = "0x4")]
	public static bool UseSceneFolderAB;

	[Token(Token = "0x401B489")]
	[FieldOffset(Offset = "0x7C")]
	private Type mResIDType;

	[Token(Token = "0x401B48A")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<string, FieldInfo> mResIDFieldInfos;

	[Token(Token = "0x401B48B")]
	[FieldOffset(Offset = "0x84")]
	private List<ResourceRefCache> m_RefCaches;

	[Token(Token = "0x401B48C")]
	[FieldOffset(Offset = "0x88")]
	private readonly LinkedList<ResAsyncRequest> mResAsyncRequestList;

	[Token(Token = "0x401B48D")]
	[FieldOffset(Offset = "0x8C")]
	private bool mPendingCleanUp;

	[Token(Token = "0x401B48E")]
	public const uint InvalidTicket = 0u;

	[Token(Token = "0x401B48F")]
	public const uint InstantCallTicket = 1u;

	[Token(Token = "0x401B490")]
	[FieldOffset(Offset = "0x8")]
	private static uint ticketGen;

	[Token(Token = "0x401B491")]
	[FieldOffset(Offset = "0x90")]
	private readonly List<ResAsyncRequest> mResAsyncRequestPool;

	[Token(Token = "0x401B492")]
	[FieldOffset(Offset = "0x94")]
	private bool mTempDisablePooling;

	[Token(Token = "0x401B493")]
	[FieldOffset(Offset = "0x98")]
	private List<ResAsyncRequest> requestsToRemove;

	[Token(Token = "0x401B494")]
	[FieldOffset(Offset = "0xC")]
	public static string UILauncherPopupMessageURL;

	[Token(Token = "0x401B495")]
	[FieldOffset(Offset = "0x10")]
	public static string UILauncherURL;

	[Token(Token = "0x401B496")]
	[FieldOffset(Offset = "0x14")]
	public static string MaxLoGoURL;

	[Token(Token = "0x401B497")]
	[FieldOffset(Offset = "0x18")]
	public static string UIWebViewWindowLiteURL;

	[Token(Token = "0x401B498")]
	[FieldOffset(Offset = "0x1C")]
	public static string UILauncherDotURL;

	[Token(Token = "0x401B499")]
	[FieldOffset(Offset = "0x20")]
	public static string LocGlobalURL;

	[Token(Token = "0x401B49A")]
	[FieldOffset(Offset = "0x24")]
	public static string LocLauncherURL;

	[Token(Token = "0x401B49B")]
	[FieldOffset(Offset = "0x28")]
	public static string LocAbConfURL;

	[Token(Token = "0x401B49C")]
	[FieldOffset(Offset = "0x9C")]
	private List<KeyValuePair<PreloadAssetKey, List<string>>> m_PreloadAssetsList;

	[Token(Token = "0x401B49D")]
	[FieldOffset(Offset = "0xA0")]
	private List<KeyValuePair<PreloadAssetKey, List<string>>> m_PreloadAssetsAudio;

	[Token(Token = "0x401B49E")]
	[FieldOffset(Offset = "0xA4")]
	private List<KeyValuePair<PreloadAssetKey, List<string>>> m_PreloadAnimators;

	[Token(Token = "0x401B49F")]
	[FieldOffset(Offset = "0xA8")]
	private List<KeyValuePair<PreloadAssetKey, List<string>>> m_PreloadUmasTmpList;

	[Token(Token = "0x17001CFE")]
	public ResourceID ResourcePathsNextID
	{
		[Token(Token = "0x601A749")]
		[Address(RVA = "0x330130C", Offset = "0x330130C", VA = "0x330130C")]
		get
		{
			return default(ResourceID);
		}
	}

	[Token(Token = "0x17001CFF")]
	public bool Inited
	{
		[Token(Token = "0x601A74D")]
		[Address(RVA = "0x33016EC", Offset = "0x33016EC", VA = "0x33016EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001D00")]
	public int LoadedAbCount
	{
		[Token(Token = "0x601A75E")]
		[Address(RVA = "0x3304BE0", Offset = "0x3304BE0", VA = "0x3304BE0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001D01")]
	public static uint NewTicket
	{
		[Token(Token = "0x601A79E")]
		[Address(RVA = "0x3309C0C", Offset = "0x3309C0C", VA = "0x3309C0C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x601A748")]
	[Address(RVA = "0x3300E24", Offset = "0x3300E24", VA = "0x3300E24")]
	public ResourceManager()
	{
	}

	[Token(Token = "0x601A74A")]
	[Address(RVA = "0x3301314", Offset = "0x3301314", VA = "0x3301314")]
	public void SetResQualityLevel(GAGILKKDDMJ q)
	{
	}

	[Token(Token = "0x601A74B")]
	[Address(RVA = "0x330131C", Offset = "0x330131C", VA = "0x330131C")]
	public GAGILKKDDMJ GetResQualityLevel()
	{
		return default(GAGILKKDDMJ);
	}

	[Token(Token = "0x601A74C")]
	[Address(RVA = "0x3301324", Offset = "0x3301324", VA = "0x3301324")]
	public bool Init(bool useAssetBundle, [Optional] string[] dontDestoryResources)
	{
		return default(bool);
	}

	[Token(Token = "0x601A74E")]
	[Address(RVA = "0x33016F4", Offset = "0x33016F4", VA = "0x33016F4")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x601A74F")]
	[Address(RVA = "0x3301680", Offset = "0x3301680", VA = "0x3301680")]
	public void LoadPersisitResource()
	{
	}

	[Token(Token = "0x601A750")]
	[Address(RVA = "0x3302B20", Offset = "0x3302B20", VA = "0x3302B20")]
	public void SwapAndReleaseAnoymousMappingTmp()
	{
	}

	[Token(Token = "0x601A751")]
	[Address(RVA = "0x33029F0", Offset = "0x33029F0", VA = "0x33029F0")]
	private void LoadDontDestoryResource(string resPath)
	{
	}

	[Token(Token = "0x601A752")]
	[Address(RVA = "0x33031EC", Offset = "0x33031EC", VA = "0x33031EC")]
	public bool PoolContainsRes(ResourceID id)
	{
		return default(bool);
	}

	[Token(Token = "0x601A753")]
	[Address(RVA = "0x3303270", Offset = "0x3303270", VA = "0x3303270")]
	public Object PoolGetRes(ResourceID id, [Optional] Transform tranformParent)
	{
		return null;
	}

	[Token(Token = "0x601A754")]
	[Address(RVA = "0x33032FC", Offset = "0x33032FC", VA = "0x33032FC")]
	public bool PoolReturnRes(ResourceID id, Object obj, bool worldPositionStays = true)
	{
		return default(bool);
	}

	[Token(Token = "0x601A755")]
	[Address(RVA = "0x3303390", Offset = "0x3303390", VA = "0x3303390")]
	public string GetResourceAbName(ResourceID id)
	{
		return null;
	}

	[Token(Token = "0x601A756")]
	[Address(RVA = "0x3303544", Offset = "0x3303544", VA = "0x3303544")]
	public string GetResourceStreamAbName(ResourceID id)
	{
		return null;
	}

	[Token(Token = "0x601A757")]
	[Address(RVA = "0x330362C", Offset = "0x330362C", VA = "0x330362C")]
	public Object GetResource(ResourceID id, bool notUsingABForcefully = false, [Optional] Type type, bool noCache = false, GAGILKKDDMJ override_quality = GAGILKKDDMJ.Total)
	{
		return null;
	}

	[Token(Token = "0x601A758")]
	[Address(RVA = "0x3303C70", Offset = "0x3303C70", VA = "0x3303C70")]
	public Object GetResource(string resPath, bool notUsingABForcefully = false, bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x601A759")]
	[Address(RVA = "0x3303ACC", Offset = "0x3303ACC", VA = "0x3303ACC")]
	private Object GetResource(string resPath, ELoadAbOption abOpt, string ab = "", [Optional] Type type, bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x601A75A")]
	[Address(RVA = "0x3303D38", Offset = "0x3303D38", VA = "0x3303D38")]
	private Object GetResourceInternalFull(string resPath, bool notUsingABForcefully = false, bool dontDestroy = false, bool isDependency = false)
	{
		return null;
	}

	[Token(Token = "0x601A75B")]
	[Address(RVA = "0x3302BE4", Offset = "0x3302BE4", VA = "0x3302BE4")]
	private Object GetResourceInternal(string resPath, ELoadAbOption abOpt = ELoadAbOption.NotAb, string abPath = "", bool dontDestroy = false, [Optional] Type type, bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x601A75C")]
	[Address(RVA = "0x33048C0", Offset = "0x33048C0", VA = "0x33048C0")]
	private AssetBundle LoadABImpl(string abPath)
	{
		return null;
	}

	[Token(Token = "0x601A75D")]
	[Address(RVA = "0x3304228", Offset = "0x3304228", VA = "0x3304228")]
	public AssetBundle LoadABWithoutLoadingAssets(string resPath, bool dontDestroy)
	{
		return null;
	}

	[Token(Token = "0x601A75F")]
	[Address(RVA = "0x3304C8C", Offset = "0x3304C8C", VA = "0x3304C8C")]
	private AssetBundle LoadAssetBundleFromCache(string abPath, bool dontDestroy = false)
	{
		return null;
	}

	[Token(Token = "0x601A760")]
	[Address(RVA = "0x3304D6C", Offset = "0x3304D6C", VA = "0x3304D6C")]
	public void RemoveSceneAB(string abPath)
	{
	}

	[Token(Token = "0x601A761")]
	[Address(RVA = "0x3304EFC", Offset = "0x3304EFC", VA = "0x3304EFC")]
	public void OnLoadSceneFinish(string scenePath, bool useAB)
	{
	}

	[Token(Token = "0x601A762")]
	[Address(RVA = "0x3304FB4", Offset = "0x3304FB4", VA = "0x3304FB4")]
	public AsyncOperation StartLoadingSceneAsync(string scenePath, string abPath = "", LoadSceneMode mode = 0, bool notUsingABForcefully = false)
	{
		return null;
	}

	[Token(Token = "0x601A763")]
	[Address(RVA = "0x3305254", Offset = "0x3305254", VA = "0x3305254")]
	public AssetBundle LoadSceneABWithoutLoadingAssets(string abPath, bool dontDestroy)
	{
		return null;
	}

	[Token(Token = "0x601A764")]
	[Address(RVA = "0x33054E8", Offset = "0x33054E8", VA = "0x33054E8")]
	public static string GetStreamABPathByABPath(string ab_path)
	{
		return null;
	}

	[Token(Token = "0x601A765")]
	[Address(RVA = "0x330557C", Offset = "0x330557C", VA = "0x330557C")]
	public string GetSceneStreamABPath(ResourceID id)
	{
		return null;
	}

	[Token(Token = "0x601A766")]
	[Address(RVA = "0x3305A28", Offset = "0x3305A28", VA = "0x3305A28")]
	public bool IsResourceUseAB(ResourceID id, ref string abPath)
	{
		return default(bool);
	}

	[Token(Token = "0x601A767")]
	[Address(RVA = "0x3305778", Offset = "0x3305778", VA = "0x3305778")]
	public bool IsResourceUseStreamAB(ResourceID id, ref string abPath, ref string streamABPath)
	{
		return default(bool);
	}

	[Token(Token = "0x601A768")]
	[Address(RVA = "0x3305B5C", Offset = "0x3305B5C", VA = "0x3305B5C")]
	public void FinishLoadingScene(ResourceID id)
	{
	}

	[Token(Token = "0x601A769")]
	[Address(RVA = "0x3305CA4", Offset = "0x3305CA4", VA = "0x3305CA4")]
	public AsyncOperation StartLoadingSceneAsync(ResourceID id, LoadSceneMode mode = 0, bool notUsingABForcefully = false, bool need_modify = false)
	{
		return null;
	}

	[Token(Token = "0x601A76A")]
	[Address(RVA = "0x3305DF4", Offset = "0x3305DF4", VA = "0x3305DF4")]
	public AsyncOperation UnloadSceneAsync(ResourceID id)
	{
		return null;
	}

	[Token(Token = "0x601A76B")]
	[Address(RVA = "0x3305E70", Offset = "0x3305E70", VA = "0x3305E70")]
	private PreloadResourceInfo[] GetPreladResources(Dictionary<PreloadResKey, PreloadResourceInfo[]> preloadResource, Enum gametypeormode, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	[Token(Token = "0x601A76C")]
	[Address(RVA = "0x3306320", Offset = "0x3306320", VA = "0x3306320")]
	private ResourceID[] GetPreladResources(Dictionary<PreloadResKey, ResourceID[]> preloadResource, Enum gametypeormode, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	[Token(Token = "0x601A76D")]
	[Address(RVA = "0x33067D0", Offset = "0x33067D0", VA = "0x33067D0")]
	private List<int> GetPreladResources(Dictionary<PreloadResKey, int[]> preloadResource, Enum gametypeormode, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	[Token(Token = "0x601A76E")]
	[Address(RVA = "0x33066D0", Offset = "0x33066D0", VA = "0x33066D0")]
	private static void AddResourceIDNoDuplicated(List<ResourceID> result, ResourceID[] ret)
	{
	}

	[Token(Token = "0x601A76F")]
	[Address(RVA = "0x3306220", Offset = "0x3306220", VA = "0x3306220")]
	private static void AddResourceIDNoDuplicated(List<PreloadResourceInfo> result, PreloadResourceInfo[] ret)
	{
	}

	[Token(Token = "0x601A770")]
	[Address(RVA = "0x3306B54", Offset = "0x3306B54", VA = "0x3306B54")]
	private static void AddResourceIDNoDuplicated(List<int> result, int[] ret)
	{
	}

	[Token(Token = "0x601A771")]
	[Address(RVA = "0x3306C54", Offset = "0x3306C54", VA = "0x3306C54")]
	private int GetInstantCountFromResultArray(PreloadResourceInfo[] ret, ResourceID resource)
	{
		return default(int);
	}

	[Token(Token = "0x601A772")]
	[Address(RVA = "0x3306DC4", Offset = "0x3306DC4", VA = "0x3306DC4")]
	public int GetPreloadResourcePoolInstantCount(ResourceID resource, Enum gametypeormode, int mapid = -1, int graphicsetting = -1)
	{
		return default(int);
	}

	[Token(Token = "0x601A773")]
	[Address(RVA = "0x3307068", Offset = "0x3307068", VA = "0x3307068")]
	private static void GetPreloadResourcePoolDic(Dictionary<ResourceID, PreloadResourceInfo> result, PreloadResourceInfo[] ret)
	{
	}

	[Token(Token = "0x601A774")]
	[Address(RVA = "0x3307274", Offset = "0x3307274", VA = "0x3307274")]
	private ResourceID[] GetPreladResourceNoDuplicated(PreloadResourceInfo[] preloadArray)
	{
		return null;
	}

	[Token(Token = "0x601A775")]
	[Address(RVA = "0x330741C", Offset = "0x330741C", VA = "0x330741C")]
	public ResourceID[] GetPreloadResource(Enum gametypeormode, int mapid = -1, int graphicsetting = -1, [Optional] Dictionary<ResourceID, PreloadResourceInfo> preloadpoolinitdic)
	{
		return null;
	}

	[Token(Token = "0x601A776")]
	[Address(RVA = "0x33074E4", Offset = "0x33074E4", VA = "0x33074E4")]
	public ResourceID[] GetPreloadAudioResource(Enum gametypeormode, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	[Token(Token = "0x601A777")]
	[Address(RVA = "0x3307510", Offset = "0x3307510", VA = "0x3307510")]
	public ResourceID[] GetPreloadPlayerAnimatorsResource(Enum key, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	[Token(Token = "0x601A778")]
	[Address(RVA = "0x330753C", Offset = "0x330753C", VA = "0x330753C")]
	public List<int> GetPreloadUmaResources(Enum gametypeormode, int mapid = -1, int graphicsetting = -1)
	{
		return null;
	}

	[Token(Token = "0x601A779")]
	[Address(RVA = "0x3307568", Offset = "0x3307568", VA = "0x3307568")]
	public string GetPath(ResourceID resourceID, GAGILKKDDMJ rq)
	{
		return null;
	}

	[Token(Token = "0x601A77A")]
	[Address(RVA = "0x33075CC", Offset = "0x33075CC", VA = "0x33075CC")]
	public string GetPath(ResourceID resourceID)
	{
		return null;
	}

	[Token(Token = "0x601A77B")]
	[Address(RVA = "0x330761C", Offset = "0x330761C", VA = "0x330761C")]
	public List<ResourceID> GetResourceIDs()
	{
		return null;
	}

	[Token(Token = "0x601A77C")]
	[Address(RVA = "0x33077D4", Offset = "0x33077D4", VA = "0x33077D4")]
	public string GetAtlasOrSpriteResourceIDName(ResourceID ResID, bool InLogErr = true)
	{
		return null;
	}

	[Token(Token = "0x601A77D")]
	[Address(RVA = "0x33079A4", Offset = "0x33079A4", VA = "0x33079A4")]
	public string GetResourceIDNameForDebugOnly(ResourceID ResID, bool InLogErr = true)
	{
		return null;
	}

	[Token(Token = "0x601A77E")]
	[Address(RVA = "0x33079A8", Offset = "0x33079A8", VA = "0x33079A8")]
	private bool TryGetAnonymousResourceIDByName(string strResid, out ResourceID ret)
	{
		return default(bool);
	}

	[Token(Token = "0x601A77F")]
	[Address(RVA = "0x3307A84", Offset = "0x3307A84", VA = "0x3307A84")]
	public ResourceID GetResourceIDByName(Type ResID, string strResid, bool InLogErr = true)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601A780")]
	[Address(RVA = "0x33047BC", Offset = "0x33047BC", VA = "0x33047BC")]
	private static bool IsPathWithSuffix(string url)
	{
		return default(bool);
	}

	[Token(Token = "0x601A781")]
	[Address(RVA = "0x3307E00", Offset = "0x3307E00", VA = "0x3307E00")]
	public AsyncOperation ClearAllLoadedResource(bool includingPreloadResource = true)
	{
		return null;
	}

	[Token(Token = "0x601A782")]
	[Address(RVA = "0x3307EB4", Offset = "0x3307EB4", VA = "0x3307EB4")]
	public void ClearResource(ResourceID id, bool isUnloadAsset = true)
	{
	}

	[Token(Token = "0x601A783")]
	[Address(RVA = "0x3308248", Offset = "0x3308248", VA = "0x3308248")]
	private void ClearResource(ResourceConfigAB config, bool isUnloadAsset = true)
	{
	}

	[Token(Token = "0x601A784")]
	[Address(RVA = "0x33080AC", Offset = "0x33080AC", VA = "0x33080AC")]
	public bool ClearResource(string path, bool isUnloadAsset = true)
	{
		return default(bool);
	}

	[Token(Token = "0x601A785")]
	[Address(RVA = "0x33084E0", Offset = "0x33084E0", VA = "0x33084E0")]
	public bool ClearPreLoadedResources(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x601A786")]
	[Address(RVA = "0x33082FC", Offset = "0x33082FC", VA = "0x33082FC")]
	public bool ClearLoadedResources(string path, bool isUnloadAsset = true)
	{
		return default(bool);
	}

	[Token(Token = "0x601A787")]
	[Address(RVA = "0x3308560", Offset = "0x3308560", VA = "0x3308560")]
	public void ClearAndUnloadLoadedResources(string path)
	{
	}

	[Token(Token = "0x601A788")]
	[Address(RVA = "0x330192C", Offset = "0x330192C", VA = "0x330192C")]
	private void ClearAllLoadedResourceInternal(bool includingPreloadResource)
	{
	}

	[Token(Token = "0x601A789")]
	[Address(RVA = "0x32F702C", Offset = "0x32F702C", VA = "0x32F702C")]
	public void UnloadBundleResourceByPath(string path)
	{
	}

	[Token(Token = "0x601A78A")]
	[Address(RVA = "0x3308638", Offset = "0x3308638", VA = "0x3308638")]
	public bool PreloadResouce(ResourceID id)
	{
		return default(bool);
	}

	[Token(Token = "0x601A78B")]
	[Address(RVA = "0x3308A30", Offset = "0x3308A30", VA = "0x3308A30")]
	public Object GetResourceNoCache(ResourceID id)
	{
		return null;
	}

	[Token(Token = "0x601A78C")]
	[Address(RVA = "0x3308A60", Offset = "0x3308A60", VA = "0x3308A60")]
	public Object GetResourceByNameAndAb(string resPath, string abPath, bool preload, bool noCache)
	{
		return null;
	}

	[Token(Token = "0x601A78D")]
	[Address(RVA = "0x3308CD4", Offset = "0x3308CD4", VA = "0x3308CD4")]
	protected Object GetResourceNoCache(string path, bool notUsingABForcefully = false)
	{
		return null;
	}

	[Token(Token = "0x601A78E")]
	[Address(RVA = "0x3308CF0", Offset = "0x3308CF0", VA = "0x3308CF0")]
	public ResourceID AddPlaceholderResForAb(string ab)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601A78F")]
	[Address(RVA = "0x3304460", Offset = "0x3304460", VA = "0x3304460")]
	private bool LoadResconfDependenciesInNeed(string ab, bool recursive = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A790")]
	[Address(RVA = "0x3308E30", Offset = "0x3308E30", VA = "0x3308E30")]
	public bool NeedDownloadOptionalBundle(bool assertInSingleBundle, ResourceID[] ids)
	{
		return default(bool);
	}

	[Token(Token = "0x601A791")]
	[Address(RVA = "0x3308F6C", Offset = "0x3308F6C", VA = "0x3308F6C")]
	public bool NeedDownloadOptionalBundle(ResourceID id)
	{
		return default(bool);
	}

	[Token(Token = "0x601A792")]
	[Address(RVA = "0x33090F8", Offset = "0x33090F8", VA = "0x33090F8")]
	public bool NeedDownloadOptionalBundle(string ab)
	{
		return default(bool);
	}

	[Token(Token = "0x601A793")]
	[Address(RVA = "0x3309358", Offset = "0x3309358", VA = "0x3309358")]
	public List<string> GetResourceDependencies(string ab)
	{
		return null;
	}

	[Token(Token = "0x601A794")]
	[Address(RVA = "0x33093F8", Offset = "0x33093F8", VA = "0x33093F8")]
	public static GameObject Instant(Object obj, [Optional] Transform parent, bool setPosAndRot = false, [Optional] Vector3 pos, [Optional] Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x601A795")]
	[Address(RVA = "0x3309684", Offset = "0x3309684", VA = "0x3309684")]
	public static GameObject InstantByResId(ResourceID resId, [Optional] Transform parent, bool setPosAndRot = false, [Optional] Vector3 pos, [Optional] Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x601A796")]
	[Address(RVA = "0x3309828", Offset = "0x3309828", VA = "0x3309828")]
	public void UnloadSplashTexture()
	{
	}

	[Token(Token = "0x601A797")]
	[Address(RVA = "0x33099AC", Offset = "0x33099AC", VA = "0x33099AC")]
	public ResourceRefCache CreateRefCache()
	{
		return null;
	}

	[Token(Token = "0x601A798")]
	[Address(RVA = "0x3309A4C", Offset = "0x3309A4C", VA = "0x3309A4C")]
	public void ReleaseRefCache(ResourceRefCache cache)
	{
	}

	[Token(Token = "0x601A799")]
	[Address(RVA = "0x3309ACC", Offset = "0x3309ACC", VA = "0x3309ACC")]
	public bool IsAudioEventResID(ResourceID res_id)
	{
		return default(bool);
	}

	[Token(Token = "0x601A79A")]
	[Address(RVA = "0x33088F4", Offset = "0x33088F4", VA = "0x33088F4")]
	private bool ResourceContains(ResourceID resourceID)
	{
		return default(bool);
	}

	[Token(Token = "0x601A79B")]
	[Address(RVA = "0x3303400", Offset = "0x3303400", VA = "0x3303400")]
	private bool TryGetResourceConfigAB(ResourceID resourceID, out ResourceConfigAB cfg)
	{
		return default(bool);
	}

	[Token(Token = "0x601A79C")]
	[Address(RVA = "0x33038A0", Offset = "0x33038A0", VA = "0x33038A0")]
	private bool TryGetResourceConfigABOrUrl(ResourceID resourceID, out ResourceConfigAB cfg, out string url)
	{
		return default(bool);
	}

	[Token(Token = "0x601A79D")]
	[Address(RVA = "0x3309B7C", Offset = "0x3309B7C", VA = "0x3309B7C")]
	private void ResetTicketGen()
	{
	}

	[Token(Token = "0x601A79F")]
	[Address(RVA = "0x3309CA0", Offset = "0x3309CA0", VA = "0x3309CA0")]
	private void RecycleRequest(ResAsyncRequest request)
	{
	}

	[Token(Token = "0x601A7A0")]
	[Address(RVA = "0x3309E18", Offset = "0x3309E18", VA = "0x3309E18")]
	private ResAsyncRequest PoolGetRequest(string resPath, ELoadAbOption abOpt, string abPath, Type type, bool preload, bool noCache, bool noDestroy)
	{
		return null;
	}

	[Token(Token = "0x601A7A1")]
	[Address(RVA = "0x3309FC0", Offset = "0x3309FC0", VA = "0x3309FC0")]
	public uint GetResource(uint ticket, ResourceID id, Action<uint, bool, Object> callback, bool notUsingABForcefully = false, [Optional] Type type, bool noCache = false)
	{
		return default(uint);
	}

	[Token(Token = "0x601A7A2")]
	[Address(RVA = "0x330A710", Offset = "0x330A710", VA = "0x330A710")]
	public uint GetResource(uint ticket, string resPath, Action<uint, bool, Object> callback, bool notUsingABForcefully = false, bool noCache = false)
	{
		return default(uint);
	}

	[Token(Token = "0x601A7A3")]
	[Address(RVA = "0x330A7F8", Offset = "0x330A7F8", VA = "0x330A7F8")]
	public uint GetResourceByNameAndAb(uint ticket, string resPath, string abPath, Action<uint, bool, Object> callback, bool preload, bool noCache)
	{
		return default(uint);
	}

	[Token(Token = "0x601A7A4")]
	[Address(RVA = "0x330A8C8", Offset = "0x330A8C8", VA = "0x330A8C8")]
	public void CancelAsyncResLoad(uint ticket)
	{
	}

	[Token(Token = "0x601A7A5")]
	[Address(RVA = "0x330AAD4", Offset = "0x330AAD4", VA = "0x330AAD4")]
	public void UpdateAsyncLoadingRes()
	{
	}

	[Token(Token = "0x601A7A6")]
	[Address(RVA = "0x33025A8", Offset = "0x33025A8", VA = "0x33025A8")]
	public void CleanUpAsyncLoadResRequests(bool cleanUpPool = false)
	{
	}

	[Token(Token = "0x601A7A7")]
	[Address(RVA = "0x330B648", Offset = "0x330B648", VA = "0x330B648")]
	private void HandlePendingCleanUp()
	{
	}

	[Token(Token = "0x601A7A8")]
	[Address(RVA = "0x330BA34", Offset = "0x330BA34", VA = "0x330BA34")]
	private void ClearListWithRecycle()
	{
	}

	[Token(Token = "0x601A7A9")]
	[Address(RVA = "0x330B668", Offset = "0x330B668", VA = "0x330B668")]
	private void PumpAsyncResLoadRequestQueue()
	{
	}

	[Token(Token = "0x601A7AA")]
	[Address(RVA = "0x330C0A0", Offset = "0x330C0A0", VA = "0x330C0A0")]
	public Object FindLoadedResource(ResourceID resId)
	{
		return null;
	}

	[Token(Token = "0x601A7AB")]
	[Address(RVA = "0x330C208", Offset = "0x330C208", VA = "0x330C208")]
	private Object FindLoadedResource(string resPath)
	{
		return null;
	}

	[Token(Token = "0x601A7AC")]
	[Address(RVA = "0x330A1D8", Offset = "0x330A1D8", VA = "0x330A1D8")]
	private uint EnqueueRequest(uint ticket, string resPath, Action<uint, bool, Object> callback, ELoadAbOption abOpt, string abPath = "", [Optional] Type type, bool preload = false, bool noCache = false, bool dontDestroy = false)
	{
		return default(uint);
	}

	[Token(Token = "0x601A7AD")]
	[Address(RVA = "0x330BB5C", Offset = "0x330BB5C", VA = "0x330BB5C")]
	private AsyncOperation GetResourceAsyncImpl(ResAsyncRequest req)
	{
		return null;
	}

	[Token(Token = "0x601A7AE")]
	[Address(RVA = "0x330B190", Offset = "0x330B190", VA = "0x330B190")]
	private void OnAsyncGetResCompleted(ResAsyncRequest req)
	{
	}

	[Token(Token = "0x601A7AF")]
	[Address(RVA = "0x330C2F0", Offset = "0x330C2F0", VA = "0x330C2F0")]
	public static Object LauncherLoadResource(string path)
	{
		return null;
	}

	[Token(Token = "0x601A7B0")]
	[Address(RVA = "0x330C2F8", Offset = "0x330C2F8", VA = "0x330C2F8")]
	public Texture2D GetOverrideTexture(string path)
	{
		return null;
	}

	[Token(Token = "0x601A7B1")]
	[Address(RVA = "0x330C520", Offset = "0x330C520", VA = "0x330C520")]
	public Material GetOverrideMaterial(string path)
	{
		return null;
	}

	[Token(Token = "0x601A7B2")]
	[Address(RVA = "0x330C780", Offset = "0x330C780", VA = "0x330C780")]
	public static Texture2D LoadHDTexture(string path)
	{
		return null;
	}

	[Token(Token = "0x601A7B3")]
	[Address(RVA = "0x330C8B0", Offset = "0x330C8B0", VA = "0x330C8B0")]
	public bool ParseResourceConf(Type ResID, Type EnumGame, Type EnumMode)
	{
		return default(bool);
	}

	[Token(Token = "0x601A7B4")]
	[Address(RVA = "0x330DB70", Offset = "0x330DB70", VA = "0x330DB70")]
	private bool ParseResourceConfInternal(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, bool overwrite = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A7B5")]
	[Address(RVA = "0x330F49C", Offset = "0x330F49C", VA = "0x330F49C")]
	private bool ParseResourceConfAsJson(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, TextReader tr, bool overwrite = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A7B6")]
	[Address(RVA = "0x331149C", Offset = "0x331149C", VA = "0x331149C")]
	private void parseResourceTag(List<string> abs, Type ResID, JsonData dataWithTag, out string url, out string ab, out string stream_ab, out ELoadAbOption isAB, out string deps, out EResourceConfigLevelSetting lowSetting, out EResourceConfigLevelSetting highSetting, out MethodInfo modifier, out bool nameHashCollided)
	{
	}

	[Token(Token = "0x601A7B7")]
	[Address(RVA = "0x331216C", Offset = "0x331216C", VA = "0x331216C")]
	private void parseAndAddResourceMapping(Type ResID, string strName, string url, string ab, string stream_ab, ELoadAbOption isAB, EResourceConfigLevelSetting lowSetting, EResourceConfigLevelSetting highSetting, MethodInfo modifier, bool needResIDToName, bool overwrite, bool nameHashCollided)
	{
	}

	[Token(Token = "0x601A7B8")]
	[Address(RVA = "0x3311034", Offset = "0x3311034", VA = "0x3311034")]
	public void AddResourceMapping(string resPath, ResourceID resourceID)
	{
	}

	[Token(Token = "0x601A7B9")]
	[Address(RVA = "0x3312DF0", Offset = "0x3312DF0", VA = "0x3312DF0")]
	public void AddResourceAnoymousMapping(string resName, bool anonymous, ResourceID resourceID, bool nameHashCollided)
	{
	}

	[Token(Token = "0x601A7BA")]
	[Address(RVA = "0x3312960", Offset = "0x3312960", VA = "0x3312960")]
	public void AddResconfDependenciesInNeed(string ab, string deps)
	{
	}

	[Token(Token = "0x601A7BB")]
	[Address(RVA = "0x330DAA8", Offset = "0x330DAA8", VA = "0x330DAA8")]
	private void InitPreloadDics()
	{
	}

	[Token(Token = "0x601A7BC")]
	[Address(RVA = "0x330DF08", Offset = "0x330DF08", VA = "0x330DF08")]
	private void ParsePreloadResIds(Type EnumGame, Type EnumMode)
	{
	}

	[Token(Token = "0x601A7BD")]
	[Address(RVA = "0x3313FA8", Offset = "0x3313FA8", VA = "0x3313FA8")]
	private void ParsePreloadUmas(Type EnumGame, Type EnumMode)
	{
	}

	[Token(Token = "0x601A7BE")]
	[Address(RVA = "0x3312F4C", Offset = "0x3312F4C", VA = "0x3312F4C")]
	private void AddPreloadList(Type EnumGame, Type EnumMode, List<KeyValuePair<PreloadAssetKey, List<string>>> enumToResNames, Dictionary<PreloadResKey, ResourceID[]> dst, bool forAudio = false, [Optional] Dictionary<PreloadResKey, PreloadResourceInfo[]> dstcnt)
	{
	}

	[Token(Token = "0x601A7BF")]
	[Address(RVA = "0x3314BB4", Offset = "0x3314BB4", VA = "0x3314BB4")]
	private void ParseResNames(List<string> resNames, List<ResourceID> resIDs, bool forAudio = false)
	{
	}

	[Token(Token = "0x601A7C0")]
	[Address(RVA = "0x330D934", Offset = "0x330D934", VA = "0x330D934")]
	private void InitResFieldsDict(Type ResID)
	{
	}

	[Token(Token = "0x601A7C1")]
	[Address(RVA = "0x3312D30", Offset = "0x3312D30", VA = "0x3312D30")]
	private FieldInfo GetResFieldInfoByName(string name)
	{
		return null;
	}

	[Token(Token = "0x601A7C2")]
	[Address(RVA = "0x3314F40", Offset = "0x3314F40", VA = "0x3314F40")]
	public static List<string> parseJsonStrList(JsonData JObjRoot, string name)
	{
		return null;
	}

	[Token(Token = "0x601A7C3")]
	[Address(RVA = "0x331140C", Offset = "0x331140C", VA = "0x331140C")]
	public static List<string> ParseResourceAbNames(JsonData JObjRoot)
	{
		return null;
	}

	[Token(Token = "0x601A7C4")]
	[Address(RVA = "0x33150E4", Offset = "0x33150E4", VA = "0x33150E4")]
	private static List<string> ParseStreamNameAbs(JsonData JObjRoot)
	{
		return null;
	}

	[Token(Token = "0x601A7C5")]
	[Address(RVA = "0x3315174", Offset = "0x3315174", VA = "0x3315174")]
	private static List<string> ParseStreamAbPathes(JsonData JObjRoot)
	{
		return null;
	}

	[Token(Token = "0x601A7C6")]
	[Address(RVA = "0x3310BA0", Offset = "0x3310BA0", VA = "0x3310BA0")]
	private static void ParseStreamAbs(JsonData JObjRoot, ref Dictionary<string, string> dst)
	{
	}

	[Token(Token = "0x601A7C7")]
	[Address(RVA = "0x330E070", Offset = "0x330E070", VA = "0x330E070")]
	private bool IsResourceConfInTxtFormat(TextReader tr)
	{
		return default(bool);
	}

	[Token(Token = "0x601A7C8")]
	[Address(RVA = "0x330E0B4", Offset = "0x330E0B4", VA = "0x330E0B4")]
	private bool ParseResourceConfAsTxt(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, TextReader tr, bool overwrite = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A7C9")]
	[Address(RVA = "0x3315204", Offset = "0x3315204", VA = "0x3315204")]
	public static List<string> ReadStringList(TextReader tr, [Optional] string countKey)
	{
		return null;
	}

	[Token(Token = "0x601A7CA")]
	[Address(RVA = "0x3315974", Offset = "0x3315974", VA = "0x3315974")]
	private static void ReadStringList(TextReader tr, List<string> ret, [Optional] string countKey)
	{
	}

	[Token(Token = "0x601A7CB")]
	[Address(RVA = "0x33158F0", Offset = "0x33158F0", VA = "0x33158F0")]
	private static int ReadCountLine(TextReader tr, [Optional] string countKey)
	{
		return default(int);
	}

	[Token(Token = "0x601A7CC")]
	[Address(RVA = "0x33152C4", Offset = "0x33152C4", VA = "0x33152C4")]
	private void ParseAndAddMember(TextReader tr, Type ResID, List<string> abNames, bool overwrite, bool forAtlas)
	{
	}
}
