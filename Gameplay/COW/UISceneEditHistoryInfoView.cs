using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003990")]
public class UISceneEditHistoryInfoView : UIBaseView
{
	[Token(Token = "0x40181E7")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView CenterSV;

	[Token(Token = "0x40181E8")]
	[FieldOffset(Offset = "0x18")]
	public UIToggleButton LatestPlayedBtn;

	[Token(Token = "0x40181E9")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton HistoryPlayedtBtn;

	[Token(Token = "0x40181EA")]
	[FieldOffset(Offset = "0x20")]
	public UITable HistroyTable;

	[Token(Token = "0x40181EB")]
	[FieldOffset(Offset = "0x24")]
	public UISprite HistroyEmpty;

	[Token(Token = "0x40181EC")]
	[FieldOffset(Offset = "0x28")]
	public UISceneEditHistoryTemplateView HistoryTemplate;

	[Token(Token = "0x40181ED")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget CenterScrollable;

	[Token(Token = "0x40181EE")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget ContentContainer;

	[Token(Token = "0x6017057")]
	[Address(RVA = "0x2D9C50C", Offset = "0x2D9C50C", VA = "0x2D9C50C")]
	public UISceneEditHistoryInfoView()
	{
	}

	[Token(Token = "0x6017058")]
	[Address(RVA = "0x2D9C514", Offset = "0x2D9C514", VA = "0x2D9C514", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017059")]
	[Address(RVA = "0x2D9C95C", Offset = "0x2D9C95C", VA = "0x2D9C95C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
