using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A15")]
public class VeteranAwardDesc
{
	[Token(Token = "0x400A391")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A392")]
	[FieldOffset(Offset = "0xC")]
	public EAttendance.VeteranAwardType type;

	[Token(Token = "0x400A393")]
	[FieldOffset(Offset = "0x10")]
	public uint term_id;

	[Token(Token = "0x400A394")]
	[FieldOffset(Offset = "0x14")]
	public uint sort_id;

	[Token(Token = "0x400A395")]
	[FieldOffset(Offset = "0x18")]
	public string slot_icon;

	[Token(Token = "0x400A396")]
	[FieldOffset(Offset = "0x1C")]
	public uint activeness_cdt;

	[Token(Token = "0x400A397")]
	[FieldOffset(Offset = "0x20")]
	public AwardDesc award;

	[Token(Token = "0x600806D")]
	[Address(RVA = "0x33E435C", Offset = "0x33E435C", VA = "0x33E435C")]
	public VeteranAwardDesc()
	{
	}
}
