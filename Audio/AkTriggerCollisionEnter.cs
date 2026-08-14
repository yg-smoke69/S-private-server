using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E41")]
public class AkTriggerCollisionEnter : AkTriggerBase
{
	[Token(Token = "0x401A588")]
	[FieldOffset(Offset = "0x10")]
	public GameObject triggerObject;

	[Token(Token = "0x60194E8")]
	[Address(RVA = "0x2EBD388", Offset = "0x2EBD388", VA = "0x2EBD388")]
	public AkTriggerCollisionEnter()
	{
	}

	[Token(Token = "0x60194E9")]
	[Address(RVA = "0x2EBD390", Offset = "0x2EBD390", VA = "0x2EBD390")]
	private void OnCollisionEnter(Collision in_other)
	{
	}

	[Token(Token = "0x60194EA")]
	[Address(RVA = "0x2EBD4E4", Offset = "0x2EBD4E4", VA = "0x2EBD4E4")]
	private void OnTriggerEnter(Collider in_other)
	{
	}
}
