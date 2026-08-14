using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C49")]
public class AccountLevelUpInfo
{
	[Token(Token = "0x400B430")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B431")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Clevel_before_003Ek__BackingField;

	[Token(Token = "0x400B432")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Clevel_after_003Ek__BackingField;

	[Token(Token = "0x400B433")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cnew_exp_003Ek__BackingField;

	[Token(Token = "0x400B434")]
	[FieldOffset(Offset = "0x1C")]
	private AwardDataTCP _003Cawards_003Ek__BackingField;

	[Token(Token = "0x170009EA")]
	public ulong account_id
	{
		[Token(Token = "0x60082A5")]
		[Address(RVA = "0x33E6FF4", Offset = "0x33E6FF4", VA = "0x33E6FF4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60082A6")]
		[Address(RVA = "0x33E6FFC", Offset = "0x33E6FFC", VA = "0x33E6FFC")]
		set
		{
		}
	}

	[Token(Token = "0x170009EB")]
	public uint level_before
	{
		[Token(Token = "0x60082A7")]
		[Address(RVA = "0x33E700C", Offset = "0x33E700C", VA = "0x33E700C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082A8")]
		[Address(RVA = "0x33E7014", Offset = "0x33E7014", VA = "0x33E7014")]
		set
		{
		}
	}

	[Token(Token = "0x170009EC")]
	public uint level_after
	{
		[Token(Token = "0x60082A9")]
		[Address(RVA = "0x33E701C", Offset = "0x33E701C", VA = "0x33E701C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082AA")]
		[Address(RVA = "0x33E7024", Offset = "0x33E7024", VA = "0x33E7024")]
		set
		{
		}
	}

	[Token(Token = "0x170009ED")]
	public uint new_exp
	{
		[Token(Token = "0x60082AB")]
		[Address(RVA = "0x33E702C", Offset = "0x33E702C", VA = "0x33E702C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60082AC")]
		[Address(RVA = "0x33E7034", Offset = "0x33E7034", VA = "0x33E7034")]
		set
		{
		}
	}

	[Token(Token = "0x170009EE")]
	public AwardDataTCP awards
	{
		[Token(Token = "0x60082AD")]
		[Address(RVA = "0x33E703C", Offset = "0x33E703C", VA = "0x33E703C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082AE")]
		[Address(RVA = "0x33E7044", Offset = "0x33E7044", VA = "0x33E7044")]
		set
		{
		}
	}

	[Token(Token = "0x60082A4")]
	[Address(RVA = "0x33E6FEC", Offset = "0x33E6FEC", VA = "0x33E6FEC")]
	public AccountLevelUpInfo()
	{
	}
}
