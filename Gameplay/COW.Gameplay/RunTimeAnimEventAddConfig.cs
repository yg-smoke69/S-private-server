using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay;

[Token(Token = "0x20003ED")]
public class RunTimeAnimEventAddConfig : MonoBehaviour
{
	[Token(Token = "0x40039BA")]
	[FieldOffset(Offset = "0xC")]
	public bool m_IsPlayFootSoundByEvent;

	[Token(Token = "0x40039BB")]
	[FieldOffset(Offset = "0x10")]
	public List<ClipEvents> m_ListClipEvents;

	[Token(Token = "0x40039BC")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, bool> m_AddedClipNameMap;

	[Token(Token = "0x6001269")]
	[Address(RVA = "0x24ACC84", Offset = "0x24ACC84", VA = "0x24ACC84")]
	public RunTimeAnimEventAddConfig()
	{
	}

	[Token(Token = "0x600126A")]
	[Address(RVA = "0x24ACD10", Offset = "0x24ACD10", VA = "0x24ACD10")]
	public Dictionary<uint, bool> InitConfigEvents(Dictionary<uint, bool> addedConfigs, uint configUID)
	{
		return null;
	}

	[Token(Token = "0x600126B")]
	[Address(RVA = "0x24ACE24", Offset = "0x24ACE24", VA = "0x24ACE24")]
	public void AddEventsToClip()
	{
	}

	[Token(Token = "0x600126C")]
	[Address(RVA = "0x24AD668", Offset = "0x24AD668", VA = "0x24AD668")]
	private string GetFunctionNameByType(AnimEventType type, string functionName)
	{
		return null;
	}

	[Token(Token = "0x600126D")]
	[Address(RVA = "0x24AD73C", Offset = "0x24AD73C", VA = "0x24AD73C")]
	private uint GetResourceIDFromString(string strResID)
	{
		return default(uint);
	}
}
