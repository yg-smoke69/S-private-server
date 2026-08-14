using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F0B")]
public class UIDigitaluniverseBTabBaseController : UIBaseController
{
	[Token(Token = "0x400C357")]
	[FieldOffset(Offset = "0x28")]
	protected UIDigitalUniverseBTabItemView m_View;

	[Token(Token = "0x400C358")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Index;

	[Token(Token = "0x400C359")]
	[FieldOffset(Offset = "0x30")]
	private UIModelDigitaluniverseB.DoorTabData m_Data;

	[Token(Token = "0x400C35A")]
	[FieldOffset(Offset = "0x34")]
	private int m_DoorType;

	[Token(Token = "0x400C35B")]
	[FieldOffset(Offset = "0x38")]
	protected bool m_IsLocked;

	[Token(Token = "0x400C35C")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelDigitaluniverseB.DoorPageState m_PageState;

	[Token(Token = "0x6009814")]
	[Address(RVA = "0x27557C8", Offset = "0x27557C8", VA = "0x27557C8")]
	public UIDigitaluniverseBTabBaseController()
	{
	}

	[Token(Token = "0x6009815")]
	[Address(RVA = "0x2755854", Offset = "0x2755854", VA = "0x2755854", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009816")]
	[Address(RVA = "0x2755CA0", Offset = "0x2755CA0", VA = "0x2755CA0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009817")]
	[Address(RVA = "0x2755D04", Offset = "0x2755D04", VA = "0x2755D04")]
	private void LoadStaticContent()
	{
	}

	[Token(Token = "0x6009818")]
	[Address(RVA = "0x2755FD0", Offset = "0x2755FD0", VA = "0x2755FD0", Slot = "31")]
	public virtual void RefreshDynamicContent()
	{
	}

	[Token(Token = "0x6009819")]
	[Address(RVA = "0x27565C4", Offset = "0x27565C4", VA = "0x27565C4", Slot = "32")]
	protected virtual void ChangeLabelColor()
	{
	}

	[Token(Token = "0x600981A")]
	[Address(RVA = "0x2755A54", Offset = "0x2755A54", VA = "0x2755A54")]
	private void SetupDefaultStateOnInit()
	{
	}

	[Token(Token = "0x600981B")]
	[Address(RVA = "0x2755920", Offset = "0x2755920", VA = "0x2755920")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x600981C")]
	[Address(RVA = "0x2756618", Offset = "0x2756618", VA = "0x2756618")]
	public void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600981D")]
	[Address(RVA = "0x275678C", Offset = "0x275678C", VA = "0x275678C")]
	private void OnSelectBtnClick()
	{
	}

	[Token(Token = "0x600981E")]
	[Address(RVA = "0x2756E14", Offset = "0x2756E14", VA = "0x2756E14", Slot = "33")]
	public virtual void OnSelect()
	{
	}

	[Token(Token = "0x600981F")]
	[Address(RVA = "0x2756F20", Offset = "0x2756F20", VA = "0x2756F20", Slot = "34")]
	public virtual void OnCancleSelect()
	{
	}

	[Token(Token = "0x6009820")]
	[Address(RVA = "0x2756368", Offset = "0x2756368", VA = "0x2756368")]
	protected bool IsMaskNeedShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6009821")]
	[Address(RVA = "0x27564B4", Offset = "0x27564B4", VA = "0x27564B4")]
	private bool IsFinishIconNeedShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6009822")]
	[Address(RVA = "0x275702C", Offset = "0x275702C", VA = "0x275702C")]
	public UIWidget GetGuideWidget()
	{
		return null;
	}

	[Token(Token = "0x6009823")]
	[Address(RVA = "0x2757100", Offset = "0x2757100", VA = "0x2757100")]
	public void RefreshRedTips()
	{
	}

	[Token(Token = "0x6009824")]
	[Address(RVA = "0x27572AC", Offset = "0x27572AC", VA = "0x27572AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009825")]
	[Address(RVA = "0x27572B4", Offset = "0x27572B4", VA = "0x27572B4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
