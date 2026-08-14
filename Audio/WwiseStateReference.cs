using Il2CppDummyDll;

[Token(Token = "0x2003DF5")]
public class WwiseStateReference : WwiseGroupValueObjectReference
{
	[Token(Token = "0x401A46E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly WwiseObjectType MyWwiseObjectType;

	[Token(Token = "0x401A46F")]
	[FieldOffset(Offset = "0x4")]
	private static readonly WwiseObjectType MyGroupWwiseObjectType;

	[Token(Token = "0x401A470")]
	[FieldOffset(Offset = "0x14")]
	private WwiseStateGroupReference WwiseStateGroupReference;

	[Token(Token = "0x17001B51")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x6019358")]
		[Address(RVA = "0x3370380", Offset = "0x3370380", VA = "0x3370380", Slot = "5")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x17001B52")]
	public override WwiseObjectReference GroupObjectReference
	{
		[Token(Token = "0x6019359")]
		[Address(RVA = "0x337040C", Offset = "0x337040C", VA = "0x337040C", Slot = "6")]
		get
		{
			return null;
		}
		[Token(Token = "0x601935A")]
		[Address(RVA = "0x3370414", Offset = "0x3370414", VA = "0x3370414", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17001B53")]
	public override WwiseObjectType GroupWwiseObjectType
	{
		[Token(Token = "0x601935B")]
		[Address(RVA = "0x33704B0", Offset = "0x33704B0", VA = "0x33704B0", Slot = "8")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x6019357")]
	[Address(RVA = "0x337037C", Offset = "0x337037C", VA = "0x337037C")]
	public WwiseStateReference()
	{
	}
}
