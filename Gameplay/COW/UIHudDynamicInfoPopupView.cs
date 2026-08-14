using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200363B")]
public class UIHudDynamicInfoPopupView : UIBaseView
{
	[Token(Token = "0x4015C11")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Message;

	[Token(Token = "0x4015C12")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Icon;

	[Token(Token = "0x601665E")]
	[Address(RVA = "0x1CD9030", Offset = "0x1CD9030", VA = "0x1CD9030")]
	public UIHudDynamicInfoPopupView()
	{
	}

	[Token(Token = "0x601665F")]
	[Address(RVA = "0x1CD9038", Offset = "0x1CD9038", VA = "0x1CD9038", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016660")]
	[Address(RVA = "0x1CD9240", Offset = "0x1CD9240", VA = "0x1CD9240")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
