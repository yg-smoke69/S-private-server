using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003493")]
public class UICupMatchChampionView : UIBaseView
{
	[Token(Token = "0x40147F5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton MaskBtn;

	[Token(Token = "0x40147F6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Next;

	[Token(Token = "0x40147F7")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture CupIcon;

	[Token(Token = "0x40147F8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject DefaultIcon;

	[Token(Token = "0x40147F9")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamIcon;

	[Token(Token = "0x40147FA")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TeamName;

	[Token(Token = "0x40147FB")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel MatchName;

	[Token(Token = "0x601616D")]
	[Address(RVA = "0x273E1B0", Offset = "0x273E1B0", VA = "0x273E1B0")]
	public UICupMatchChampionView()
	{
	}

	[Token(Token = "0x601616E")]
	[Address(RVA = "0x273E1B8", Offset = "0x273E1B8", VA = "0x273E1B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601616F")]
	[Address(RVA = "0x273E594", Offset = "0x273E594", VA = "0x273E594")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
