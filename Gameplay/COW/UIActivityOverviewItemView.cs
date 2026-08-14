using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033AE")]
public class UIActivityOverviewItemView : UIBaseView
{
	[Token(Token = "0x4013BBD")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIActivityOverviewItem;

	[Token(Token = "0x4013BBE")]
	[FieldOffset(Offset = "0x18")]
	public UIButton LittleGoTo;

	[Token(Token = "0x4013BBF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BtnTitle;

	[Token(Token = "0x4013BC0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GoToRedpoint;

	[Token(Token = "0x4013BC1")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Title;

	[Token(Token = "0x4013BC2")]
	[FieldOffset(Offset = "0x28")]
	public UINetworkTexture BGCDN;

	[Token(Token = "0x4013BC3")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject FinishState;

	[Token(Token = "0x4013BC4")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ComingState;

	[Token(Token = "0x4013BC5")]
	[FieldOffset(Offset = "0x34")]
	public GameObject NormalState;

	[Token(Token = "0x4013BC6")]
	[FieldOffset(Offset = "0x38")]
	public UIButton GotoBtn;

	[Token(Token = "0x6015EC0")]
	[Address(RVA = "0x2FBB8B0", Offset = "0x2FBB8B0", VA = "0x2FBB8B0")]
	public UIActivityOverviewItemView()
	{
	}

	[Token(Token = "0x6015EC1")]
	[Address(RVA = "0x2FBB8B8", Offset = "0x2FBB8B8", VA = "0x2FBB8B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EC2")]
	[Address(RVA = "0x2FBBD90", Offset = "0x2FBBD90", VA = "0x2FBBD90")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
