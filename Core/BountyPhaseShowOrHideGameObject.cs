using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B0A")]
internal class BountyPhaseShowOrHideGameObject : MonoBehaviour
{
	[Token(Token = "0x4005F63")]
	[FieldOffset(Offset = "0xC")]
	public HLOONAALFOE.PMIAFNGJGHA ShowPhase;

	[Token(Token = "0x4005F64")]
	[FieldOffset(Offset = "0x10")]
	public List<int> m_ExPhases;

	[Token(Token = "0x60054D2")]
	[Address(RVA = "0x2ED6AEC", Offset = "0x2ED6AEC", VA = "0x2ED6AEC")]
	public BountyPhaseShowOrHideGameObject()
	{
	}

	[Token(Token = "0x60054D3")]
	[Address(RVA = "0x2ED6B78", Offset = "0x2ED6B78", VA = "0x2ED6B78")]
	private void Start()
	{
	}

	[Token(Token = "0x60054D4")]
	[Address(RVA = "0x2ED6C94", Offset = "0x2ED6C94", VA = "0x2ED6C94")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60054D5")]
	[Address(RVA = "0x2ED6D74", Offset = "0x2ED6D74", VA = "0x2ED6D74")]
	private void OnPhaseChange(GEvent gEvent)
	{
	}

	[Token(Token = "0x60054D6")]
	[Address(RVA = "0x2ED6F00", Offset = "0x2ED6F00", VA = "0x2ED6F00")]
	private bool IsInExPhases(HLOONAALFOE.PMIAFNGJGHA phaseType)
	{
		return default(bool);
	}
}
