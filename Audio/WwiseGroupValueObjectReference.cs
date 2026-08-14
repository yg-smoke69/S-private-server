using Il2CppDummyDll;

[Token(Token = "0x2003DF1")]
public abstract class WwiseGroupValueObjectReference : WwiseObjectReference
{
	[Token(Token = "0x17001B4C")]
	public abstract WwiseObjectReference GroupObjectReference
	{
		[Token(Token = "0x601934D")]
		get;
		[Token(Token = "0x601934E")]
		set;
	}

	[Token(Token = "0x17001B4D")]
	public abstract WwiseObjectType GroupWwiseObjectType
	{
		[Token(Token = "0x601934F")]
		get;
	}

	[Token(Token = "0x17001B4E")]
	public override string DisplayName
	{
		[Token(Token = "0x6019350")]
		[Address(RVA = "0x336FD7C", Offset = "0x336FD7C", VA = "0x336FD7C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601934C")]
	[Address(RVA = "0x336FD78", Offset = "0x336FD78", VA = "0x336FD78")]
	protected WwiseGroupValueObjectReference()
	{
	}
}
