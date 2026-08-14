using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015E9")]
public class CSGetAttendanceListRes
{
	[Token(Token = "0x4009494")]
	[FieldOffset(Offset = "0x8")]
	public List<AttendanceList> attendance_list;

	[Token(Token = "0x6007C33")]
	[Address(RVA = "0x3181B34", Offset = "0x3181B34", VA = "0x3181B34")]
	public CSGetAttendanceListRes()
	{
	}
}
