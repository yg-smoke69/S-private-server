using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003270")]
public class UIModelSplashBanner : UIBaseModel
{
	[Token(Token = "0x401331D")]
	public const uint PropID_SplashBannerRetOK = 2u;

	[Token(Token = "0x401331E")]
	public const uint PropID_SplashBannerRetFail = 4u;

	[Token(Token = "0x401331F")]
	public const uint PropID_SplashBannerRetEmpty = 4u;

	[Token(Token = "0x4013320")]
	public const uint PropID_SplashBannerGetInfo = 8u;

	[Token(Token = "0x4013321")]
	[FieldOffset(Offset = "0xC")]
	private List<SplashBannerInfo> m_SplashBannerDataList;

	[Token(Token = "0x4013322")]
	[FieldOffset(Offset = "0x10")]
	private bool _003CIsSplanBannerShowed_003Ek__BackingField;

	[Token(Token = "0x4013323")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<SplashBannerInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700166C")]
	public List<SplashBannerInfo> SplashBannerDataList
	{
		[Token(Token = "0x6015454")]
		[Address(RVA = "0x168AB20", Offset = "0x168AB20", VA = "0x168AB20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700166D")]
	public bool IsSplanBannerShowed
	{
		[Token(Token = "0x6015455")]
		[Address(RVA = "0x168AB78", Offset = "0x168AB78", VA = "0x168AB78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6015456")]
		[Address(RVA = "0x168AB80", Offset = "0x168AB80", VA = "0x168AB80")]
		set
		{
		}
	}

	[Token(Token = "0x6015452")]
	[Address(RVA = "0x168AA10", Offset = "0x168AA10", VA = "0x168AA10")]
	public UIModelSplashBanner()
	{
	}

	[Token(Token = "0x6015453")]
	[Address(RVA = "0x168AAC8", Offset = "0x168AAC8", VA = "0x168AAC8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015457")]
	[Address(RVA = "0x168AB88", Offset = "0x168AB88", VA = "0x168AB88", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6015458")]
	[Address(RVA = "0x168AC00", Offset = "0x168AC00", VA = "0x168AC00")]
	public HttpRequest RequestSplashBannerData()
	{
		return null;
	}

	[Token(Token = "0x6015459")]
	[Address(RVA = "0x168AD3C", Offset = "0x168AD3C", VA = "0x168AD3C")]
	public void SetSplashBannerData(HttpErrorCode errorCode, SplashBannerDescList res)
	{
	}

	[Token(Token = "0x601545A")]
	[Address(RVA = "0x168B8CC", Offset = "0x168B8CC", VA = "0x168B8CC")]
	private void RandomPickSplashBannerByWeight(int maxCount, List<SplashBannerDesc> splashBanners)
	{
	}

	[Token(Token = "0x601545B")]
	[Address(RVA = "0x168BF50", Offset = "0x168BF50", VA = "0x168BF50")]
	public SplashBannerInfo GetUnShowedSplash()
	{
		return null;
	}

	[Token(Token = "0x601545C")]
	[Address(RVA = "0x168B39C", Offset = "0x168B39C", VA = "0x168B39C")]
	public bool HaveShowedWebViewBannerToday()
	{
		return default(bool);
	}

	[Token(Token = "0x601545D")]
	[Address(RVA = "0x168C104", Offset = "0x168C104", VA = "0x168C104")]
	public void SetShowWebViewSplashBannerTime()
	{
	}

	[Token(Token = "0x601545E")]
	[Address(RVA = "0x168B5A8", Offset = "0x168B5A8", VA = "0x168B5A8")]
	public bool CheckCanShowByAccountID(string lastNums)
	{
		return default(bool);
	}

	[Token(Token = "0x601545F")]
	[Address(RVA = "0x168C2F0", Offset = "0x168C2F0", VA = "0x168C2F0")]
	private static int _003CSetSplashBannerData_003Em__0(SplashBannerInfo a, SplashBannerInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6015460")]
	[Address(RVA = "0x168C338", Offset = "0x168C338", VA = "0x168C338")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
