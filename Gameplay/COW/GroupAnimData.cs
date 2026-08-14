using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000F1")]
public class GroupAnimData : CSVBaseData
{
	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0xC")]
	public uint sortId;

	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID AnimationResIDMale;

	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID AnimationResIDFemale;

	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID CameraAnimationResIDMale;

	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID CameraAnimationResIDFemale;

	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID VFXMaleIngame;

	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID VFXMaleSystem;

	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID VFXFemaleIngame;

	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID VFXFemaleSystem;

	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0x30")]
	public ESourceType sourceTypeKey;

	[Token(Token = "0x400061B")]
	[FieldOffset(Offset = "0x34")]
	public float AnimDuration;

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x120FF5C", Offset = "0x120FF5C", VA = "0x120FF5C")]
	public GroupAnimData()
	{
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x121004C", Offset = "0x121004C", VA = "0x121004C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0x12100B0", Offset = "0x12100B0", VA = "0x12100B0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
