using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000F0")]
public class TransformData : CSVBaseData
{
	[Token(Token = "0x4000602")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x4000603")]
	[FieldOffset(Offset = "0xC")]
	public uint sortId;

	[Token(Token = "0x4000604")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	[Token(Token = "0x4000605")]
	[FieldOffset(Offset = "0x14")]
	public string Desc;

	[Token(Token = "0x4000606")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID AnimationMaleBeforeID;

	[Token(Token = "0x4000607")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID AnimationMaleAfterID;

	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID AnimationFemaleBeforeID;

	[Token(Token = "0x4000609")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID AnimationFemaleAfterID;

	[Token(Token = "0x400060A")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID TransformVFXLobbyMale;

	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID TransformVFXIngameMale;

	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x30")]
	public ResourceID TransformVFXLobbyFemale;

	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x34")]
	public ResourceID TransformVFXIngameFemale;

	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0x38")]
	public ResourceID TransformModelIdle;

	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x3C")]
	public AvatarTransformData AvatarTransformData;

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x232DD84", Offset = "0x232DD84", VA = "0x232DD84")]
	public TransformData()
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0x232DEB0", Offset = "0x232DEB0", VA = "0x232DEB0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600061C")]
	[Address(RVA = "0x232DF14", Offset = "0x232DF14", VA = "0x232DF14", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
