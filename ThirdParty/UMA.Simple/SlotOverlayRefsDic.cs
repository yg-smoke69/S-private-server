using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C7E")]
public class SlotOverlayRefsDic : _Attribute
{
	[Token(Token = "0x4019B43")]
	[FieldOffset(Offset = "0x8")]
	internal readonly Dictionary<SlotDataAsset, short> m_SlotRefCount;

	[Token(Token = "0x4019B44")]
	[FieldOffset(Offset = "0xC")]
	internal readonly Dictionary<OverlayDataAsset, short> m_OverlayRefCount;

	[Token(Token = "0x4019B45")]
	[FieldOffset(Offset = "0x10")]
	protected Dictionary<UMAMeshAsset, short> m_MeshRefCount;

	[Token(Token = "0x4019B46")]
	[FieldOffset(Offset = "0x14")]
	protected Dictionary<Texture, short> m_TextureRefCount;

	[Token(Token = "0x60182B6")]
	[Address(RVA = "0x2D5CF50", Offset = "0x2D5CF50", VA = "0x2D5CF50")]
	public SlotOverlayRefsDic()
	{
	}

	[Token(Token = "0x60182B7")]
	[Address(RVA = "0x2D5F320", Offset = "0x2D5F320", VA = "0x2D5F320")]
	public void InitMeshTexRefCounts(bool mesh, bool tex)
	{
	}

	[Token(Token = "0x60182B8")]
	private void InitRefsDic<T>(ref Dictionary<T, short> dic, bool create)
	{
	}

	[Token(Token = "0x60182B9")]
	[Address(RVA = "0x2D66C90", Offset = "0x2D66C90", VA = "0x2D66C90", Slot = "4")]
	public bool HasRefs()
	{
		return default(bool);
	}

	[Token(Token = "0x60182BA")]
	[Address(RVA = "0x2D66D54", Offset = "0x2D66D54", VA = "0x2D66D54", Slot = "5")]
	public void ClearRefs()
	{
	}

	[Token(Token = "0x60182BB")]
	[Address(RVA = "0x2D66E38", Offset = "0x2D66E38", VA = "0x2D66E38", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60182BC")]
	[Address(RVA = "0x2D65940", Offset = "0x2D65940", VA = "0x2D65940", Slot = "8")]
	public void PrintCacheRefs(StreamWriter sw)
	{
	}

	[Token(Token = "0x60182BD")]
	private static void PrintCacheRefs<T>(StreamWriter sw, string name, Dictionary<T, short> refs)
	{
	}

	[Token(Token = "0x60182BE")]
	[Address(RVA = "0x2D6717C", Offset = "0x2D6717C", VA = "0x2D6717C")]
	public bool TryGetRefCount(bool isSlot, Object asset, out short count)
	{
		return default(bool);
	}

	[Token(Token = "0x60182BF")]
	[Address(RVA = "0x2D672C0", Offset = "0x2D672C0", VA = "0x2D672C0", Slot = "7")]
	public void GetRefedAssets(ICollection<SlotDataAsset> slots, ICollection<OverlayDataAsset> overlays)
	{
	}

	[Token(Token = "0x60182C0")]
	[Address(RVA = "0x2D67348", Offset = "0x2D67348", VA = "0x2D67348")]
	public bool AddRefIfAbsent(bool isSlot, Object asset)
	{
		return default(bool);
	}

	[Token(Token = "0x60182C1")]
	[Address(RVA = "0x2D673A8", Offset = "0x2D673A8", VA = "0x2D673A8", Slot = "6")]
	public short AddRefCount(bool isSlot, Object asset, short deltaCount)
	{
		return default(short);
	}

	[Token(Token = "0x60182C2")]
	[Address(RVA = "0x2D67A60", Offset = "0x2D67A60", VA = "0x2D67A60")]
	private short AddSlotRefCount(SlotDataAsset slot, short deltaCount)
	{
		return default(short);
	}

	[Token(Token = "0x60182C3")]
	[Address(RVA = "0x2D67E80", Offset = "0x2D67E80", VA = "0x2D67E80")]
	private short AddOverlayRefCount(OverlayDataAsset overlay, short deltaCount)
	{
		return default(short);
	}

	[Token(Token = "0x60182C4")]
	[Address(RVA = "0x2D67978", Offset = "0x2D67978", VA = "0x2D67978")]
	private void AddMeshRefCount(SlotDataAsset slot, short deltaCount)
	{
	}

	[Token(Token = "0x60182C5")]
	[Address(RVA = "0x2D67AE4", Offset = "0x2D67AE4", VA = "0x2D67AE4")]
	private void AddTextureRefCount(OverlayDataAsset overlay, short deltaCount)
	{
	}

	[Token(Token = "0x60182C6")]
	private short AddRefCount<T>(Dictionary<T, short> refs, T asset, short deltaCount) where T : Object
	{
		return default(short);
	}

	[Token(Token = "0x60182C7")]
	[Address(RVA = "0x2D5D69C", Offset = "0x2D5D69C", VA = "0x2D5D69C")]
	public bool RemoveRefCount(bool isSlot, Object asset)
	{
		return default(bool);
	}

	[Token(Token = "0x60182C8")]
	[Address(RVA = "0x2D64778", Offset = "0x2D64778", VA = "0x2D64778")]
	public bool RemoveIfNotRefed(UMAMeshAsset asset)
	{
		return default(bool);
	}

	[Token(Token = "0x60182C9")]
	[Address(RVA = "0x2D64B20", Offset = "0x2D64B20", VA = "0x2D64B20")]
	public bool RemoveIfNotRefed(Texture asset)
	{
		return default(bool);
	}

	[Token(Token = "0x60182CA")]
	private bool RemoveIfNotRefed<T>(Dictionary<T, short> refs, T asset)
	{
		return default(bool);
	}

	[Token(Token = "0x60182CB")]
	[Address(RVA = "0x2D67F04", Offset = "0x2D67F04", VA = "0x2D67F04")]
	private void Debug(string s)
	{
	}
}
