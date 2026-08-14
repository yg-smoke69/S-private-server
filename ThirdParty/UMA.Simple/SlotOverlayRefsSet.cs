using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C7D")]
public class SlotOverlayRefsSet : _Attribute
{
	[Token(Token = "0x4019B41")]
	[FieldOffset(Offset = "0x8")]
	internal readonly HashSet<SlotDataAsset> m_SlotRefs;

	[Token(Token = "0x4019B42")]
	[FieldOffset(Offset = "0xC")]
	internal readonly HashSet<OverlayDataAsset> m_OverlayRefs;

	[Token(Token = "0x60182AA")]
	[Address(RVA = "0x2D5B15C", Offset = "0x2D5B15C", VA = "0x2D5B15C")]
	public SlotOverlayRefsSet()
	{
	}

	[Token(Token = "0x60182AB")]
	[Address(RVA = "0x2D68430", Offset = "0x2D68430", VA = "0x2D68430", Slot = "4")]
	public bool HasRefs()
	{
		return default(bool);
	}

	[Token(Token = "0x60182AC")]
	[Address(RVA = "0x2D684F4", Offset = "0x2D684F4", VA = "0x2D684F4", Slot = "5")]
	public void ClearRefs()
	{
	}

	[Token(Token = "0x60182AD")]
	[Address(RVA = "0x2D68598", Offset = "0x2D68598", VA = "0x2D68598", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60182AE")]
	[Address(RVA = "0x2D66988", Offset = "0x2D66988", VA = "0x2D66988", Slot = "8")]
	public void PrintCacheRefs(StreamWriter sw)
	{
	}

	[Token(Token = "0x60182AF")]
	private static void PrintCacheRefs<T>(StreamWriter sw, string name, HashSet<T> refs)
	{
	}

	[Token(Token = "0x60182B0")]
	[Address(RVA = "0x2D66A30", Offset = "0x2D66A30", VA = "0x2D66A30")]
	public void AddRefs(Dictionary<SlotDataAsset, short> slotRefs, Dictionary<OverlayDataAsset, short> overlayRefs)
	{
	}

	[Token(Token = "0x60182B1")]
	private static void AddRefs<T>(Dictionary<T, short> dst, HashSet<T> src)
	{
	}

	[Token(Token = "0x60182B2")]
	[Address(RVA = "0x2D5CDC8", Offset = "0x2D5CDC8", VA = "0x2D5CDC8")]
	public bool AddRefCount(SlotDataAsset asset)
	{
		return default(bool);
	}

	[Token(Token = "0x60182B3")]
	[Address(RVA = "0x2D5CE48", Offset = "0x2D5CE48", VA = "0x2D5CE48")]
	public bool AddRefCount(OverlayDataAsset asset)
	{
		return default(bool);
	}

	[Token(Token = "0x60182B4")]
	[Address(RVA = "0x2D686D8", Offset = "0x2D686D8", VA = "0x2D686D8", Slot = "6")]
	public short AddRefCount(bool isSlot, Object asset, short deltaCount)
	{
		return default(short);
	}

	[Token(Token = "0x60182B5")]
	[Address(RVA = "0x2D68760", Offset = "0x2D68760", VA = "0x2D68760", Slot = "7")]
	public void GetRefedAssets(ICollection<SlotDataAsset> slots, ICollection<OverlayDataAsset> overlays)
	{
	}
}
