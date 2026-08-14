using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002967")]
internal class UIMailController : UINavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x2002968")]
	private enum MailTab
	{
		[Token(Token = "0x400FF44")]
		DAILY,
		[Token(Token = "0x400FF45")]
		REPORT
	}

	[Token(Token = "0x2002969")]
	private sealed class _003CSelectMail_003Ec__AnonStorey1
	{
		[Token(Token = "0x400FF46")]
		[FieldOffset(Offset = "0x8")]
		internal uint type;

		[Token(Token = "0x60109BA")]
		[Address(RVA = "0x18D5358", Offset = "0x18D5358", VA = "0x18D5358")]
		public _003CSelectMail_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60109BB")]
		[Address(RVA = "0x18E1A50", Offset = "0x18E1A50", VA = "0x18E1A50")]
		internal bool _003C_003Em__0(MailInfo mail)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200296A")]
	private sealed class _003CShowGetGiftPanel_003Ec__AnonStorey2
	{
		[Token(Token = "0x400FF47")]
		[FieldOffset(Offset = "0x8")]
		internal MailInfo mailInfo;

		[Token(Token = "0x400FF48")]
		[FieldOffset(Offset = "0xC")]
		internal UIMailController _0024this;

		[Token(Token = "0x60109BC")]
		[Address(RVA = "0x18D6E0C", Offset = "0x18D6E0C", VA = "0x18D6E0C")]
		public _003CShowGetGiftPanel_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60109BD")]
		[Address(RVA = "0x18E1A98", Offset = "0x18E1A98", VA = "0x18E1A98")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200296B")]
	private sealed class _003CShowGiftMail_003Ec__AnonStorey3
	{
		[Token(Token = "0x400FF49")]
		[FieldOffset(Offset = "0x8")]
		internal MailInfo info;

		[Token(Token = "0x400FF4A")]
		[FieldOffset(Offset = "0xC")]
		internal UIMailController _0024this;

		[Token(Token = "0x60109BE")]
		[Address(RVA = "0x18E08A8", Offset = "0x18E08A8", VA = "0x18E08A8")]
		public _003CShowGiftMail_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60109BF")]
		[Address(RVA = "0x18E1AF8", Offset = "0x18E1AF8", VA = "0x18E1AF8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200296C")]
	private sealed class _003CtReasonTableReposition_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FF4B")]
		[FieldOffset(Offset = "0x8")]
		internal UIMailController _0024this;

		[Token(Token = "0x400FF4C")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400FF4D")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400FF4E")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700125D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60109C2")]
			[Address(RVA = "0x18E1C70", Offset = "0x18E1C70", VA = "0x18E1C70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700125E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60109C3")]
			[Address(RVA = "0x18E1C78", Offset = "0x18E1C78", VA = "0x18E1C78", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60109C0")]
		[Address(RVA = "0x18E1618", Offset = "0x18E1618", VA = "0x18E1618")]
		public _003CtReasonTableReposition_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60109C1")]
		[Address(RVA = "0x18E1B58", Offset = "0x18E1B58", VA = "0x18E1B58", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60109C4")]
		[Address(RVA = "0x18E1C80", Offset = "0x18E1C80", VA = "0x18E1C80", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60109C5")]
		[Address(RVA = "0x18E1C94", Offset = "0x18E1C94", VA = "0x18E1C94", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400FF2A")]
	[FieldOffset(Offset = "0x68")]
	private UIMailView m_View;

	[Token(Token = "0x400FF2B")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelMail m_Model;

	[Token(Token = "0x400FF2C")]
	[FieldOffset(Offset = "0x70")]
	private MailTab m_CurrentTab;

	[Token(Token = "0x400FF2D")]
	[FieldOffset(Offset = "0x74")]
	private List<MailInfo> m_MailInfoList;

	[Token(Token = "0x400FF2E")]
	[FieldOffset(Offset = "0x78")]
	private int m_CurrentIndex;

	[Token(Token = "0x400FF2F")]
	[FieldOffset(Offset = "0x7C")]
	private MailInfo m_CurrentMailInfo;

	[Token(Token = "0x400FF30")]
	[FieldOffset(Offset = "0x80")]
	private ulong m_CurrentMailId;

	[Token(Token = "0x400FF31")]
	[FieldOffset(Offset = "0x88")]
	private List<MailInfo> m_ShouldUpdateMail;

	[Token(Token = "0x400FF32")]
	[FieldOffset(Offset = "0x8C")]
	private List<MailInfo> m_ShouldDelayUpdateMail;

	[Token(Token = "0x400FF33")]
	[FieldOffset(Offset = "0x90")]
	private List<ReportMailInfo> m_ReportMailInfoList;

	[Token(Token = "0x400FF34")]
	[FieldOffset(Offset = "0x94")]
	private int m_CurrentReportIndex;

	[Token(Token = "0x400FF35")]
	[FieldOffset(Offset = "0x98")]
	private ReportMailInfo m_CurrentReportMailInfo;

	[Token(Token = "0x400FF36")]
	[FieldOffset(Offset = "0xA0")]
	private ulong m_CurrentReportMailId;

	[Token(Token = "0x400FF37")]
	[FieldOffset(Offset = "0xA8")]
	private List<ReportMailInfo> m_ShouldUpdateReportMail;

	[Token(Token = "0x400FF38")]
	[FieldOffset(Offset = "0xAC")]
	private List<ReportMailInfo> m_ShouldDelayUpdateReportMail;

	[Token(Token = "0x400FF39")]
	[FieldOffset(Offset = "0xB0")]
	private UIMailReportReasonItemController m_UIMailReportReason;

	[Token(Token = "0x400FF3A")]
	private const int MailNoRewardBottom = 20;

	[Token(Token = "0x400FF3B")]
	private const int MailRewardBottom = 140;

	[Token(Token = "0x400FF3C")]
	[FieldOffset(Offset = "0xB4")]
	private string mainReasons;

	[Token(Token = "0x400FF3D")]
	[FieldOffset(Offset = "0xB8")]
	private string matchTimeStamp;

	[Token(Token = "0x400FF3E")]
	[FieldOffset(Offset = "0xBC")]
	private string reportTimeStamp;

	[Token(Token = "0x400FF3F")]
	[FieldOffset(Offset = "0xC0")]
	private bool outGameFlg;

	[Token(Token = "0x400FF40")]
	[FieldOffset(Offset = "0xC4")]
	private List<uint> m_ReportTypeLists;

	[Token(Token = "0x400FF41")]
	[FieldOffset(Offset = "0x0")]
	private static Color m_ColorSpriteLight;

	[Token(Token = "0x400FF42")]
	[FieldOffset(Offset = "0x10")]
	private static Color m_ColorSpriteDark;

	[Token(Token = "0x6010977")]
	[Address(RVA = "0x18D2980", Offset = "0x18D2980", VA = "0x18D2980")]
	public UIMailController()
	{
	}

	[Token(Token = "0x6010978")]
	[Address(RVA = "0x18D2B60", Offset = "0x18D2B60", VA = "0x18D2B60")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010979")]
	[Address(RVA = "0x18D2C04", Offset = "0x18D2C04", VA = "0x18D2C04", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601097A")]
	[Address(RVA = "0x18D3788", Offset = "0x18D3788", VA = "0x18D3788", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x601097B")]
	[Address(RVA = "0x18D3E4C", Offset = "0x18D3E4C", VA = "0x18D3E4C")]
	private void OnReceiveAllBtnClick()
	{
	}

	[Token(Token = "0x601097C")]
	[Address(RVA = "0x18D4848", Offset = "0x18D4848", VA = "0x18D4848")]
	private void OnDeleteAllBtnClick()
	{
	}

	[Token(Token = "0x601097D")]
	[Address(RVA = "0x18D4EA0", Offset = "0x18D4EA0", VA = "0x18D4EA0")]
	private void OnRejectBtnClick()
	{
	}

	[Token(Token = "0x601097E")]
	[Address(RVA = "0x18D51A8", Offset = "0x18D51A8", VA = "0x18D51A8")]
	public void SelectMail(uint type)
	{
	}

	[Token(Token = "0x601097F")]
	[Address(RVA = "0x18D5360", Offset = "0x18D5360", VA = "0x18D5360")]
	private void OnAcceptBtnClick()
	{
	}

	[Token(Token = "0x6010980")]
	[Address(RVA = "0x18D5500", Offset = "0x18D5500", VA = "0x18D5500")]
	private void OnReceiveBtnClick()
	{
	}

	[Token(Token = "0x6010981")]
	[Address(RVA = "0x18D5718", Offset = "0x18D5718", VA = "0x18D5718")]
	private void OnOpenBtnClick()
	{
	}

	[Token(Token = "0x6010982")]
	[Address(RVA = "0x18D5AC0", Offset = "0x18D5AC0", VA = "0x18D5AC0", Slot = "46")]
	protected virtual void OnClose()
	{
	}

	[Token(Token = "0x6010983")]
	[Address(RVA = "0x18D5BCC", Offset = "0x18D5BCC", VA = "0x18D5BCC")]
	private void OnGoToAppealWebClick()
	{
	}

	[Token(Token = "0x6010984")]
	[Address(RVA = "0x18D5E60", Offset = "0x18D5E60", VA = "0x18D5E60")]
	private void OnClickGoToCreditButton()
	{
	}

	[Token(Token = "0x6010985")]
	[Address(RVA = "0x18D6038", Offset = "0x18D6038", VA = "0x18D6038")]
	private void OnClickDailyTabBtn()
	{
	}

	[Token(Token = "0x6010986")]
	[Address(RVA = "0x18D6DA4", Offset = "0x18D6DA4", VA = "0x18D6DA4")]
	private void OnClickReportTabBtn()
	{
	}

	[Token(Token = "0x6010987")]
	[Address(RVA = "0x18D579C", Offset = "0x18D579C", VA = "0x18D579C")]
	public void ShowGetGiftPanel(MailInfo mailInfo)
	{
	}

	[Token(Token = "0x6010988")]
	[Address(RVA = "0x18D6E14", Offset = "0x18D6E14", VA = "0x18D6E14")]
	private void OnDeleteBtnClick()
	{
	}

	[Token(Token = "0x6010989")]
	[Address(RVA = "0x18D5050", Offset = "0x18D5050", VA = "0x18D5050")]
	public void SetMailStatus(EMail.Status status)
	{
	}

	[Token(Token = "0x601098A")]
	[Address(RVA = "0x18D55C4", Offset = "0x18D55C4", VA = "0x18D55C4")]
	public void SetReportMailStatus(EMail.Status status)
	{
	}

	[Token(Token = "0x601098B")]
	[Address(RVA = "0x18D3540", Offset = "0x18D3540", VA = "0x18D3540")]
	private void SetMailContentBtnStatus(bool del = true, bool rec = false, bool acc = false, bool rej = false, bool open = false)
	{
	}

	[Token(Token = "0x601098C")]
	[Address(RVA = "0x18D6ED8", Offset = "0x18D6ED8", VA = "0x18D6ED8")]
	private void UpdateMailView(object[] data)
	{
	}

	[Token(Token = "0x601098D")]
	[Address(RVA = "0x18DB4CC", Offset = "0x18DB4CC", VA = "0x18DB4CC")]
	private void SetButtonStateByMailType()
	{
	}

	[Token(Token = "0x601098E")]
	[Address(RVA = "0x18DA88C", Offset = "0x18DA88C", VA = "0x18DA88C")]
	private void RefreshBatchOperationBtns()
	{
	}

	[Token(Token = "0x601098F")]
	[Address(RVA = "0x18D381C", Offset = "0x18D381C", VA = "0x18D381C")]
	private void RefreshRewardData()
	{
	}

	[Token(Token = "0x6010990")]
	[Address(RVA = "0x18DDFCC", Offset = "0x18DDFCC", VA = "0x18DDFCC")]
	private void SetMailGrid(UIGrid grid)
	{
	}

	[Token(Token = "0x6010991")]
	[Address(RVA = "0x18DE614", Offset = "0x18DE614", VA = "0x18DE614", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010992")]
	[Address(RVA = "0x18DE7B0", Offset = "0x18DE7B0", VA = "0x18DE7B0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010993")]
	[Address(RVA = "0x18DEA40", Offset = "0x18DEA40", VA = "0x18DEA40", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010994")]
	[Address(RVA = "0x18DEAC4", Offset = "0x18DEAC4", VA = "0x18DEAC4", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010995")]
	[Address(RVA = "0x18DF398", Offset = "0x18DF398", VA = "0x18DF398")]
	private void CheckIfPopupRewards(object[] objects)
	{
	}

	[Token(Token = "0x6010996")]
	[Address(RVA = "0x18D60A0", Offset = "0x18D60A0", VA = "0x18D60A0")]
	private void GetMailRefreshUIData()
	{
	}

	[Token(Token = "0x6010997")]
	[Address(RVA = "0x18DF5A0", Offset = "0x18DF5A0", VA = "0x18DF5A0")]
	private void ReadMailRefreshUIData(object[] objects)
	{
	}

	[Token(Token = "0x6010998")]
	[Address(RVA = "0x18DFB60", Offset = "0x18DFB60", VA = "0x18DFB60")]
	private void ReadReportMailRefreshUIData(object[] objects)
	{
	}

	[Token(Token = "0x6010999")]
	[Address(RVA = "0x18E03BC", Offset = "0x18E03BC", VA = "0x18E03BC")]
	private void SelectMailItem(int index)
	{
	}

	[Token(Token = "0x601099A")]
	[Address(RVA = "0x18E051C", Offset = "0x18E051C", VA = "0x18E051C")]
	private void SelectReportMailItem(int index)
	{
	}

	[Token(Token = "0x601099B")]
	[Address(RVA = "0x18E0120", Offset = "0x18E0120", VA = "0x18E0120")]
	private void RefreshMailUI(bool show)
	{
	}

	[Token(Token = "0x601099C")]
	[Address(RVA = "0x18E067C", Offset = "0x18E067C", VA = "0x18E067C", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601099D")]
	[Address(RVA = "0x18E0734", Offset = "0x18E0734", VA = "0x18E0734", Slot = "44")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x601099E")]
	[Address(RVA = "0x18E082C", Offset = "0x18E082C", VA = "0x18E082C", Slot = "45")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x601099F")]
	[Address(RVA = "0x18D4374", Offset = "0x18D4374", VA = "0x18D4374")]
	private void ShowGiftMail(object[] data)
	{
	}

	[Token(Token = "0x60109A0")]
	[Address(RVA = "0x18DB838", Offset = "0x18DB838", VA = "0x18DB838")]
	private void RefreshReportMailView()
	{
	}

	[Token(Token = "0x60109A1")]
	[Address(RVA = "0x18E154C", Offset = "0x18E154C", VA = "0x18E154C")]
	private IEnumerator tReasonTableReposition()
	{
		return null;
	}

	[Token(Token = "0x60109A2")]
	[Address(RVA = "0x18DAC98", Offset = "0x18DAC98", VA = "0x18DAC98")]
	private void SetMailContentText(string text)
	{
	}

	[Token(Token = "0x60109A3")]
	[Address(RVA = "0x18DAF30", Offset = "0x18DAF30", VA = "0x18DAF30")]
	private void SetMailContextTextWithSpritesMixed(string text, string[] spriteNames)
	{
	}

	[Token(Token = "0x60109A4")]
	[Address(RVA = "0x18DADE0", Offset = "0x18DADE0", VA = "0x18DADE0")]
	private void SetGiftMailContentText(string text)
	{
	}

	[Token(Token = "0x60109A5")]
	[Address(RVA = "0x18DAE88", Offset = "0x18DAE88", VA = "0x18DAE88")]
	private void SetGiftMailMessageText(string text)
	{
	}

	[Token(Token = "0x60109A6")]
	[Address(RVA = "0x18E08B0", Offset = "0x18E08B0", VA = "0x18E08B0")]
	private string FixRichTextToBlack(string str)
	{
		return null;
	}

	[Token(Token = "0x60109A7")]
	[Address(RVA = "0x18E09A4", Offset = "0x18E09A4", VA = "0x18E09A4")]
	private string GetMainReason(uint reason)
	{
		return null;
	}

	[Token(Token = "0x60109A9")]
	[Address(RVA = "0x18E16EC", Offset = "0x18E16EC", VA = "0x18E16EC")]
	private bool _003COnDeleteAllBtnClick_003Em__0(MailInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x60109AA")]
	[Address(RVA = "0x18E1720", Offset = "0x18E1720", VA = "0x18E1720")]
	private void _003COnDeleteAllBtnClick_003Em__1()
	{
	}

	[Token(Token = "0x60109AB")]
	[Address(RVA = "0x18E1798", Offset = "0x18E1798", VA = "0x18E1798")]
	private void _003COnDeleteAllBtnClick_003Em__2()
	{
	}

	[Token(Token = "0x60109AC")]
	[Address(RVA = "0x18E17E4", Offset = "0x18E17E4", VA = "0x18E17E4")]
	private bool _003COnDeleteAllBtnClick_003Em__3(ReportMailInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x60109AD")]
	[Address(RVA = "0x18E1818", Offset = "0x18E1818", VA = "0x18E1818")]
	private void _003COnDeleteAllBtnClick_003Em__4()
	{
	}

	[Token(Token = "0x60109AE")]
	[Address(RVA = "0x18E1890", Offset = "0x18E1890", VA = "0x18E1890")]
	private void _003COnDeleteAllBtnClick_003Em__5()
	{
	}

	[Token(Token = "0x60109AF")]
	[Address(RVA = "0x18E18D8", Offset = "0x18E18D8", VA = "0x18E18D8")]
	private bool _003CRefreshBatchOperationBtns_003Em__6(MailInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x60109B0")]
	[Address(RVA = "0x18E190C", Offset = "0x18E190C", VA = "0x18E190C")]
	private bool _003CRefreshBatchOperationBtns_003Em__7(MailInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x60109B1")]
	[Address(RVA = "0x18E1940", Offset = "0x18E1940", VA = "0x18E1940")]
	private bool _003CRefreshBatchOperationBtns_003Em__8(ReportMailInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x60109B2")]
	[Address(RVA = "0x18E1974", Offset = "0x18E1974", VA = "0x18E1974")]
	private bool _003CRefreshBatchOperationBtns_003Em__9(ReportMailInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x60109B3")]
	[Address(RVA = "0x18E19A8", Offset = "0x18E19A8", VA = "0x18E19A8")]
	private bool _003CReadMailRefreshUIData_003Em__A(MailInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x60109B4")]
	[Address(RVA = "0x18E19E8", Offset = "0x18E19E8", VA = "0x18E19E8")]
	private bool _003CReadReportMailRefreshUIData_003Em__B(ReportMailInfo a)
	{
		return default(bool);
	}

	[Token(Token = "0x60109B5")]
	[Address(RVA = "0x18E1A28", Offset = "0x18E1A28", VA = "0x18E1A28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60109B6")]
	[Address(RVA = "0x18E1A30", Offset = "0x18E1A30", VA = "0x18E1A30")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x60109B7")]
	[Address(RVA = "0x18E1A38", Offset = "0x18E1A38", VA = "0x18E1A38")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x60109B8")]
	[Address(RVA = "0x18E1A40", Offset = "0x18E1A40", VA = "0x18E1A40")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60109B9")]
	[Address(RVA = "0x18E1A48", Offset = "0x18E1A48", VA = "0x18E1A48")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
