using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034A6")]
public class UICupMatchTeamJoinItemView : UIBaseView
{
	[Token(Token = "0x40148CE")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Head;

	[Token(Token = "0x40148CF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Name;

	[Token(Token = "0x40148D0")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LV;

	[Token(Token = "0x40148D1")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Number;

	[Token(Token = "0x40148D2")]
	[FieldOffset(Offset = "0x24")]
	public UILabel FriendNumber;

	[Token(Token = "0x40148D3")]
	[FieldOffset(Offset = "0x28")]
	public UIButton LookOver;

	[Token(Token = "0x40148D4")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ApplyFor;

	[Token(Token = "0x40148D5")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TireLabel;

	[Token(Token = "0x40148D6")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ApplyState;

	[Token(Token = "0x60161A6")]
	[Address(RVA = "0x11DB888", Offset = "0x11DB888", VA = "0x11DB888")]
	public UICupMatchTeamJoinItemView()
	{
	}

	[Token(Token = "0x60161A7")]
	[Address(RVA = "0x11DB890", Offset = "0x11DB890", VA = "0x11DB890", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161A8")]
	[Address(RVA = "0x11DBD38", Offset = "0x11DBD38", VA = "0x11DBD38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
