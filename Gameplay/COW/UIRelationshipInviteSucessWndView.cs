using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003952")]
public class UIRelationshipInviteSucessWndView : UIBaseView
{
	[Token(Token = "0x4017FDE")]
	[FieldOffset(Offset = "0x14")]
	public UIEffectSprite MyHeadPic;

	[Token(Token = "0x4017FDF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel MyNickName;

	[Token(Token = "0x4017FE0")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite FriendHeadPic;

	[Token(Token = "0x4017FE1")]
	[FieldOffset(Offset = "0x20")]
	public UILabel FriendNickName;

	[Token(Token = "0x4017FE2")]
	[FieldOffset(Offset = "0x24")]
	public UIButton ClickMask;

	[Token(Token = "0x6016F9D")]
	[Address(RVA = "0x1E4E724", Offset = "0x1E4E724", VA = "0x1E4E724")]
	public UIRelationshipInviteSucessWndView()
	{
	}

	[Token(Token = "0x6016F9E")]
	[Address(RVA = "0x1E4E72C", Offset = "0x1E4E72C", VA = "0x1E4E72C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F9F")]
	[Address(RVA = "0x1E4EA54", Offset = "0x1E4EA54", VA = "0x1E4EA54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
