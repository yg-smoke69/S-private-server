using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200144C")]
public class LinkageInfo
{
	[Token(Token = "0x4008D2E")]
	[FieldOffset(Offset = "0x8")]
	public uint type;

	[Token(Token = "0x4008D2F")]
	[FieldOffset(Offset = "0xC")]
	public uint link_activity_map_token_id;

	[Token(Token = "0x6007AFA")]
	[Address(RVA = "0x30A6404", Offset = "0x30A6404", VA = "0x30A6404")]
	public LinkageInfo()
	{
	}
}
