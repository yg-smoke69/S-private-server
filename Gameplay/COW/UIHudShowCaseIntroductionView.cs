using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003743")]
public class UIHudShowCaseIntroductionView : UIBaseView
{
	[Token(Token = "0x401659B")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x401659C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Content;

	[Token(Token = "0x401659D")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnClose;

	[Token(Token = "0x6016974")]
	[Address(RVA = "0x16B94D8", Offset = "0x16B94D8", VA = "0x16B94D8")]
	public UIHudShowCaseIntroductionView()
	{
	}

	[Token(Token = "0x6016975")]
	[Address(RVA = "0x16B94E0", Offset = "0x16B94E0", VA = "0x16B94E0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016976")]
	[Address(RVA = "0x16B9748", Offset = "0x16B9748", VA = "0x16B9748")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
