using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002687")]
public class UILegendDrawAnimSetting : MonoBehaviour
{
	[Token(Token = "0x400EDCD")]
	[FieldOffset(Offset = "0xC")]
	public float TotalTime;

	[Token(Token = "0x400EDCE")]
	[FieldOffset(Offset = "0x10")]
	public float StayTimeAfterAnimEnd;

	[Token(Token = "0x400EDCF")]
	[FieldOffset(Offset = "0x14")]
	public int PrizeListLength;

	[Token(Token = "0x600E743")]
	[Address(RVA = "0x2546CF8", Offset = "0x2546CF8", VA = "0x2546CF8")]
	public UILegendDrawAnimSetting()
	{
	}
}
