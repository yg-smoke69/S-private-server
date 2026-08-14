using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E46")]
public class AkTriggerExit : AkTriggerBase
{
	[Token(Token = "0x401A58B")]
	[FieldOffset(Offset = "0x10")]
	public GameObject triggerObject;

	[Token(Token = "0x60194F3")]
	[Address(RVA = "0x2EBD930", Offset = "0x2EBD930", VA = "0x2EBD930")]
	public AkTriggerExit()
	{
	}

	[Token(Token = "0x60194F4")]
	[Address(RVA = "0x2EBD938", Offset = "0x2EBD938", VA = "0x2EBD938")]
	private void OnTriggerExit(Collider in_other)
	{
	}
}
