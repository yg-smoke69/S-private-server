using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A07")]
public class AttendanceConfigDesc
{
	[Token(Token = "0x400A330")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A331")]
	[FieldOffset(Offset = "0xC")]
	public string start_time;

	[Token(Token = "0x400A332")]
	[FieldOffset(Offset = "0x10")]
	public string end_time;

	[Token(Token = "0x400A333")]
	[FieldOffset(Offset = "0x14")]
	public string url;

	[Token(Token = "0x400A334")]
	[FieldOffset(Offset = "0x18")]
	public string loc_key;

	[Token(Token = "0x400A335")]
	[FieldOffset(Offset = "0x1C")]
	public EAttendance.AttendanceType attendance_type;

	[Token(Token = "0x600805F")]
	[Address(RVA = "0x317AD78", Offset = "0x317AD78", VA = "0x317AD78")]
	public AttendanceConfigDesc()
	{
	}
}
