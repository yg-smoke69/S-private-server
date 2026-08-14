using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2002488")]
internal class UIHUDUGCCountDownTipController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E28E")]
	[FieldOffset(Offset = "0x28")]
	private string m_EntityID;

	[Token(Token = "0x400E28F")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSimpleCountdownView m_View;

	[Token(Token = "0x400E290")]
	[FieldOffset(Offset = "0x30")]
	private CountdownHudEntity m_ViewData;

	[Token(Token = "0x400E291")]
	[FieldOffset(Offset = "0x34")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x600D0A2")]
	[Address(RVA = "0x1481B68", Offset = "0x1481B68", VA = "0x1481B68")]
	public UIHUDUGCCountDownTipController()
	{
	}

	[Token(Token = "0x600D0A3")]
	[Address(RVA = "0x1481BEC", Offset = "0x1481BEC", VA = "0x1481BEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D0A4")]
	[Address(RVA = "0x1481C50", Offset = "0x1481C50", VA = "0x1481C50", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600D0A5")]
	[Address(RVA = "0x14824B4", Offset = "0x14824B4", VA = "0x14824B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D0A6")]
	[Address(RVA = "0x1482598", Offset = "0x1482598", VA = "0x1482598", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600D0A7")]
	[Address(RVA = "0x14825C8", Offset = "0x14825C8", VA = "0x14825C8", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600D0A8")]
	[Address(RVA = "0x14825DC", Offset = "0x14825DC", VA = "0x14825DC")]
	private void Update()
	{
	}

	[Token(Token = "0x600D0A9")]
	[Address(RVA = "0x14825FC", Offset = "0x14825FC", VA = "0x14825FC")]
	private void UpdateLeftTimeShow()
	{
	}

	[Token(Token = "0x600D0AA")]
	[Address(RVA = "0x148261C", Offset = "0x148261C", VA = "0x148261C")]
	private void OnOpenStateChangeEventHandle(bool oldValue, bool nowValue)
	{
	}

	[Token(Token = "0x600D0AB")]
	[Address(RVA = "0x1482628", Offset = "0x1482628", VA = "0x1482628")]
	private void OnBaseTimeChangeHandle(int oldValue, int nowValue)
	{
	}

	[Token(Token = "0x600D0AC")]
	[Address(RVA = "0x148262C", Offset = "0x148262C", VA = "0x148262C")]
	private void OnDurationChangeHandle(int oldValue, int nowValue)
	{
	}

	[Token(Token = "0x600D0AD")]
	[Address(RVA = "0x1482630", Offset = "0x1482630", VA = "0x1482630")]
	private void OnUpdateTypeChangeHandle(int oldValue, int nowValue)
	{
	}

	[Token(Token = "0x600D0AE")]
	[Address(RVA = "0x14820D0", Offset = "0x14820D0", VA = "0x14820D0")]
	private void RefreshViewData2View()
	{
	}
}
