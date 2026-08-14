using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200395F")]
public class UIRoomCheckSliderTemplateView : UIBaseView
{
	[Token(Token = "0x4018037")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle CheckToggle;

	[Token(Token = "0x4018038")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4018039")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Value;

	[Token(Token = "0x401803A")]
	[FieldOffset(Offset = "0x20")]
	public UIButton plusBtn;

	[Token(Token = "0x401803B")]
	[FieldOffset(Offset = "0x24")]
	public UISlider slider;

	[Token(Token = "0x401803C")]
	[FieldOffset(Offset = "0x28")]
	public UIButton minusBtn;

	[Token(Token = "0x6016FC4")]
	[Address(RVA = "0x23BBE94", Offset = "0x23BBE94", VA = "0x23BBE94")]
	public UIRoomCheckSliderTemplateView()
	{
	}

	[Token(Token = "0x6016FC5")]
	[Address(RVA = "0x23BBE9C", Offset = "0x23BBE9C", VA = "0x23BBE9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FC6")]
	[Address(RVA = "0x23BC224", Offset = "0x23BC224", VA = "0x23BC224")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
