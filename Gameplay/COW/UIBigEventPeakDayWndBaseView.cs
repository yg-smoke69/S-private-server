using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F90")]
public class UIBigEventPeakDayWndBaseView : MonoBehaviour
{
	[Token(Token = "0x400C613")]
	[FieldOffset(Offset = "0xC")]
	public UILabel LabelDesc;

	[Token(Token = "0x400C614")]
	[FieldOffset(Offset = "0x10")]
	public UIGrid RewardGrid;

	[Token(Token = "0x400C615")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClaim;

	[Token(Token = "0x400C616")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ExpiredDesc;

	[Token(Token = "0x400C617")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelTitle;

	[Token(Token = "0x400C618")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnClose;

	[Token(Token = "0x6009D18")]
	[Address(RVA = "0x30171F8", Offset = "0x30171F8", VA = "0x30171F8")]
	public UIBigEventPeakDayWndBaseView()
	{
	}
}
