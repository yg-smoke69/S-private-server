using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

[Token(Token = "0x2003C94")]
public class OverlayLibrary : OverlayLibraryBase
{
	[Token(Token = "0x4019C17")]
	[FieldOffset(Offset = "0xC")]
	protected OverlayDataAsset[] overlayElementList;

	[NonSerialized]
	[Token(Token = "0x4019C18")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, OverlayDataAsset> overlayDictionary;

	[Token(Token = "0x4019C19")]
	[FieldOffset(Offset = "0x14")]
	public int scaleAdjust;

	[Token(Token = "0x4019C1A")]
	[FieldOffset(Offset = "0x18")]
	public bool readWrite;

	[Token(Token = "0x4019C1B")]
	[FieldOffset(Offset = "0x19")]
	public bool compress;

	[Token(Token = "0x60183C7")]
	[Address(RVA = "0x1C75F30", Offset = "0x1C75F30", VA = "0x1C75F30")]
	public OverlayLibrary()
	{
	}

	[Token(Token = "0x60183C8")]
	[Address(RVA = "0x1C75FB4", Offset = "0x1C75FB4", VA = "0x1C75FB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60183C9")]
	[Address(RVA = "0x1C75FC4", Offset = "0x1C75FC4", VA = "0x1C75FC4", Slot = "10")]
	public override void UpdateDictionary()
	{
	}

	[Token(Token = "0x60183CA")]
	[Address(RVA = "0x1C76204", Offset = "0x1C76204", VA = "0x1C76204", Slot = "4")]
	public override void AddOverlayAsset(OverlayDataAsset overlay)
	{
	}

	[Token(Token = "0x60183CB")]
	[Address(RVA = "0x1C76590", Offset = "0x1C76590", VA = "0x1C76590", Slot = "11")]
	public override void ValidateDictionary()
	{
	}

	[Token(Token = "0x60183CC")]
	[Address(RVA = "0x1C76630", Offset = "0x1C76630", VA = "0x1C76630", Slot = "5")]
	public override OverlayData InstantiateOverlay(string name)
	{
		return null;
	}

	[Token(Token = "0x60183CD")]
	[Address(RVA = "0x1C76820", Offset = "0x1C76820", VA = "0x1C76820", Slot = "6")]
	public override OverlayData InstantiateOverlay(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x60183CE")]
	[Address(RVA = "0x1C76950", Offset = "0x1C76950", VA = "0x1C76950", Slot = "7")]
	public override OverlayData InstantiateOverlay(string name, Color color)
	{
		return null;
	}

	[Token(Token = "0x60183CF")]
	[Address(RVA = "0x1C76AC4", Offset = "0x1C76AC4", VA = "0x1C76AC4", Slot = "8")]
	public override OverlayData InstantiateOverlay(int nameHash, Color color)
	{
		return null;
	}

	[Token(Token = "0x60183D0")]
	[Address(RVA = "0x1C76744", Offset = "0x1C76744", VA = "0x1C76744")]
	private OverlayData Internal_InstantiateOverlay(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x60183D1")]
	[Address(RVA = "0x1C76C4C", Offset = "0x1C76C4C", VA = "0x1C76C4C", Slot = "9")]
	public override OverlayDataAsset[] GetAllOverlayAssets()
	{
		return null;
	}
}
