using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003254")]
public class UIModelShare : UIBaseModel
{
	[Token(Token = "0x4013253")]
	private const string FALLBACK_INVITE_STR = "http://www.freefiremobile.com/mobile/ff/deeplink";

	[Token(Token = "0x4013254")]
	[FieldOffset(Offset = "0xC")]
	private List<ShareSettingDesc> m_ShareSettingList;

	[Token(Token = "0x60153A2")]
	[Address(RVA = "0x30EE31C", Offset = "0x30EE31C", VA = "0x30EE31C")]
	public UIModelShare()
	{
	}

	[Token(Token = "0x60153A3")]
	[Address(RVA = "0x30EE3A0", Offset = "0x30EE3A0", VA = "0x30EE3A0", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60153A4")]
	[Address(RVA = "0x30EE3F8", Offset = "0x30EE3F8", VA = "0x30EE3F8")]
	private string ModifyContentKey(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return null;
	}

	[Token(Token = "0x60153A5")]
	[Address(RVA = "0x30EEF68", Offset = "0x30EEF68", VA = "0x30EEF68")]
	private static string MakeInviteUrl(UIUtils.ShareUrlType shareUrlType, string url)
	{
		return null;
	}

	[Token(Token = "0x60153A6")]
	[Address(RVA = "0x30EF608", Offset = "0x30EF608", VA = "0x30EF608")]
	private static bool CheckIsValidToShare(UIUtils.ShareUrlType shareUrlType)
	{
		return default(bool);
	}

	[Token(Token = "0x60153A7")]
	[Address(RVA = "0x30EF844", Offset = "0x30EF844", VA = "0x30EF844")]
	internal bool ShareLine(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return default(bool);
	}

	[Token(Token = "0x60153A8")]
	[Address(RVA = "0x30EFCA4", Offset = "0x30EFCA4", VA = "0x30EFCA4")]
	internal bool ShareLoginPlatform(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return default(bool);
	}

	[Token(Token = "0x60153A9")]
	[Address(RVA = "0x30F02E4", Offset = "0x30F02E4", VA = "0x30F02E4")]
	internal bool ShareOther(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return default(bool);
	}

	[Token(Token = "0x60153AA")]
	[Address(RVA = "0x30F0684", Offset = "0x30F0684", VA = "0x30F0684")]
	internal bool ShareCopyLink(UIUtils.ShareUrlType shareUrlType)
	{
		return default(bool);
	}

	[Token(Token = "0x60153AB")]
	[Address(RVA = "0x30F0A1C", Offset = "0x30F0A1C", VA = "0x30F0A1C")]
	public void ProcessShareSetting(CSShareSettingDescRes res)
	{
	}

	[Token(Token = "0x60153AC")]
	[Address(RVA = "0x30EEDB4", Offset = "0x30EEDB4", VA = "0x30EEDB4")]
	public ShareSettingDesc GetShareSetting(uint shareID)
	{
		return null;
	}

	[Token(Token = "0x60153AD")]
	[Address(RVA = "0x30F0C70", Offset = "0x30F0C70", VA = "0x30F0C70", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60153AE")]
	[Address(RVA = "0x30F0618", Offset = "0x30F0618", VA = "0x30F0618")]
	public static string GetSystemTextKey(ShareSettingDesc data)
	{
		return null;
	}

	[Token(Token = "0x60153AF")]
	[Address(RVA = "0x30F0CE8", Offset = "0x30F0CE8", VA = "0x30F0CE8")]
	public static string MakeInviteUrl(uint shareType, string url)
	{
		return null;
	}

	[Token(Token = "0x60153B0")]
	[Address(RVA = "0x30F0D54", Offset = "0x30F0D54", VA = "0x30F0D54")]
	public void ShareActivity(EActivity.Event shareEvent)
	{
	}

	[Token(Token = "0x60153B1")]
	[Address(RVA = "0x30F0FC4", Offset = "0x30F0FC4", VA = "0x30F0FC4")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
