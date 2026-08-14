using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A0E")]
public class VeteranTaskDesc
{
	[Token(Token = "0x400A359")]
	[FieldOffset(Offset = "0x8")]
	public uint task_id;

	[Token(Token = "0x400A35A")]
	[FieldOffset(Offset = "0xC")]
	public EAttendance.VeteranTaskClass task_class;

	[Token(Token = "0x400A35B")]
	[FieldOffset(Offset = "0x10")]
	public EActivity.PreConditionType pre_cdt_type1;

	[Token(Token = "0x400A35C")]
	[FieldOffset(Offset = "0x14")]
	public uint pre_cdt_value1;

	[Token(Token = "0x400A35D")]
	[FieldOffset(Offset = "0x18")]
	public EActivity.PreConditionType pre_cdt_type2;

	[Token(Token = "0x400A35E")]
	[FieldOffset(Offset = "0x1C")]
	public uint pre_cdt_value2;

	[Token(Token = "0x400A35F")]
	[FieldOffset(Offset = "0x20")]
	public EActivity.PreConditionType pre_cdt_type3;

	[Token(Token = "0x400A360")]
	[FieldOffset(Offset = "0x24")]
	public uint pre_cdt_value3;

	[Token(Token = "0x400A361")]
	[FieldOffset(Offset = "0x28")]
	public EActivity.PreConditionType pre_cdt_type4;

	[Token(Token = "0x400A362")]
	[FieldOffset(Offset = "0x2C")]
	public uint pre_cdt_value4;

	[Token(Token = "0x400A363")]
	[FieldOffset(Offset = "0x30")]
	public EActivity.PreConditionType pre_cdt_type5;

	[Token(Token = "0x400A364")]
	[FieldOffset(Offset = "0x34")]
	public uint pre_cdt_value5;

	[Token(Token = "0x400A365")]
	[FieldOffset(Offset = "0x38")]
	public EActivity.ConditionType cdt_type;

	[Token(Token = "0x400A366")]
	[FieldOffset(Offset = "0x3C")]
	public uint cdt_value;

	[Token(Token = "0x400A367")]
	[FieldOffset(Offset = "0x40")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400A368")]
	[FieldOffset(Offset = "0x44")]
	public List<Item> exchange_items;

	[Token(Token = "0x400A369")]
	[FieldOffset(Offset = "0x48")]
	public string task_text;

	[Token(Token = "0x400A36A")]
	[FieldOffset(Offset = "0x4C")]
	public bool task_switch;

	[Token(Token = "0x400A36B")]
	[FieldOffset(Offset = "0x50")]
	public uint pre_cdt_switch;

	[Token(Token = "0x400A36C")]
	[FieldOffset(Offset = "0x54")]
	public EActivity.CircleType circle_type;

	[Token(Token = "0x400A36D")]
	[FieldOffset(Offset = "0x58")]
	public uint activeness;

	[Token(Token = "0x400A36E")]
	[FieldOffset(Offset = "0x5C")]
	public EAttendance.VeteranTaskType task_type;

	[Token(Token = "0x6008066")]
	[Address(RVA = "0x33E4784", Offset = "0x33E4784", VA = "0x33E4784")]
	public VeteranTaskDesc()
	{
	}
}
