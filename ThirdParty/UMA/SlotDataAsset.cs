using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CBB")]
public class SlotDataAsset : ScriptableObject, _Attribute, IConvertible
{
	[Token(Token = "0x4019CA2")]
	[FieldOffset(Offset = "0xC")]
	public string slotName;

	[NonSerialized]
	[Token(Token = "0x4019CA3")]
	[FieldOffset(Offset = "0x10")]
	public int nameHash;

	[Token(Token = "0x4019CA4")]
	[FieldOffset(Offset = "0x14")]
	public UMAMaterial material;

	[Token(Token = "0x4019CA5")]
	[FieldOffset(Offset = "0x18")]
	public float overlayScale;

	[Token(Token = "0x4019CA6")]
	[FieldOffset(Offset = "0x1C")]
	public string[] animatedBoneNames;

	[Token(Token = "0x4019CA7")]
	[FieldOffset(Offset = "0x20")]
	public int[] animatedBoneHashes;

	[Token(Token = "0x4019CA8")]
	[FieldOffset(Offset = "0x24")]
	public UMAMeshAsset meshAsset;

	[Token(Token = "0x4019CA9")]
	[FieldOffset(Offset = "0x28")]
	public int subMeshIndex;

	[Token(Token = "0x4019CAA")]
	[FieldOffset(Offset = "0x2C")]
	public string slotGroup;

	[Token(Token = "0x4019CAB")]
	[FieldOffset(Offset = "0x30")]
	public string[] dynamicBoneRoots;

	[Token(Token = "0x4019CAC")]
	[FieldOffset(Offset = "0x34")]
	public UMADynamicBoneProperties[] dynamicBones;

	[Token(Token = "0x4019CAD")]
	[FieldOffset(Offset = "0x38")]
	public UMADynamicBoneColliderProperties[] dynamicBoneColliders;

	[Token(Token = "0x4019CAE")]
	[FieldOffset(Offset = "0x3C")]
	public List<HangStringProperty> fluxAssets;

	[Token(Token = "0x4019CAF")]
	[FieldOffset(Offset = "0x40")]
	public OverlayDataAsset overlayAsset;

	[Token(Token = "0x60184C7")]
	[Address(RVA = "0x2DF04D8", Offset = "0x2DF04D8", VA = "0x2DF04D8")]
	public SlotDataAsset()
	{
	}

	[Token(Token = "0x60184C8")]
	[Address(RVA = "0x2DF0570", Offset = "0x2DF0570", VA = "0x2DF0570", Slot = "6")]
	public string GetAssetName()
	{
		return null;
	}

	[Token(Token = "0x60184C9")]
	[Address(RVA = "0x2DE5CC4", Offset = "0x2DE5CC4", VA = "0x2DE5CC4", Slot = "7")]
	public int GetNameHash()
	{
		return default(int);
	}

	[Token(Token = "0x60184CA")]
	[Address(RVA = "0x2DF0578", Offset = "0x2DF0578", VA = "0x2DF0578", Slot = "8")]
	public virtual AdditiveInfo GetAdditiveInfo()
	{
		return null;
	}

	[Token(Token = "0x60184CB")]
	[Address(RVA = "0x2DF0580", Offset = "0x2DF0580", VA = "0x2DF0580")]
	public bool ValidateDynamicBones()
	{
		return default(bool);
	}

	[Token(Token = "0x60184CC")]
	[Address(RVA = "0x2DF015C", Offset = "0x2DF015C", VA = "0x2DF015C")]
	public UMAMeshData GetMeshData()
	{
		return null;
	}

	[Token(Token = "0x60184CD")]
	[Address(RVA = "0x2DEED30", Offset = "0x2DEED30", VA = "0x2DEED30")]
	public int GetTextureChannelCount(UMAGeneratorBase generator)
	{
		return default(int);
	}

	[Token(Token = "0x60184CE")]
	[Address(RVA = "0x2DF0690", Offset = "0x2DF0690", VA = "0x2DF0690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60184CF")]
	[Address(RVA = "0x2DF0728", Offset = "0x2DF0728", VA = "0x2DF0728")]
	public void UpdateMeshAsset(UMAMeshAsset mas)
	{
	}

	[Token(Token = "0x60184D0")]
	[Address(RVA = "0x2DF0730", Offset = "0x2DF0730", VA = "0x2DF0730", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60184D1")]
	[Address(RVA = "0x2DF0750", Offset = "0x2DF0750", VA = "0x2DF0750", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60184D2")]
	[Address(RVA = "0x2DF0754", Offset = "0x2DF0754", VA = "0x2DF0754")]
	public void Assign(SlotDataAsset source, bool assignDynamicBones = false, bool keepMaterial = false)
	{
	}
}
