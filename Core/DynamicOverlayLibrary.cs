using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

[Token(Token = "0x2003C59")]
public class DynamicOverlayLibrary : OverlayLibrary
{
	[Token(Token = "0x4019AB1")]
	[FieldOffset(Offset = "0x1A")]
	public bool dynamicallyAddFromResources;

	[Token(Token = "0x4019AB2")]
	[FieldOffset(Offset = "0x1C")]
	public string resourcesFolderPath;

	[Token(Token = "0x4019AB3")]
	[FieldOffset(Offset = "0x20")]
	public bool dynamicallyAddFromAssetBundles;

	[Token(Token = "0x4019AB4")]
	[FieldOffset(Offset = "0x24")]
	public string assetBundleNamesToSearch;

	[Token(Token = "0x4019AB5")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<string, List<string>> assetBundlesUsedDict;

	[NonSerialized]
	[Token(Token = "0x4019AB6")]
	[FieldOffset(Offset = "0x2C")]
	public bool downloadAssetsEnabled;

	[Token(Token = "0x6018176")]
	[Address(RVA = "0x31FF59C", Offset = "0x31FF59C", VA = "0x31FF59C")]
	public DynamicOverlayLibrary()
	{
	}

	[Token(Token = "0x6018177")]
	[Address(RVA = "0x31FF688", Offset = "0x31FF688", VA = "0x31FF688")]
	public void Start()
	{
	}

	[Token(Token = "0x6018178")]
	[Address(RVA = "0x31FF710", Offset = "0x31FF710", VA = "0x31FF710")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6018179")]
	[Address(RVA = "0x31FF714", Offset = "0x31FF714", VA = "0x31FF714")]
	public void ClearEditorAddedAssets()
	{
	}

	[Token(Token = "0x601817A")]
	[Address(RVA = "0x31FF718", Offset = "0x31FF718", VA = "0x31FF718")]
	public void UpdateDynamicOverlayLibrary([Optional] int? nameHash)
	{
	}

	[Token(Token = "0x601817B")]
	[Address(RVA = "0x31FF8C8", Offset = "0x31FF8C8", VA = "0x31FF8C8")]
	public void UpdateDynamicOverlayLibrary(string overlayName)
	{
	}

	[Token(Token = "0x601817C")]
	[Address(RVA = "0x31FFA28", Offset = "0x31FFA28", VA = "0x31FFA28")]
	private void AddOverlayAssets(OverlayDataAsset[] overlays)
	{
	}

	[Token(Token = "0x601817D")]
	[Address(RVA = "0x31FFA98", Offset = "0x31FFA98", VA = "0x31FFA98", Slot = "5")]
	public override OverlayData InstantiateOverlay(string name)
	{
		return null;
	}

	[Token(Token = "0x601817E")]
	[Address(RVA = "0x31FFCF0", Offset = "0x31FFCF0", VA = "0x31FFCF0", Slot = "6")]
	public override OverlayData InstantiateOverlay(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x601817F")]
	[Address(RVA = "0x31FFFE0", Offset = "0x31FFFE0", VA = "0x31FFFE0", Slot = "7")]
	public override OverlayData InstantiateOverlay(string name, Color color)
	{
		return null;
	}

	[Token(Token = "0x6018180")]
	[Address(RVA = "0x3200294", Offset = "0x3200294", VA = "0x3200294", Slot = "8")]
	public override OverlayData InstantiateOverlay(int nameHash, Color color)
	{
		return null;
	}

	[Token(Token = "0x6018181")]
	[Address(RVA = "0x32005D8", Offset = "0x32005D8", VA = "0x32005D8")]
	public string GetOriginatingAssetBundle(string overlayName)
	{
		return null;
	}
}
