using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003901")]
public class UIPetActionItemView : UIBaseView
{
	[Token(Token = "0x4017B2B")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIPetActionItem;

	[Token(Token = "0x4017B2C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject UnlockMask;

	[Token(Token = "0x4017B2D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel UnlockIcon;

	[Token(Token = "0x4017B2E")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ActionName;

	[Token(Token = "0x4017B2F")]
	[FieldOffset(Offset = "0x24")]
	public UILabel DescLabel;

	[Token(Token = "0x4017B30")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NewTips;

	[Token(Token = "0x4017B31")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject DownloadMask;

	[Token(Token = "0x6016EAC")]
	[Address(RVA = "0x23E6C58", Offset = "0x23E6C58", VA = "0x23E6C58")]
	public UIPetActionItemView()
	{
	}

	[Token(Token = "0x6016EAD")]
	[Address(RVA = "0x23E6C60", Offset = "0x23E6C60", VA = "0x23E6C60", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EAE")]
	[Address(RVA = "0x23E7024", Offset = "0x23E7024", VA = "0x23E7024")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
