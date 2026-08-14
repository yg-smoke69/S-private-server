using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020F7")]
public class UIFlashStoreActivityPhaseNodeController : UIBaseController
{
	[Token(Token = "0x20020F8")]
	public delegate void OnPhaseNodeSelect(uint activityGroupID);

	[Token(Token = "0x400CE29")]
	private const int OVERDUE_GROUP_ID = 0;

	[Token(Token = "0x400CE2A")]
	private const int PROCEEDING_GROUP_ID = 1;

	[Token(Token = "0x400CE2B")]
	private const int LOCKED_GROUP_ID = 2;

	[Token(Token = "0x400CE2C")]
	private const float SELECTED_OFFSET_X = 15f;

	[Token(Token = "0x400CE2D")]
	private const float NOT_SELECTED_OFFSET_X = 0f;

	[Token(Token = "0x400CE2E")]
	private const int SELECTED_FONT_SIZE = 30;

	[Token(Token = "0x400CE2F")]
	private const int NOT_SELECTED_FONT_SIZE = 20;

	[Token(Token = "0x400CE30")]
	private const string DATETIME_DISPLAY_FORMAT = "MM.dd";

	[Token(Token = "0x400CE31")]
	private const string OVERDUE_TIPS_KEY = "T_35_LC_FLASHSTORE_TIMEEXPIRED";

	[Token(Token = "0x400CE32")]
	private const string LOCKED_TIPS_KEY = "T_35_LC_FLASHSTORE_TIMELIMITED";

	[Token(Token = "0x400CE33")]
	private const string FLASH_GEM_SPRITE_NAME = "FF_UI_FlashStore_PurpleDiamond";

	[Token(Token = "0x400CE34")]
	[FieldOffset(Offset = "0x28")]
	private uint m_FlashStoreActivityID;

	[Token(Token = "0x400CE35")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_ActivityGroupID;

	[Token(Token = "0x400CE36")]
	[FieldOffset(Offset = "0x30")]
	private OnPhaseNodeSelect m_OnPhaseNodeSelect;

	[Token(Token = "0x400CE37")]
	[FieldOffset(Offset = "0x34")]
	private UIFlashStoreActivityPhaseNodeView m_View;

	[Token(Token = "0x600AB0A")]
	[Address(RVA = "0x1DCEE40", Offset = "0x1DCEE40", VA = "0x1DCEE40")]
	public UIFlashStoreActivityPhaseNodeController()
	{
	}

	[Token(Token = "0x600AB0B")]
	[Address(RVA = "0x1DCEEC4", Offset = "0x1DCEEC4", VA = "0x1DCEEC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AB0C")]
	[Address(RVA = "0x1DCEF6C", Offset = "0x1DCEF6C", VA = "0x1DCEF6C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AB0D")]
	[Address(RVA = "0x1DCF038", Offset = "0x1DCF038", VA = "0x1DCF038")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x600AB0E")]
	[Address(RVA = "0x1DCF2D0", Offset = "0x1DCF2D0", VA = "0x1DCF2D0")]
	private void OnActionBtnClick()
	{
	}

	[Token(Token = "0x600AB0F")]
	[Address(RVA = "0x1DCF16C", Offset = "0x1DCF16C", VA = "0x1DCF16C")]
	private void SetupDefaultState()
	{
	}

	[Token(Token = "0x600AB10")]
	[Address(RVA = "0x1DCFDC0", Offset = "0x1DCFDC0", VA = "0x1DCFDC0")]
	private void SetActiveGroup(int group)
	{
	}

	[Token(Token = "0x600AB11")]
	[Address(RVA = "0x1DCFF1C", Offset = "0x1DCFF1C", VA = "0x1DCFF1C")]
	private void RefreshDynamicContent()
	{
	}

	[Token(Token = "0x600AB12")]
	[Address(RVA = "0x1DCB160", Offset = "0x1DCB160", VA = "0x1DCB160")]
	public void SetViewData(uint flashStoreActivityID, uint activityGroupID, OnPhaseNodeSelect onPhaseNodeSelect)
	{
	}

	[Token(Token = "0x600AB13")]
	[Address(RVA = "0x1DCA360", Offset = "0x1DCA360", VA = "0x1DCA360")]
	public uint GetActivityGroupID()
	{
		return default(uint);
	}

	[Token(Token = "0x600AB14")]
	[Address(RVA = "0x1DCA448", Offset = "0x1DCA448", VA = "0x1DCA448")]
	public void SelectPhaseNode(bool select)
	{
	}

	[Token(Token = "0x600AB15")]
	[Address(RVA = "0x1DCCB1C", Offset = "0x1DCCB1C", VA = "0x1DCCB1C")]
	public UIWidget GetWidgetForGuide()
	{
		return null;
	}

	[Token(Token = "0x600AB16")]
	[Address(RVA = "0x1DD03E8", Offset = "0x1DD03E8", VA = "0x1DD03E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
