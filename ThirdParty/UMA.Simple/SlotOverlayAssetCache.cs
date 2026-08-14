using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C76")]
public class SlotOverlayAssetCache
{
	[Token(Token = "0x4019B13")]
	[FieldOffset(Offset = "0x8")]
	internal Dictionary<int, SlotDataAsset> m_SlotCache;

	[Token(Token = "0x4019B14")]
	[FieldOffset(Offset = "0xC")]
	internal Dictionary<int, OverlayDataAsset> m_OverlayCache;

	[Token(Token = "0x4019B15")]
	[FieldOffset(Offset = "0x10")]
	protected int m_AddCacheCount;

	[Token(Token = "0x4019B16")]
	[FieldOffset(Offset = "0x14")]
	protected int m_LoadCount;

	[Token(Token = "0x4019B17")]
	[FieldOffset(Offset = "0x18")]
	protected int m_LoadFailCount;

	[Token(Token = "0x4019B18")]
	[FieldOffset(Offset = "0x1C")]
	protected int m_LoadAsyncCount;

	[Token(Token = "0x4019B19")]
	[FieldOffset(Offset = "0x20")]
	protected int m_LoadAsyncFailCount;

	[Token(Token = "0x4019B1A")]
	[FieldOffset(Offset = "0x24")]
	protected Dictionary<uint, AsyncLoadReq> m_LoadingReqs;

	[Token(Token = "0x4019B1B")]
	[FieldOffset(Offset = "0x28")]
	protected AsyncLoadReqPool m_ReqPool;

	[Token(Token = "0x4019B1C")]
	[FieldOffset(Offset = "0x2C")]
	protected Sample m_SyncSample;

	[Token(Token = "0x1700199B")]
	public int CachedSlotCount
	{
		[Token(Token = "0x601822D")]
		[Address(RVA = "0x2D565BC", Offset = "0x2D565BC", VA = "0x2D565BC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700199C")]
	public int CachedOverlayCount
	{
		[Token(Token = "0x601822E")]
		[Address(RVA = "0x2D56630", Offset = "0x2D56630", VA = "0x2D56630")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x601822C")]
	[Address(RVA = "0x2D565B4", Offset = "0x2D565B4", VA = "0x2D565B4")]
	public SlotOverlayAssetCache()
	{
	}

	[Token(Token = "0x601822F")]
	[Address(RVA = "0x2D566A4", Offset = "0x2D566A4", VA = "0x2D566A4", Slot = "4")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x6018230")]
	[Address(RVA = "0x2D566C0", Offset = "0x2D566C0", VA = "0x2D566C0")]
	public void InitCaches()
	{
	}

	[Token(Token = "0x6018231")]
	[Address(RVA = "0x2D56860", Offset = "0x2D56860", VA = "0x2D56860", Slot = "5")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x6018232")]
	[Address(RVA = "0x2D56968", Offset = "0x2D56968", VA = "0x2D56968")]
	protected void ClearCaches()
	{
	}

	[Token(Token = "0x6018233")]
	[Address(RVA = "0x2D56774", Offset = "0x2D56774", VA = "0x2D56774")]
	protected void InitAsyncAndLogSamples()
	{
	}

	[Token(Token = "0x6018234")]
	[Address(RVA = "0x2D5687C", Offset = "0x2D5687C", VA = "0x2D5687C")]
	protected void ClearAsyncAndLogSamples()
	{
	}

	[Token(Token = "0x6018235")]
	[Address(RVA = "0x2D56E84", Offset = "0x2D56E84", VA = "0x2D56E84")]
	public SlotDataAsset GetSlotDataAsset(string name, bool cache)
	{
		return null;
	}

	[Token(Token = "0x6018236")]
	[Address(RVA = "0x2D56F34", Offset = "0x2D56F34", VA = "0x2D56F34")]
	public SlotDataAsset GetSlotDataAsset(int hash, bool cache)
	{
		return null;
	}

	[Token(Token = "0x6018237")]
	[Address(RVA = "0x2D56FE4", Offset = "0x2D56FE4", VA = "0x2D56FE4")]
	public OverlayDataAsset GetOverlayDataAsset(string name, bool cache)
	{
		return null;
	}

	[Token(Token = "0x6018238")]
	[Address(RVA = "0x2D57094", Offset = "0x2D57094", VA = "0x2D57094")]
	public OverlayDataAsset GetOverlayDataAsset(int hash, bool cache)
	{
		return null;
	}

	[Token(Token = "0x6018239")]
	protected virtual T GetAsset<T>(string name, bool isSlot, Dictionary<int, T> dic, bool preload = false) where T : Object
	{
		return (T)null;
	}

	[Token(Token = "0x601823A")]
	protected virtual T GetAsset<T>(int nameHash, bool isSlot, Dictionary<int, T> dic, bool preload = false) where T : Object
	{
		return (T)null;
	}

	[Token(Token = "0x601823B")]
	protected T GetAssetImp<T>(string name) where T : Object
	{
		return (T)null;
	}

	[Token(Token = "0x601823C")]
	protected T GetAssetImp<T>(int nameHash, bool preload) where T : Object
	{
		return (T)null;
	}

	[Token(Token = "0x601823D")]
	[Address(RVA = "0x2D57144", Offset = "0x2D57144", VA = "0x2D57144")]
	public void PreloadRecipe(string recipe)
	{
	}

	[Token(Token = "0x601823E")]
	[Address(RVA = "0x2D574C8", Offset = "0x2D574C8", VA = "0x2D574C8")]
	public void PreloadRecipe(int hash, out bool anyThingLoadedInCall)
	{
	}

	[Token(Token = "0x601823F")]
	[Address(RVA = "0x2D572DC", Offset = "0x2D572DC", VA = "0x2D572DC")]
	public void PreloadRecipe(UmaRecipeSimple recipe)
	{
	}

	[Token(Token = "0x6018240")]
	[Address(RVA = "0x2D578EC", Offset = "0x2D578EC", VA = "0x2D578EC")]
	public bool PreloadAsset(string name, bool isSlot, bool cache)
	{
		return default(bool);
	}

	[Token(Token = "0x6018241")]
	[Address(RVA = "0x2D57768", Offset = "0x2D57768", VA = "0x2D57768")]
	public bool PreloadAsset(int hash, bool isSlot, bool cache)
	{
		return default(bool);
	}

	[Token(Token = "0x6018242")]
	[Address(RVA = "0x2D57A70", Offset = "0x2D57A70", VA = "0x2D57A70")]
	public bool IsSlotContainsOverlay(string slotName, string overlayName, bool cache)
	{
		return default(bool);
	}

	[Token(Token = "0x6018243")]
	[Address(RVA = "0x2D57C40", Offset = "0x2D57C40", VA = "0x2D57C40")]
	public bool IsSlotContainsOverlay(int slotHash, int overlayHash, bool cache)
	{
		return default(bool);
	}

	[Token(Token = "0x6018244")]
	protected virtual void SaveToCacheChecked<T>(int nameHash, bool isSlot, Dictionary<int, T> dic, T asset, bool alreadyInCache = false, bool preload = false) where T : Object
	{
	}

	[Token(Token = "0x6018245")]
	[Address(RVA = "0x2D57DE8", Offset = "0x2D57DE8", VA = "0x2D57DE8")]
	public bool IsAssetCached(string name, bool isSlot)
	{
		return default(bool);
	}

	[Token(Token = "0x6018246")]
	[Address(RVA = "0x2D57E18", Offset = "0x2D57E18", VA = "0x2D57E18")]
	public bool IsAssetCached(int hash, bool isSlot)
	{
		return default(bool);
	}

	[Token(Token = "0x6018247")]
	[Address(RVA = "0x2D57EC8", Offset = "0x2D57EC8", VA = "0x2D57EC8")]
	public Object GetAssetFromCache(int hash, bool isSlot)
	{
		return null;
	}

	[Token(Token = "0x6018248")]
	[Address(RVA = "0x2D57F9C", Offset = "0x2D57F9C", VA = "0x2D57F9C")]
	public bool RemoveSlotDataAsset(int hash)
	{
		return default(bool);
	}

	[Token(Token = "0x6018249")]
	[Address(RVA = "0x2D5801C", Offset = "0x2D5801C", VA = "0x2D5801C")]
	public bool RemoveOverlayDataAsset(int hash)
	{
		return default(bool);
	}

	[Token(Token = "0x601824A")]
	[Address(RVA = "0x2D56A00", Offset = "0x2D56A00", VA = "0x2D56A00")]
	protected void InitAsyncLoading()
	{
	}

	[Token(Token = "0x601824B")]
	[Address(RVA = "0x2D5809C", Offset = "0x2D5809C", VA = "0x2D5809C")]
	public uint GetAssetAsync(string name, Action<Object, uint> callback, bool isSlot, bool cache)
	{
		return default(uint);
	}

	[Token(Token = "0x601824C")]
	[Address(RVA = "0x2D580E4", Offset = "0x2D580E4", VA = "0x2D580E4")]
	public uint GetAssetAsync(int hash, Action<Object, uint> callback, bool isSlot, bool cache)
	{
		return default(uint);
	}

	[Token(Token = "0x601824D")]
	[Address(RVA = "0x2D58238", Offset = "0x2D58238", VA = "0x2D58238")]
	public uint GetAssetAsync(int hash, Action<Object, uint, int> callback, int param, bool isSlot, bool cache)
	{
		return default(uint);
	}

	[Token(Token = "0x601824E")]
	[Address(RVA = "0x2D583AC", Offset = "0x2D583AC", VA = "0x2D583AC", Slot = "9")]
	protected virtual uint GetAssetAsync(AsyncLoadReq req)
	{
		return default(uint);
	}

	[Token(Token = "0x601824F")]
	[Address(RVA = "0x2D584C0", Offset = "0x2D584C0", VA = "0x2D584C0")]
	protected uint GetAssetAsyncImp(AsyncLoadReq req)
	{
		return default(uint);
	}

	[Token(Token = "0x6018250")]
	[Address(RVA = "0x2D58958", Offset = "0x2D58958", VA = "0x2D58958")]
	internal void OnAssetLoaded(uint ticket, Object asset, AsyncLoadReq req)
	{
	}

	[Token(Token = "0x6018251")]
	[Address(RVA = "0x2D58E44", Offset = "0x2D58E44", VA = "0x2D58E44")]
	protected void SaveToCacheChecked(AsyncLoadReq req, Object asset, bool alreadyInCache)
	{
	}

	[Token(Token = "0x6018252")]
	[Address(RVA = "0x2D590B8", Offset = "0x2D590B8", VA = "0x2D590B8")]
	public void CancelAsyncLoad(uint ticket)
	{
	}

	[Token(Token = "0x6018253")]
	[Address(RVA = "0x2D56AA0", Offset = "0x2D56AA0", VA = "0x2D56AA0")]
	public void CancelAllAsyncLoad()
	{
	}

	[Token(Token = "0x6018254")]
	[Address(RVA = "0x2D5968C", Offset = "0x2D5968C", VA = "0x2D5968C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6018255")]
	[Address(RVA = "0x2D59778", Offset = "0x2D59778", VA = "0x2D59778", Slot = "10")]
	protected virtual void Log(string s)
	{
	}

	[Token(Token = "0x6018256")]
	[Address(RVA = "0x2D59954", Offset = "0x2D59954", VA = "0x2D59954", Slot = "11")]
	protected virtual void LogError(string s)
	{
	}

	[Token(Token = "0x6018257")]
	[Address(RVA = "0x2D59B30", Offset = "0x2D59B30", VA = "0x2D59B30", Slot = "12")]
	protected virtual void InitSamples()
	{
	}

	[Token(Token = "0x6018258")]
	[Address(RVA = "0x2D59BC4", Offset = "0x2D59BC4", VA = "0x2D59BC4")]
	protected void BeginSyncSample()
	{
	}

	[Token(Token = "0x6018259")]
	[Address(RVA = "0x2D59BEC", Offset = "0x2D59BEC", VA = "0x2D59BEC")]
	protected void EndSyncSample(string name)
	{
	}

	[Token(Token = "0x601825A")]
	[Address(RVA = "0x2D59ECC", Offset = "0x2D59ECC", VA = "0x2D59ECC")]
	protected void EndSyncSample(int hash)
	{
	}

	[Token(Token = "0x601825B")]
	[Address(RVA = "0x2D5A1CC", Offset = "0x2D5A1CC", VA = "0x2D5A1CC", Slot = "13")]
	public virtual void LogSamples()
	{
	}
}
