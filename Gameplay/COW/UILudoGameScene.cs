using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003327")]
internal class UILudoGameScene : UIInGameScene
{
	[Token(Token = "0x40137ED")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudLudoGameCountDownTipController m_CountDownCtrl;

	[Token(Token = "0x40137EE")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudModeIntroInfoController m_GameIntroCtrl;

	[Token(Token = "0x40137EF")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6015A9B")]
	[Address(RVA = "0x18D0AE0", Offset = "0x18D0AE0", VA = "0x18D0AE0")]
	public UILudoGameScene()
	{
	}

	[Token(Token = "0x6015A9C")]
	[Address(RVA = "0x18D0B64", Offset = "0x18D0B64", VA = "0x18D0B64", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015A9D")]
	[Address(RVA = "0x18D0D00", Offset = "0x18D0D00", VA = "0x18D0D00", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015A9E")]
	[Address(RVA = "0x18D0D64", Offset = "0x18D0D64", VA = "0x18D0D64", Slot = "17")]
	public override void OpenHud()
	{
	}

	[Token(Token = "0x6015A9F")]
	[Address(RVA = "0x18D0EE0", Offset = "0x18D0EE0", VA = "0x18D0EE0", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015AA0")]
	[Address(RVA = "0x18D13C0", Offset = "0x18D13C0", VA = "0x18D13C0", Slot = "29")]
	protected override bool IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x6015AA1")]
	[Address(RVA = "0x18D12B0", Offset = "0x18D12B0", VA = "0x18D12B0")]
	private void OpenMatchInfo()
	{
	}

	[Token(Token = "0x6015AA2")]
	[Address(RVA = "0x18D1418", Offset = "0x18D1418", VA = "0x18D1418", Slot = "22")]
	protected override void OnHudSettingChanged(object[] param)
	{
	}

	[Token(Token = "0x6015AA3")]
	[Address(RVA = "0x18D1474", Offset = "0x18D1474", VA = "0x18D1474")]
	private void OnLudoFinish(object[] data)
	{
	}

	[Token(Token = "0x6015AA4")]
	[Address(RVA = "0x18D16F0", Offset = "0x18D16F0", VA = "0x18D16F0")]
	private void OnLudoStateChange(object[] data)
	{
	}

	[Token(Token = "0x6015AA5")]
	[Address(RVA = "0x18D1EA8", Offset = "0x18D1EA8", VA = "0x18D1EA8", Slot = "44")]
	public override ResourceID GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015AA6")]
	[Address(RVA = "0x18D1F54", Offset = "0x18D1F54", VA = "0x18D1F54")]
	public void OpenMatchResult()
	{
	}

	[Token(Token = "0x6015AA7")]
	[Address(RVA = "0x18D20EC", Offset = "0x18D20EC", VA = "0x18D20EC")]
	private static void _003COnLudoStateChange_003Em__0()
	{
	}

	[Token(Token = "0x6015AA8")]
	[Address(RVA = "0x18D21D0", Offset = "0x18D21D0", VA = "0x18D21D0")]
	private void _003COnLudoStateChange_003Em__1()
	{
	}

	[Token(Token = "0x6015AA9")]
	[Address(RVA = "0x18D2240", Offset = "0x18D2240", VA = "0x18D2240")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015AAA")]
	[Address(RVA = "0x18D2248", Offset = "0x18D2248", VA = "0x18D2248")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015AAB")]
	[Address(RVA = "0x18D2250", Offset = "0x18D2250", VA = "0x18D2250")]
	public void _003C_003EiFixBaseProxy_OpenHud()
	{
	}

	[Token(Token = "0x6015AAC")]
	[Address(RVA = "0x18D2258", Offset = "0x18D2258", VA = "0x18D2258")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015AAD")]
	[Address(RVA = "0x18D2260", Offset = "0x18D2260", VA = "0x18D2260")]
	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x6015AAE")]
	[Address(RVA = "0x18D2268", Offset = "0x18D2268", VA = "0x18D2268")]
	public void _003C_003EiFixBaseProxy_OnHudSettingChanged(object[] P0)
	{
	}

	[Token(Token = "0x6015AAF")]
	[Address(RVA = "0x18D2270", Offset = "0x18D2270", VA = "0x18D2270")]
	public ResourceID _003C_003EiFixBaseProxy_GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}
}
