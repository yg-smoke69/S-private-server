using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D0A")]
public class DigitaluniverseBTimeAttackStart
{
	[Token(Token = "0x400B78B")]
	[FieldOffset(Offset = "0x8")]
	private long _003Ctime_attack_expire_at_003Ek__BackingField;

	[Token(Token = "0x400B78C")]
	[FieldOffset(Offset = "0x10")]
	private bool _003Cshow_hint_003Ek__BackingField;

	[Token(Token = "0x17000BCF")]
	public long time_attack_expire_at
	{
		[Token(Token = "0x60086FD")]
		[Address(RVA = "0x33E8CD4", Offset = "0x33E8CD4", VA = "0x33E8CD4")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60086FE")]
		[Address(RVA = "0x33E8CDC", Offset = "0x33E8CDC", VA = "0x33E8CDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000BD0")]
	public bool show_hint
	{
		[Token(Token = "0x60086FF")]
		[Address(RVA = "0x33E8CEC", Offset = "0x33E8CEC", VA = "0x33E8CEC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008700")]
		[Address(RVA = "0x33E8CF4", Offset = "0x33E8CF4", VA = "0x33E8CF4")]
		set
		{
		}
	}

	[Token(Token = "0x60086FC")]
	[Address(RVA = "0x33E8CCC", Offset = "0x33E8CCC", VA = "0x33E8CCC")]
	public DigitaluniverseBTimeAttackStart()
	{
	}
}
