using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035F6")]
public class UIHudBountyContractView : UIBaseView
{
	[Token(Token = "0x40159B5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnBountyContract;

	[Token(Token = "0x40159B6")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BGBountyContract;

	[Token(Token = "0x40159B7")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BountyIcon;

	[Token(Token = "0x6016590")]
	[Address(RVA = "0x1E16938", Offset = "0x1E16938", VA = "0x1E16938")]
	public UIHudBountyContractView()
	{
	}

	[Token(Token = "0x6016591")]
	[Address(RVA = "0x1E16940", Offset = "0x1E16940", VA = "0x1E16940", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016592")]
	[Address(RVA = "0x1E16BA8", Offset = "0x1E16BA8", VA = "0x1E16BA8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
