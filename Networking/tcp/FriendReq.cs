using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CBE")]
public class FriendReq
{
	[Token(Token = "0x400B5BF")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cadder_003Ek__BackingField;

	[Token(Token = "0x400B5C0")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Caddee_003Ek__BackingField;

	[Token(Token = "0x400B5C1")]
	[FieldOffset(Offset = "0x18")]
	private string _003Clock_region_003Ek__BackingField;

	[Token(Token = "0x400B5C2")]
	[FieldOffset(Offset = "0x1C")]
	private string _003Cnoti_region_003Ek__BackingField;

	[Token(Token = "0x17000ACD")]
	public ulong adder
	{
		[Token(Token = "0x60084BF")]
		[Address(RVA = "0x33E9470", Offset = "0x33E9470", VA = "0x33E9470")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60084C0")]
		[Address(RVA = "0x33E9478", Offset = "0x33E9478", VA = "0x33E9478")]
		set
		{
		}
	}

	[Token(Token = "0x17000ACE")]
	public ulong addee
	{
		[Token(Token = "0x60084C1")]
		[Address(RVA = "0x33E9488", Offset = "0x33E9488", VA = "0x33E9488")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60084C2")]
		[Address(RVA = "0x33E9490", Offset = "0x33E9490", VA = "0x33E9490")]
		set
		{
		}
	}

	[Token(Token = "0x17000ACF")]
	public string lock_region
	{
		[Token(Token = "0x60084C3")]
		[Address(RVA = "0x33E94A0", Offset = "0x33E94A0", VA = "0x33E94A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084C4")]
		[Address(RVA = "0x33E9460", Offset = "0x33E9460", VA = "0x33E9460")]
		set
		{
		}
	}

	[Token(Token = "0x17000AD0")]
	public string noti_region
	{
		[Token(Token = "0x60084C5")]
		[Address(RVA = "0x33E94A8", Offset = "0x33E94A8", VA = "0x33E94A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084C6")]
		[Address(RVA = "0x33E9468", Offset = "0x33E9468", VA = "0x33E9468")]
		set
		{
		}
	}

	[Token(Token = "0x60084BE")]
	[Address(RVA = "0x33E93B4", Offset = "0x33E93B4", VA = "0x33E93B4")]
	public FriendReq()
	{
	}
}
