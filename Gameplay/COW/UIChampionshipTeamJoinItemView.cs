using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200341F")]
public class UIChampionshipTeamJoinItemView : UIBaseView
{
	[Token(Token = "0x401420C")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Head;

	[Token(Token = "0x401420D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Name;

	[Token(Token = "0x401420E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LV;

	[Token(Token = "0x401420F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Number;

	[Token(Token = "0x4014210")]
	[FieldOffset(Offset = "0x24")]
	public UILabel FriendNumber;

	[Token(Token = "0x4014211")]
	[FieldOffset(Offset = "0x28")]
	public UIButton LookOver;

	[Token(Token = "0x4014212")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ApplyFor;

	[Token(Token = "0x4014213")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ApplyState;

	[Token(Token = "0x6016011")]
	[Address(RVA = "0x2617740", Offset = "0x2617740", VA = "0x2617740")]
	public UIChampionshipTeamJoinItemView()
	{
	}

	[Token(Token = "0x6016012")]
	[Address(RVA = "0x2617748", Offset = "0x2617748", VA = "0x2617748", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016013")]
	[Address(RVA = "0x2617B90", Offset = "0x2617B90", VA = "0x2617B90")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
