using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20020F3")]
public class UIFlashStoreActivityItemController : UIBaseController
{
	[Token(Token = "0x400CDFB")]
	private const string ON_START_ANIM_NAME = "UIFlashStoreActivityItem_In";

	[Token(Token = "0x400CDFC")]
	[FieldOffset(Offset = "0x28")]
	private uint m_ActivityID;

	[Token(Token = "0x400CDFD")]
	[FieldOffset(Offset = "0x2C")]
	private string m_ClickLogIdentifier;

	[Token(Token = "0x400CDFE")]
	[FieldOffset(Offset = "0x30")]
	private EventLogger.ClickType m_ClickType;

	[Token(Token = "0x400CDFF")]
	[FieldOffset(Offset = "0x34")]
	private ClientActivityDesc m_ActivityDesc;

	[Token(Token = "0x400CE00")]
	[FieldOffset(Offset = "0x38")]
	private UIFlashStoreActivityItemView m_View;

	[Token(Token = "0x17000FEA")]
	private bool IsReady
	{
		[Token(Token = "0x600AAC3")]
		[Address(RVA = "0x1DC38D8", Offset = "0x1DC38D8", VA = "0x1DC38D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600AAC2")]
	[Address(RVA = "0x1DC380C", Offset = "0x1DC380C", VA = "0x1DC380C")]
	public UIFlashStoreActivityItemController()
	{
	}

	[Token(Token = "0x600AAC4")]
	[Address(RVA = "0x1DC3950", Offset = "0x1DC3950", VA = "0x1DC3950")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AAC5")]
	[Address(RVA = "0x1DC39F8", Offset = "0x1DC39F8", VA = "0x1DC39F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AAC6")]
	[Address(RVA = "0x1DC3D10", Offset = "0x1DC3D10", VA = "0x1DC3D10")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x600AAC7")]
	[Address(RVA = "0x1DC3EB8", Offset = "0x1DC3EB8", VA = "0x1DC3EB8")]
	private void OnClaimBtnClick()
	{
	}

	[Token(Token = "0x600AAC8")]
	[Address(RVA = "0x1DC41A0", Offset = "0x1DC41A0", VA = "0x1DC41A0")]
	private void OnGoBtnClick()
	{
	}

	[Token(Token = "0x600AAC9")]
	[Address(RVA = "0x1DC446C", Offset = "0x1DC446C", VA = "0x1DC446C")]
	private void SetStartAnimToFirstFrame()
	{
	}

	[Token(Token = "0x600AACA")]
	[Address(RVA = "0x1DC3AC4", Offset = "0x1DC3AC4", VA = "0x1DC3AC4")]
	private void SetupDefaultState()
	{
	}

	[Token(Token = "0x600AACB")]
	[Address(RVA = "0x1DC46BC", Offset = "0x1DC46BC", VA = "0x1DC46BC")]
	private void LoadStaticContent()
	{
	}

	[Token(Token = "0x600AACC")]
	[Address(RVA = "0x1DC4B4C", Offset = "0x1DC4B4C", VA = "0x1DC4B4C")]
	private void RefreshBtnWithActivityState(EActivity.State state)
	{
	}

	[Token(Token = "0x600AACD")]
	[Address(RVA = "0x1DC4ED8", Offset = "0x1DC4ED8", VA = "0x1DC4ED8")]
	private void RefreshDynamicContent()
	{
	}

	[Token(Token = "0x600AACE")]
	[Address(RVA = "0x1DC5118", Offset = "0x1DC5118", VA = "0x1DC5118")]
	public UIFlashStoreActivityItemController SetViewData(uint activityID, EventLogger.ClickType clickType, string logIdentifier)
	{
		return null;
	}

	[Token(Token = "0x600AACF")]
	[Address(RVA = "0x1DC533C", Offset = "0x1DC533C", VA = "0x1DC533C")]
	public void PlayStartAnim()
	{
	}

	[Token(Token = "0x600AAD0")]
	[Address(RVA = "0x1DC5500", Offset = "0x1DC5500", VA = "0x1DC5500")]
	public void SkipStartAnimToLastFrame()
	{
	}

	[Token(Token = "0x600AAD1")]
	[Address(RVA = "0x1DC577C", Offset = "0x1DC577C", VA = "0x1DC577C")]
	public void OnUpdateActivityInfo()
	{
	}

	[Token(Token = "0x600AAD2")]
	[Address(RVA = "0x1DC57DC", Offset = "0x1DC57DC", VA = "0x1DC57DC")]
	public uint GetActivityID()
	{
		return default(uint);
	}

	[Token(Token = "0x600AAD3")]
	[Address(RVA = "0x1DC5834", Offset = "0x1DC5834", VA = "0x1DC5834")]
	public UIWidget GetWidgetForGuide()
	{
		return null;
	}

	[Token(Token = "0x600AAD4")]
	[Address(RVA = "0x1DC5908", Offset = "0x1DC5908", VA = "0x1DC5908")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
