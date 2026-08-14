using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;

[Token(Token = "0x2003C97")]
public class SlotLibrary : SlotLibraryBase
{
	[Token(Token = "0x4019C22")]
	[FieldOffset(Offset = "0xC")]
	protected SlotDataAsset[] slotElementList;

	[NonSerialized]
	[Token(Token = "0x4019C23")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, SlotDataAsset> slotDictionary;

	[Token(Token = "0x60183DD")]
	[Address(RVA = "0x21D1850", Offset = "0x21D1850", VA = "0x21D1850")]
	public SlotLibrary()
	{
	}

	[Token(Token = "0x60183DE")]
	[Address(RVA = "0x21D18CC", Offset = "0x21D18CC", VA = "0x21D18CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60183DF")]
	[Address(RVA = "0x21D18DC", Offset = "0x21D18DC", VA = "0x21D18DC", Slot = "13")]
	public override void UpdateDictionary()
	{
	}

	[Token(Token = "0x60183E0")]
	[Address(RVA = "0x21D1B10", Offset = "0x21D1B10", VA = "0x21D1B10", Slot = "14")]
	public override void ValidateDictionary()
	{
	}

	[Token(Token = "0x60183E1")]
	[Address(RVA = "0x21D1BB0", Offset = "0x21D1BB0", VA = "0x21D1BB0", Slot = "4")]
	public override void AddSlotAsset(SlotDataAsset slot)
	{
	}

	[Token(Token = "0x60183E2")]
	[Address(RVA = "0x21D1F40", Offset = "0x21D1F40", VA = "0x21D1F40", Slot = "10")]
	public override bool HasSlot(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60183E3")]
	[Address(RVA = "0x21D1FE4", Offset = "0x21D1FE4", VA = "0x21D1FE4", Slot = "11")]
	public override bool HasSlot(int nameHash)
	{
		return default(bool);
	}

	[Token(Token = "0x60183E4")]
	[Address(RVA = "0x21D2078", Offset = "0x21D2078", VA = "0x21D2078", Slot = "6")]
	public override SlotData InstantiateSlot(string name)
	{
		return null;
	}

	[Token(Token = "0x60183E5")]
	[Address(RVA = "0x21D2268", Offset = "0x21D2268", VA = "0x21D2268", Slot = "7")]
	public override SlotData InstantiateSlot(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x60183E6")]
	[Address(RVA = "0x21D2398", Offset = "0x21D2398", VA = "0x21D2398", Slot = "8")]
	public override SlotData InstantiateSlot(string name, List<OverlayData> overlayList)
	{
		return null;
	}

	[Token(Token = "0x60183E7")]
	[Address(RVA = "0x21D24D4", Offset = "0x21D24D4", VA = "0x21D24D4", Slot = "9")]
	public override SlotData InstantiateSlot(int nameHash, List<OverlayData> overlayList)
	{
		return null;
	}

	[Token(Token = "0x60183E8")]
	[Address(RVA = "0x21D218C", Offset = "0x21D218C", VA = "0x21D218C")]
	private SlotData Internal_InstantiateSlot(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x60183E9")]
	[Address(RVA = "0x21D262C", Offset = "0x21D262C", VA = "0x21D262C", Slot = "5")]
	public override SlotDataAsset[] GetAllSlotAssets()
	{
		return null;
	}

	[Token(Token = "0x60183EA")]
	[Address(RVA = "0x21D2634", Offset = "0x21D2634", VA = "0x21D2634", Slot = "12")]
	public override SlotDataAsset GetSlotDataAsset(string name)
	{
		return null;
	}
}
