using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033B4")]
public class UIActivitySecretMessageGeneratePopupWndView : UIBaseView
{
	[Token(Token = "0x4013BE0")]
	[FieldOffset(Offset = "0x14")]
	public UILabel SecretMessageLabel;

	[Token(Token = "0x4013BE1")]
	[FieldOffset(Offset = "0x18")]
	public UILabel HelpTipsLabel;

	[Token(Token = "0x4013BE2")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CopyBtn;

	[Token(Token = "0x4013BE3")]
	[FieldOffset(Offset = "0x20")]
	public Transform InvitePlatformCommonGridRoot;

	[Token(Token = "0x4013BE4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject VFXContainer;

	[Token(Token = "0x4013BE5")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget GuideStep2Widget;

	[Token(Token = "0x4013BE6")]
	[FieldOffset(Offset = "0x2C")]
	public UIPanel GuideMaskPanel;

	[Token(Token = "0x4013BE7")]
	[FieldOffset(Offset = "0x30")]
	public UIButton GuideMask;

	[Token(Token = "0x4013BE8")]
	[FieldOffset(Offset = "0x34")]
	public UIButton CopyBtnGrey;

	[Token(Token = "0x6015ED2")]
	[Address(RVA = "0x2FC4644", Offset = "0x2FC4644", VA = "0x2FC4644")]
	public UIActivitySecretMessageGeneratePopupWndView()
	{
	}

	[Token(Token = "0x6015ED3")]
	[Address(RVA = "0x2FC464C", Offset = "0x2FC464C", VA = "0x2FC464C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015ED4")]
	[Address(RVA = "0x2FC4AC0", Offset = "0x2FC4AC0", VA = "0x2FC4AC0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
