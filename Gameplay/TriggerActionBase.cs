using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200079E")]
public class TriggerActionBase : MonoBehaviour
{
	[Token(Token = "0x4004EDE")]
	[FieldOffset(Offset = "0xC")]
	public GlobalTriggerAction TriggerType;

	[Token(Token = "0x4004EDF")]
	[FieldOffset(Offset = "0x10")]
	public TriggerActionTarget ActionTargetType;

	[Token(Token = "0x4004EE0")]
	[FieldOffset(Offset = "0x14")]
	public float DelayTime;

	[Token(Token = "0x4004EE1")]
	[FieldOffset(Offset = "0x18")]
	public bool StopWhenEnter;

	[Token(Token = "0x4004EE2")]
	[FieldOffset(Offset = "0x19")]
	public bool DeactivateSelf;

	[Token(Token = "0x60030A5")]
	[Address(RVA = "0x263C2F8", Offset = "0x263C2F8", VA = "0x263C2F8")]
	public TriggerActionBase()
	{
	}
}
