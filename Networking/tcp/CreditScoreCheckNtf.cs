using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D6F")]
public class CreditScoreCheckNtf
{
	[Token(Token = "0x400B9EB")]
	[FieldOffset(Offset = "0x8")]
	private ulong[] _003Caccount_ids_003Ek__BackingField;

	[Token(Token = "0x17000D2B")]
	public ulong[] account_ids
	{
		[Token(Token = "0x60089FD")]
		[Address(RVA = "0x33E89F0", Offset = "0x33E89F0", VA = "0x33E89F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60089FE")]
		[Address(RVA = "0x33E89F8", Offset = "0x33E89F8", VA = "0x33E89F8")]
		set
		{
		}
	}

	[Token(Token = "0x60089FC")]
	[Address(RVA = "0x33E89E8", Offset = "0x33E89E8", VA = "0x33E89E8")]
	public CreditScoreCheckNtf()
	{
	}
}
