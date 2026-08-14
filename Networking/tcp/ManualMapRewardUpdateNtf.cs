using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D19")]
public class ManualMapRewardUpdateNtf
{
	[Token(Token = "0x400B7A8")]
	[FieldOffset(Offset = "0x8")]
	private ManualMapRewardUpdateInfo _003Cmap_info_003Ek__BackingField;

	[Token(Token = "0x17000BDB")]
	public ManualMapRewardUpdateInfo map_info
	{
		[Token(Token = "0x600871E")]
		[Address(RVA = "0x33EC588", Offset = "0x33EC588", VA = "0x33EC588")]
		get
		{
			return null;
		}
		[Token(Token = "0x600871F")]
		[Address(RVA = "0x33EC590", Offset = "0x33EC590", VA = "0x33EC590")]
		set
		{
		}
	}

	[Token(Token = "0x600871D")]
	[Address(RVA = "0x33EC580", Offset = "0x33EC580", VA = "0x33EC580")]
	public ManualMapRewardUpdateNtf()
	{
	}
}
