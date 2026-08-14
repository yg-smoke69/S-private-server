using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027E2")]
public class UIHudObGlobalEventPollEntryController : UIBaseController
{
	[Token(Token = "0x400F640")]
	[FieldOffset(Offset = "0x28")]
	private UIHudObGlobalEventPollEntryView m_View;

	[Token(Token = "0x400F641")]
	[FieldOffset(Offset = "0x2C")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400F642")]
	[FieldOffset(Offset = "0x30")]
	private LDAFPHICDJJ m_EventManager;

	[Token(Token = "0x400F643")]
	[FieldOffset(Offset = "0x34")]
	private bool showCD;

	[Token(Token = "0x600F73A")]
	[Address(RVA = "0x1F68230", Offset = "0x1F68230", VA = "0x1F68230")]
	public UIHudObGlobalEventPollEntryController()
	{
	}

	[Token(Token = "0x600F73B")]
	[Address(RVA = "0x1F682B4", Offset = "0x1F682B4", VA = "0x1F682B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F73C")]
	[Address(RVA = "0x1F6835C", Offset = "0x1F6835C", VA = "0x1F6835C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F73D")]
	[Address(RVA = "0x1F68AC4", Offset = "0x1F68AC4", VA = "0x1F68AC4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F73E")]
	[Address(RVA = "0x1F68BF8", Offset = "0x1F68BF8", VA = "0x1F68BF8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F73F")]
	[Address(RVA = "0x1F68DBC", Offset = "0x1F68DBC", VA = "0x1F68DBC")]
	private void Update()
	{
	}

	[Token(Token = "0x600F740")]
	[Address(RVA = "0x1F690D4", Offset = "0x1F690D4", VA = "0x1F690D4")]
	private void OnPollClick()
	{
	}

	[Token(Token = "0x600F741")]
	[Address(RVA = "0x1F6863C", Offset = "0x1F6863C", VA = "0x1F6863C")]
	private void OnPollNtf(object[] data)
	{
	}

	[Token(Token = "0x600F742")]
	[Address(RVA = "0x1F69340", Offset = "0x1F69340", VA = "0x1F69340")]
	private void RefreshCDUI()
	{
	}

	[Token(Token = "0x600F743")]
	[Address(RVA = "0x1F69460", Offset = "0x1F69460", VA = "0x1F69460")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F744")]
	[Address(RVA = "0x1F69468", Offset = "0x1F69468", VA = "0x1F69468")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F745")]
	[Address(RVA = "0x1F69470", Offset = "0x1F69470", VA = "0x1F69470")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
