using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003843")]
public class UILobbyLeaderBoardItemView : UIBaseView
{
	[Token(Token = "0x4016FAF")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture iconimage;

	[Token(Token = "0x4016FB0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject first;

	[Token(Token = "0x4016FB1")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject second;

	[Token(Token = "0x4016FB2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject third;

	[Token(Token = "0x6016C74")]
	[Address(RVA = "0xDBBB38", Offset = "0xDBBB38", VA = "0xDBBB38")]
	public UILobbyLeaderBoardItemView()
	{
	}

	[Token(Token = "0x6016C75")]
	[Address(RVA = "0xDBBB40", Offset = "0xDBBB40", VA = "0xDBBB40", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C76")]
	[Address(RVA = "0xDBBDE4", Offset = "0xDBBDE4", VA = "0xDBBDE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
