using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003426")]
public class UIChampionshipWarmUpView : UIBaseView
{
	[Token(Token = "0x40142AB")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnRule;

	[Token(Token = "0x40142AC")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x40142AD")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TitleDesc;

	[Token(Token = "0x40142AE")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CDNIcon;

	[Token(Token = "0x40142AF")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture CDNTexture;

	[Token(Token = "0x40142B0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DefaultIcon;

	[Token(Token = "0x40142B1")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel OpenDateDesc;

	[Token(Token = "0x6016026")]
	[Address(RVA = "0x2625D2C", Offset = "0x2625D2C", VA = "0x2625D2C")]
	public UIChampionshipWarmUpView()
	{
	}

	[Token(Token = "0x6016027")]
	[Address(RVA = "0x2625D34", Offset = "0x2625D34", VA = "0x2625D34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016028")]
	[Address(RVA = "0x2626104", Offset = "0x2626104", VA = "0x2626104")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
