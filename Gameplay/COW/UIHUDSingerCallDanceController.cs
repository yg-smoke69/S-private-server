using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023A3")]
public class UIHUDSingerCallDanceController : UIBaseController
{
	[Token(Token = "0x400DDF4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] _PhotoPermissions;

	[Token(Token = "0x400DDF5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSingerCallDanceView m_view;

	[Token(Token = "0x400DDF6")]
	[FieldOffset(Offset = "0x30")]
	private ulong m_PreUIGroup;

	[Token(Token = "0x400DDF7")]
	[FieldOffset(Offset = "0x38")]
	private Texture2D m_screenShotTex;

	[Token(Token = "0x400DDF8")]
	[FieldOffset(Offset = "0x3C")]
	private uint countDownCallId;

	[Token(Token = "0x400DDF9")]
	[FieldOffset(Offset = "0x40")]
	private int closeSmallCardCountDown;

	[Token(Token = "0x400DDFA")]
	[FieldOffset(Offset = "0x44")]
	private uint screenShotCallId;

	[Token(Token = "0x600C858")]
	[Address(RVA = "0x220F658", Offset = "0x220F658", VA = "0x220F658")]
	public UIHUDSingerCallDanceController()
	{
	}

	[Token(Token = "0x600C859")]
	[Address(RVA = "0x220F730", Offset = "0x220F730", VA = "0x220F730")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C85A")]
	[Address(RVA = "0x220F7D8", Offset = "0x220F7D8", VA = "0x220F7D8")]
	public void CallDance()
	{
	}

	[Token(Token = "0x600C85B")]
	[Address(RVA = "0x220F964", Offset = "0x220F964", VA = "0x220F964")]
	public void ScreenShot()
	{
	}

	[Token(Token = "0x600C85C")]
	[Address(RVA = "0x220FB08", Offset = "0x220FB08", VA = "0x220FB08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C85D")]
	[Address(RVA = "0x220FDA0", Offset = "0x220FDA0", VA = "0x220FDA0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C85E")]
	[Address(RVA = "0x2210158", Offset = "0x2210158", VA = "0x2210158", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600C85F")]
	[Address(RVA = "0x2210298", Offset = "0x2210298", VA = "0x2210298", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600C860")]
	[Address(RVA = "0x22103B0", Offset = "0x22103B0", VA = "0x22103B0")]
	private void DoScreenShot()
	{
	}

	[Token(Token = "0x600C861")]
	[Address(RVA = "0x2210610", Offset = "0x2210610", VA = "0x2210610")]
	private void OnScreenShotFinish(Texture2D tex)
	{
	}

	[Token(Token = "0x600C862")]
	[Address(RVA = "0x221083C", Offset = "0x221083C", VA = "0x221083C")]
	private void _ScreenShotFinish()
	{
	}

	[Token(Token = "0x600C863")]
	[Address(RVA = "0x2210AD8", Offset = "0x2210AD8", VA = "0x2210AD8")]
	private void CountDownCloseSmallCard()
	{
	}

	[Token(Token = "0x600C864")]
	[Address(RVA = "0x2210D2C", Offset = "0x2210D2C", VA = "0x2210D2C")]
	private void OnClickNoBtn()
	{
	}

	[Token(Token = "0x600C865")]
	[Address(RVA = "0x2210D98", Offset = "0x2210D98", VA = "0x2210D98")]
	private void OnClickYesBtn()
	{
	}

	[Token(Token = "0x600C866")]
	[Address(RVA = "0x2210E0C", Offset = "0x2210E0C", VA = "0x2210E0C")]
	private void SaveScreenShot()
	{
	}

	[Token(Token = "0x600C867")]
	[Address(RVA = "0x2211014", Offset = "0x2211014", VA = "0x2211014")]
	private void OnImageSaveToAlbumDone(string error)
	{
	}

	[Token(Token = "0x600C868")]
	[Address(RVA = "0x2210C94", Offset = "0x2210C94", VA = "0x2210C94")]
	private void CloseSmallCard()
	{
	}

	[Token(Token = "0x600C869")]
	[Address(RVA = "0x2210038", Offset = "0x2210038", VA = "0x2210038")]
	private void DestroyScreenShot()
	{
	}

	[Token(Token = "0x600C86B")]
	[Address(RVA = "0x2211470", Offset = "0x2211470", VA = "0x2211470")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C86C")]
	[Address(RVA = "0x2211478", Offset = "0x2211478", VA = "0x2211478")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600C86D")]
	[Address(RVA = "0x2211480", Offset = "0x2211480", VA = "0x2211480")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600C86E")]
	[Address(RVA = "0x2211488", Offset = "0x2211488", VA = "0x2211488")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
