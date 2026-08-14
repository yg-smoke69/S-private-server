using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037EF")]
public class UIHyperBookEntranceView : UIBaseView
{
	[Token(Token = "0x4016B14")]
	[FieldOffset(Offset = "0x14")]
	public UIButton EntranceBtn;

	[Token(Token = "0x4016B15")]
	[FieldOffset(Offset = "0x18")]
	public UIDragScrollView EntranceDragScrollView;

	[Token(Token = "0x4016B16")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BookNameLabel;

	[Token(Token = "0x4016B17")]
	[FieldOffset(Offset = "0x20")]
	public UITable ProgressTable;

	[Token(Token = "0x4016B18")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ProgressUnit;

	[Token(Token = "0x4016B19")]
	[FieldOffset(Offset = "0x28")]
	public UILabel BookStatusLabel;

	[Token(Token = "0x4016B1A")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite BookCoverIcon;

	[Token(Token = "0x4016B1B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BookEntranceTips;

	[Token(Token = "0x4016B1C")]
	[FieldOffset(Offset = "0x34")]
	public UISprite LockIconBg;

	[Token(Token = "0x4016B1D")]
	[FieldOffset(Offset = "0x38")]
	public UISprite BookCoverIconMask;

	[Token(Token = "0x4016B1E")]
	[FieldOffset(Offset = "0x3C")]
	public Transform DownloadCtrlTrans;

	[Token(Token = "0x4016B1F")]
	[FieldOffset(Offset = "0x40")]
	public Animation UnlockAnim;

	[Token(Token = "0x6016B78")]
	[Address(RVA = "0x295E834", Offset = "0x295E834", VA = "0x295E834")]
	public UIHyperBookEntranceView()
	{
	}

	[Token(Token = "0x6016B79")]
	[Address(RVA = "0x295E83C", Offset = "0x295E83C", VA = "0x295E83C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B7A")]
	[Address(RVA = "0x295EDC4", Offset = "0x295EDC4", VA = "0x295EDC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
