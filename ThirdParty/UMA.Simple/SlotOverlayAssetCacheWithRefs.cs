using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C78")]
public abstract class SlotOverlayAssetCacheWithRefs : SlotOverlayAssetCache
{
	[Token(Token = "0x4019B22")]
	[FieldOffset(Offset = "0x30")]
	public bool IsBot;

	[Token(Token = "0x4019B23")]
	[FieldOffset(Offset = "0x38")]
	public ulong Id;

	[Token(Token = "0x4019B24")]
	[FieldOffset(Offset = "0x40")]
	public bool DisableRefCount;

	[Token(Token = "0x4019B25")]
	[FieldOffset(Offset = "0x44")]
	protected ISlotOverlayRefs m_Refs;

	[Token(Token = "0x601825D")]
	[Address(RVA = "0x2D5A440", Offset = "0x2D5A440", VA = "0x2D5A440")]
	protected SlotOverlayAssetCacheWithRefs()
	{
	}

	[Token(Token = "0x601825E")]
	[Address(RVA = "0x2D5A448", Offset = "0x2D5A448", VA = "0x2D5A448", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x601825F")]
	[Address(RVA = "0x2D5A6D4", Offset = "0x2D5A6D4", VA = "0x2D5A6D4")]
	public void Init(bool isBot, ulong id, bool disableRefs)
	{
	}

	[Token(Token = "0x6018260")]
	[Address(RVA = "0x2D5A708", Offset = "0x2D5A708", VA = "0x2D5A708", Slot = "4")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6018261")]
	protected abstract void InitRefs();

	[Token(Token = "0x6018262")]
	[Address(RVA = "0x2D5A738", Offset = "0x2D5A738", VA = "0x2D5A738", Slot = "5")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6018263")]
	[Address(RVA = "0x2D5A768", Offset = "0x2D5A768", VA = "0x2D5A768", Slot = "15")]
	protected virtual void ClearRefs()
	{
	}

	[Token(Token = "0x6018264")]
	[Address(RVA = "0x2D5A840", Offset = "0x2D5A840", VA = "0x2D5A840", Slot = "9")]
	protected override uint GetAssetAsync(AsyncLoadReq req)
	{
		return default(uint);
	}

	[Token(Token = "0x6018265")]
	protected override void SaveToCacheChecked<T>(int nameHash, bool isSlot, Dictionary<int, T> dic, T asset, bool alreadyInCache = false, bool preload = false)
	{
	}

	[Token(Token = "0x6018266")]
	protected abstract void AddRefCountChecked(int nameHash, bool isSlot, Object asset, bool alreadyInCache, bool preload);

	[Token(Token = "0x6018267")]
	[Address(RVA = "0x2D5A9B4", Offset = "0x2D5A9B4", VA = "0x2D5A9B4")]
	public short AddRefCount(bool isSlot, Object asset, short deltaCount)
	{
		return default(short);
	}

	[Token(Token = "0x6018268")]
	[Address(RVA = "0x2D5ADEC", Offset = "0x2D5ADEC", VA = "0x2D5ADEC")]
	public void GetRefedAssets(ICollection<SlotDataAsset> slots, ICollection<OverlayDataAsset> overlays)
	{
	}
}
