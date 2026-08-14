using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200382C")]
public class UILinkActivityPVEView : UIBaseView
{
	[Token(Token = "0x4016E6C")]
	[FieldOffset(Offset = "0x14")]
	public Animator AnimPlayer;

	[Token(Token = "0x4016E6D")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture Role;

	[Token(Token = "0x4016E6E")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnClose;

	[Token(Token = "0x4016E6F")]
	[FieldOffset(Offset = "0x20")]
	public UICountDownLabel CountDownLabel;

	[Token(Token = "0x4016E70")]
	[FieldOffset(Offset = "0x24")]
	public UIProgressBar LinkActivityPVEProgress;

	[Token(Token = "0x4016E71")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CollectionItemRoot;

	[Token(Token = "0x4016E72")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject CollectionItemTemplate;

	[Token(Token = "0x4016E73")]
	[FieldOffset(Offset = "0x30")]
	public UILabel EPCountLabelOne;

	[Token(Token = "0x4016E74")]
	[FieldOffset(Offset = "0x34")]
	public UILabel EPCountLabelTwo;

	[Token(Token = "0x4016E75")]
	[FieldOffset(Offset = "0x38")]
	public UILabel EPCountLabelThree;

	[Token(Token = "0x4016E76")]
	[FieldOffset(Offset = "0x3C")]
	public UILinkActivityPVERankItem Rank1Item;

	[Token(Token = "0x4016E77")]
	[FieldOffset(Offset = "0x40")]
	public UILinkActivityPVERankItem Rank2Item;

	[Token(Token = "0x4016E78")]
	[FieldOffset(Offset = "0x44")]
	public UILinkActivityPVERankItem Rank3Item;

	[Token(Token = "0x4016E79")]
	[FieldOffset(Offset = "0x48")]
	public UILinkActivityPVERankItem MyRankItem;

	[Token(Token = "0x6016C2F")]
	[Address(RVA = "0x255803C", Offset = "0x255803C", VA = "0x255803C")]
	public UILinkActivityPVEView()
	{
	}

	[Token(Token = "0x6016C30")]
	[Address(RVA = "0x2558044", Offset = "0x2558044", VA = "0x2558044", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C31")]
	[Address(RVA = "0x25586B4", Offset = "0x25586B4", VA = "0x25586B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
