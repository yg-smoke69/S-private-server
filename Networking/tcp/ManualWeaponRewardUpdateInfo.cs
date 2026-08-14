using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D18")]
public class ManualWeaponRewardUpdateInfo
{
	[Token(Token = "0x400B7A6")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cquantity_period_003Ek__BackingField;

	[Token(Token = "0x400B7A7")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cstate_003Ek__BackingField;

	[Token(Token = "0x17000BD9")]
	public uint quantity_period
	{
		[Token(Token = "0x6008719")]
		[Address(RVA = "0x33EC5A0", Offset = "0x33EC5A0", VA = "0x33EC5A0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600871A")]
		[Address(RVA = "0x33EC5A8", Offset = "0x33EC5A8", VA = "0x33EC5A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000BDA")]
	public uint state
	{
		[Token(Token = "0x600871B")]
		[Address(RVA = "0x33EC5B0", Offset = "0x33EC5B0", VA = "0x33EC5B0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600871C")]
		[Address(RVA = "0x33EC5B8", Offset = "0x33EC5B8", VA = "0x33EC5B8")]
		set
		{
		}
	}

	[Token(Token = "0x6008718")]
	[Address(RVA = "0x33EC598", Offset = "0x33EC598", VA = "0x33EC598")]
	public ManualWeaponRewardUpdateInfo()
	{
	}
}
