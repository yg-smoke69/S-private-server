using System;
using Il2CppDummyDll;
using message;

[Serializable]
[Token(Token = "0x200088F")]
public class PetAnimation
{
	[Token(Token = "0x4005349")]
	[FieldOffset(Offset = "0x8")]
	public string animationName;

	[Token(Token = "0x400534A")]
	[FieldOffset(Offset = "0xC")]
	public ODFIIFHKNNG animationType;

	[Token(Token = "0x6003C0E")]
	[Address(RVA = "0x1C79D28", Offset = "0x1C79D28", VA = "0x1C79D28")]
	public PetAnimation()
	{
	}
}
