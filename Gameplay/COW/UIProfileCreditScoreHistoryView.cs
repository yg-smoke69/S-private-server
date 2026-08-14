using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003920")]
public class UIProfileCreditScoreHistoryView : UIBaseView
{
	[Token(Token = "0x4017C6D")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList HistoryList;

	[Token(Token = "0x4017C6E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Title;

	[Token(Token = "0x4017C6F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Tips;

	[Token(Token = "0x6016F07")]
	[Address(RVA = "0x16D3490", Offset = "0x16D3490", VA = "0x16D3490")]
	public UIProfileCreditScoreHistoryView()
	{
	}

	[Token(Token = "0x6016F08")]
	[Address(RVA = "0x16D3498", Offset = "0x16D3498", VA = "0x16D3498", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F09")]
	[Address(RVA = "0x16D36E8", Offset = "0x16D36E8", VA = "0x16D36E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
