using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003910")]
public class UIPopInTipsView : UIBaseView
{
	[Token(Token = "0x4017BD9")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelTips;

	[Token(Token = "0x4017BDA")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnReject;

	[Token(Token = "0x4017BDB")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelCounbtDown;

	[Token(Token = "0x4017BDC")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnConfirm;

	[Token(Token = "0x6016ED9")]
	[Address(RVA = "0x2C56D90", Offset = "0x2C56D90", VA = "0x2C56D90")]
	public UIPopInTipsView()
	{
	}

	[Token(Token = "0x6016EDA")]
	[Address(RVA = "0x2C56D98", Offset = "0x2C56D98", VA = "0x2C56D98", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EDB")]
	[Address(RVA = "0x2C57060", Offset = "0x2C57060", VA = "0x2C57060")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
