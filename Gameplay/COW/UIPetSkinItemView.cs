using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003908")]
public class UIPetSkinItemView : UIBaseView
{
	[Token(Token = "0x4017B5C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIPetSkinItem;

	[Token(Token = "0x4017B5D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NewTips;

	[Token(Token = "0x4017B5E")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject UnlockMask;

	[Token(Token = "0x4017B5F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel UnlockIcon;

	[Token(Token = "0x4017B60")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ActionName;

	[Token(Token = "0x4017B61")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DescLabel;

	[Token(Token = "0x4017B62")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SelectTag;

	[Token(Token = "0x4017B63")]
	[FieldOffset(Offset = "0x30")]
	public GameObject DownloadMask;

	[Token(Token = "0x6016EC1")]
	[Address(RVA = "0x2C51040", Offset = "0x2C51040", VA = "0x2C51040")]
	public UIPetSkinItemView()
	{
	}

	[Token(Token = "0x6016EC2")]
	[Address(RVA = "0x2C51048", Offset = "0x2C51048", VA = "0x2C51048", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EC3")]
	[Address(RVA = "0x2C51460", Offset = "0x2C51460", VA = "0x2C51460")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
