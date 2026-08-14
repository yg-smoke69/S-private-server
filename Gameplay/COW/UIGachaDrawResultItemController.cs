using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002637")]
public class UIGachaDrawResultItemController : UIBaseController
{
	[Token(Token = "0x400EBFE")]
	[FieldOffset(Offset = "0x28")]
	private UIGachaDrawResultItemView m_View;

	[Token(Token = "0x400EBFF")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Idx;

	[Token(Token = "0x400EC00")]
	private const float m_FlowRangeY = 9f;

	[Token(Token = "0x400EC01")]
	[FieldOffset(Offset = "0x30")]
	private CommonRewardItemInfo m_Info;

	[Token(Token = "0x17001172")]
	public CommonRewardItemInfo Info
	{
		[Token(Token = "0x600E38B")]
		[Address(RVA = "0x2471384", Offset = "0x2471384", VA = "0x2471384")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600E38A")]
	[Address(RVA = "0x24712F8", Offset = "0x24712F8", VA = "0x24712F8")]
	public UIGachaDrawResultItemController()
	{
	}

	[Token(Token = "0x600E38C")]
	[Address(RVA = "0x24713DC", Offset = "0x24713DC", VA = "0x24713DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E38D")]
	[Address(RVA = "0x2471480", Offset = "0x2471480", VA = "0x2471480", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E38E")]
	[Address(RVA = "0x247153C", Offset = "0x247153C", VA = "0x247153C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E38F")]
	[Address(RVA = "0x24715A0", Offset = "0x24715A0", VA = "0x24715A0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E390")]
	[Address(RVA = "0x2471604", Offset = "0x2471604", VA = "0x2471604", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E391")]
	[Address(RVA = "0x2471668", Offset = "0x2471668", VA = "0x2471668")]
	public void DoFlowAnim()
	{
	}

	[Token(Token = "0x600E392")]
	[Address(RVA = "0x24716F8", Offset = "0x24716F8", VA = "0x24716F8")]
	public void SetData(CommonRewardItemInfo info, int index)
	{
	}

	[Token(Token = "0x600E393")]
	[Address(RVA = "0x24719A8", Offset = "0x24719A8", VA = "0x24719A8")]
	public void ShowGemView()
	{
	}

	[Token(Token = "0x600E394")]
	[Address(RVA = "0x2471C50", Offset = "0x2471C50", VA = "0x2471C50")]
	public void ShowRewardView()
	{
	}

	[Token(Token = "0x600E395")]
	[Address(RVA = "0x2471E14", Offset = "0x2471E14", VA = "0x2471E14")]
	public void AdjustScale(float scale)
	{
	}

	[Token(Token = "0x600E396")]
	[Address(RVA = "0x2471FB4", Offset = "0x2471FB4", VA = "0x2471FB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E397")]
	[Address(RVA = "0x2471FBC", Offset = "0x2471FBC", VA = "0x2471FBC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E398")]
	[Address(RVA = "0x2471FC4", Offset = "0x2471FC4", VA = "0x2471FC4")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E399")]
	[Address(RVA = "0x2471FCC", Offset = "0x2471FCC", VA = "0x2471FCC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
