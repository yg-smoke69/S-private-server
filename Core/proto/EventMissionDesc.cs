using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019D8")]
public class EventMissionDesc
{
	[Token(Token = "0x400A21E")]
	[FieldOffset(Offset = "0x8")]
	public string mission_name;

	[Token(Token = "0x400A21F")]
	[FieldOffset(Offset = "0xC")]
	public EActivity.EventMissionType mission_type;

	[Token(Token = "0x400A220")]
	[FieldOffset(Offset = "0x10")]
	public uint mission_id;

	[Token(Token = "0x6008030")]
	[Address(RVA = "0x309FA70", Offset = "0x309FA70", VA = "0x309FA70")]
	public EventMissionDesc()
	{
	}
}
