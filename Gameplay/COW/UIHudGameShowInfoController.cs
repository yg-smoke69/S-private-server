using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002760")]
internal class UIHudGameShowInfoController : UIBaseController
{
	[Token(Token = "0x400F322")]
	[FieldOffset(Offset = "0x28")]
	private uint m_ShowinfodelayCall;

	[Token(Token = "0x400F323")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudGameShowInfoView m_View;

	[Token(Token = "0x400F324")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<int, UIHudGameShowInfoStyleController> m_StyleCtrlDict;

	[Token(Token = "0x600F092")]
	[Address(RVA = "0x188CDA8", Offset = "0x188CDA8", VA = "0x188CDA8")]
	public UIHudGameShowInfoController()
	{
	}

	[Token(Token = "0x600F093")]
	[Address(RVA = "0x188CE60", Offset = "0x188CE60", VA = "0x188CE60")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F094")]
	[Address(RVA = "0x188CF08", Offset = "0x188CF08", VA = "0x188CF08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F095")]
	[Address(RVA = "0x188CFC4", Offset = "0x188CFC4", VA = "0x188CFC4")]
	public void SetUIdata(EGameShowStyle style, string introKey = "", string introDeatil = "", float duration = 2f)
	{
	}

	[Token(Token = "0x600F096")]
	[Address(RVA = "0x188DA84", Offset = "0x188DA84", VA = "0x188DA84", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600F097")]
	[Address(RVA = "0x188DBA0", Offset = "0x188DBA0", VA = "0x188DBA0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F098")]
	[Address(RVA = "0x188DCBC", Offset = "0x188DCBC", VA = "0x188DCBC")]
	public void DebugShowInfo()
	{
	}

	[Token(Token = "0x600F099")]
	[Address(RVA = "0x188DDB8", Offset = "0x188DDB8", VA = "0x188DDB8")]
	private void _003CSetUIdata_003Em__0()
	{
	}

	[Token(Token = "0x600F09A")]
	[Address(RVA = "0x188DDC8", Offset = "0x188DDC8", VA = "0x188DDC8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F09B")]
	[Address(RVA = "0x188DDD0", Offset = "0x188DDD0", VA = "0x188DDD0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600F09C")]
	[Address(RVA = "0x188DDD8", Offset = "0x188DDD8", VA = "0x188DDD8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
