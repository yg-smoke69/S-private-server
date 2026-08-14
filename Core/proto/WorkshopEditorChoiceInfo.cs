using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014C2")]
public class WorkshopEditorChoiceInfo
{
	[Token(Token = "0x4008FBB")]
	[FieldOffset(Offset = "0x8")]
	public uint order;

	[Token(Token = "0x4008FBC")]
	[FieldOffset(Offset = "0xC")]
	public string picture;

	[Token(Token = "0x4008FBD")]
	[FieldOffset(Offset = "0x10")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x4008FBE")]
	[FieldOffset(Offset = "0x14")]
	public string workshop_code;

	[Token(Token = "0x6007B23")]
	[Address(RVA = "0x33E6320", Offset = "0x33E6320", VA = "0x33E6320")]
	public WorkshopEditorChoiceInfo()
	{
	}
}
