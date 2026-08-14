using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033A8")]
public class UIActivityFriendReunionInviterView : UIBaseView
{
	[Token(Token = "0x4013B96")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SearchBarContainer;

	[Token(Token = "0x4013B97")]
	[FieldOffset(Offset = "0x18")]
	public UILabel InviteDescription;

	[Token(Token = "0x4013B98")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TimeRoot;

	[Token(Token = "0x4013B99")]
	[FieldOffset(Offset = "0x20")]
	public Transform CountDown;

	[Token(Token = "0x4013B9A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ActivityCounterLabel;

	[Token(Token = "0x4013B9B")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ReunionInviterItemBg;

	[Token(Token = "0x6015EAE")]
	[Address(RVA = "0x2FB21D0", Offset = "0x2FB21D0", VA = "0x2FB21D0")]
	public UIActivityFriendReunionInviterView()
	{
	}

	[Token(Token = "0x6015EAF")]
	[Address(RVA = "0x2FB21D8", Offset = "0x2FB21D8", VA = "0x2FB21D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EB0")]
	[Address(RVA = "0x2FB2520", Offset = "0x2FB2520", VA = "0x2FB2520")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
