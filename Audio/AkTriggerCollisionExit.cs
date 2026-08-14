using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E42")]
public class AkTriggerCollisionExit : AkTriggerBase
{
	[Token(Token = "0x401A589")]
	[FieldOffset(Offset = "0x10")]
	public GameObject triggerObject;

	[Token(Token = "0x60194EB")]
	[Address(RVA = "0x2EBD638", Offset = "0x2EBD638", VA = "0x2EBD638")]
	public AkTriggerCollisionExit()
	{
	}

	[Token(Token = "0x60194EC")]
	[Address(RVA = "0x2EBD640", Offset = "0x2EBD640", VA = "0x2EBD640")]
	private void OnCollisionExit(Collision in_other)
	{
	}
}
