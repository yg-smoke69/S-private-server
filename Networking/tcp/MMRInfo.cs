using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D89")]
public class MMRInfo
{
	[Token(Token = "0x400BA8F")]
	[FieldOffset(Offset = "0x8")]
	private EMatch.GameMode _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400BA90")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cmmr_003Ek__BackingField;

	[Token(Token = "0x400BA91")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cbot_point_003Ek__BackingField;

	[Token(Token = "0x17000D3B")]
	public EMatch.GameMode game_mode
	{
		[Token(Token = "0x6008A2B")]
		[Address(RVA = "0x33EC528", Offset = "0x33EC528", VA = "0x33EC528")]
		get
		{
			return default(EMatch.GameMode);
		}
		[Token(Token = "0x6008A2C")]
		[Address(RVA = "0x33EC530", Offset = "0x33EC530", VA = "0x33EC530")]
		set
		{
		}
	}

	[Token(Token = "0x17000D3C")]
	public uint mmr
	{
		[Token(Token = "0x6008A2D")]
		[Address(RVA = "0x33EC538", Offset = "0x33EC538", VA = "0x33EC538")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A2E")]
		[Address(RVA = "0x33EC540", Offset = "0x33EC540", VA = "0x33EC540")]
		set
		{
		}
	}

	[Token(Token = "0x17000D3D")]
	public uint bot_point
	{
		[Token(Token = "0x6008A2F")]
		[Address(RVA = "0x33EC548", Offset = "0x33EC548", VA = "0x33EC548")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A30")]
		[Address(RVA = "0x33EC550", Offset = "0x33EC550", VA = "0x33EC550")]
		set
		{
		}
	}

	[Token(Token = "0x6008A2A")]
	[Address(RVA = "0x33EC520", Offset = "0x33EC520", VA = "0x33EC520")]
	public MMRInfo()
	{
	}
}
