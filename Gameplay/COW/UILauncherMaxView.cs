using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003815")]
public class UILauncherMaxView : UIBaseView
{
	[Token(Token = "0x4016D06")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel MainWidget;

	[Token(Token = "0x4016D07")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel FullScreenRect;

	[Token(Token = "0x4016D08")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture CDNBG;

	[Token(Token = "0x4016D09")]
	[FieldOffset(Offset = "0x20")]
	public UIButton GotoWebsiteBtn;

	[Token(Token = "0x4016D0A")]
	[FieldOffset(Offset = "0x24")]
	public UIButton MaxDownloadBtn;

	[Token(Token = "0x4016D0B")]
	[FieldOffset(Offset = "0x28")]
	public UIButton NormalUpdateBtn;

	[Token(Token = "0x4016D0C")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton GotoVideoBtn;

	[Token(Token = "0x4016D0D")]
	[FieldOffset(Offset = "0x30")]
	public UIButton CloseBtn;

	[Token(Token = "0x6016BEA")]
	[Address(RVA = "0x1A844E4", Offset = "0x1A844E4", VA = "0x1A844E4")]
	public UILauncherMaxView()
	{
	}

	[Token(Token = "0x6016BEB")]
	[Address(RVA = "0x1A844EC", Offset = "0x1A844EC", VA = "0x1A844EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BEC")]
	[Address(RVA = "0x1A84934", Offset = "0x1A84934", VA = "0x1A84934")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
