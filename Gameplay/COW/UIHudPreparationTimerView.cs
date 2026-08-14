using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036E8")]
public class UIHudPreparationTimerView : UIBaseView
{
	[Token(Token = "0x4016300")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Alien_Skill;

	[Token(Token = "0x4016301")]
	[FieldOffset(Offset = "0x18")]
	public UISprite content;

	[Token(Token = "0x4016302")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Progress;

	[Token(Token = "0x4016303")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TimeLabel;

	[Token(Token = "0x6016863")]
	[Address(RVA = "0x1FC41AC", Offset = "0x1FC41AC", VA = "0x1FC41AC")]
	public UIHudPreparationTimerView()
	{
	}

	[Token(Token = "0x6016864")]
	[Address(RVA = "0x1FC41B4", Offset = "0x1FC41B4", VA = "0x1FC41B4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016865")]
	[Address(RVA = "0x1FC4470", Offset = "0x1FC4470", VA = "0x1FC4470")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
