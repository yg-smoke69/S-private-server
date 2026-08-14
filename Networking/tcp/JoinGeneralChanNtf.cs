using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C7A")]
public class JoinGeneralChanNtf
{
	[Token(Token = "0x400B4E4")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cchannel_id_003Ek__BackingField;

	[Token(Token = "0x400B4E5")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cleft_talk_times_default_003Ek__BackingField;

	[Token(Token = "0x400B4E6")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cleft_talk_times_fast_003Ek__BackingField;

	[Token(Token = "0x400B4E7")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cdaily_msg_limit_default_003Ek__BackingField;

	[Token(Token = "0x400B4E8")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cdaily_msg_limit_fast_003Ek__BackingField;

	[Token(Token = "0x400B4E9")]
	[FieldOffset(Offset = "0x20")]
	private bool _003Cenable_custom_msg_003Ek__BackingField;

	[Token(Token = "0x400B4EA")]
	[FieldOffset(Offset = "0x24")]
	private EChannel.ChannelType _003Cchannel_type_003Ek__BackingField;

	[Token(Token = "0x17000A44")]
	public ulong channel_id
	{
		[Token(Token = "0x6008379")]
		[Address(RVA = "0x33EBF4C", Offset = "0x33EBF4C", VA = "0x33EBF4C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600837A")]
		[Address(RVA = "0x33EBF54", Offset = "0x33EBF54", VA = "0x33EBF54")]
		set
		{
		}
	}

	[Token(Token = "0x17000A45")]
	public uint left_talk_times_default
	{
		[Token(Token = "0x600837B")]
		[Address(RVA = "0x33EBF64", Offset = "0x33EBF64", VA = "0x33EBF64")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600837C")]
		[Address(RVA = "0x33EBF6C", Offset = "0x33EBF6C", VA = "0x33EBF6C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A46")]
	public uint left_talk_times_fast
	{
		[Token(Token = "0x600837D")]
		[Address(RVA = "0x33EBF74", Offset = "0x33EBF74", VA = "0x33EBF74")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600837E")]
		[Address(RVA = "0x33EBF7C", Offset = "0x33EBF7C", VA = "0x33EBF7C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A47")]
	public uint daily_msg_limit_default
	{
		[Token(Token = "0x600837F")]
		[Address(RVA = "0x33EBF84", Offset = "0x33EBF84", VA = "0x33EBF84")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008380")]
		[Address(RVA = "0x33EBF8C", Offset = "0x33EBF8C", VA = "0x33EBF8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A48")]
	public uint daily_msg_limit_fast
	{
		[Token(Token = "0x6008381")]
		[Address(RVA = "0x33EBF94", Offset = "0x33EBF94", VA = "0x33EBF94")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008382")]
		[Address(RVA = "0x33EBF9C", Offset = "0x33EBF9C", VA = "0x33EBF9C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A49")]
	public bool enable_custom_msg
	{
		[Token(Token = "0x6008383")]
		[Address(RVA = "0x33EBFA4", Offset = "0x33EBFA4", VA = "0x33EBFA4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008384")]
		[Address(RVA = "0x33EBFAC", Offset = "0x33EBFAC", VA = "0x33EBFAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000A4A")]
	public EChannel.ChannelType channel_type
	{
		[Token(Token = "0x6008385")]
		[Address(RVA = "0x33EBFB4", Offset = "0x33EBFB4", VA = "0x33EBFB4")]
		get
		{
			return default(EChannel.ChannelType);
		}
		[Token(Token = "0x6008386")]
		[Address(RVA = "0x33EBFBC", Offset = "0x33EBFBC", VA = "0x33EBFBC")]
		set
		{
		}
	}

	[Token(Token = "0x6008378")]
	[Address(RVA = "0x33EBF44", Offset = "0x33EBF44", VA = "0x33EBF44")]
	public JoinGeneralChanNtf()
	{
	}
}
