using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C78")]
public class JoinWorldChanNtf
{
	[Token(Token = "0x400B4D8")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cchannel_id_003Ek__BackingField;

	[Token(Token = "0x400B4D9")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cleft_talk_times_default_003Ek__BackingField;

	[Token(Token = "0x400B4DA")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cleft_talk_times_fast_003Ek__BackingField;

	[Token(Token = "0x400B4DB")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cdaily_msg_limit_default_003Ek__BackingField;

	[Token(Token = "0x400B4DC")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cdaily_msg_limit_fast_003Ek__BackingField;

	[Token(Token = "0x400B4DD")]
	[FieldOffset(Offset = "0x20")]
	private bool _003Cenable_custom_msg_003Ek__BackingField;

	[Token(Token = "0x17000A38")]
	public ulong channel_id
	{
		[Token(Token = "0x600835F")]
		[Address(RVA = "0x33EC0D4", Offset = "0x33EC0D4", VA = "0x33EC0D4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008360")]
		[Address(RVA = "0x33EC0DC", Offset = "0x33EC0DC", VA = "0x33EC0DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000A39")]
	public uint left_talk_times_default
	{
		[Token(Token = "0x6008361")]
		[Address(RVA = "0x33EC0EC", Offset = "0x33EC0EC", VA = "0x33EC0EC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008362")]
		[Address(RVA = "0x33EC0F4", Offset = "0x33EC0F4", VA = "0x33EC0F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000A3A")]
	public uint left_talk_times_fast
	{
		[Token(Token = "0x6008363")]
		[Address(RVA = "0x33EC0FC", Offset = "0x33EC0FC", VA = "0x33EC0FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008364")]
		[Address(RVA = "0x33EC104", Offset = "0x33EC104", VA = "0x33EC104")]
		set
		{
		}
	}

	[Token(Token = "0x17000A3B")]
	public uint daily_msg_limit_default
	{
		[Token(Token = "0x6008365")]
		[Address(RVA = "0x33EC10C", Offset = "0x33EC10C", VA = "0x33EC10C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008366")]
		[Address(RVA = "0x33EC114", Offset = "0x33EC114", VA = "0x33EC114")]
		set
		{
		}
	}

	[Token(Token = "0x17000A3C")]
	public uint daily_msg_limit_fast
	{
		[Token(Token = "0x6008367")]
		[Address(RVA = "0x33EC11C", Offset = "0x33EC11C", VA = "0x33EC11C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008368")]
		[Address(RVA = "0x33EC124", Offset = "0x33EC124", VA = "0x33EC124")]
		set
		{
		}
	}

	[Token(Token = "0x17000A3D")]
	public bool enable_custom_msg
	{
		[Token(Token = "0x6008369")]
		[Address(RVA = "0x33EC12C", Offset = "0x33EC12C", VA = "0x33EC12C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600836A")]
		[Address(RVA = "0x33EC134", Offset = "0x33EC134", VA = "0x33EC134")]
		set
		{
		}
	}

	[Token(Token = "0x600835E")]
	[Address(RVA = "0x33EC0CC", Offset = "0x33EC0CC", VA = "0x33EC0CC")]
	public JoinWorldChanNtf()
	{
	}
}
