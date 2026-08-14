using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2003DEE")]
public class WwiseEventReference : WwiseObjectReference
{
	[Token(Token = "0x401A456")]
	[FieldOffset(Offset = "0x0")]
	private static readonly WwiseObjectType MyWwiseObjectType;

	[Token(Token = "0x17001B46")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x601933E")]
		[Address(RVA = "0x336D938", Offset = "0x336D938", VA = "0x336D938", Slot = "5")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x601933D")]
	[Address(RVA = "0x336D934", Offset = "0x336D934", VA = "0x336D934")]
	public WwiseEventReference()
	{
	}
}
