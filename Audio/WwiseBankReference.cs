using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2003DED")]
public class WwiseBankReference : WwiseObjectReference
{
	[Token(Token = "0x401A455")]
	[FieldOffset(Offset = "0x0")]
	private static readonly WwiseObjectType MyWwiseObjectType;

	[Token(Token = "0x17001B45")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x601933B")]
		[Address(RVA = "0x336D840", Offset = "0x336D840", VA = "0x336D840", Slot = "5")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x601933A")]
	[Address(RVA = "0x336D83C", Offset = "0x336D83C", VA = "0x336D83C")]
	public WwiseBankReference()
	{
	}
}
