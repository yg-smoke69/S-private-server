using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EA7")]
public class PartyShowAutoDestory : MonoBehaviour
{
	[Token(Token = "0x401A777")]
	[FieldOffset(Offset = "0xC")]
	public float m_DurationTime;

	[Token(Token = "0x401A778")]
	[FieldOffset(Offset = "0x10")]
	private bool m_StartDestroy;

	[Token(Token = "0x401A779")]
	[FieldOffset(Offset = "0x14")]
	private float m_PastTime;

	[Token(Token = "0x60197CC")]
	[Address(RVA = "0x2981F60", Offset = "0x2981F60", VA = "0x2981F60")]
	public PartyShowAutoDestory()
	{
	}

	[Token(Token = "0x60197CD")]
	[Address(RVA = "0x2981F70", Offset = "0x2981F70", VA = "0x2981F70")]
	private void Start()
	{
	}

	[Token(Token = "0x60197CE")]
	[Address(RVA = "0x2981F74", Offset = "0x2981F74", VA = "0x2981F74")]
	public void StartDestory()
	{
	}

	[Token(Token = "0x60197CF")]
	[Address(RVA = "0x2981F80", Offset = "0x2981F80", VA = "0x2981F80")]
	private void Update()
	{
	}
}
