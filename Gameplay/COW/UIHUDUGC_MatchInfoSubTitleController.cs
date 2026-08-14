using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002453")]
public class UIHUDUGC_MatchInfoSubTitleController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E1A3")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_MatchInfoSubTitleView m_View;

	[Token(Token = "0x400E1A4")]
	[FieldOffset(Offset = "0x2C")]
	private MatchInfoSubTitleHudEntity m_ViewData;

	[Token(Token = "0x400E1A5")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x600CE56")]
	[Address(RVA = "0x2E0B64C", Offset = "0x2E0B64C", VA = "0x2E0B64C")]
	public UIHUDUGC_MatchInfoSubTitleController()
	{
	}

	[Token(Token = "0x600CE57")]
	[Address(RVA = "0x2E0B6D0", Offset = "0x2E0B6D0", VA = "0x2E0B6D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CE58")]
	[Address(RVA = "0x2E0B774", Offset = "0x2E0B774", VA = "0x2E0B774", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CE59")]
	[Address(RVA = "0x2E0B830", Offset = "0x2E0B830", VA = "0x2E0B830", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CE5A")]
	[Address(RVA = "0x2E0B910", Offset = "0x2E0B910", VA = "0x2E0B910", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CE5B")]
	[Address(RVA = "0x2E0B89C", Offset = "0x2E0B89C", VA = "0x2E0B89C", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CE5C")]
	[Address(RVA = "0x2E0BB44", Offset = "0x2E0BB44", VA = "0x2E0BB44")]
	private string GetText(string key, object[] param)
	{
		return null;
	}

	[Token(Token = "0x600CE5D")]
	[Address(RVA = "0x2E0BEB4", Offset = "0x2E0BEB4", VA = "0x2E0BEB4")]
	private void ShowSubTitle()
	{
	}

	[Token(Token = "0x600CE5E")]
	[Address(RVA = "0x2E0C018", Offset = "0x2E0C018", VA = "0x2E0C018")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CE5F")]
	[Address(RVA = "0x2E0C0A0", Offset = "0x2E0C0A0", VA = "0x2E0C0A0")]
	private void OnLocSwitchChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CE60")]
	[Address(RVA = "0x2E0C120", Offset = "0x2E0C120", VA = "0x2E0C120")]
	private void OnTextKeyChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CE61")]
	[Address(RVA = "0x2E0C1A0", Offset = "0x2E0C1A0", VA = "0x2E0C1A0")]
	private void OnTextKey_ParamsChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CE62")]
	[Address(RVA = "0x2E0C220", Offset = "0x2E0C220", VA = "0x2E0C220")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CE63")]
	[Address(RVA = "0x2E0C228", Offset = "0x2E0C228", VA = "0x2E0C228")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
