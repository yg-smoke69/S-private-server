using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003903")]
public class UIPetLevelUpView : UIBaseView
{
	[Token(Token = "0x4017B39")]
	[FieldOffset(Offset = "0x14")]
	public UILabel BeforeLevel;

	[Token(Token = "0x4017B3A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel AfterLevel;

	[Token(Token = "0x4017B3B")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BG;

	[Token(Token = "0x4017B3C")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid AwardGrid;

	[Token(Token = "0x4017B3D")]
	[FieldOffset(Offset = "0x24")]
	public UIButton OKBtn;

	[Token(Token = "0x4017B3E")]
	[FieldOffset(Offset = "0x28")]
	public UISprite PetIcon;

	[Token(Token = "0x6016EB2")]
	[Address(RVA = "0x2C48D08", Offset = "0x2C48D08", VA = "0x2C48D08")]
	public UIPetLevelUpView()
	{
	}

	[Token(Token = "0x6016EB3")]
	[Address(RVA = "0x2C48D10", Offset = "0x2C48D10", VA = "0x2C48D10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EB4")]
	[Address(RVA = "0x2C49098", Offset = "0x2C49098", VA = "0x2C49098")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
