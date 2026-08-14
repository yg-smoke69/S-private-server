using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C80")]
public class LikeMsg
{
	[Token(Token = "0x400B4F7")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B4F8")]
	[FieldOffset(Offset = "0x10")]
	private bool _003Cliked_003Ek__BackingField;

	[Token(Token = "0x17000A4F")]
	public ulong account_id
	{
		[Token(Token = "0x6008393")]
		[Address(RVA = "0x33EC324", Offset = "0x33EC324", VA = "0x33EC324")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008394")]
		[Address(RVA = "0x33EC32C", Offset = "0x33EC32C", VA = "0x33EC32C")]
		set
		{
		}
	}

	[Token(Token = "0x17000A50")]
	public bool liked
	{
		[Token(Token = "0x6008395")]
		[Address(RVA = "0x33EC33C", Offset = "0x33EC33C", VA = "0x33EC33C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008396")]
		[Address(RVA = "0x33EC344", Offset = "0x33EC344", VA = "0x33EC344")]
		set
		{
		}
	}

	[Token(Token = "0x6008392")]
	[Address(RVA = "0x33EC31C", Offset = "0x33EC31C", VA = "0x33EC31C")]
	public LikeMsg()
	{
	}
}
