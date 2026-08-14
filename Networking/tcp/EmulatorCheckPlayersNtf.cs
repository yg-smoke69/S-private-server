using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D6C")]
public class EmulatorCheckPlayersNtf
{
	[Token(Token = "0x400B9E8")]
	[FieldOffset(Offset = "0x8")]
	private ulong[] _003Caccount_ids_003Ek__BackingField;

	[Token(Token = "0x17000D28")]
	public ulong[] account_ids
	{
		[Token(Token = "0x60089F4")]
		[Address(RVA = "0x33E9288", Offset = "0x33E9288", VA = "0x33E9288")]
		get
		{
			return null;
		}
		[Token(Token = "0x60089F5")]
		[Address(RVA = "0x33E9290", Offset = "0x33E9290", VA = "0x33E9290")]
		set
		{
		}
	}

	[Token(Token = "0x60089F3")]
	[Address(RVA = "0x33E9280", Offset = "0x33E9280", VA = "0x33E9280")]
	public EmulatorCheckPlayersNtf()
	{
	}
}
