using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CE5")]
public class UMAMeshAsset : ScriptableObject, _Attribute, IConvertible
{
	[Token(Token = "0x4019DDE")]
	[FieldOffset(Offset = "0xC")]
	public string meshName;

	[NonSerialized]
	[Token(Token = "0x4019DDF")]
	[FieldOffset(Offset = "0x10")]
	public int nameHash;

	[Token(Token = "0x4019DE0")]
	[FieldOffset(Offset = "0x14")]
	public string[] animatedBoneNames;

	[Token(Token = "0x4019DE1")]
	[FieldOffset(Offset = "0x18")]
	public int[] animatedBoneHashes;

	[Token(Token = "0x4019DE2")]
	[FieldOffset(Offset = "0x1C")]
	public UMAMeshData meshData;

	[Token(Token = "0x4019DE3")]
	[FieldOffset(Offset = "0x20")]
	public string slotGroup;

	[Token(Token = "0x60185F8")]
	[Address(RVA = "0x35DFD00", Offset = "0x35DFD00", VA = "0x35DFD00")]
	public UMAMeshAsset()
	{
	}

	[Token(Token = "0x60185F9")]
	[Address(RVA = "0x35DFD90", Offset = "0x35DFD90", VA = "0x35DFD90", Slot = "6")]
	public string GetAssetName()
	{
		return null;
	}

	[Token(Token = "0x60185FA")]
	[Address(RVA = "0x35DFD98", Offset = "0x35DFD98", VA = "0x35DFD98", Slot = "7")]
	public int GetNameHash()
	{
		return default(int);
	}

	[Token(Token = "0x60185FB")]
	[Address(RVA = "0x35DFDA0", Offset = "0x35DFDA0", VA = "0x35DFDA0")]
	public void Release()
	{
	}

	[Token(Token = "0x60185FC")]
	[Address(RVA = "0x35DFDAC", Offset = "0x35DFDAC", VA = "0x35DFDAC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60185FD")]
	[Address(RVA = "0x35DFE44", Offset = "0x35DFE44", VA = "0x35DFE44")]
	public static bool GetMaleInfoByName(string assetName, ref bool isMale)
	{
		return default(bool);
	}

	[Token(Token = "0x60185FE")]
	[Address(RVA = "0x35E0000", Offset = "0x35E0000", VA = "0x35E0000", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60185FF")]
	[Address(RVA = "0x35E0028", Offset = "0x35E0028", VA = "0x35E0028", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6018600")]
	[Address(RVA = "0x35E002C", Offset = "0x35E002C", VA = "0x35E002C")]
	public void Assign(UMAMeshAsset source)
	{
	}
}
