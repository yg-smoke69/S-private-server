using System;
using System.Collections.Generic;
using System.IO;
using COW.GamePlay;
using Il2CppDummyDll;
using TsiU;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C7B")]
public class SlotOverlayCacheManager : TSingleton<SlotOverlayCacheManager>
{
	[Token(Token = "0x4019B29")]
	private const ulong AnonymousUserID = 0uL;

	[Token(Token = "0x4019B2A")]
	public const bool UnloadSlotOverlays = true;

	[Token(Token = "0x4019B2B")]
	[FieldOffset(Offset = "0x0")]
	public static bool UnloadSlotMeshAssets;

	[Token(Token = "0x4019B2C")]
	[FieldOffset(Offset = "0x1")]
	public static bool UnloadOverlayTextures;

	[Token(Token = "0x4019B2D")]
	[FieldOffset(Offset = "0x2")]
	public static bool ClearSlotMeshAssets;

	[Token(Token = "0x4019B2E")]
	public const bool PreloadBotAssets = true;

	[Token(Token = "0x4019B2F")]
	public const bool PreloadBotAssetsInRootCache = true;

	[Token(Token = "0x4019B30")]
	public const bool UnloadBotAssets = true;

	[Token(Token = "0x4019B31")]
	[FieldOffset(Offset = "0x8")]
	private bool m_Preloading;

	[Token(Token = "0x4019B32")]
	[FieldOffset(Offset = "0x9")]
	private bool m_PreloadingClothes;

	[Token(Token = "0x4019B33")]
	[FieldOffset(Offset = "0xA")]
	private bool _003CLoadNoCache_003Ek__BackingField;

	[Token(Token = "0x4019B34")]
	[FieldOffset(Offset = "0xB")]
	private bool _003CUnloadAssets_003Ek__BackingField;

	[Token(Token = "0x4019B35")]
	[FieldOffset(Offset = "0xC")]
	private bool _003CDisableRefs_003Ek__BackingField;

	[Token(Token = "0x4019B36")]
	[FieldOffset(Offset = "0xD")]
	private bool m_HasCaches;

	[Token(Token = "0x4019B37")]
	[FieldOffset(Offset = "0x10")]
	private SlotOverlayAssetCacheWithRefsDic m_RootCache;

	[Token(Token = "0x4019B38")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<ulong, SlotOverlayAssetCacheWithRefsChild> m_PlayerCaches;

	[Token(Token = "0x4019B39")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, SlotOverlayAssetCacheWithRefsChild> m_BotCaches;

	[Token(Token = "0x4019B3A")]
	[FieldOffset(Offset = "0x1C")]
	private HashSet<SlotOverlayAssetCache> m_AnonymousCaches;

	[Token(Token = "0x4019B3B")]
	[FieldOffset(Offset = "0x20")]
	private uint m_UnloadDelayCall;

	[Token(Token = "0x4019B3C")]
	[FieldOffset(Offset = "0x24")]
	protected List<SlotDataAsset> m_UnloadingSlots;

	[Token(Token = "0x4019B3D")]
	[FieldOffset(Offset = "0x28")]
	protected List<OverlayDataAsset> m_UnloadingOverlays;

	[Token(Token = "0x4019B3E")]
	[FieldOffset(Offset = "0x4")]
	private static List<string> s_SharedRecipeList;

	[Token(Token = "0x4019B3F")]
	[FieldOffset(Offset = "0x2C")]
	protected Sample m_SampleUnloadCache;

	[Token(Token = "0x4019B40")]
	[FieldOffset(Offset = "0x30")]
	protected Sample m_SampleCheckAndUnload;

	[Token(Token = "0x1700199F")]
	public bool LoadNoCache
	{
		[Token(Token = "0x601827B")]
		[Address(RVA = "0x2D5DBA0", Offset = "0x2D5DBA0", VA = "0x2D5DBA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601827C")]
		[Address(RVA = "0x2D5DBA8", Offset = "0x2D5DBA8", VA = "0x2D5DBA8")]
		private set
		{
		}
	}

	[Token(Token = "0x170019A0")]
	public bool UnloadAssets
	{
		[Token(Token = "0x601827D")]
		[Address(RVA = "0x2D5DBB0", Offset = "0x2D5DBB0", VA = "0x2D5DBB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601827E")]
		[Address(RVA = "0x2D5DBB8", Offset = "0x2D5DBB8", VA = "0x2D5DBB8")]
		private set
		{
		}
	}

	[Token(Token = "0x170019A1")]
	public bool DisableRefs
	{
		[Token(Token = "0x601827F")]
		[Address(RVA = "0x2D5DBC0", Offset = "0x2D5DBC0", VA = "0x2D5DBC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6018280")]
		[Address(RVA = "0x2D5DBC8", Offset = "0x2D5DBC8", VA = "0x2D5DBC8")]
		private set
		{
		}
	}

	[Token(Token = "0x601827A")]
	[Address(RVA = "0x2D5DA0C", Offset = "0x2D5DA0C", VA = "0x2D5DA0C")]
	public SlotOverlayCacheManager()
	{
	}

	[Token(Token = "0x6018281")]
	[Address(RVA = "0x2D5DBD0", Offset = "0x2D5DBD0", VA = "0x2D5DBD0")]
	public void SetLobbyOptions()
	{
	}

	[Token(Token = "0x6018282")]
	[Address(RVA = "0x2D5E600", Offset = "0x2D5E600", VA = "0x2D5E600")]
	public void SetGameOptions(bool isWaitingRoom, bool noWaitingRoomBattle, bool preloadInWaiting, bool releaseInGame)
	{
	}

	[Token(Token = "0x6018283")]
	[Address(RVA = "0x2D5E038", Offset = "0x2D5E038", VA = "0x2D5E038")]
	private void SetUnloadAssetsOnCacheDestroy(bool unload)
	{
	}

	[Token(Token = "0x6018284")]
	[Address(RVA = "0x2D5DE0C", Offset = "0x2D5DE0C", VA = "0x2D5DE0C")]
	private void SetNeedPreloadAssets(bool need)
	{
	}

	[Token(Token = "0x6018285")]
	[Address(RVA = "0x2D5DC08", Offset = "0x2D5DC08", VA = "0x2D5DC08")]
	private void SetLoadNoCache(bool noCache)
	{
	}

	[Token(Token = "0x6018286")]
	[Address(RVA = "0x2D5F070", Offset = "0x2D5F070", VA = "0x2D5F070")]
	private void UpdateDisableRefCount()
	{
	}

	[Token(Token = "0x6018287")]
	[Address(RVA = "0x2D5F0C0", Offset = "0x2D5F0C0", VA = "0x2D5F0C0")]
	private void EnsureRootCache()
	{
	}

	[Token(Token = "0x6018288")]
	[Address(RVA = "0x2D5F3B4", Offset = "0x2D5F3B4", VA = "0x2D5F3B4")]
	public SlotOverlayAssetCacheWithRefs GetRootCache()
	{
		return null;
	}

	[Token(Token = "0x6018289")]
	[Address(RVA = "0x2D5F3CC", Offset = "0x2D5F3CC", VA = "0x2D5F3CC")]
	public SlotOverlayAssetCacheWithRefs GetPlayerCache(ulong uid, IHAAMHPPLMG pid, bool create = true)
	{
		return null;
	}

	[Token(Token = "0x601828A")]
	[Address(RVA = "0x2D60324", Offset = "0x2D60324", VA = "0x2D60324")]
	public SlotOverlayAssetCache CreateAnonymousCache(bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x601828B")]
	[Address(RVA = "0x2D60490", Offset = "0x2D60490", VA = "0x2D60490")]
	public void PreloadClothes(ulong userID, IHAAMHPPLMG pid, bool useHighQualityAvatar, uint avatarId, List<uint> clothList)
	{
	}

	[Token(Token = "0x601828C")]
	[Address(RVA = "0x2D61A38", Offset = "0x2D61A38", VA = "0x2D61A38")]
	public bool PreloadClothes(int hash)
	{
		return default(bool);
	}

	[Token(Token = "0x601828D")]
	[Address(RVA = "0x2D61F18", Offset = "0x2D61F18", VA = "0x2D61F18")]
	public void ClearCaches(bool removeChildren = true)
	{
	}

	[Token(Token = "0x601828E")]
	[Address(RVA = "0x2D62950", Offset = "0x2D62950", VA = "0x2D62950")]
	public void ReleaseCache(SlotOverlayAssetCache cache)
	{
	}

	[Token(Token = "0x601828F")]
	[Address(RVA = "0x2D63CEC", Offset = "0x2D63CEC", VA = "0x2D63CEC")]
	private bool RemoveCache(SlotOverlayAssetCacheWithRefsChild cache)
	{
		return default(bool);
	}

	[Token(Token = "0x6018290")]
	[Address(RVA = "0x2D63DF0", Offset = "0x2D63DF0", VA = "0x2D63DF0")]
	private void UpdateHasCaches()
	{
	}

	[Token(Token = "0x6018291")]
	[Address(RVA = "0x2D63EE4", Offset = "0x2D63EE4", VA = "0x2D63EE4")]
	private void UnloadCache(SlotOverlayAssetCacheWithRefsChild cache)
	{
	}

	[Token(Token = "0x6018292")]
	[Address(RVA = "0x2D628AC", Offset = "0x2D628AC", VA = "0x2D628AC")]
	private void ClearUnloadingLists()
	{
	}

	[Token(Token = "0x6018293")]
	[Address(RVA = "0x2D6406C", Offset = "0x2D6406C", VA = "0x2D6406C")]
	private bool HasUnloadingAssets()
	{
		return default(bool);
	}

	[Token(Token = "0x6018294")]
	[Address(RVA = "0x2D5F084", Offset = "0x2D5F084", VA = "0x2D5F084")]
	private void StartOrStopUnloading()
	{
	}

	[Token(Token = "0x6018295")]
	[Address(RVA = "0x2D636B4", Offset = "0x2D636B4", VA = "0x2D636B4")]
	private void StartOrStopUnloading(bool start, bool clearOnStop = true)
	{
	}

	[Token(Token = "0x6018296")]
	[Address(RVA = "0x2D64130", Offset = "0x2D64130", VA = "0x2D64130")]
	private void TryUpdateUnloading()
	{
	}

	[Token(Token = "0x6018297")]
	[Address(RVA = "0x2D64350", Offset = "0x2D64350", VA = "0x2D64350")]
	private bool DoUpdateUnloading()
	{
		return default(bool);
	}

	[Token(Token = "0x6018298")]
	private bool CheckAndUnload<T>(bool isSlot, List<T> list, Action<T> unloadFunc) where T : Object
	{
		return default(bool);
	}

	[Token(Token = "0x6018299")]
	[Address(RVA = "0x2D64498", Offset = "0x2D64498", VA = "0x2D64498")]
	private void UnloadSlot(SlotDataAsset slot)
	{
	}

	[Token(Token = "0x601829A")]
	[Address(RVA = "0x2D648E4", Offset = "0x2D648E4", VA = "0x2D648E4")]
	private void UnloadOverlay(OverlayDataAsset overlay)
	{
	}

	[Token(Token = "0x601829B")]
	[Address(RVA = "0x2D647E8", Offset = "0x2D647E8", VA = "0x2D647E8")]
	private void UnloadAsset(Object asset)
	{
	}

	[Token(Token = "0x601829C")]
	[Address(RVA = "0x2D5E658", Offset = "0x2D5E658", VA = "0x2D5E658")]
	private void Debug(string s)
	{
	}

	[Token(Token = "0x601829D")]
	[Address(RVA = "0x2D5EF40", Offset = "0x2D5EF40", VA = "0x2D5EF40")]
	public void InitSamples()
	{
	}

	[Token(Token = "0x601829E")]
	[Address(RVA = "0x2D5F004", Offset = "0x2D5F004", VA = "0x2D5F004")]
	public void LogSamples()
	{
	}

	[Token(Token = "0x601829F")]
	[Address(RVA = "0x2D64B90", Offset = "0x2D64B90", VA = "0x2D64B90")]
	public void PrintCacheRefs(StreamWriter sw)
	{
	}

	[Token(Token = "0x60182A0")]
	private static void PrintUnRefed<T>(StreamWriter sw, string name, Dictionary<int, T> cache, Dictionary<T, short> refs)
	{
	}

	[Token(Token = "0x60182A1")]
	[Address(RVA = "0x2D65A40", Offset = "0x2D65A40", VA = "0x2D65A40")]
	private static void PrintCacheRefs(StreamWriter sw, string name, ICollection<SlotOverlayAssetCacheWithRefsChild> caches, Dictionary<SlotDataAsset, short> slotRefs, Dictionary<OverlayDataAsset, short> overlayRefs)
	{
	}

	[Token(Token = "0x60182A2")]
	[Address(RVA = "0x2D65F0C", Offset = "0x2D65F0C", VA = "0x2D65F0C")]
	private static void PrintCacheRefs(StreamWriter sw, string name, ICollection<SlotOverlayAssetCache> caches)
	{
	}

	[Token(Token = "0x60182A3")]
	protected void CheckRefCounts<T>(StreamWriter sw, Dictionary<T, short> self, Dictionary<T, short> children)
	{
	}
}
