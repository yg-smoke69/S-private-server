using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029D6")]
public class UIMysteryBonusSpinWndAnimationConfig : MonoBehaviour
{
	[Token(Token = "0x401013C")]
	[FieldOffset(Offset = "0xC")]
	public float Number_Ones_Speed;

	[Token(Token = "0x401013D")]
	[FieldOffset(Offset = "0x10")]
	public float Number_Tens_Speed;

	[Token(Token = "0x401013E")]
	[FieldOffset(Offset = "0x14")]
	public float ScrollOffset_End;

	[Token(Token = "0x401013F")]
	[FieldOffset(Offset = "0x18")]
	public float LerpFactor;

	[Token(Token = "0x6010D45")]
	[Address(RVA = "0x1955E90", Offset = "0x1955E90", VA = "0x1955E90")]
	public UIMysteryBonusSpinWndAnimationConfig()
	{
	}
}
