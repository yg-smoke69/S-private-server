using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F47")]
public class UIModelFFWS03 : UIBaseModel, _Attribute
{
	[Token(Token = "0x400C4A7")]
	[FieldOffset(Offset = "0xC")]
	private FFWSMiscSettingDesc m_FFWSSetting;

	[Token(Token = "0x400C4A8")]
	public const uint PropID_GetMiscSetting = 2u;

	[Token(Token = "0x6009A82")]
	[Address(RVA = "0xFC4864", Offset = "0xFC4864", VA = "0xFC4864")]
	public UIModelFFWS03()
	{
	}

	[Token(Token = "0x6009A83")]
	[Address(RVA = "0xFC48E8", Offset = "0xFC48E8", VA = "0xFC48E8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6009A84")]
	[Address(RVA = "0xFC4940", Offset = "0xFC4940", VA = "0xFC4940", Slot = "15")]
	public UIBigEventLobbyEnterWndControler GetBigEventLobbyEnterWnd()
	{
		return null;
	}

	[Token(Token = "0x6009A85")]
	[Address(RVA = "0xFC4A50", Offset = "0xFC4A50", VA = "0xFC4A50", Slot = "14")]
	public void OnProcessEventOpenInfo()
	{
	}

	[Token(Token = "0x6009A86")]
	[Address(RVA = "0xFC4E10", Offset = "0xFC4E10", VA = "0xFC4E10")]
	public FFWSMiscSettingDesc GetMiscSetting()
	{
		return null;
	}

	[Token(Token = "0x6009A87")]
	[Address(RVA = "0xFC4BA8", Offset = "0xFC4BA8", VA = "0xFC4BA8")]
	public void RequestMiscSetting()
	{
	}

	[Token(Token = "0x6009A88")]
	[Address(RVA = "0xFC4E68", Offset = "0xFC4E68", VA = "0xFC4E68")]
	public bool IsExchangeStoreLocked(uint storeId)
	{
		return default(bool);
	}

	[Token(Token = "0x6009A89")]
	[Address(RVA = "0xFC5044", Offset = "0xFC5044", VA = "0xFC5044")]
	public bool IsInMatchLive()
	{
		return default(bool);
	}

	[Token(Token = "0x6009A8A")]
	[Address(RVA = "0xFC5178", Offset = "0xFC5178", VA = "0xFC5178")]
	public bool IsInMatchTeamShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6009A8B")]
	[Address(RVA = "0xFC52AC", Offset = "0xFC52AC", VA = "0xFC52AC")]
	public bool IsInMatchGuess()
	{
		return default(bool);
	}

	[Token(Token = "0x6009A8C")]
	[Address(RVA = "0xFC53B8", Offset = "0xFC53B8", VA = "0xFC53B8")]
	public bool CanClaimReward()
	{
		return default(bool);
	}

	[Token(Token = "0x6009A8D")]
	[Address(RVA = "0xFC54C4", Offset = "0xFC54C4", VA = "0xFC54C4", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6009A8E")]
	[Address(RVA = "0xFC553C", Offset = "0xFC553C", VA = "0xFC553C")]
	private void _003CRequestMiscSetting_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6009A8F")]
	[Address(RVA = "0xFC5678", Offset = "0xFC5678", VA = "0xFC5678")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
