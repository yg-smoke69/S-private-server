using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20000E5")]
public class SkyboardData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4000583")]
	[FieldOffset(Offset = "0xC")]
	public string description;

	[Token(Token = "0x4000584")]
	[FieldOffset(Offset = "0x10")]
	public uint iID;

	[Token(Token = "0x4000585")]
	[FieldOffset(Offset = "0x14")]
	public uint sortId;

	[Token(Token = "0x4000586")]
	[FieldOffset(Offset = "0x18")]
	public float skyDivingMinVSpeed;

	[Token(Token = "0x4000587")]
	[FieldOffset(Offset = "0x1C")]
	public float skyDivingMaxVSpeed;

	[Token(Token = "0x4000588")]
	[FieldOffset(Offset = "0x20")]
	public float skyDivingMinHSpeed;

	[Token(Token = "0x4000589")]
	[FieldOffset(Offset = "0x24")]
	public float skyDivingMaxHSpeed;

	[Token(Token = "0x400058A")]
	[FieldOffset(Offset = "0x28")]
	public float skyDivingSpeedDelta;

	[Token(Token = "0x400058B")]
	[FieldOffset(Offset = "0x2C")]
	public float skySurfingMinVSpeed;

	[Token(Token = "0x400058C")]
	[FieldOffset(Offset = "0x30")]
	public float skySurfingMaxVSpeed;

	[Token(Token = "0x400058D")]
	[FieldOffset(Offset = "0x34")]
	public float skySurfingMinHSpeed;

	[Token(Token = "0x400058E")]
	[FieldOffset(Offset = "0x38")]
	public float skySurfingMaxHSpeed;

	[Token(Token = "0x400058F")]
	[FieldOffset(Offset = "0x3C")]
	public float skySurfingSpeedDelta;

	[Token(Token = "0x4000590")]
	[FieldOffset(Offset = "0x40")]
	public float swimSurfingSpeed;

	[Token(Token = "0x4000591")]
	[FieldOffset(Offset = "0x44")]
	public ResourceID previewRes;

	[Token(Token = "0x4000592")]
	[FieldOffset(Offset = "0x48")]
	public ResourceID inGameRes;

	[Token(Token = "0x4000593")]
	[FieldOffset(Offset = "0x4C")]
	public bool MAXShow;

	[Token(Token = "0x4000594")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 HDLobbyInGamePosition;

	[Token(Token = "0x4000595")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 HDLobbyInGameScale;

	[Token(Token = "0x4000596")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 HDLobbyInGameAngle;

	[Token(Token = "0x4000597")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 HDLobbyPreviewPosition;

	[Token(Token = "0x4000598")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 HDLobbyPreviewScale;

	[Token(Token = "0x4000599")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 HDLobbyPreviewAngle;

	[Token(Token = "0x400059A")]
	[FieldOffset(Offset = "0x98")]
	public ESourceType sourceTypeKey;

	[Token(Token = "0x400059B")]
	[FieldOffset(Offset = "0x99")]
	public bool IsWithEffect;

	[Token(Token = "0x400059C")]
	[FieldOffset(Offset = "0x9A")]
	public bool showHoverboardComponent;

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x20F103C", Offset = "0x20F103C", VA = "0x20F103C")]
	public SkyboardData()
	{
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x20F11F4", Offset = "0x20F11F4", VA = "0x20F11F4", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x20F124C", Offset = "0x20F124C", VA = "0x20F124C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x20F12B0", Offset = "0x20F12B0", VA = "0x20F12B0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
