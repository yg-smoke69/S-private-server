using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C81")]
public static class UmaAssetUtil
{
	[Token(Token = "0x4019B58")]
	[FieldOffset(Offset = "0x0")]
	public static bool LoadNoCache;

	[Token(Token = "0x4019B59")]
	public const bool LoadFromAssetDatabase = false;

	[Token(Token = "0x4019B5A")]
	public const bool LoadFromIndexer = false;

	[Token(Token = "0x4019B5B")]
	[FieldOffset(Offset = "0x1")]
	public static readonly bool LoadFromResManager;

	[Token(Token = "0x4019B5C")]
	[FieldOffset(Offset = "0x4")]
	private static ResourceManager ResManagerInstance;

	[Token(Token = "0x4019B5D")]
	[FieldOffset(Offset = "0x8")]
	public static readonly uint INVALID_REQUEST_ID;

	[Token(Token = "0x4019B5E")]
	[FieldOffset(Offset = "0xC")]
	public static readonly uint INSTANT_REQUEST_ID;

	[Token(Token = "0x4019B5F")]
	[FieldOffset(Offset = "0x10")]
	public static readonly uint VALID_REQUEST_ID_START;

	[Token(Token = "0x60182E5")]
	[Address(RVA = "0x2D6CDB0", Offset = "0x2D6CDB0", VA = "0x2D6CDB0")]
	public static void Init()
	{
	}

	[Token(Token = "0x60182E6")]
	[Address(RVA = "0x2D5984C", Offset = "0x2D5984C", VA = "0x2D5984C")]
	public static void LogDebug(string s)
	{
	}

	[Token(Token = "0x60182E7")]
	[Address(RVA = "0x2D6CECC", Offset = "0x2D6CECC", VA = "0x2D6CECC")]
	public static void LogWarning(string s)
	{
	}

	[Token(Token = "0x60182E8")]
	[Address(RVA = "0x2D59A28", Offset = "0x2D59A28", VA = "0x2D59A28")]
	public static void LogError(string s)
	{
	}

	[Token(Token = "0x60182E9")]
	public static T GetAsset<T>(string name) where T : Object
	{
		return (T)null;
	}

	[Token(Token = "0x60182EA")]
	public static T GetAsset<T>(string ab, string path, bool preload) where T : Object
	{
		return (T)null;
	}

	[Token(Token = "0x60182EB")]
	[Address(RVA = "0x2D6CFD4", Offset = "0x2D6CFD4", VA = "0x2D6CFD4")]
	public static bool ClearAsset(string path, bool unload = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60182EC")]
	[Address(RVA = "0x2D588BC", Offset = "0x2D588BC", VA = "0x2D588BC")]
	public static bool IsDelayedRequestId(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60182ED")]
	public static uint GetAsset<T>(string ab, string path, Action<uint, bool, Object> callback) where T : Object
	{
		return default(uint);
	}

	[Token(Token = "0x60182EE")]
	[Address(RVA = "0x2D5955C", Offset = "0x2D5955C", VA = "0x2D5955C")]
	public static void CancelAsyncLoad(uint ticket)
	{
	}
}
