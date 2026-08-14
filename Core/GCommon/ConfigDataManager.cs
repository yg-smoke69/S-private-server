using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F30")]
public class ConfigDataManager : SingletonModule<ConfigDataManager>
{
	[Token(Token = "0x401AA39")]
	[FieldOffset(Offset = "0xA")]
	public bool UnLoadNoCacheConfigText;

	[Token(Token = "0x401AA3A")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, List<CSVBaseData>> m_ConfigDataLists;

	[Token(Token = "0x401AA3B")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, Dictionary<string, CSVBaseData>> m_ConfigDataItemss;

	[Token(Token = "0x401AA3C")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, ResourceID> m_ConfigLoadResID;

	[Token(Token = "0x401AA3D")]
	private const int DecryptionBufferSize = 2662400;

	[Token(Token = "0x401AA3E")]
	[FieldOffset(Offset = "0x18")]
	private byte[] m_DecryptionBuffer;

	[Token(Token = "0x401AA3F")]
	[FieldOffset(Offset = "0x1C")]
	private int m_DecryptorBlockSize;

	[Token(Token = "0x401AA40")]
	[FieldOffset(Offset = "0x20")]
	private ICryptoTransform m_Decryptor;

	[Token(Token = "0x401AA41")]
	[FieldOffset(Offset = "0x24")]
	private GameMiscConfig _miscConfig;

	[Token(Token = "0x17001C20")]
	public GameMiscConfig MiscConfig
	{
		[Token(Token = "0x6019B83")]
		[Address(RVA = "0x3089804", Offset = "0x3089804", VA = "0x3089804")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019B80")]
	[Address(RVA = "0x30895EC", Offset = "0x30895EC", VA = "0x30895EC")]
	public ConfigDataManager()
	{
	}

	[Token(Token = "0x6019B81")]
	[Address(RVA = "0x3089718", Offset = "0x3089718", VA = "0x3089718", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6019B82")]
	[Address(RVA = "0x308971C", Offset = "0x308971C", VA = "0x308971C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6019B84")]
	[Address(RVA = "0x30898D4", Offset = "0x30898D4", VA = "0x30898D4")]
	public void InitCsvDecryptionCache()
	{
	}

	[Token(Token = "0x6019B85")]
	[Address(RVA = "0x308994C", Offset = "0x308994C", VA = "0x308994C")]
	public void ReleaseCsvDecryptionCache()
	{
	}

	[Token(Token = "0x6019B86")]
	[Address(RVA = "0x308995C", Offset = "0x308995C", VA = "0x308995C")]
	private byte[] AcquireSharedBuffer()
	{
		return null;
	}

	[Token(Token = "0x6019B87")]
	[Address(RVA = "0x3089970", Offset = "0x3089970", VA = "0x3089970")]
	private void ReleaseSharedBuffer(byte[] buffer)
	{
	}

	[Token(Token = "0x6019B88")]
	[Address(RVA = "0x308997C", Offset = "0x308997C", VA = "0x308997C")]
	public TextReader LoadCsvText(ResourceID resID, ref byte[] sharedBuffer)
	{
		return null;
	}

	[Token(Token = "0x6019B89")]
	public List<T> LoadCSVNoCache<T>(ResourceID resID) where T : CSVBaseData, new()
	{
		return null;
	}

	[Token(Token = "0x6019B8A")]
	public List<T> LoadCSVNoCacheCapSize<T>(ResourceID resID) where T : CSVBaseData, new()
	{
		return null;
	}

	[Token(Token = "0x6019B8B")]
	public List<T> LoadCSVDataByStream<T>(StreamReader stream) where T : CSVBaseData, new()
	{
		return null;
	}

	[Token(Token = "0x6019B8C")]
	public void LoadCSVNoCache<T, P>(ResourceID resID, ICollection<_00211> result) where T : _00211, new() where P : CSVBaseData
	{
	}

	[Token(Token = "0x6019B8D")]
	public void LoadCSVNoCache<T>(ResourceID resID, IDictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
	{
	}

	[Token(Token = "0x6019B8E")]
	public void LoadCSVNoCacheCapSize<T, P>(ResourceID resID, out List<_00211> result) where T : _00211, new() where P : CSVBaseData
	{
	}

	[Token(Token = "0x6019B8F")]
	public void LoadCSVNoCacheCapSize<T>(ResourceID resID, out Dictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
	{
	}

	[Token(Token = "0x6019B90")]
	public void LoadCSV<T>(ResourceID resID) where T : CSVBaseData, new()
	{
	}

	[Token(Token = "0x6019B91")]
	public void LoadCSVCapSize<T>(ResourceID resID) where T : CSVBaseData, new()
	{
	}

	[Token(Token = "0x6019B92")]
	public List<CSVBaseData> GetDataList<T>() where T : CSVBaseData
	{
		return null;
	}

	[Token(Token = "0x6019B93")]
	public Dictionary<string, CSVBaseData> GetDataDictionary<T>() where T : CSVBaseData
	{
		return null;
	}

	[Token(Token = "0x6019B94")]
	public T GetData<T>(string key) where T : CSVBaseData
	{
		return null;
	}

	[Token(Token = "0x6019B95")]
	private static string GetDataListsKey<T>() where T : CSVBaseData
	{
		return null;
	}

	[Token(Token = "0x6019B96")]
	private string GetDataItemKey<T>(string pKey) where T : CSVBaseData
	{
		return null;
	}

	[Token(Token = "0x6019B97")]
	public static List<T> ParseCSV<T>(string csvText) where T : CSVBaseData, new()
	{
		return null;
	}

	[Token(Token = "0x6019B98")]
	public static List<T> ParseCSV<T>(TextReader csvText) where T : CSVBaseData, new()
	{
		return null;
	}

	[Token(Token = "0x6019B99")]
	public static List<T> ParseCSVCapSize<T>(TextReader csvText) where T : CSVBaseData, new()
	{
		return null;
	}

	[Token(Token = "0x6019B9A")]
	[Address(RVA = "0x3089D74", Offset = "0x3089D74", VA = "0x3089D74")]
	private static int LineCount(string str)
	{
		return default(int);
	}

	[Token(Token = "0x6019B9B")]
	public static void ParseCSV<T, P>(TextReader csvText, out List<_00211> result) where T : _00211, new() where P : CSVBaseData
	{
	}

	[Token(Token = "0x6019B9C")]
	public static void ParseCSV<T, P>(TextReader reader, ICollection<_00211> result) where T : _00211, new() where P : CSVBaseData
	{
	}

	[Token(Token = "0x6019B9D")]
	public static void ParseCSV<T>(TextReader csvText, out Dictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
	{
	}

	[Token(Token = "0x6019B9E")]
	public static void ParseCSV<T>(TextReader reader, IDictionary<uint, T> result) where T : CSVBaseData, IGetId, new()
	{
	}

	[Token(Token = "0x6019B9F")]
	public T LoadScriptObject<T>(ResourceID resID) where T : ScriptableObject
	{
		return (T)null;
	}

	[Token(Token = "0x6019BA0")]
	[Address(RVA = "0x3089E64", Offset = "0x3089E64", VA = "0x3089E64")]
	private void UnLoadCachedConfigByDataType(string typeStr)
	{
	}

	[Token(Token = "0x6019BA1")]
	[Address(RVA = "0x3089F84", Offset = "0x3089F84", VA = "0x3089F84")]
	public void UnloadCachedConfigs(List<Type> typeList)
	{
	}

	[Token(Token = "0x6019BA2")]
	public void UnLoadCSVManually<T>()
	{
	}

	[Token(Token = "0x6019BA3")]
	[Address(RVA = "0x308A070", Offset = "0x308A070", VA = "0x308A070")]
	public void ReloadCachedConfigs(List<Type> typeList)
	{
	}
}
