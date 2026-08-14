using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D6D")]
public class RoleCheckPlayersNtf
{
	[Token(Token = "0x400B9E9")]
	[FieldOffset(Offset = "0x8")]
	private ulong[] _003Caccount_ids_003Ek__BackingField;

	[Token(Token = "0x17000D29")]
	public ulong[] account_ids
	{
		[Token(Token = "0x60089F7")]
		[Address(RVA = "0x435D690", Offset = "0x435D690", VA = "0x435D690")]
		get
		{
			return null;
		}
		[Token(Token = "0x60089F8")]
		[Address(RVA = "0x435D698", Offset = "0x435D698", VA = "0x435D698")]
		set
		{
		}
	}

	[Token(Token = "0x60089F6")]
	[Address(RVA = "0x435D688", Offset = "0x435D688", VA = "0x435D688")]
	public RoleCheckPlayersNtf()
	{
	}
}
