using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003749")]
public class UIHUDSingersBHideAllView : UIBaseView
{
	[Token(Token = "0x40165B4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton HideBtn;

	[Token(Token = "0x40165B5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TutorialHideRoot;

	[Token(Token = "0x40165B6")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TutorialShowRoot;

	[Token(Token = "0x40165B7")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ShowBtn;

	[Token(Token = "0x6016986")]
	[Address(RVA = "0x221371C", Offset = "0x221371C", VA = "0x221371C")]
	public UIHUDSingersBHideAllView()
	{
	}

	[Token(Token = "0x6016987")]
	[Address(RVA = "0x2213724", Offset = "0x2213724", VA = "0x2213724", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016988")]
	[Address(RVA = "0x22139D4", Offset = "0x22139D4", VA = "0x22139D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
