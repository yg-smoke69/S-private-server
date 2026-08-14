using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003478")]
public class UICommonOptionalDownloaderView : UIBaseView
{
	[Token(Token = "0x40146B4")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x40146B5")]
	[FieldOffset(Offset = "0x18")]
	public UISprite RunningSprite;

	[Token(Token = "0x40146B6")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ControlBtn;

	[Token(Token = "0x601611C")]
	[Address(RVA = "0x2CE4128", Offset = "0x2CE4128", VA = "0x2CE4128")]
	public UICommonOptionalDownloaderView()
	{
	}

	[Token(Token = "0x601611D")]
	[Address(RVA = "0x2CE4130", Offset = "0x2CE4130", VA = "0x2CE4130", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601611E")]
	[Address(RVA = "0x2CE438C", Offset = "0x2CE438C", VA = "0x2CE438C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
