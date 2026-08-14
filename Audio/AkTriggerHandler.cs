using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E47")]
public abstract class AkTriggerHandler : MonoBehaviour
{
	[Token(Token = "0x401A58C")]
	public const int AWAKE_TRIGGER_ID = 1151176110;

	[Token(Token = "0x401A58D")]
	public const int START_TRIGGER_ID = 1281810935;

	[Token(Token = "0x401A58E")]
	public const int DESTROY_TRIGGER_ID = -358577003;

	[Token(Token = "0x401A58F")]
	public const int MAX_NB_TRIGGERS = 32;

	[Token(Token = "0x401A590")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<uint, string> triggerTypes;

	[Token(Token = "0x401A591")]
	[FieldOffset(Offset = "0xC")]
	private bool didDestroy;

	[Token(Token = "0x401A592")]
	[FieldOffset(Offset = "0x10")]
	public List<int> triggerList;

	[Token(Token = "0x401A593")]
	[FieldOffset(Offset = "0x14")]
	public bool useOtherObject;

	[Token(Token = "0x60194F5")]
	[Address(RVA = "0x2EBDA8C", Offset = "0x2EBDA8C", VA = "0x2EBDA8C")]
	protected AkTriggerHandler()
	{
	}

	[Token(Token = "0x60194F6")]
	public abstract void HandleEvent(GameObject in_gameObject);

	[Token(Token = "0x60194F7")]
	[Address(RVA = "0x2EBDB48", Offset = "0x2EBDB48", VA = "0x2EBDB48", Slot = "5")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60194F8")]
	[Address(RVA = "0x2EBE340", Offset = "0x2EBE340", VA = "0x2EBE340", Slot = "6")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60194F9")]
	[Address(RVA = "0x2EBE3E0", Offset = "0x2EBE3E0", VA = "0x2EBE3E0", Slot = "7")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x60194FA")]
	[Address(RVA = "0x2EBE3F0", Offset = "0x2EBE3F0", VA = "0x2EBE3F0")]
	public void DoDestroy()
	{
	}

	[Token(Token = "0x60194FB")]
	[Address(RVA = "0x2EBDC3C", Offset = "0x2EBDC3C", VA = "0x2EBDC3C")]
	protected void RegisterTriggers(List<int> in_triggerList, AkTriggerBase.Trigger in_delegate)
	{
	}

	[Token(Token = "0x60194FC")]
	[Address(RVA = "0x2EBE4EC", Offset = "0x2EBE4EC", VA = "0x2EBE4EC")]
	protected void UnregisterTriggers(List<int> in_triggerList, AkTriggerBase.Trigger in_delegate)
	{
	}
}
