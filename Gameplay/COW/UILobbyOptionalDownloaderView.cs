using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200384C")]
public class UILobbyOptionalDownloaderView : UIBaseView
{
	[Token(Token = "0x40170E3")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x40170E4")]
	[FieldOffset(Offset = "0x18")]
	public UISprite RunningSprite;

	[Token(Token = "0x40170E5")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GiftTipsContainer;

	[Token(Token = "0x40170E6")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Error_Tips_pic;

	[Token(Token = "0x40170E7")]
	[FieldOffset(Offset = "0x24")]
	public UIButton ControlBtn;

	[Token(Token = "0x40170E8")]
	[FieldOffset(Offset = "0x28")]
	public Transform TipsContainer;

	[Token(Token = "0x6016C8F")]
	[Address(RVA = "0x1CB0D88", Offset = "0x1CB0D88", VA = "0x1CB0D88")]
	public UILobbyOptionalDownloaderView()
	{
	}

	[Token(Token = "0x6016C90")]
	[Address(RVA = "0x1CB0D90", Offset = "0x1CB0D90", VA = "0x1CB0D90", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C91")]
	[Address(RVA = "0x1CB10CC", Offset = "0x1CB10CC", VA = "0x1CB10CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
