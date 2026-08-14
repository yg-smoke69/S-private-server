using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003953")]
public class UIRelationshipMsgDetailWndView : UIBaseView
{
	[Token(Token = "0x4017FE3")]
	[FieldOffset(Offset = "0x14")]
	public Animator UIRelationshipMsgDetailWnd;

	[Token(Token = "0x4017FE4")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4017FE5")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton RefuceBtn;

	[Token(Token = "0x4017FE6")]
	[FieldOffset(Offset = "0x20")]
	public UILabel MsgContent;

	[Token(Token = "0x4017FE7")]
	[FieldOffset(Offset = "0x24")]
	public UILabel MsgContent_1;

	[Token(Token = "0x4017FE8")]
	[FieldOffset(Offset = "0x28")]
	public UINetworkTexture CDNTexture;

	[Token(Token = "0x4017FE9")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton CloseBtn;

	[Token(Token = "0x6016FA0")]
	[Address(RVA = "0x1E4F970", Offset = "0x1E4F970", VA = "0x1E4F970")]
	public UIRelationshipMsgDetailWndView()
	{
	}

	[Token(Token = "0x6016FA1")]
	[Address(RVA = "0x1E4F978", Offset = "0x1E4F978", VA = "0x1E4F978", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FA2")]
	[Address(RVA = "0x1E4FD60", Offset = "0x1E4FD60", VA = "0x1E4FD60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
