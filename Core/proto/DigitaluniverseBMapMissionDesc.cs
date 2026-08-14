using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B65")]
public class DigitaluniverseBMapMissionDesc
{
	[Token(Token = "0x400AC5F")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AC60")]
	[FieldOffset(Offset = "0xC")]
	public uint group_id;

	[Token(Token = "0x400AC61")]
	[FieldOffset(Offset = "0x10")]
	public uint activity_id;

	[Token(Token = "0x400AC62")]
	[FieldOffset(Offset = "0x18")]
	public long start_time;

	[Token(Token = "0x400AC63")]
	[FieldOffset(Offset = "0x20")]
	public long end_time;

	[Token(Token = "0x400AC64")]
	[FieldOffset(Offset = "0x28")]
	public uint progress_value;

	[Token(Token = "0x60081C0")]
	[Address(RVA = "0x309EAC8", Offset = "0x309EAC8", VA = "0x309EAC8")]
	public DigitaluniverseBMapMissionDesc()
	{
	}
}
