using Il2CppDummyDll;

[Token(Token = "0x2003DF7")]
public class WwiseSwitchReference : WwiseGroupValueObjectReference
{
	[Token(Token = "0x401A472")]
	[FieldOffset(Offset = "0x0")]
	private static readonly WwiseObjectType MyWwiseObjectType;

	[Token(Token = "0x401A473")]
	[FieldOffset(Offset = "0x4")]
	private static readonly WwiseObjectType MyGroupWwiseObjectType;

	[Token(Token = "0x401A474")]
	[FieldOffset(Offset = "0x14")]
	private WwiseSwitchGroupReference WwiseSwitchGroupReference;

	[Token(Token = "0x17001B55")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x6019361")]
		[Address(RVA = "0x33706B0", Offset = "0x33706B0", VA = "0x33706B0", Slot = "5")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x17001B56")]
	public override WwiseObjectReference GroupObjectReference
	{
		[Token(Token = "0x6019362")]
		[Address(RVA = "0x337073C", Offset = "0x337073C", VA = "0x337073C", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019363")]
		[Address(RVA = "0x3370744", Offset = "0x3370744", VA = "0x3370744", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17001B57")]
	public override WwiseObjectType GroupWwiseObjectType
	{
		[Token(Token = "0x6019364")]
		[Address(RVA = "0x33707E0", Offset = "0x33707E0", VA = "0x33707E0", Slot = "8")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x6019360")]
	[Address(RVA = "0x33706AC", Offset = "0x33706AC", VA = "0x33706AC")]
	public WwiseSwitchReference()
	{
	}
}
