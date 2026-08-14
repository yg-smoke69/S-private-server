using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003484")]
public class UICommonSlideToggleView : UIBaseView
{
	[Token(Token = "0x4014710")]
	[FieldOffset(Offset = "0x14")]
	public Animation slideAnim;

	[Token(Token = "0x4014711")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelSelectLeft;

	[Token(Token = "0x4014712")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelSelectRight;

	[Token(Token = "0x6016140")]
	[Address(RVA = "0x1EB9C30", Offset = "0x1EB9C30", VA = "0x1EB9C30")]
	public UICommonSlideToggleView()
	{
	}

	[Token(Token = "0x6016141")]
	[Address(RVA = "0x1EB9C38", Offset = "0x1EB9C38", VA = "0x1EB9C38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016142")]
	[Address(RVA = "0x1EB9EA0", Offset = "0x1EB9EA0", VA = "0x1EB9EA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
