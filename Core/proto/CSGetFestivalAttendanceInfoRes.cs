using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015FC")]
public class CSGetFestivalAttendanceInfoRes
{
	[Token(Token = "0x40094B3")]
	[FieldOffset(Offset = "0x8")]
	public List<FestivalAttendanceItem> attendance;

	[Token(Token = "0x40094B4")]
	[FieldOffset(Offset = "0xC")]
	public bool is_signed_today;

	[Token(Token = "0x40094B5")]
	[FieldOffset(Offset = "0x10")]
	public string act_text1;

	[Token(Token = "0x40094B6")]
	[FieldOffset(Offset = "0x14")]
	public string act_text2;

	[Token(Token = "0x40094B7")]
	[FieldOffset(Offset = "0x18")]
	public string act_text3;

	[Token(Token = "0x40094B8")]
	[FieldOffset(Offset = "0x20")]
	public long start_time;

	[Token(Token = "0x40094B9")]
	[FieldOffset(Offset = "0x28")]
	public long end_time;

	[Token(Token = "0x40094BA")]
	[FieldOffset(Offset = "0x30")]
	public bool is_in_attendance_time;

	[Token(Token = "0x40094BB")]
	[FieldOffset(Offset = "0x34")]
	public uint festival_item_id1;

	[Token(Token = "0x40094BC")]
	[FieldOffset(Offset = "0x38")]
	public uint festival_item_id2;

	[Token(Token = "0x6007C46")]
	[Address(RVA = "0x3184BE0", Offset = "0x3184BE0", VA = "0x3184BE0")]
	public CSGetFestivalAttendanceInfoRes()
	{
	}
}
