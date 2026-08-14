using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003844")]
public class UILobbyLeaderBoardView : UIBaseView
{
	[Token(Token = "0x4016FB3")]
	[FieldOffset(Offset = "0x14")]
	public UIButton btnMore;

	[Token(Token = "0x4016FB4")]
	[FieldOffset(Offset = "0x18")]
	public UICustomizedWrapContent WrapContent;

	[Token(Token = "0x6016C77")]
	[Address(RVA = "0xDBBDEC", Offset = "0xDBBDEC", VA = "0xDBBDEC")]
	public UILobbyLeaderBoardView()
	{
	}

	[Token(Token = "0x6016C78")]
	[Address(RVA = "0xDBBDF4", Offset = "0xDBBDF4", VA = "0xDBBDF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C79")]
	[Address(RVA = "0xDBBFFC", Offset = "0xDBBFFC", VA = "0xDBBFFC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
