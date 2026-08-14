using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2002705")]
internal class UIHudCatagoryRangeShopController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002706")]
	private sealed class FGDDBJCLGEH
	{
		[Token(Token = "0x400F0EB")]
		[FieldOffset(Offset = "0x8")]
		internal uint EMCPCCILIGF;

		[Token(Token = "0x600ED15")]
		[Address(RVA = "0xF7339C", Offset = "0xF7339C", VA = "0xF7339C")]
		public FGDDBJCLGEH()
		{
		}

		[Token(Token = "0x600ED16")]
		[Address(RVA = "0xF747AC", Offset = "0xF747AC", VA = "0xF747AC")]
		internal bool CHOPCLCOBKC(KEDNMNBLODN NHJNFPKBBLI)
		{
			return default(bool);
		}

		[Token(Token = "0x600ED17")]
		[Address(RVA = "0xF747E4", Offset = "0xF747E4", VA = "0xF747E4")]
		internal bool HJGBDJENEAM(UIHudRangeShopItemController NHJNFPKBBLI)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400F0E5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCatagoryRangeShopView NOJLDPLOCIH;

	[Token(Token = "0x400F0E6")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIHudRangeShopItemController> DCBCJLPFHAD;

	[Token(Token = "0x400F0E7")]
	[FieldOffset(Offset = "0x30")]
	private KEDNMNBLODN FPHONGFBDFA;

	[Token(Token = "0x400F0E8")]
	[FieldOffset(Offset = "0x34")]
	private OJCOOJEIJPD CNFJOAPOHHG;

	[Token(Token = "0x400F0E9")]
	[FieldOffset(Offset = "0x38")]
	private List<KEDNMNBLODN> PPAIGNGFNBO;

	[Token(Token = "0x400F0EA")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<KEDNMNBLODN> HMDOHFBHDOB;

	[Token(Token = "0x600ED00")]
	[Address(RVA = "0xF70BF4", Offset = "0xF70BF4", VA = "0xF70BF4")]
	public UIHudCatagoryRangeShopController()
	{
	}

	[Token(Token = "0x600ED01")]
	[Address(RVA = "0xF70D04", Offset = "0xF70D04", VA = "0xF70D04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ED02")]
	[Address(RVA = "0xF70DA8", Offset = "0xF70DA8", VA = "0xF70DA8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ED03")]
	[Address(RVA = "0xF71524", Offset = "0xF71524", VA = "0xF71524")]
	private bool CDPKOMIDIIK()
	{
		return default(bool);
	}

	[Token(Token = "0x600ED04")]
	[Address(RVA = "0xF715B8", Offset = "0xF715B8", VA = "0xF715B8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600ED05")]
	[Address(RVA = "0xF7194C", Offset = "0xF7194C", VA = "0xF7194C")]
	public void InitData(List<KEDNMNBLODN> JMHKDJDCIEH, uint POOPHEIGELJ, OJCOOJEIJPD NOCECPGIDFD, ENNMDCLGJPA OBFAABIKBCM)
	{
	}

	[Token(Token = "0x600ED06")]
	[Address(RVA = "0xF72368", Offset = "0xF72368", VA = "0xF72368")]
	private void FMOMFGKILKH(OJCOOJEIJPD NOCECPGIDFD, ENNMDCLGJPA OBFAABIKBCM)
	{
	}

	[Token(Token = "0x600ED07")]
	[Address(RVA = "0xF72FAC", Offset = "0xF72FAC", VA = "0xF72FAC")]
	private void HBHOCPNGKAL(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600ED08")]
	[Address(RVA = "0xF73120", Offset = "0xF73120", VA = "0xF73120")]
	private void AIJGHNLNLJP(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600ED09")]
	[Address(RVA = "0xF733A4", Offset = "0xF733A4", VA = "0xF733A4")]
	private void JCCCAIFJEDB(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600ED0A")]
	[Address(RVA = "0xF72CAC", Offset = "0xF72CAC", VA = "0xF72CAC")]
	private void BNPJNPNKPIO(uint POOPHEIGELJ, List<KEDNMNBLODN> FCIOJOOOAPF)
	{
	}

	[Token(Token = "0x600ED0B")]
	[Address(RVA = "0xF7353C", Offset = "0xF7353C", VA = "0xF7353C")]
	private void KLHIDIOCIPA(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600ED0C")]
	[Address(RVA = "0xF7397C", Offset = "0xF7397C", VA = "0xF7397C")]
	private void GCPNLEDBIEB()
	{
	}

	[Token(Token = "0x600ED0D")]
	[Address(RVA = "0xF74130", Offset = "0xF74130", VA = "0xF74130", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform PHLFBBIAEFE)
	{
		return null;
	}

	[Token(Token = "0x600ED0E")]
	[Address(RVA = "0xF74228", Offset = "0xF74228", VA = "0xF74228", Slot = "32")]
	public void CloseItemController(UIEasyListItemController NIJJNDAMKCD)
	{
	}

	[Token(Token = "0x600ED0F")]
	[Address(RVA = "0xF742A4", Offset = "0xF742A4", VA = "0xF742A4", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600ED10")]
	[Address(RVA = "0xF74580", Offset = "0xF74580", VA = "0xF74580")]
	private void EMLLAJDCEHN()
	{
	}

	[Token(Token = "0x600ED11")]
	[Address(RVA = "0xF74704", Offset = "0xF74704", VA = "0xF74704")]
	private static int LNANDOKKPKA(KEDNMNBLODN AAFBIANMEAL, KEDNMNBLODN KENDCFNPDCE)
	{
		return default(int);
	}

	[Token(Token = "0x600ED12")]
	[Address(RVA = "0xF74794", Offset = "0xF74794", VA = "0xF74794")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ED13")]
	[Address(RVA = "0xF7479C", Offset = "0xF7479C", VA = "0xF7479C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600ED14")]
	[Address(RVA = "0xF747A4", Offset = "0xF747A4", VA = "0xF747A4")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
