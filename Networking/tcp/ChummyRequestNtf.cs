using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C85")]
public class ChummyRequestNtf
{
	[Token(Token = "0x400B504")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Capplicant_id_003Ek__BackingField;

	[Token(Token = "0x17000A53")]
	public ulong applicant_id
	{
		[Token(Token = "0x600839E")]
		[Address(RVA = "0x33E855C", Offset = "0x33E855C", VA = "0x33E855C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600839F")]
		[Address(RVA = "0x33E8564", Offset = "0x33E8564", VA = "0x33E8564")]
		set
		{
		}
	}

	[Token(Token = "0x600839D")]
	[Address(RVA = "0x33E8554", Offset = "0x33E8554", VA = "0x33E8554")]
	public ChummyRequestNtf()
	{
	}
}
