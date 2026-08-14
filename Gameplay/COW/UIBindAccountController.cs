using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using GarenaMSDK;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20021AC")]
public class UIBindAccountController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400D2EA")]
	[FieldOffset(Offset = "0x48")]
	private UIBindAccountView m_View;

	[Token(Token = "0x400D2EB")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelLogin m_ModelLogin;

	[Token(Token = "0x400D2EC")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<int, bool> m_PlatformNeedShowOutOfMore;

	[Token(Token = "0x400D2ED")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<int, bool> m_PlatformSupportSignin;

	[Token(Token = "0x400D2EE")]
	[FieldOffset(Offset = "0x0")]
	private static SDKBind.GetBindSessionFaildCb _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600B302")]
	[Address(RVA = "0x10D46A0", Offset = "0x10D46A0", VA = "0x10D46A0")]
	public UIBindAccountController()
	{
	}

	[Token(Token = "0x600B303")]
	[Address(RVA = "0x10D46A8", Offset = "0x10D46A8", VA = "0x10D46A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B304")]
	[Address(RVA = "0x10D4CD0", Offset = "0x10D4CD0", VA = "0x10D4CD0")]
	private void InitPlatformBtns()
	{
	}

	[Token(Token = "0x600B305")]
	[Address(RVA = "0x10D5808", Offset = "0x10D5808", VA = "0x10D5808", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B306")]
	[Address(RVA = "0x10D592C", Offset = "0x10D592C", VA = "0x10D592C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B307")]
	[Address(RVA = "0x10D59D4", Offset = "0x10D59D4", VA = "0x10D59D4", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B308")]
	[Address(RVA = "0x10D5A68", Offset = "0x10D5A68", VA = "0x10D5A68", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B309")]
	[Address(RVA = "0x10D5030", Offset = "0x10D5030", VA = "0x10D5030")]
	private void SetCDNTexture()
	{
	}

	[Token(Token = "0x600B30A")]
	[Address(RVA = "0x10D5C54", Offset = "0x10D5C54", VA = "0x10D5C54")]
	public void SetShowLabel(bool isGameModeCall, [Optional] string labelInfo, int guestRank = 0, int normalRank = 0)
	{
	}

	[Token(Token = "0x600B30B")]
	[Address(RVA = "0x10D5264", Offset = "0x10D5264", VA = "0x10D5264")]
	public void ShowAwardItem()
	{
	}

	[Token(Token = "0x600B30C")]
	[Address(RVA = "0x10D60E0", Offset = "0x10D60E0", VA = "0x10D60E0")]
	private void Bind(PlatformType platform)
	{
	}

	[Token(Token = "0x600B30D")]
	[Address(RVA = "0x10D61F4", Offset = "0x10D61F4", VA = "0x10D61F4")]
	private void BindGarena(PlatformType platform)
	{
	}

	[Token(Token = "0x600B30E")]
	[Address(RVA = "0x10D63B4", Offset = "0x10D63B4", VA = "0x10D63B4")]
	private void PlatformLoginDone(PlatformType platformType, string userId, string accessToken)
	{
	}

	[Token(Token = "0x600B30F")]
	[Address(RVA = "0x10D6640", Offset = "0x10D6640", VA = "0x10D6640")]
	private void OnFacebookBindClick()
	{
	}

	[Token(Token = "0x600B310")]
	[Address(RVA = "0x10D66A4", Offset = "0x10D66A4", VA = "0x10D66A4")]
	private void OnVKontakteBindClick()
	{
	}

	[Token(Token = "0x600B311")]
	[Address(RVA = "0x10D6708", Offset = "0x10D6708", VA = "0x10D6708")]
	private void OnHuaweiBindClick()
	{
	}

	[Token(Token = "0x600B312")]
	[Address(RVA = "0x10D67E4", Offset = "0x10D67E4", VA = "0x10D67E4")]
	private void OnGoogleBindClick()
	{
	}

	[Token(Token = "0x600B313")]
	[Address(RVA = "0x10D6848", Offset = "0x10D6848", VA = "0x10D6848")]
	private void OnAppleBindClick()
	{
	}

	[Token(Token = "0x600B314")]
	[Address(RVA = "0x10D68AC", Offset = "0x10D68AC", VA = "0x10D68AC")]
	private void OnTwitterBindClick()
	{
	}

	[Token(Token = "0x600B315")]
	[Address(RVA = "0x10D6910", Offset = "0x10D6910", VA = "0x10D6910")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600B316")]
	[Address(RVA = "0x10D4C30", Offset = "0x10D4C30", VA = "0x10D4C30")]
	private void InitBindPlatformDict()
	{
	}

	[Token(Token = "0x600B317")]
	[Address(RVA = "0x10D6974", Offset = "0x10D6974", VA = "0x10D6974")]
	private void CheckPlatformBtnState(PlatformType platformType)
	{
	}

	[Token(Token = "0x600B318")]
	[Address(RVA = "0x10D5660", Offset = "0x10D5660", VA = "0x10D5660")]
	private bool CheckPlatformBindBtnCanShow(bool showOutOfMore, PlatformType platformType)
	{
		return default(bool);
	}

	[Token(Token = "0x600B319")]
	[Address(RVA = "0x10D6B48", Offset = "0x10D6B48", VA = "0x10D6B48")]
	private void OnPlatformCombinedBtnClick()
	{
	}

	[Token(Token = "0x600B31A")]
	[Address(RVA = "0x10D6D4C", Offset = "0x10D6D4C", VA = "0x10D6D4C")]
	private void _003CBindGarena_003Em__0(BindSessionRsp rsp)
	{
	}

	[Token(Token = "0x600B31B")]
	[Address(RVA = "0x10D6DB8", Offset = "0x10D6DB8", VA = "0x10D6DB8")]
	private static void _003CBindGarena_003Em__1(ErrorCode errCode)
	{
	}

	[Token(Token = "0x600B31C")]
	[Address(RVA = "0x10D72DC", Offset = "0x10D72DC", VA = "0x10D72DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B31D")]
	[Address(RVA = "0x10D72E4", Offset = "0x10D72E4", VA = "0x10D72E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
