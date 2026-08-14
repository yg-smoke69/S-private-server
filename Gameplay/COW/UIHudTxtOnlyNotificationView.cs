using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200378C")]
public class UIHudTxtOnlyNotificationView : UIBaseView
{
	[Token(Token = "0x4016820")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x4016821")]
	[FieldOffset(Offset = "0x18")]
	public UILabel content;

	[Token(Token = "0x6016A4F")]
	[Address(RVA = "0x159510C", Offset = "0x159510C", VA = "0x159510C")]
	public UIHudTxtOnlyNotificationView()
	{
	}

	[Token(Token = "0x6016A50")]
	[Address(RVA = "0x1595114", Offset = "0x1595114", VA = "0x1595114", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A51")]
	[Address(RVA = "0x1595310", Offset = "0x1595310", VA = "0x1595310")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
