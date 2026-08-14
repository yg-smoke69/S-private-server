using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2003E0E")]
public class AkMultiPosEvent
{
	[Token(Token = "0x401A4A9")]
	[FieldOffset(Offset = "0x8")]
	public bool eventIsPlaying;

	[Token(Token = "0x401A4AA")]
	[FieldOffset(Offset = "0xC")]
	public List<AkAmbient> list;

	[Token(Token = "0x60193C0")]
	[Address(RVA = "0x36BA00C", Offset = "0x36BA00C", VA = "0x36BA00C")]
	public AkMultiPosEvent()
	{
	}

	[Token(Token = "0x60193C1")]
	[Address(RVA = "0x36BA098", Offset = "0x36BA098", VA = "0x36BA098")]
	public void FinishedPlaying(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}
}
