using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200226B")]
internal class MaxHypePlayerHint : MonoBehaviour
{
	[Token(Token = "0x400D733")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_MaxHypeMark;

	[Token(Token = "0x400D734")]
	[FieldOffset(Offset = "0x10")]
	public Transform m_PlayerDirection;

	[Token(Token = "0x600BBFE")]
	[Address(RVA = "0x1546AF4", Offset = "0x1546AF4", VA = "0x1546AF4")]
	public MaxHypePlayerHint()
	{
	}

	[Token(Token = "0x600BBFF")]
	[Address(RVA = "0x1546AFC", Offset = "0x1546AFC", VA = "0x1546AFC")]
	private void Start()
	{
	}
}
