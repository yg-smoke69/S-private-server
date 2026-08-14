using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D1A")]
public class ManualMapRewardUpdateInfo
{
	[Token(Token = "0x400B7A9")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cmap_id_003Ek__BackingField;

	[Token(Token = "0x400B7AA")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cstate_003Ek__BackingField;

	[Token(Token = "0x17000BDC")]
	public uint map_id
	{
		[Token(Token = "0x6008721")]
		[Address(RVA = "0x33EC560", Offset = "0x33EC560", VA = "0x33EC560")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008722")]
		[Address(RVA = "0x33EC568", Offset = "0x33EC568", VA = "0x33EC568")]
		set
		{
		}
	}

	[Token(Token = "0x17000BDD")]
	public uint state
	{
		[Token(Token = "0x6008723")]
		[Address(RVA = "0x33EC570", Offset = "0x33EC570", VA = "0x33EC570")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008724")]
		[Address(RVA = "0x33EC578", Offset = "0x33EC578", VA = "0x33EC578")]
		set
		{
		}
	}

	[Token(Token = "0x6008720")]
	[Address(RVA = "0x33EC558", Offset = "0x33EC558", VA = "0x33EC558")]
	public ManualMapRewardUpdateInfo()
	{
	}
}
