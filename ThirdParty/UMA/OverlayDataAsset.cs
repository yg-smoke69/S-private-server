using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CB1")]
public class OverlayDataAsset : ScriptableObject, _Attribute, IConvertible
{
	[Token(Token = "0x2003CB2")]
	public enum OverlayType
	{
		[Token(Token = "0x4019C83")]
		Normal,
		[Token(Token = "0x4019C84")]
		Cutout,
		[Token(Token = "0x4019C85")]
		Additive
	}

	[Token(Token = "0x4019C7B")]
	[FieldOffset(Offset = "0xC")]
	public string overlayName;

	[NonSerialized]
	[Token(Token = "0x4019C7C")]
	[FieldOffset(Offset = "0x10")]
	public int nameHash;

	[Token(Token = "0x4019C7D")]
	[FieldOffset(Offset = "0x14")]
	public OverlayType overlayType;

	[Token(Token = "0x4019C7E")]
	[FieldOffset(Offset = "0x18")]
	public Rect rect;

	[Token(Token = "0x4019C7F")]
	[FieldOffset(Offset = "0x28")]
	public Texture alphaMask;

	[Token(Token = "0x4019C80")]
	[FieldOffset(Offset = "0x2C")]
	public Texture[] textureList;

	[Token(Token = "0x4019C81")]
	[FieldOffset(Offset = "0x30")]
	public UMAMaterial material;

	[Token(Token = "0x601847A")]
	[Address(RVA = "0x2D524E0", Offset = "0x2D524E0", VA = "0x2D524E0")]
	public OverlayDataAsset()
	{
	}

	[Token(Token = "0x601847B")]
	[Address(RVA = "0x2D524E8", Offset = "0x2D524E8", VA = "0x2D524E8", Slot = "6")]
	public string GetAssetName()
	{
		return null;
	}

	[Token(Token = "0x601847C")]
	[Address(RVA = "0x2D524F0", Offset = "0x2D524F0", VA = "0x2D524F0", Slot = "7")]
	public int GetNameHash()
	{
		return default(int);
	}

	[Token(Token = "0x601847D")]
	[Address(RVA = "0x2D524F8", Offset = "0x2D524F8", VA = "0x2D524F8", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x601847E")]
	[Address(RVA = "0x2D52518", Offset = "0x2D52518", VA = "0x2D52518", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x601847F")]
	[Address(RVA = "0x2D5251C", Offset = "0x2D5251C", VA = "0x2D5251C")]
	public Texture GetAlphaMask()
	{
		return null;
	}
}
