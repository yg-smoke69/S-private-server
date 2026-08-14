using System;
using Il2CppDummyDll;

namespace AK.Wwise;

[Serializable]
[Token(Token = "0x2003DF9")]
public class AcousticTexture : BaseType
{
	[Token(Token = "0x401A476")]
	[FieldOffset(Offset = "0x10")]
	public WwiseAcousticTextureReference WwiseObjectReference;

	[Token(Token = "0x17001B59")]
	public override WwiseObjectReference ObjectReference
	{
		[Token(Token = "0x601936A")]
		[Address(RVA = "0x35BBD9C", Offset = "0x35BBD9C", VA = "0x35BBD9C", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601936B")]
		[Address(RVA = "0x35BBDA4", Offset = "0x35BBDA4", VA = "0x35BBDA4", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17001B5A")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x601936C")]
		[Address(RVA = "0x35BBE40", Offset = "0x35BBE40", VA = "0x35BBE40", Slot = "6")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x6019369")]
	[Address(RVA = "0x35BBD8C", Offset = "0x35BBD8C", VA = "0x35BBD8C")]
	public AcousticTexture()
	{
	}
}
