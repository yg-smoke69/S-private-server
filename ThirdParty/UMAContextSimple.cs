using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UMA.Simple;
using UnityEngine;

[Token(Token = "0x2003C86")]
public class UMAContextSimple : UMAContext
{
	[Token(Token = "0x4019B91")]
	[FieldOffset(Offset = "0x1C")]
	public bool CacheSlotOverlay;

	[Token(Token = "0x4019B92")]
	[FieldOffset(Offset = "0x20")]
	protected SlotOverlayAssetCache m_Cache;

	[Token(Token = "0x4019B93")]
	[FieldOffset(Offset = "0x24")]
	private bool m_AsyncLoadAllCancled;

	[Token(Token = "0x170019A4")]
	public SlotOverlayAssetCache Cache
	{
		[Token(Token = "0x601834D")]
		[Address(RVA = "0x2A5A3A0", Offset = "0x2A5A3A0", VA = "0x2A5A3A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601834C")]
	[Address(RVA = "0x2A5A2C0", Offset = "0x2A5A2C0", VA = "0x2A5A2C0")]
	public UMAContextSimple()
	{
	}

	[Token(Token = "0x601834E")]
	[Address(RVA = "0x2A5A3A8", Offset = "0x2A5A3A8", VA = "0x2A5A3A8", Slot = "11")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x601834F")]
	[Address(RVA = "0x2A5A4EC", Offset = "0x2A5A4EC", VA = "0x2A5A4EC", Slot = "4")]
	public override void Start()
	{
	}

	[Token(Token = "0x6018350")]
	[Address(RVA = "0x2A5A638", Offset = "0x2A5A638", VA = "0x2A5A638", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x6018351")]
	[Address(RVA = "0x2A5A3AC", Offset = "0x2A5A3AC", VA = "0x2A5A3AC")]
	private void InitCacheAndManagers()
	{
	}

	[Token(Token = "0x6018352")]
	[Address(RVA = "0x2A5A734", Offset = "0x2A5A734", VA = "0x2A5A734", Slot = "12")]
	public virtual void SetCacheSlotOverlay(bool cache)
	{
	}

	[Token(Token = "0x6018353")]
	[Address(RVA = "0x2A5A73C", Offset = "0x2A5A73C", VA = "0x2A5A73C")]
	protected SlotDataAsset GetSlotDataAsset(string name)
	{
		return null;
	}

	[Token(Token = "0x6018354")]
	[Address(RVA = "0x2A5A780", Offset = "0x2A5A780", VA = "0x2A5A780")]
	protected SlotDataAsset GetSlotDataAsset(int hash)
	{
		return null;
	}

	[Token(Token = "0x6018355")]
	[Address(RVA = "0x2A5A7C4", Offset = "0x2A5A7C4", VA = "0x2A5A7C4")]
	public OverlayDataAsset GetOverlayDataAsset(string name)
	{
		return null;
	}

	[Token(Token = "0x6018356")]
	[Address(RVA = "0x2A5A808", Offset = "0x2A5A808", VA = "0x2A5A808")]
	public OverlayDataAsset GetOverlayDataAsset(int hash)
	{
		return null;
	}

	[Token(Token = "0x6018357")]
	[Address(RVA = "0x2A5A84C", Offset = "0x2A5A84C", VA = "0x2A5A84C", Slot = "7")]
	public override SlotData InstantiateSlot(string name)
	{
		return null;
	}

	[Token(Token = "0x6018358")]
	[Address(RVA = "0x2A5A91C", Offset = "0x2A5A91C", VA = "0x2A5A91C", Slot = "8")]
	public override SlotData InstantiateSlot(int hash)
	{
		return null;
	}

	[Token(Token = "0x6018359")]
	[Address(RVA = "0x2A5A9EC", Offset = "0x2A5A9EC", VA = "0x2A5A9EC", Slot = "9")]
	public override OverlayData InstantiateOverlay(string name)
	{
		return null;
	}

	[Token(Token = "0x601835A")]
	[Address(RVA = "0x2A5AABC", Offset = "0x2A5AABC", VA = "0x2A5AABC", Slot = "10")]
	public override OverlayData InstantiateOverlay(int hash)
	{
		return null;
	}

	[Token(Token = "0x601835B")]
	[Address(RVA = "0x2A5AB8C", Offset = "0x2A5AB8C", VA = "0x2A5AB8C")]
	public bool IsSlotDataAssetCached(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x601835C")]
	[Address(RVA = "0x2A5ABC4", Offset = "0x2A5ABC4", VA = "0x2A5ABC4")]
	public bool IsSlotDataAssetCached(int hash)
	{
		return default(bool);
	}

	[Token(Token = "0x601835D")]
	[Address(RVA = "0x2A5ABFC", Offset = "0x2A5ABFC", VA = "0x2A5ABFC")]
	public bool IsOverlayDataAssetCached(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x601835E")]
	[Address(RVA = "0x2A5AC34", Offset = "0x2A5AC34", VA = "0x2A5AC34")]
	public bool IsOverlayDataAssetCached(int hash)
	{
		return default(bool);
	}

	[Token(Token = "0x601835F")]
	[Address(RVA = "0x2A5AC6C", Offset = "0x2A5AC6C", VA = "0x2A5AC6C")]
	public bool PreloadSlotDataAsset(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6018360")]
	[Address(RVA = "0x2A5ACC0", Offset = "0x2A5ACC0", VA = "0x2A5ACC0")]
	public bool PreloadSlotDataAsset(int hash)
	{
		return default(bool);
	}

	[Token(Token = "0x6018361")]
	[Address(RVA = "0x2A5AD14", Offset = "0x2A5AD14", VA = "0x2A5AD14")]
	public bool PreloadOverlayDataAsset(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6018362")]
	[Address(RVA = "0x2A5AD68", Offset = "0x2A5AD68", VA = "0x2A5AD68")]
	public bool PreloadOverlayDataAsset(int hash)
	{
		return default(bool);
	}

	[Token(Token = "0x6018363")]
	[Address(RVA = "0x2A5ADBC", Offset = "0x2A5ADBC", VA = "0x2A5ADBC")]
	public bool IsSlotContainsOverlay(string slotName, string overlayName)
	{
		return default(bool);
	}

	[Token(Token = "0x6018364")]
	[Address(RVA = "0x2A5AE14", Offset = "0x2A5AE14", VA = "0x2A5AE14")]
	public bool IsSlotContainsOverlay(int slotHash, int overlayHash)
	{
		return default(bool);
	}

	[Token(Token = "0x6018365")]
	[Address(RVA = "0x2A5AE6C", Offset = "0x2A5AE6C", VA = "0x2A5AE6C")]
	public uint LoadSlotOrOverlayDataAsset(string name, bool isSlot, Action<Object, uint> callback)
	{
		return default(uint);
	}

	[Token(Token = "0x6018366")]
	[Address(RVA = "0x2A5AECC", Offset = "0x2A5AECC", VA = "0x2A5AECC")]
	public uint LoadSlotOrOverlayDataAsset(int hash, bool isSlot, Action<Object, uint, int> callback, int param)
	{
		return default(uint);
	}

	[Token(Token = "0x6018367")]
	[Address(RVA = "0x2A5AF34", Offset = "0x2A5AF34", VA = "0x2A5AF34")]
	public void CancelAsyncLoad(ICollection<uint> tickets, bool clear = true)
	{
	}

	[Token(Token = "0x6018368")]
	[Address(RVA = "0x2A5B330", Offset = "0x2A5B330", VA = "0x2A5B330")]
	public void CancelAsyncLoad(uint ticket)
	{
	}

	[Token(Token = "0x6018369")]
	[Address(RVA = "0x2A5B370", Offset = "0x2A5B370", VA = "0x2A5B370")]
	public UMATextRecipe GetTextRecipe(string name)
	{
		return null;
	}

	[Token(Token = "0x601836A")]
	[Address(RVA = "0x2A5B4C0", Offset = "0x2A5B4C0", VA = "0x2A5B4C0")]
	public static UmaRecipeSimple GetSimpleRecipe(string name)
	{
		return default(UmaRecipeSimple);
	}

	[Token(Token = "0x601836B")]
	[Address(RVA = "0x2A5B5C4", Offset = "0x2A5B5C4", VA = "0x2A5B5C4")]
	public static UmaRecipeSimple GetSimpleRecipe(int hash)
	{
		return default(UmaRecipeSimple);
	}
}
