using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034AF")]
public class UIDailyBonusView : UIBaseView
{
	[Token(Token = "0x40149B5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton TipsBtn;

	[Token(Token = "0x40149B6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ExpBonus;

	[Token(Token = "0x40149B7")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GoldBonus;

	[Token(Token = "0x40149B8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ExpBonusAchieved;

	[Token(Token = "0x40149B9")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GoldBonusAchieved;

	[Token(Token = "0x60161C1")]
	[Address(RVA = "0x11F0C2C", Offset = "0x11F0C2C", VA = "0x11F0C2C")]
	public UIDailyBonusView()
	{
	}

	[Token(Token = "0x60161C2")]
	[Address(RVA = "0x11F0C34", Offset = "0x11F0C34", VA = "0x11F0C34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161C3")]
	[Address(RVA = "0x11F0F2C", Offset = "0x11F0F2C", VA = "0x11F0F2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
