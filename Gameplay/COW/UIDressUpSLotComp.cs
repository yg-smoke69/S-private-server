using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20025D8")]
public class UIDressUpSLotComp : MonoBehaviour
{
	[Token(Token = "0x400EA03")]
	[FieldOffset(Offset = "0xC")]
	public List<Vector3> m_SlotEndPos;

	[Token(Token = "0x400EA04")]
	[FieldOffset(Offset = "0x10")]
	public List<Vector3> m_SlotStartPos;

	[Token(Token = "0x600DECD")]
	[Address(RVA = "0x2B99054", Offset = "0x2B99054", VA = "0x2B99054")]
	public UIDressUpSLotComp()
	{
	}
}
