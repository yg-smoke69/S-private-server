using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033F9")]
public class UIBigEventFriendReunionInviterView : UIBaseView
{
	[Token(Token = "0x401401F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SearchBarContainer;

	[Token(Token = "0x4014020")]
	[FieldOffset(Offset = "0x18")]
	public UILabel InviteDescription;

	[Token(Token = "0x4014021")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TimeRoot;

	[Token(Token = "0x4014022")]
	[FieldOffset(Offset = "0x20")]
	public Transform CountDown;

	[Token(Token = "0x4014023")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ActivityCounterLabel;

	[Token(Token = "0x4014024")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ReunionInviterItemBg;

	[Token(Token = "0x6015F9F")]
	[Address(RVA = "0x141CD68", Offset = "0x141CD68", VA = "0x141CD68")]
	public UIBigEventFriendReunionInviterView()
	{
	}

	[Token(Token = "0x6015FA0")]
	[Address(RVA = "0x141CD70", Offset = "0x141CD70", VA = "0x141CD70", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FA1")]
	[Address(RVA = "0x141D0B8", Offset = "0x141D0B8", VA = "0x141D0B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
