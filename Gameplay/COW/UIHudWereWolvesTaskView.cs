using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037DB")]
public class UIHudWereWolvesTaskView : UIBaseView
{
	[Token(Token = "0x4016A5F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TaskPanel;

	[Token(Token = "0x4016A60")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClose;

	[Token(Token = "0x4016A61")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TitleLabel;

	[Token(Token = "0x6016B3C")]
	[Address(RVA = "0x2571654", Offset = "0x2571654", VA = "0x2571654")]
	public UIHudWereWolvesTaskView()
	{
	}

	[Token(Token = "0x6016B3D")]
	[Address(RVA = "0x257165C", Offset = "0x257165C", VA = "0x257165C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B3E")]
	[Address(RVA = "0x25718B8", Offset = "0x25718B8", VA = "0x25718B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
