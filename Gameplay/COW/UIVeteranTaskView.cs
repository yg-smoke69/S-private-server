using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A65")]
public class UIVeteranTaskView : UIBaseView
{
	[Token(Token = "0x4018BEA")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList List;

	[Token(Token = "0x4018BEB")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BundleImageLocal;

	[Token(Token = "0x4018BEC")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTextureExt BundleImageRemote;

	[Token(Token = "0x4018BED")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ProgressNum;

	[Token(Token = "0x4018BEE")]
	[FieldOffset(Offset = "0x24")]
	public UIProgressBar ProgressBar1;

	[Token(Token = "0x4018BEF")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TaskNum1;

	[Token(Token = "0x4018BF0")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject UnFinish1;

	[Token(Token = "0x4018BF1")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Finished1;

	[Token(Token = "0x4018BF2")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BigPrizePos1;

	[Token(Token = "0x4018BF3")]
	[FieldOffset(Offset = "0x38")]
	public UIButton ClaimBtn1;

	[Token(Token = "0x4018BF4")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject VfxRareReward1;

	[Token(Token = "0x4018BF5")]
	[FieldOffset(Offset = "0x40")]
	public UILabel TaskNum2;

	[Token(Token = "0x4018BF6")]
	[FieldOffset(Offset = "0x44")]
	public GameObject UnFinish2;

	[Token(Token = "0x4018BF7")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Finished2;

	[Token(Token = "0x4018BF8")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject BigPrizePos2;

	[Token(Token = "0x4018BF9")]
	[FieldOffset(Offset = "0x50")]
	public GameObject VfxRareReward2;

	[Token(Token = "0x4018BFA")]
	[FieldOffset(Offset = "0x54")]
	public UIButton ClaimBtn2;

	[Token(Token = "0x4018BFB")]
	[FieldOffset(Offset = "0x58")]
	public UILabel TaskNum3;

	[Token(Token = "0x4018BFC")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject UnFinish3;

	[Token(Token = "0x4018BFD")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Finished3;

	[Token(Token = "0x4018BFE")]
	[FieldOffset(Offset = "0x64")]
	public GameObject BigPrizePos3;

	[Token(Token = "0x4018BFF")]
	[FieldOffset(Offset = "0x68")]
	public UIButton ClaimBtn3;

	[Token(Token = "0x4018C00")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject VfxRareReward3;

	[Token(Token = "0x60172D5")]
	[Address(RVA = "0x2CCA8A8", Offset = "0x2CCA8A8", VA = "0x2CCA8A8")]
	public UIVeteranTaskView()
	{
	}

	[Token(Token = "0x60172D6")]
	[Address(RVA = "0x2CCA8B0", Offset = "0x2CCA8B0", VA = "0x2CCA8B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172D7")]
	[Address(RVA = "0x2CCB1FC", Offset = "0x2CCB1FC", VA = "0x2CCB1FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
