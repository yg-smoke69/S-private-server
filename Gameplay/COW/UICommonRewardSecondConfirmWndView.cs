using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200347C")]
public class UICommonRewardSecondConfirmWndView : UIBaseView
{
	[Token(Token = "0x40146CB")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CancelBtn;

	[Token(Token = "0x40146CC")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x40146CD")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Label;

	[Token(Token = "0x6016128")]
	[Address(RVA = "0x2CEA97C", Offset = "0x2CEA97C", VA = "0x2CEA97C")]
	public UICommonRewardSecondConfirmWndView()
	{
	}

	[Token(Token = "0x6016129")]
	[Address(RVA = "0x2CEA984", Offset = "0x2CEA984", VA = "0x2CEA984", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601612A")]
	[Address(RVA = "0x2CEABEC", Offset = "0x2CEABEC", VA = "0x2CEABEC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
