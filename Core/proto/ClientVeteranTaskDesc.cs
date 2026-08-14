using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017CF")]
public class ClientVeteranTaskDesc
{
	[Token(Token = "0x4009B72")]
	[FieldOffset(Offset = "0x8")]
	public uint task_id;

	[Token(Token = "0x4009B73")]
	[FieldOffset(Offset = "0xC")]
	public string act_text;

	[Token(Token = "0x4009B74")]
	[FieldOffset(Offset = "0x10")]
	public uint task_class;

	[Token(Token = "0x4009B75")]
	[FieldOffset(Offset = "0x14")]
	public uint cdt_value;

	[Token(Token = "0x4009B76")]
	[FieldOffset(Offset = "0x18")]
	public List<AwardDesc> awards;

	[Token(Token = "0x4009B77")]
	[FieldOffset(Offset = "0x1C")]
	public uint pre_cdt_value3;

	[Token(Token = "0x4009B78")]
	[FieldOffset(Offset = "0x20")]
	public EActivity.CircleType circle_type;

	[Token(Token = "0x4009B79")]
	[FieldOffset(Offset = "0x24")]
	public uint activeness;

	[Token(Token = "0x4009B7A")]
	[FieldOffset(Offset = "0x28")]
	public EAttendance.VeteranTaskType task_type;

	[Token(Token = "0x6007E29")]
	[Address(RVA = "0x309C96C", Offset = "0x309C96C", VA = "0x309C96C")]
	public ClientVeteranTaskDesc()
	{
	}
}
