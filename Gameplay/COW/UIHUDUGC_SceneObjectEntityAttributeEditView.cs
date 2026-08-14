using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037AA")]
public class UIHUDUGC_SceneObjectEntityAttributeEditView : UIBaseView
{
	[Token(Token = "0x40168A4")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList EasyListGrid;

	[Token(Token = "0x40168A5")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LocaltionValue;

	[Token(Token = "0x40168A6")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton confirmbtn;

	[Token(Token = "0x6016AA9")]
	[Address(RVA = "0x291E028", Offset = "0x291E028", VA = "0x291E028")]
	public UIHUDUGC_SceneObjectEntityAttributeEditView()
	{
	}

	[Token(Token = "0x6016AAA")]
	[Address(RVA = "0x291E030", Offset = "0x291E030", VA = "0x291E030", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AAB")]
	[Address(RVA = "0x291E298", Offset = "0x291E298", VA = "0x291E298")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
