using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200370F")]
public class UIHudRescureView : UIBaseView
{
	[Token(Token = "0x40163CC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton RescureBtn;

	[Token(Token = "0x40163CD")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BGHelping;

	[Token(Token = "0x40163CE")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RescureProcess;

	[Token(Token = "0x40163CF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Alien_Skill;

	[Token(Token = "0x40163D0")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TimeLabel;

	[Token(Token = "0x40163D1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject RescuredAnim;

	[Token(Token = "0x60168D8")]
	[Address(RVA = "0x13F0CC4", Offset = "0x13F0CC4", VA = "0x13F0CC4")]
	public UIHudRescureView()
	{
	}

	[Token(Token = "0x60168D9")]
	[Address(RVA = "0x13F0CCC", Offset = "0x13F0CCC", VA = "0x13F0CCC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168DA")]
	[Address(RVA = "0x13F1030", Offset = "0x13F1030", VA = "0x13F1030")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
