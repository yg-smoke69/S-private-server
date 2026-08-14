using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200395C")]
public class UIRewardPreviewView : UIBaseView
{
	[Token(Token = "0x401802C")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid PreviewGrid;

	[Token(Token = "0x401802D")]
	[FieldOffset(Offset = "0x18")]
	public UIButton OKBtn;

	[Token(Token = "0x401802E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BtnLabel;

	[Token(Token = "0x401802F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel DescLabel;

	[Token(Token = "0x6016FBB")]
	[Address(RVA = "0x1E59754", Offset = "0x1E59754", VA = "0x1E59754")]
	public UIRewardPreviewView()
	{
	}

	[Token(Token = "0x6016FBC")]
	[Address(RVA = "0x1E5975C", Offset = "0x1E5975C", VA = "0x1E5975C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FBD")]
	[Address(RVA = "0x1E59A24", Offset = "0x1E59A24", VA = "0x1E59A24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
