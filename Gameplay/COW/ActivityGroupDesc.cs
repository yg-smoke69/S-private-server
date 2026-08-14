using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E8B")]
public class ActivityGroupDesc
{
	[Token(Token = "0x4011C3D")]
	[FieldOffset(Offset = "0x8")]
	public uint group_id;

	[Token(Token = "0x4011C3E")]
	[FieldOffset(Offset = "0xC")]
	public string act_title;

	[Token(Token = "0x4011C3F")]
	[FieldOffset(Offset = "0x10")]
	public string act_text;

	[Token(Token = "0x4011C40")]
	[FieldOffset(Offset = "0x14")]
	public string image_url;

	[Token(Token = "0x4011C41")]
	[FieldOffset(Offset = "0x18")]
	public string image_url_for_lobby;

	[Token(Token = "0x4011C42")]
	[FieldOffset(Offset = "0x1C")]
	public string image_url_for_top_up;

	[Token(Token = "0x4011C43")]
	[FieldOffset(Offset = "0x20")]
	public uint activity_type;

	[Token(Token = "0x4011C44")]
	[FieldOffset(Offset = "0x24")]
	public uint activity_id;

	[Token(Token = "0x4011C45")]
	[FieldOffset(Offset = "0x28")]
	public uint sort_id;

	[Token(Token = "0x4011C46")]
	[FieldOffset(Offset = "0x2C")]
	public uint is_process_show;

	[Token(Token = "0x4011C47")]
	[FieldOffset(Offset = "0x30")]
	public uint act_tag;

	[Token(Token = "0x4011C48")]
	[FieldOffset(Offset = "0x34")]
	public uint go_pos;

	[Token(Token = "0x4011C49")]
	[FieldOffset(Offset = "0x38")]
	public ulong show_time;

	[Token(Token = "0x4011C4A")]
	[FieldOffset(Offset = "0x40")]
	public ulong start_time;

	[Token(Token = "0x4011C4B")]
	[FieldOffset(Offset = "0x48")]
	public ulong end_time;

	[Token(Token = "0x4011C4C")]
	[FieldOffset(Offset = "0x50")]
	public uint cdt_value;

	[Token(Token = "0x4011C4D")]
	[FieldOffset(Offset = "0x54")]
	public string cfg_starttime;

	[Token(Token = "0x4011C4E")]
	[FieldOffset(Offset = "0x58")]
	public string cfg_endtime;

	[Token(Token = "0x4011C4F")]
	[FieldOffset(Offset = "0x5C")]
	public uint table_type;

	[Token(Token = "0x4011C50")]
	[FieldOffset(Offset = "0x60")]
	public EActivity.SubType sub_type;

	[Token(Token = "0x4011C51")]
	[FieldOffset(Offset = "0x64")]
	public ulong[] hint_reset_times;

	[Token(Token = "0x4011C52")]
	[FieldOffset(Offset = "0x68")]
	public List<ClientActivityDesc> activityList;

	[Token(Token = "0x4011C53")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<uint, List<ClientActivityDesc>> _003CThirdTabDict_003Ek__BackingField;

	[Token(Token = "0x4011C54")]
	[FieldOffset(Offset = "0x70")]
	public bool awarded;

	[Token(Token = "0x4011C55")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<ClientActivityDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001427")]
	public Dictionary<uint, List<ClientActivityDesc>> ThirdTabDict
	{
		[Token(Token = "0x60136C3")]
		[Address(RVA = "0x14C15C0", Offset = "0x14C15C0", VA = "0x14C15C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60136C2")]
		[Address(RVA = "0x14C15B8", Offset = "0x14C15B8", VA = "0x14C15B8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001428")]
	public bool IsActivityOpen
	{
		[Token(Token = "0x60136C4")]
		[Address(RVA = "0x14C15C8", Offset = "0x14C15C8", VA = "0x14C15C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60136C1")]
	[Address(RVA = "0x14C0C18", Offset = "0x14C0C18", VA = "0x14C0C18")]
	public ActivityGroupDesc(List<ClientActivityDesc> actList)
	{
	}

	[Token(Token = "0x60136C5")]
	[Address(RVA = "0x14C16BC", Offset = "0x14C16BC", VA = "0x14C16BC")]
	private static int _003CActivityGroupDesc_003Em__0(ClientActivityDesc a, ClientActivityDesc b)
	{
		return default(int);
	}
}
