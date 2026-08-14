using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E3F")]
public abstract class AkTriggerBase : MonoBehaviour
{
	[Token(Token = "0x2003E40")]
	public delegate void Trigger(GameObject in_gameObject);

	[Token(Token = "0x401A587")]
	[FieldOffset(Offset = "0xC")]
	public Trigger triggerDelegate;

	[Token(Token = "0x60194E2")]
	[Address(RVA = "0x2EBC978", Offset = "0x2EBC978", VA = "0x2EBC978")]
	protected AkTriggerBase()
	{
	}

	[Token(Token = "0x60194E3")]
	[Address(RVA = "0x2EBC980", Offset = "0x2EBC980", VA = "0x2EBC980")]
	public static Dictionary<uint, string> GetAllDerivedTypes()
	{
		return null;
	}
}
