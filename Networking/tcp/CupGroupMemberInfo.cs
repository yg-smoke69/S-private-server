using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CAE")]
public class CupGroupMemberInfo
{
	[Token(Token = "0x400B58D")]
	[FieldOffset(Offset = "0x8")]
	private string _003Cnickname_003Ek__BackingField;

	[Token(Token = "0x400B58E")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Ccs_rank_003Ek__BackingField;

	[Token(Token = "0x400B58F")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Ccs_ranking_points_003Ek__BackingField;

	[Token(Token = "0x400B590")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Ccs_peak_ranking_pos_003Ek__BackingField;

	[Token(Token = "0x17000AB5")]
	public string nickname
	{
		[Token(Token = "0x6008485")]
		[Address(RVA = "0x33E8AA8", Offset = "0x33E8AA8", VA = "0x33E8AA8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008486")]
		[Address(RVA = "0x33E8AA0", Offset = "0x33E8AA0", VA = "0x33E8AA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000AB6")]
	public uint cs_rank
	{
		[Token(Token = "0x6008487")]
		[Address(RVA = "0x33E8AB0", Offset = "0x33E8AB0", VA = "0x33E8AB0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008488")]
		[Address(RVA = "0x33E8AB8", Offset = "0x33E8AB8", VA = "0x33E8AB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AB7")]
	public uint cs_ranking_points
	{
		[Token(Token = "0x6008489")]
		[Address(RVA = "0x33E8AC0", Offset = "0x33E8AC0", VA = "0x33E8AC0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600848A")]
		[Address(RVA = "0x33E8AC8", Offset = "0x33E8AC8", VA = "0x33E8AC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AB8")]
	public uint cs_peak_ranking_pos
	{
		[Token(Token = "0x600848B")]
		[Address(RVA = "0x33E8AD0", Offset = "0x33E8AD0", VA = "0x33E8AD0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600848C")]
		[Address(RVA = "0x33E8AD8", Offset = "0x33E8AD8", VA = "0x33E8AD8")]
		set
		{
		}
	}

	[Token(Token = "0x6008484")]
	[Address(RVA = "0x33E8A00", Offset = "0x33E8A00", VA = "0x33E8A00")]
	public CupGroupMemberInfo()
	{
	}
}
