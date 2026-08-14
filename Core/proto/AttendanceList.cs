using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015E8")]
public class AttendanceList
{
	[Token(Token = "0x400948C")]
	[FieldOffset(Offset = "0x8")]
	public List<AttendanceItem> attendance;

	[Token(Token = "0x400948D")]
	[FieldOffset(Offset = "0x10")]
	public long end_time;

	[Token(Token = "0x400948E")]
	[FieldOffset(Offset = "0x18")]
	public string url;

	[Token(Token = "0x400948F")]
	[FieldOffset(Offset = "0x1C")]
	public string loc_key;

	[Token(Token = "0x4009490")]
	[FieldOffset(Offset = "0x20")]
	public bool is_signed_today;

	[Token(Token = "0x4009491")]
	[FieldOffset(Offset = "0x24")]
	public EAttendance.AttendanceType attendance_type;

	[Token(Token = "0x4009492")]
	[FieldOffset(Offset = "0x28")]
	public long start_time;

	[Token(Token = "0x4009493")]
	[FieldOffset(Offset = "0x30")]
	public uint attendance_config_id;

	[Token(Token = "0x6007C32")]
	[Address(RVA = "0x317AF54", Offset = "0x317AF54", VA = "0x317AF54")]
	public AttendanceList()
	{
	}
}
