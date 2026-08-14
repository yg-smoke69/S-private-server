using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DA8")]
public class CupMatchInfo
{
	[Token(Token = "0x400BBF2")]
	[FieldOffset(Offset = "0x8")]
	private List<TypedCupMatchInfo> _003Cinfos_003Ek__BackingField;

	[Token(Token = "0x400BBF3")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Climited_level_003Ek__BackingField;

	[Token(Token = "0x400BBF4")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Climited_rank_003Ek__BackingField;

	[Token(Token = "0x400BBF5")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cupper_limited_level_003Ek__BackingField;

	[Token(Token = "0x400BBF6")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cupper_limited_rank_003Ek__BackingField;

	[Token(Token = "0x400BBF7")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cplayer_count_limit_003Ek__BackingField;

	[Token(Token = "0x17000E9E")]
	public List<TypedCupMatchInfo> infos
	{
		[Token(Token = "0x6008D10")]
		[Address(RVA = "0x33E8B74", Offset = "0x33E8B74", VA = "0x33E8B74")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008D11")]
		[Address(RVA = "0x33E8B6C", Offset = "0x33E8B6C", VA = "0x33E8B6C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000E9F")]
	public uint limited_level
	{
		[Token(Token = "0x6008D12")]
		[Address(RVA = "0x33E8B7C", Offset = "0x33E8B7C", VA = "0x33E8B7C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D13")]
		[Address(RVA = "0x33E8B84", Offset = "0x33E8B84", VA = "0x33E8B84")]
		set
		{
		}
	}

	[Token(Token = "0x17000EA0")]
	public uint limited_rank
	{
		[Token(Token = "0x6008D14")]
		[Address(RVA = "0x33E8B8C", Offset = "0x33E8B8C", VA = "0x33E8B8C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D15")]
		[Address(RVA = "0x33E8B94", Offset = "0x33E8B94", VA = "0x33E8B94")]
		set
		{
		}
	}

	[Token(Token = "0x17000EA1")]
	public uint upper_limited_level
	{
		[Token(Token = "0x6008D16")]
		[Address(RVA = "0x33E8B9C", Offset = "0x33E8B9C", VA = "0x33E8B9C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D17")]
		[Address(RVA = "0x33E8BA4", Offset = "0x33E8BA4", VA = "0x33E8BA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000EA2")]
	public uint upper_limited_rank
	{
		[Token(Token = "0x6008D18")]
		[Address(RVA = "0x33E8BAC", Offset = "0x33E8BAC", VA = "0x33E8BAC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D19")]
		[Address(RVA = "0x33E8BB4", Offset = "0x33E8BB4", VA = "0x33E8BB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000EA3")]
	public uint player_count_limit
	{
		[Token(Token = "0x6008D1A")]
		[Address(RVA = "0x33E8BBC", Offset = "0x33E8BBC", VA = "0x33E8BBC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D1B")]
		[Address(RVA = "0x33E8BC4", Offset = "0x33E8BC4", VA = "0x33E8BC4")]
		set
		{
		}
	}

	[Token(Token = "0x6008D0F")]
	[Address(RVA = "0x33E8AE0", Offset = "0x33E8AE0", VA = "0x33E8AE0")]
	public CupMatchInfo()
	{
	}
}
