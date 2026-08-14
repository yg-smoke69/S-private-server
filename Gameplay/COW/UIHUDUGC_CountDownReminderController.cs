using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200244A")]
public class UIHUDUGC_CountDownReminderController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E18A")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_CountDownReminderView m_View;

	[Token(Token = "0x400E18B")]
	[FieldOffset(Offset = "0x2C")]
	private CountdownReminderHudEntity m_ViewData;

	[Token(Token = "0x400E18C")]
	[FieldOffset(Offset = "0x30")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400E18D")]
	[FieldOffset(Offset = "0x34")]
	private string m_EntityID;

	[Token(Token = "0x400E18E")]
	[FieldOffset(Offset = "0x38")]
	private int m_LastSeconds;

	[Token(Token = "0x600CDFE")]
	[Address(RVA = "0x2229AF0", Offset = "0x2229AF0", VA = "0x2229AF0")]
	public UIHUDUGC_CountDownReminderController()
	{
	}

	[Token(Token = "0x600CDFF")]
	[Address(RVA = "0x2229B7C", Offset = "0x2229B7C", VA = "0x2229B7C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CE00")]
	[Address(RVA = "0x2229C24", Offset = "0x2229C24", VA = "0x2229C24", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CE01")]
	[Address(RVA = "0x2229D88", Offset = "0x2229D88", VA = "0x2229D88", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CE02")]
	[Address(RVA = "0x2229E68", Offset = "0x2229E68", VA = "0x2229E68")]
	private void Update()
	{
	}

	[Token(Token = "0x600CE03")]
	[Address(RVA = "0x222A008", Offset = "0x222A008", VA = "0x222A008", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CE04")]
	[Address(RVA = "0x2229DF4", Offset = "0x2229DF4", VA = "0x2229DF4", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CE05")]
	[Address(RVA = "0x222A298", Offset = "0x222A298", VA = "0x222A298")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CE06")]
	[Address(RVA = "0x222A320", Offset = "0x222A320", VA = "0x222A320")]
	private void OnDurationTimeSChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CE07")]
	[Address(RVA = "0x222A758", Offset = "0x222A758", VA = "0x222A758")]
	private void OnDescriptionChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CE08")]
	[Address(RVA = "0x222AC94", Offset = "0x222AC94", VA = "0x222AC94")]
	private void OnDescriptionParamsChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CE09")]
	[Address(RVA = "0x222AE30", Offset = "0x222AE30", VA = "0x222AE30")]
	private string[] getDescriptionParams()
	{
		return null;
	}

	[Token(Token = "0x600CE0A")]
	[Address(RVA = "0x222A94C", Offset = "0x222A94C", VA = "0x222A94C")]
	private string GetText(string key, object[] param)
	{
		return null;
	}

	[Token(Token = "0x600CE0B")]
	[Address(RVA = "0x222B0D4", Offset = "0x222B0D4", VA = "0x222B0D4")]
	private void OnBaseTimeChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CE0C")]
	[Address(RVA = "0x222A490", Offset = "0x222A490", VA = "0x222A490")]
	private void InitTimer()
	{
	}

	[Token(Token = "0x600CE0D")]
	[Address(RVA = "0x222B154", Offset = "0x222B154", VA = "0x222B154")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CE0E")]
	[Address(RVA = "0x222B15C", Offset = "0x222B15C", VA = "0x222B15C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
