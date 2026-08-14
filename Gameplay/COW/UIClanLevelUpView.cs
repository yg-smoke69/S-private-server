using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200344D")]
public class UIClanLevelUpView : UIBaseView
{
	[Token(Token = "0x4014495")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid AwardGrid;

	[Token(Token = "0x4014496")]
	[FieldOffset(Offset = "0x18")]
	public UIButton OKBtn;

	[Token(Token = "0x4014497")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite LevelIcon;

	[Token(Token = "0x4014498")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LevelLabel;

	[Token(Token = "0x601609B")]
	[Address(RVA = "0x2B2FDA0", Offset = "0x2B2FDA0", VA = "0x2B2FDA0")]
	public UIClanLevelUpView()
	{
	}

	[Token(Token = "0x601609C")]
	[Address(RVA = "0x2B2FDA8", Offset = "0x2B2FDA8", VA = "0x2B2FDA8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601609D")]
	[Address(RVA = "0x2B30070", Offset = "0x2B30070", VA = "0x2B30070")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
