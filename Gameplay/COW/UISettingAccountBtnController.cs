using System.Collections.Generic;
using GCommon;
using GarenaMSDK;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B19")]
internal class UISettingAccountBtnController : UIBaseController
{
	[Token(Token = "0x4010862")]
	[FieldOffset(Offset = "0x0")]
	public static List<int> SpriteList;

	[Token(Token = "0x4010863")]
	[FieldOffset(Offset = "0x28")]
	private UIModelLogin m_LoginModel;

	[Token(Token = "0x4010864")]
	[FieldOffset(Offset = "0x4")]
	public static Dictionary<int, string> SpriteMap;

	[Token(Token = "0x4010865")]
	[FieldOffset(Offset = "0x2C")]
	private AccountPlatform m_Type;

	[Token(Token = "0x4010866")]
	[FieldOffset(Offset = "0x30")]
	private UISettingAccountBtnView m_View;

	[Token(Token = "0x4010867")]
	[FieldOffset(Offset = "0x8")]
	private static Callback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6011B7E")]
	[Address(RVA = "0x1A55100", Offset = "0x1A55100", VA = "0x1A55100")]
	public UISettingAccountBtnController()
	{
	}

	[Token(Token = "0x6011B7F")]
	[Address(RVA = "0x1A55184", Offset = "0x1A55184", VA = "0x1A55184")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011B80")]
	[Address(RVA = "0x1A5522C", Offset = "0x1A5522C", VA = "0x1A5522C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011B81")]
	[Address(RVA = "0x1A55358", Offset = "0x1A55358", VA = "0x1A55358")]
	public void SetViewData(AccountPlatform type)
	{
	}

	[Token(Token = "0x6011B82")]
	[Address(RVA = "0x1A55704", Offset = "0x1A55704", VA = "0x1A55704")]
	private void RefreshBindIcon()
	{
	}

	[Token(Token = "0x6011B83")]
	[Address(RVA = "0x1A55B10", Offset = "0x1A55B10", VA = "0x1A55B10")]
	private void OnHuaweiBindClick()
	{
	}

	[Token(Token = "0x6011B84")]
	[Address(RVA = "0x1A55BEC", Offset = "0x1A55BEC", VA = "0x1A55BEC")]
	private void OnGoogleBindClick()
	{
	}

	[Token(Token = "0x6011B86")]
	[Address(RVA = "0x1A56094", Offset = "0x1A56094", VA = "0x1A56094")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x6011B87")]
	[Address(RVA = "0x1A560C8", Offset = "0x1A560C8", VA = "0x1A560C8")]
	private static void _003CRefreshBindIcon_003Em__1()
	{
	}

	[Token(Token = "0x6011B88")]
	[Address(RVA = "0x1A5620C", Offset = "0x1A5620C", VA = "0x1A5620C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
