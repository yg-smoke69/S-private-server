using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CBA")]
public class SlotData : _Attribute, IConvertible
{
	[Token(Token = "0x4019C9C")]
	[FieldOffset(Offset = "0x8")]
	public SlotDataAsset asset;

	[Token(Token = "0x4019C9D")]
	[FieldOffset(Offset = "0xC")]
	public float overlayScale;

	[Token(Token = "0x4019C9E")]
	[FieldOffset(Offset = "0x10")]
	public int overlayLimitSize;

	[Token(Token = "0x4019C9F")]
	[FieldOffset(Offset = "0x14")]
	public bool dontSerialize;

	[Token(Token = "0x4019CA0")]
	[FieldOffset(Offset = "0x18")]
	private List<OverlayData> overlayList;

	[NonSerialized]
	[Token(Token = "0x4019CA1")]
	[FieldOffset(Offset = "0x1C")]
	public UMAMaterial overrideMaterial;

	[Token(Token = "0x170019B0")]
	public string slotName
	{
		[Token(Token = "0x60184AF")]
		[Address(RVA = "0x2DE5B30", Offset = "0x2DE5B30", VA = "0x2DE5B30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019B1")]
	public int OverlayCount
	{
		[Token(Token = "0x60184B9")]
		[Address(RVA = "0x2DEF864", Offset = "0x2DEF864", VA = "0x2DEF864")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60184AE")]
	[Address(RVA = "0x2DEEA60", Offset = "0x2DEEA60", VA = "0x2DEEA60")]
	public SlotData(SlotDataAsset asset)
	{
	}

	[Token(Token = "0x60184B0")]
	[Address(RVA = "0x2DEEB14", Offset = "0x2DEEB14", VA = "0x2DEEB14")]
	public SlotData Copy()
	{
		return null;
	}

	[Token(Token = "0x60184B1")]
	[Address(RVA = "0x2DEED08", Offset = "0x2DEED08", VA = "0x2DEED08")]
	public int GetTextureChannelCount(UMAGeneratorBase generator)
	{
		return default(int);
	}

	[Token(Token = "0x60184B2")]
	[Address(RVA = "0x2DEED68", Offset = "0x2DEED68", VA = "0x2DEED68")]
	public bool RemoveOverlay(string[] names)
	{
		return default(bool);
	}

	[Token(Token = "0x60184B3")]
	[Address(RVA = "0x2DEEF48", Offset = "0x2DEEF48", VA = "0x2DEEF48")]
	public bool SetOverlayColor(Color32 color, string[] names)
	{
		return default(bool);
	}

	[Token(Token = "0x60184B4")]
	[Address(RVA = "0x2DEF210", Offset = "0x2DEF210", VA = "0x2DEF210")]
	public OverlayData GetOverlay(string[] names)
	{
		return null;
	}

	[Token(Token = "0x60184B5")]
	[Address(RVA = "0x2DEF4E0", Offset = "0x2DEF4E0", VA = "0x2DEF4E0")]
	public void SetOverlay(int index, OverlayData overlay)
	{
	}

	[Token(Token = "0x60184B6")]
	[Address(RVA = "0x2DEF634", Offset = "0x2DEF634", VA = "0x2DEF634")]
	public OverlayData GetOverlay(int index)
	{
		return null;
	}

	[Token(Token = "0x60184B7")]
	[Address(RVA = "0x2DEF6FC", Offset = "0x2DEF6FC", VA = "0x2DEF6FC")]
	public OverlayData GetEquivalentOverlay(OverlayData overlay)
	{
		return null;
	}

	[Token(Token = "0x60184B8")]
	[Address(RVA = "0x2DE5B5C", Offset = "0x2DE5B5C", VA = "0x2DE5B5C")]
	public OverlayData GetEquivalentUsedOverlay(OverlayData overlay)
	{
		return null;
	}

	[Token(Token = "0x60184BA")]
	[Address(RVA = "0x2DEF8DC", Offset = "0x2DEF8DC", VA = "0x2DEF8DC")]
	public void SetOverlayList(List<OverlayData> overlayList)
	{
	}

	[Token(Token = "0x60184BB")]
	[Address(RVA = "0x2DE5A9C", Offset = "0x2DE5A9C", VA = "0x2DE5A9C")]
	public void AddOverlay(OverlayData overlayData)
	{
	}

	[Token(Token = "0x60184BC")]
	[Address(RVA = "0x2DE5B54", Offset = "0x2DE5B54", VA = "0x2DE5B54")]
	public List<OverlayData> GetOverlayList()
	{
		return null;
	}

	[Token(Token = "0x60184BD")]
	[Address(RVA = "0x2DEF8E4", Offset = "0x2DEF8E4", VA = "0x2DEF8E4")]
	internal bool Validate()
	{
		return default(bool);
	}

	[Token(Token = "0x60184BE")]
	[Address(RVA = "0x2DF0210", Offset = "0x2DF0210", VA = "0x2DF0210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60184BF")]
	[Address(RVA = "0x2DF02BC", Offset = "0x2DF02BC", VA = "0x2DF02BC")]
	public static implicit operator bool(SlotData obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60184C0")]
	[Address(RVA = "0x2DF0358", Offset = "0x2DF0358", VA = "0x2DF0358", Slot = "4")]
	public bool Equals(SlotData other)
	{
		return default(bool);
	}

	[Token(Token = "0x60184C1")]
	[Address(RVA = "0x2DF035C", Offset = "0x2DF035C", VA = "0x2DF035C", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60184C2")]
	[Address(RVA = "0x2DE4B70", Offset = "0x2DE4B70", VA = "0x2DE4B70")]
	public static bool operator ==(SlotData slot, SlotData obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60184C3")]
	[Address(RVA = "0x2DF03FC", Offset = "0x2DF03FC", VA = "0x2DF03FC")]
	public static bool operator !=(SlotData slot, SlotData obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60184C4")]
	[Address(RVA = "0x2DF0440", Offset = "0x2DF0440", VA = "0x2DF0440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60184C5")]
	[Address(RVA = "0x2DF0448", Offset = "0x2DF0448", VA = "0x2DF0448", Slot = "6")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60184C6")]
	[Address(RVA = "0x2DF04D4", Offset = "0x2DF04D4", VA = "0x2DF04D4", Slot = "5")]
	public void OnBeforeSerialize()
	{
	}
}
