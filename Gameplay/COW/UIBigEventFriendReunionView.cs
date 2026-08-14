using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033FC")]
public class UIBigEventFriendReunionView : UIBaseView
{
	[Token(Token = "0x401403C")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x401403D")]
	[FieldOffset(Offset = "0x18")]
	public UITable ContentTable;

	[Token(Token = "0x401403E")]
	[FieldOffset(Offset = "0x1C")]
	public UIDragScrollView DragArea;

	[Token(Token = "0x401403F")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture ADMini;

	[Token(Token = "0x4014040")]
	[FieldOffset(Offset = "0x24")]
	public GameObject IntroBG;

	[Token(Token = "0x4014041")]
	[FieldOffset(Offset = "0x28")]
	public UISprite IntroBGSprite;

	[Token(Token = "0x4014042")]
	[FieldOffset(Offset = "0x2C")]
	public UITable IntroRoot;

	[Token(Token = "0x4014043")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Introduction;

	[Token(Token = "0x4014044")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Time;

	[Token(Token = "0x4014045")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Progress;

	[Token(Token = "0x4014046")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ProgressNum;

	[Token(Token = "0x4014047")]
	[FieldOffset(Offset = "0x40")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x6015FA8")]
	[Address(RVA = "0x300B630", Offset = "0x300B630", VA = "0x300B630")]
	public UIBigEventFriendReunionView()
	{
	}

	[Token(Token = "0x6015FA9")]
	[Address(RVA = "0x300B638", Offset = "0x300B638", VA = "0x300B638", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FAA")]
	[Address(RVA = "0x300BBE8", Offset = "0x300BBE8", VA = "0x300BBE8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
