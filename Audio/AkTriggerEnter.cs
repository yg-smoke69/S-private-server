using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E45")]
public class AkTriggerEnter : AkTriggerBase
{
	[Token(Token = "0x401A58A")]
	[FieldOffset(Offset = "0x10")]
	public GameObject triggerObject;

	[Token(Token = "0x60194F1")]
	[Address(RVA = "0x2EBD7D4", Offset = "0x2EBD7D4", VA = "0x2EBD7D4")]
	public AkTriggerEnter()
	{
	}

	[Token(Token = "0x60194F2")]
	[Address(RVA = "0x2EBD7DC", Offset = "0x2EBD7DC", VA = "0x2EBD7DC")]
	private void OnTriggerEnter(Collider in_other)
	{
	}
}
