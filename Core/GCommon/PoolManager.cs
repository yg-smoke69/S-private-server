using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040E7")]
public static class PoolManager
{
	[Token(Token = "0x401B459")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<ResourceID, SpawnPool> m_ResPool;

	[Token(Token = "0x401B45A")]
	[FieldOffset(Offset = "0x4")]
	private static GameObject m_Parent;

	[Token(Token = "0x401B45B")]
	public const uint InvalidTicket = 0u;

	[Token(Token = "0x601A731")]
	[Address(RVA = "0x3323B28", Offset = "0x3323B28", VA = "0x3323B28")]
	public static void InitRes(ResourceID resID, int num, uint maxSize = 0u)
	{
	}

	[Token(Token = "0x601A732")]
	[Address(RVA = "0x3323E9C", Offset = "0x3323E9C", VA = "0x3323E9C")]
	public static bool ContainsRes(ResourceID resID)
	{
		return default(bool);
	}

	[Token(Token = "0x601A733")]
	[Address(RVA = "0x3323FA0", Offset = "0x3323FA0", VA = "0x3323FA0")]
	public static Object GetRes(ResourceID resID, [Optional] Transform parentTrans)
	{
		return null;
	}

	[Token(Token = "0x601A734")]
	[Address(RVA = "0x3324280", Offset = "0x3324280", VA = "0x3324280")]
	public static uint GetRes(ResourceID resID, Action<uint, bool, Object> callback, [Optional] Transform parentTrans)
	{
		return default(uint);
	}

	[Token(Token = "0x601A735")]
	[Address(RVA = "0x3324570", Offset = "0x3324570", VA = "0x3324570")]
	public static void UpdateCachedAsyncRequests()
	{
	}

	[Token(Token = "0x601A736")]
	[Address(RVA = "0x332474C", Offset = "0x332474C", VA = "0x332474C")]
	public static void CancelGetResAsync(ResourceID resID, uint ticket)
	{
	}

	[Token(Token = "0x601A737")]
	[Address(RVA = "0x332484C", Offset = "0x332484C", VA = "0x332484C")]
	public static void CancelAllResAsyncByResID(ResourceID resID)
	{
	}

	[Token(Token = "0x601A738")]
	[Address(RVA = "0x3324944", Offset = "0x3324944", VA = "0x3324944")]
	public static bool RecyleRes(ResourceID resID, Object obj, bool worldPositionStays = true)
	{
		return default(bool);
	}

	[Token(Token = "0x601A739")]
	[Address(RVA = "0x3324D44", Offset = "0x3324D44", VA = "0x3324D44")]
	public static bool CleanPool(ResourceID resID)
	{
		return default(bool);
	}

	[Token(Token = "0x601A73A")]
	[Address(RVA = "0x3324E48", Offset = "0x3324E48", VA = "0x3324E48")]
	public static void ClearAll()
	{
	}

	[Token(Token = "0x601A73B")]
	[Address(RVA = "0x3325198", Offset = "0x3325198", VA = "0x3325198")]
	public static string GetPoolDebugInfo()
	{
		return null;
	}

	[Token(Token = "0x601A73C")]
	[Address(RVA = "0x3325408", Offset = "0x3325408", VA = "0x3325408")]
	public static string GetPoolDebugInfo(ResourceID resID)
	{
		return null;
	}
}
