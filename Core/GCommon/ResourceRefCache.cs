using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040F3")]
public class ResourceRefCache
{
	[Token(Token = "0x20040F4")]
	public delegate void ResourceClearCallback(ResourceID res_id, Object obj);

	[Token(Token = "0x401B4CC")]
	[FieldOffset(Offset = "0x8")]
	public bool ClearOnQualityChange;

	[Token(Token = "0x401B4CD")]
	[FieldOffset(Offset = "0xC")]
	private GAGILKKDDMJ m_CurrentQuality;

	[Token(Token = "0x401B4CE")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<ResourceID, Object> m_LoadedResources;

	[Token(Token = "0x401B4CF")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, List<ResourceID>> m_LoadedABPathToUrls;

	[Token(Token = "0x17001D0C")]
	public int LoadedResourcesCount
	{
		[Token(Token = "0x601A7F6")]
		[Address(RVA = "0x322B450", Offset = "0x322B450", VA = "0x322B450")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x601A7F5")]
	[Address(RVA = "0x322B388", Offset = "0x322B388", VA = "0x322B388")]
	public ResourceRefCache()
	{
	}

	[Token(Token = "0x601A7F7")]
	[Address(RVA = "0x322B4C8", Offset = "0x322B4C8", VA = "0x322B4C8")]
	public Object GetResource(ResourceID id, bool notUsingABForcefully = false, [Optional] Type type, bool record_ab_name = false)
	{
		return null;
	}

	[Token(Token = "0x601A7F8")]
	[Address(RVA = "0x322B99C", Offset = "0x322B99C", VA = "0x322B99C")]
	public void ClearResource(ResourceID id, bool isUnloadAsset = true)
	{
	}

	[Token(Token = "0x601A7F9")]
	[Address(RVA = "0x322BA1C", Offset = "0x322BA1C", VA = "0x322BA1C")]
	public void ClearResourcesByABPath(string ab_path, ResourceClearCallback clear_callBack)
	{
	}

	[Token(Token = "0x601A7FA")]
	[Address(RVA = "0x322BBE0", Offset = "0x322BBE0", VA = "0x322BBE0")]
	public void ClearResource(ResourceID id, ResourceClearCallback clear_callBack)
	{
	}

	[Token(Token = "0x601A7FB")]
	[Address(RVA = "0x322BF60", Offset = "0x322BF60", VA = "0x322BF60")]
	public void Clear(ResourceClearCallback clear_callBack)
	{
	}

	[Token(Token = "0x601A7FC")]
	[Address(RVA = "0x322C1BC", Offset = "0x322C1BC", VA = "0x322C1BC")]
	public void OnClearResource(ResourceID id)
	{
	}

	[Token(Token = "0x601A7FD")]
	[Address(RVA = "0x322B8F8", Offset = "0x322B8F8", VA = "0x322B8F8")]
	public void Clear()
	{
	}
}
