using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E57")]
public class AudioResource_Wwise : AudioResource
{
	[Token(Token = "0x401A5CB")]
	[FieldOffset(Offset = "0x20")]
	public AudioEvent OwnedEvent;

	[Token(Token = "0x6019583")]
	[Address(RVA = "0x3079F58", Offset = "0x3079F58", VA = "0x3079F58")]
	public AudioResource_Wwise()
	{
	}

	[Token(Token = "0x6019584")]
	[Address(RVA = "0x3079F60", Offset = "0x3079F60", VA = "0x3079F60", Slot = "8")]
	public override void OnCollected()
	{
	}
}
