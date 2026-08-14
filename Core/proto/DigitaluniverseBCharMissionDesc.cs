using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B61")]
public class DigitaluniverseBCharMissionDesc
{
	[Token(Token = "0x400AC48")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AC49")]
	[FieldOffset(Offset = "0xC")]
	public uint mission_type;

	[Token(Token = "0x400AC4A")]
	[FieldOffset(Offset = "0x10")]
	public uint misson_content;

	[Token(Token = "0x400AC4B")]
	[FieldOffset(Offset = "0x14")]
	public uint character;

	[Token(Token = "0x400AC4C")]
	[FieldOffset(Offset = "0x18")]
	public long time_limit;

	[Token(Token = "0x400AC4D")]
	[FieldOffset(Offset = "0x20")]
	public uint progress_value;

	[Token(Token = "0x400AC4E")]
	[FieldOffset(Offset = "0x24")]
	public string content_key;

	[Token(Token = "0x400AC4F")]
	[FieldOffset(Offset = "0x28")]
	public long start_time;

	[Token(Token = "0x400AC50")]
	[FieldOffset(Offset = "0x30")]
	public long end_time;

	[Token(Token = "0x60081BC")]
	[Address(RVA = "0x309E94C", Offset = "0x309E94C", VA = "0x309E94C")]
	public DigitaluniverseBCharMissionDesc()
	{
	}
}
