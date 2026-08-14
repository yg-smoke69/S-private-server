using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A62")]
public class UIVeteranSigninView : UIBaseView
{
	[Token(Token = "0x4018BD4")]
	[FieldOffset(Offset = "0x14")]
	public UISprite bg;

	[Token(Token = "0x4018BD5")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TitleLabel;

	[Token(Token = "0x4018BD6")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnClose;

	[Token(Token = "0x4018BD7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BundleImageLocal;

	[Token(Token = "0x4018BD8")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTextureExt BundleImageRemote;

	[Token(Token = "0x4018BD9")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid NormalDaysGridTop;

	[Token(Token = "0x4018BDA")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid NormalDaysGridBottom;

	[Token(Token = "0x4018BDB")]
	[FieldOffset(Offset = "0x30")]
	public Transform BigDayContainer;

	[Token(Token = "0x4018BDC")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnVeteranReturn;

	[Token(Token = "0x4018BDD")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ReadMeDot;

	[Token(Token = "0x60172CC")]
	[Address(RVA = "0x2CC55E0", Offset = "0x2CC55E0", VA = "0x2CC55E0")]
	public UIVeteranSigninView()
	{
	}

	[Token(Token = "0x60172CD")]
	[Address(RVA = "0x2CC55E8", Offset = "0x2CC55E8", VA = "0x2CC55E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172CE")]
	[Address(RVA = "0x2CC5AB0", Offset = "0x2CC5AB0", VA = "0x2CC5AB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
