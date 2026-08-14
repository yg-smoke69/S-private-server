using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA;

[Token(Token = "0x2003C5B")]
public class DynamicSlotLibrary : SlotLibrary
{
	[Token(Token = "0x4019ABE")]
	[FieldOffset(Offset = "0x14")]
	public bool dynamicallyAddFromResources;

	[Token(Token = "0x4019ABF")]
	[FieldOffset(Offset = "0x18")]
	public string resourcesFolderPath;

	[Token(Token = "0x4019AC0")]
	[FieldOffset(Offset = "0x1C")]
	public bool dynamicallyAddFromAssetBundles;

	[Token(Token = "0x4019AC1")]
	[FieldOffset(Offset = "0x20")]
	public string assetBundleNamesToSearch;

	[Token(Token = "0x4019AC2")]
	[FieldOffset(Offset = "0x24")]
	public Dictionary<string, List<string>> assetBundlesUsedDict;

	[NonSerialized]
	[Token(Token = "0x4019AC3")]
	[FieldOffset(Offset = "0x28")]
	public bool downloadAssetsEnabled;

	[Token(Token = "0x6018192")]
	[Address(RVA = "0x3201B74", Offset = "0x3201B74", VA = "0x3201B74")]
	public DynamicSlotLibrary()
	{
	}

	[Token(Token = "0x6018193")]
	[Address(RVA = "0x3201C60", Offset = "0x3201C60", VA = "0x3201C60")]
	public void Start()
	{
	}

	[Token(Token = "0x6018194")]
	[Address(RVA = "0x3201CE8", Offset = "0x3201CE8", VA = "0x3201CE8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6018195")]
	[Address(RVA = "0x3201CEC", Offset = "0x3201CEC", VA = "0x3201CEC")]
	public void ClearEditorAddedAssets()
	{
	}

	[Token(Token = "0x6018196")]
	[Address(RVA = "0x3201CF0", Offset = "0x3201CF0", VA = "0x3201CF0")]
	public void UpdateDynamicSlotLibrary([Optional] int? nameHash)
	{
	}

	[Token(Token = "0x6018197")]
	[Address(RVA = "0x3201EA0", Offset = "0x3201EA0", VA = "0x3201EA0")]
	public void UpdateDynamicSlotLibrary(string slotName)
	{
	}

	[Token(Token = "0x6018198")]
	[Address(RVA = "0x3202000", Offset = "0x3202000", VA = "0x3202000", Slot = "12")]
	public override SlotDataAsset GetSlotDataAsset(string name)
	{
		return null;
	}

	[Token(Token = "0x6018199")]
	[Address(RVA = "0x3202110", Offset = "0x3202110", VA = "0x3202110")]
	private void AddSlotAssets(SlotDataAsset[] slots)
	{
	}

	[Token(Token = "0x601819A")]
	[Address(RVA = "0x3202180", Offset = "0x3202180", VA = "0x3202180", Slot = "6")]
	public override SlotData InstantiateSlot(string name)
	{
		return null;
	}

	[Token(Token = "0x601819B")]
	[Address(RVA = "0x32023E8", Offset = "0x32023E8", VA = "0x32023E8", Slot = "7")]
	public override SlotData InstantiateSlot(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x601819C")]
	[Address(RVA = "0x3202694", Offset = "0x3202694", VA = "0x3202694", Slot = "8")]
	public override SlotData InstantiateSlot(string name, List<OverlayData> overlayList)
	{
		return null;
	}

	[Token(Token = "0x601819D")]
	[Address(RVA = "0x3202910", Offset = "0x3202910", VA = "0x3202910", Slot = "9")]
	public override SlotData InstantiateSlot(int nameHash, List<OverlayData> overlayList)
	{
		return null;
	}

	[Token(Token = "0x601819E")]
	[Address(RVA = "0x3202BE0", Offset = "0x3202BE0", VA = "0x3202BE0")]
	public string GetOriginatingAssetBundle(string slotName)
	{
		return null;
	}
}
