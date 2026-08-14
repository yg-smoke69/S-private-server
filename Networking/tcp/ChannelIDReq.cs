using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C76")]
public class ChannelIDReq
{
	[Token(Token = "0x400B4CA")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cchannel_id_003Ek__BackingField;

	[Token(Token = "0x400B4CB")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cchannel_type_003Ek__BackingField;

	[Token(Token = "0x400B4CC")]
	[FieldOffset(Offset = "0x14")]
	private string _003Cchannel_lang_003Ek__BackingField;

	[Token(Token = "0x400B4CD")]
	[FieldOffset(Offset = "0x18")]
	private string _003Cchannel_secret_003Ek__BackingField;

	[Token(Token = "0x17000A2A")]
	public ulong channel_id
	{
		[Token(Token = "0x6008341")]
		[Address(RVA = "0x33E8454", Offset = "0x33E8454", VA = "0x33E8454")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008342")]
		[Address(RVA = "0x33E845C", Offset = "0x33E845C", VA = "0x33E845C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A2B")]
	public uint channel_type
	{
		[Token(Token = "0x6008343")]
		[Address(RVA = "0x33E846C", Offset = "0x33E846C", VA = "0x33E846C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008344")]
		[Address(RVA = "0x33E8474", Offset = "0x33E8474", VA = "0x33E8474")]
		set
		{
		}
	}

	[Token(Token = "0x17000A2C")]
	public string channel_lang
	{
		[Token(Token = "0x6008345")]
		[Address(RVA = "0x33E847C", Offset = "0x33E847C", VA = "0x33E847C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008346")]
		[Address(RVA = "0x33E8444", Offset = "0x33E8444", VA = "0x33E8444")]
		set
		{
		}
	}

	[Token(Token = "0x17000A2D")]
	public string channel_secret
	{
		[Token(Token = "0x6008347")]
		[Address(RVA = "0x33E8484", Offset = "0x33E8484", VA = "0x33E8484")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008348")]
		[Address(RVA = "0x33E844C", Offset = "0x33E844C", VA = "0x33E844C")]
		set
		{
		}
	}

	[Token(Token = "0x6008340")]
	[Address(RVA = "0x33E8398", Offset = "0x33E8398", VA = "0x33E8398")]
	public ChannelIDReq()
	{
	}
}
