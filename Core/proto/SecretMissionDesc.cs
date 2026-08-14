using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019DB")]
public class SecretMissionDesc
{
	[Token(Token = "0x400A22E")]
	[FieldOffset(Offset = "0x8")]
	public uint secret_mission_id;

	[Token(Token = "0x400A22F")]
	[FieldOffset(Offset = "0xC")]
	public uint max_key_exchanged_num;

	[Token(Token = "0x400A230")]
	[FieldOffset(Offset = "0x10")]
	public string additional_message;

	[Token(Token = "0x400A231")]
	[FieldOffset(Offset = "0x14")]
	public string prefix_code;

	[Token(Token = "0x400A232")]
	[FieldOffset(Offset = "0x18")]
	public string mission_title;

	[Token(Token = "0x400A233")]
	[FieldOffset(Offset = "0x20")]
	public long start_time;

	[Token(Token = "0x400A234")]
	[FieldOffset(Offset = "0x28")]
	public long end_time;

	[Token(Token = "0x6008033")]
	[Address(RVA = "0x33E2074", Offset = "0x33E2074", VA = "0x33E2074")]
	public SecretMissionDesc()
	{
	}
}
