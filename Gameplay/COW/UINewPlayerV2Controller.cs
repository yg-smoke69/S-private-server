using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029EC")]
internal class UINewPlayerV2Controller : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x20029ED")]
	private sealed class _003CSetViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x40101DF")]
		[FieldOffset(Offset = "0x8")]
		internal StandardTabItemViewData view;

		[Token(Token = "0x40101E0")]
		[FieldOffset(Offset = "0xC")]
		internal UINewPlayerV2Controller _0024this;

		[Token(Token = "0x6010E43")]
		[Address(RVA = "0x27B23B8", Offset = "0x27B23B8", VA = "0x27B23B8")]
		public _003CSetViewData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010E44")]
		[Address(RVA = "0x27B3264", Offset = "0x27B3264", VA = "0x27B3264")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x40101D2")]
	[FieldOffset(Offset = "0x7C")]
	private UINewPlayerV2View m_View;

	[Token(Token = "0x40101D3")]
	[FieldOffset(Offset = "0x80")]
	private UIStandardCDNTabController m_TabCtrl;

	[Token(Token = "0x40101D4")]
	[FieldOffset(Offset = "0x84")]
	private UINewPlayerSurveyController m_SurveyCtrl;

	[Token(Token = "0x40101D5")]
	[FieldOffset(Offset = "0x88")]
	private UINewPlayerUpGradesController m_UpGradesCtrl;

	[Token(Token = "0x40101D6")]
	[FieldOffset(Offset = "0x8C")]
	private List<StandardTabItemViewData> m_TabDataList;

	[Token(Token = "0x40101D7")]
	[FieldOffset(Offset = "0x90")]
	private uint m_PreviewItemId;

	[Token(Token = "0x40101D8")]
	[FieldOffset(Offset = "0x94")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x40101D9")]
	[FieldOffset(Offset = "0x98")]
	private UINewPlayerAttendanceController m_AttendanceCtrl;

	[Token(Token = "0x40101DA")]
	[FieldOffset(Offset = "0x9C")]
	private UIModelNewPlayer m_ModelNewPlayer;

	[Token(Token = "0x40101DB")]
	[FieldOffset(Offset = "0xA0")]
	private int m_CurTab;

	[Token(Token = "0x40101DC")]
	private const int SHOWED = 1;

	[Token(Token = "0x40101DD")]
	private const int UNSHOWED = 0;

	[Token(Token = "0x40101DE")]
	private const string NEWPLAYER = "NEWPLAYER";

	[Token(Token = "0x6010E30")]
	[Address(RVA = "0x27B1294", Offset = "0x27B1294", VA = "0x27B1294")]
	public UINewPlayerV2Controller()
	{
	}

	[Token(Token = "0x6010E31")]
	[Address(RVA = "0x27B1328", Offset = "0x27B1328", VA = "0x27B1328")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010E32")]
	[Address(RVA = "0x27B13D0", Offset = "0x27B13D0", VA = "0x27B13D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010E33")]
	[Address(RVA = "0x27B1704", Offset = "0x27B1704", VA = "0x27B1704")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x6010E34")]
	[Address(RVA = "0x27B1810", Offset = "0x27B1810", VA = "0x27B1810", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010E35")]
	[Address(RVA = "0x27B19D4", Offset = "0x27B19D4", VA = "0x27B19D4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010E36")]
	[Address(RVA = "0x27B1B04", Offset = "0x27B1B04", VA = "0x27B1B04")]
	public void SetViewData(int index)
	{
	}

	[Token(Token = "0x6010E37")]
	[Address(RVA = "0x27B23C0", Offset = "0x27B23C0", VA = "0x27B23C0")]
	private void OnTipsBtnClick()
	{
	}

	[Token(Token = "0x6010E38")]
	[Address(RVA = "0x27B261C", Offset = "0x27B261C", VA = "0x27B261C")]
	private void OnTabItemClick(int index)
	{
	}

	[Token(Token = "0x6010E39")]
	[Address(RVA = "0x27A89BC", Offset = "0x27A89BC", VA = "0x27A89BC")]
	public void SetPreviewItemByChild(bool isAttendance)
	{
	}

	[Token(Token = "0x6010E3A")]
	[Address(RVA = "0x27B28EC", Offset = "0x27B28EC", VA = "0x27B28EC", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010E3B")]
	[Address(RVA = "0x27B2980", Offset = "0x27B2980", VA = "0x27B2980", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010E3C")]
	[Address(RVA = "0x27B2D40", Offset = "0x27B2D40", VA = "0x27B2D40")]
	private void ShowIntroBubble()
	{
	}

	[Token(Token = "0x6010E3D")]
	[Address(RVA = "0x27B3140", Offset = "0x27B3140", VA = "0x27B3140", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x6010E3E")]
	[Address(RVA = "0x27B31B0", Offset = "0x27B31B0", VA = "0x27B31B0", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x6010E3F")]
	[Address(RVA = "0x27B3208", Offset = "0x27B3208", VA = "0x27B3208")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x6010E40")]
	[Address(RVA = "0x27B324C", Offset = "0x27B324C", VA = "0x27B324C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010E41")]
	[Address(RVA = "0x27B3254", Offset = "0x27B3254", VA = "0x27B3254")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6010E42")]
	[Address(RVA = "0x27B325C", Offset = "0x27B325C", VA = "0x27B325C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
