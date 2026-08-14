using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A34")]
public class UIUGCHudWidgetAttributeSpriteView : UIBaseView
{
	[Token(Token = "0x4018945")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x4018946")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Btn;

	[Token(Token = "0x4018947")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4018948")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList Grid;

	[Token(Token = "0x6017242")]
	[Address(RVA = "0x2FF91C0", Offset = "0x2FF91C0", VA = "0x2FF91C0")]
	public UIUGCHudWidgetAttributeSpriteView()
	{
	}

	[Token(Token = "0x6017243")]
	[Address(RVA = "0x2FF91C8", Offset = "0x2FF91C8", VA = "0x2FF91C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017244")]
	[Address(RVA = "0x2FF9490", Offset = "0x2FF9490", VA = "0x2FF9490")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
