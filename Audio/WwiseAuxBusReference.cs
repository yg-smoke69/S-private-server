using Il2CppDummyDll;

[Token(Token = "0x2003DEC")]
public class WwiseAuxBusReference : WwiseObjectReference
{
	[Token(Token = "0x401A454")]
	[FieldOffset(Offset = "0x0")]
	private static readonly WwiseObjectType MyWwiseObjectType;

	[Token(Token = "0x17001B44")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x6019338")]
		[Address(RVA = "0x336D748", Offset = "0x336D748", VA = "0x336D748", Slot = "5")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x6019337")]
	[Address(RVA = "0x336D744", Offset = "0x336D744", VA = "0x336D744")]
	public WwiseAuxBusReference()
	{
	}
}
