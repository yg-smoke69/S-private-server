using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039F7")]
public class UISyncSettingConfirmView : UIBaseView
{
	[Token(Token = "0x40186DE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UploadCoverContainer;

	[Token(Token = "0x40186DF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnUploadCoverConfirm;

	[Token(Token = "0x40186E0")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnUploadCoverCancel;

	[Token(Token = "0x40186E1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject DownloadCoverContainer;

	[Token(Token = "0x40186E2")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnDownloadCoverConfirm;

	[Token(Token = "0x40186E3")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnDownloadCoverCancel;

	[Token(Token = "0x40186E4")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject DownloadNotFoundContainer;

	[Token(Token = "0x40186E5")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnDownloadNotFoundConfirm;

	[Token(Token = "0x601718B")]
	[Address(RVA = "0x2014828", Offset = "0x2014828", VA = "0x2014828")]
	public UISyncSettingConfirmView()
	{
	}

	[Token(Token = "0x601718C")]
	[Address(RVA = "0x2014830", Offset = "0x2014830", VA = "0x2014830", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601718D")]
	[Address(RVA = "0x2014C54", Offset = "0x2014C54", VA = "0x2014C54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
