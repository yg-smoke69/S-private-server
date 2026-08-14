using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027DC")]
public class UIHudObGlobalEventActiveController : UIBaseController
{
	[Token(Token = "0x400F615")]
	[FieldOffset(Offset = "0x28")]
	private UIHudObGlobalEventActiveView m_View;

	[Token(Token = "0x400F616")]
	[FieldOffset(Offset = "0x2C")]
	private bool isActive;

	[Token(Token = "0x400F617")]
	[FieldOffset(Offset = "0x30")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400F618")]
	[FieldOffset(Offset = "0x34")]
	private LDAFPHICDJJ m_EventManager;

	[Token(Token = "0x400F619")]
	[FieldOffset(Offset = "0x38")]
	private StringBuilder m_EventString;

	[Token(Token = "0x400F61A")]
	[FieldOffset(Offset = "0x3C")]
	private UIDetailTipsInGameController m_DetailTips;

	[Token(Token = "0x600F701")]
	[Address(RVA = "0x1F5C5D4", Offset = "0x1F5C5D4", VA = "0x1F5C5D4")]
	public UIHudObGlobalEventActiveController()
	{
	}

	[Token(Token = "0x600F702")]
	[Address(RVA = "0x1F5C658", Offset = "0x1F5C658", VA = "0x1F5C658")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F703")]
	[Address(RVA = "0x1F5C700", Offset = "0x1F5C700", VA = "0x1F5C700", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F704")]
	[Address(RVA = "0x1F5C990", Offset = "0x1F5C990", VA = "0x1F5C990", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F705")]
	[Address(RVA = "0x1F5C9F4", Offset = "0x1F5C9F4", VA = "0x1F5C9F4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F706")]
	[Address(RVA = "0x1F5CB1C", Offset = "0x1F5CB1C", VA = "0x1F5CB1C")]
	private void Update()
	{
	}

	[Token(Token = "0x600F707")]
	[Address(RVA = "0x1F5D304", Offset = "0x1F5D304", VA = "0x1F5D304")]
	private void OnEventTakeEffectNtf(object[] data)
	{
	}

	[Token(Token = "0x600F708")]
	[Address(RVA = "0x1F5CE30", Offset = "0x1F5CE30", VA = "0x1F5CE30")]
	private void RefreshCD()
	{
	}

	[Token(Token = "0x600F709")]
	[Address(RVA = "0x1F5D380", Offset = "0x1F5D380", VA = "0x1F5D380")]
	private void OnIconClick()
	{
	}

	[Token(Token = "0x600F70A")]
	[Address(RVA = "0x1F5D950", Offset = "0x1F5D950", VA = "0x1F5D950")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F70B")]
	[Address(RVA = "0x1F5D958", Offset = "0x1F5D958", VA = "0x1F5D958")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600F70C")]
	[Address(RVA = "0x1F5D960", Offset = "0x1F5D960", VA = "0x1F5D960")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
