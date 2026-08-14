using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F88")]
internal class UIBigEventMainBaseController : UIBigEventNaviPopBaseController, _Attribute
{
	[Token(Token = "0x2001F89")]
	public class BigEventEntranceView
	{
		[Token(Token = "0x400C5FA")]
		[FieldOffset(Offset = "0x8")]
		public UIModelBigEvent.EBigEventEntranceID EntranceID;

		[Token(Token = "0x400C5FB")]
		[FieldOffset(Offset = "0xC")]
		public UIButton BtnObj;

		[Token(Token = "0x400C5FC")]
		[FieldOffset(Offset = "0x10")]
		public GameObject OpenObj;

		[Token(Token = "0x400C5FD")]
		[FieldOffset(Offset = "0x14")]
		public GameObject GreyObj;

		[Token(Token = "0x400C5FE")]
		[FieldOffset(Offset = "0x18")]
		public GameObject RedPoint;

		[Token(Token = "0x400C5FF")]
		[FieldOffset(Offset = "0x1C")]
		public UINetworkTexture CDNIcon;

		[Token(Token = "0x400C600")]
		[FieldOffset(Offset = "0x20")]
		public GameObject DefaultIcon;

		[Token(Token = "0x400C601")]
		[FieldOffset(Offset = "0x24")]
		public UILabel LabelIntroduce;

		[Token(Token = "0x6009CEE")]
		[Address(RVA = "0x3014264", Offset = "0x3014264", VA = "0x3014264")]
		public BigEventEntranceView(UIModelBigEvent.EBigEventEntranceID entranceID, UIButton btnObj, GameObject openObj, GameObject greyObj, GameObject redPoint, UILabel labelInroduce)
		{
		}
	}

	[Token(Token = "0x2001F8A")]
	private sealed class _003CAddBigEventBtnEntranceEffect_003Ec__AnonStorey1
	{
		[Token(Token = "0x400C602")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject effect;

		[Token(Token = "0x400C603")]
		[FieldOffset(Offset = "0xC")]
		internal float effectTime;

		[Token(Token = "0x400C604")]
		[FieldOffset(Offset = "0x10")]
		internal UIBigEventMainBaseController _0024this;

		[Token(Token = "0x6009CEF")]
		[Address(RVA = "0x3013E14", Offset = "0x3013E14", VA = "0x3013E14")]
		public _003CAddBigEventBtnEntranceEffect_003Ec__AnonStorey1()
		{
		}
	}

	[Token(Token = "0x2001F8B")]
	private sealed class _003CAddBigEventBtnEntranceEffect_003Ec__AnonStorey2
	{
		[Token(Token = "0x400C605")]
		[FieldOffset(Offset = "0x8")]
		internal List<EventDelegate> onclick;

		[Token(Token = "0x400C606")]
		[FieldOffset(Offset = "0xC")]
		internal _003CAddBigEventBtnEntranceEffect_003Ec__AnonStorey1 _003C_003Ef__ref_00241;

		[Token(Token = "0x6009CF0")]
		[Address(RVA = "0x3013E1C", Offset = "0x3013E1C", VA = "0x3013E1C")]
		public _003CAddBigEventBtnEntranceEffect_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6009CF1")]
		[Address(RVA = "0x3014E94", Offset = "0x3014E94", VA = "0x3014E94")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2001F8C")]
	private sealed class _003CNaviCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C607")]
		[FieldOffset(Offset = "0x8")]
		internal float effectTime;

		[Token(Token = "0x400C608")]
		[FieldOffset(Offset = "0xC")]
		internal List<EventDelegate> actionList;

		[Token(Token = "0x400C609")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400C60A")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400C60B")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000F99")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009CF4")]
			[Address(RVA = "0x3015204", Offset = "0x3015204", VA = "0x3015204", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F9A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009CF5")]
			[Address(RVA = "0x301520C", Offset = "0x301520C", VA = "0x301520C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009CF2")]
		[Address(RVA = "0x3013F30", Offset = "0x3013F30", VA = "0x3013F30")]
		public _003CNaviCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009CF3")]
		[Address(RVA = "0x30150F4", Offset = "0x30150F4", VA = "0x30150F4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009CF6")]
		[Address(RVA = "0x3015214", Offset = "0x3015214", VA = "0x3015214", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009CF7")]
		[Address(RVA = "0x3015228", Offset = "0x3015228", VA = "0x3015228", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001F8D")]
	private sealed class _003CInitBigEventBtnEntrance_003Ec__AnonStorey3
	{
		[Token(Token = "0x400C60C")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelBigEvent.EBigEventEntranceID entranceID;

		[Token(Token = "0x400C60D")]
		[FieldOffset(Offset = "0xC")]
		internal UIBigEventMainBaseController _0024this;

		[Token(Token = "0x6009CF8")]
		[Address(RVA = "0x301425C", Offset = "0x301425C", VA = "0x301425C")]
		public _003CInitBigEventBtnEntrance_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6009CF9")]
		[Address(RVA = "0x30150C4", Offset = "0x30150C4", VA = "0x30150C4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400C5EE")]
	[FieldOffset(Offset = "0x70")]
	protected UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C5EF")]
	[FieldOffset(Offset = "0x74")]
	protected UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C5F0")]
	[FieldOffset(Offset = "0x78")]
	private uint m_DelayCallId;

	[Token(Token = "0x400C5F1")]
	[FieldOffset(Offset = "0x7C")]
	private UIButton m_BtnPeakDay;

	[Token(Token = "0x400C5F2")]
	[FieldOffset(Offset = "0x80")]
	private GameObject m_Bubble;

	[Token(Token = "0x400C5F3")]
	[FieldOffset(Offset = "0x84")]
	private GameObject m_BubbleVFX;

	[Token(Token = "0x400C5F4")]
	[FieldOffset(Offset = "0x88")]
	private UILabel m_BubbleLabel;

	[Token(Token = "0x400C5F5")]
	[FieldOffset(Offset = "0x8C")]
	private UIBigEventPeakDayWndBaseController m_PeakDayCtrl;

	[Token(Token = "0x400C5F6")]
	[FieldOffset(Offset = "0x90")]
	protected float m_PeakDayDelayLength;

	[Token(Token = "0x400C5F7")]
	[FieldOffset(Offset = "0x94")]
	public Dictionary<int, BigEventEntranceView> m_EntranceViewDict;

	[Token(Token = "0x400C5F8")]
	[FieldOffset(Offset = "0x98")]
	private Coroutine m_NaviCoroutine;

	[Token(Token = "0x400C5F9")]
	[FieldOffset(Offset = "0x9C")]
	public bool EnableAutoPeakday;

	[Token(Token = "0x6009CCB")]
	[Address(RVA = "0x3011438", Offset = "0x3011438", VA = "0x3011438")]
	public UIBigEventMainBaseController()
	{
	}

	[Token(Token = "0x6009CCC")]
	[Address(RVA = "0x30114DC", Offset = "0x30114DC", VA = "0x30114DC", Slot = "48")]
	public virtual UINavigationUtil.UINavigationFrom GetNavigationFrom()
	{
		return default(UINavigationUtil.UINavigationFrom);
	}

	[Token(Token = "0x6009CCD")]
	[Address(RVA = "0x3011534", Offset = "0x3011534", VA = "0x3011534", Slot = "38")]
	public override EFrontendBGMType GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x6009CCE")]
	[Address(RVA = "0x30115EC", Offset = "0x30115EC", VA = "0x30115EC", Slot = "45")]
	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x6009CCF")]
	[Address(RVA = "0x3011644", Offset = "0x3011644", VA = "0x3011644", Slot = "49")]
	public virtual string GetEntranceOverStateTipKey()
	{
		return null;
	}

	[Token(Token = "0x6009CD0")]
	[Address(RVA = "0x30116E8", Offset = "0x30116E8", VA = "0x30116E8", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6009CD1")]
	[Address(RVA = "0x3011CF8", Offset = "0x3011CF8", VA = "0x3011CF8", Slot = "50")]
	protected virtual bool AutoOpenPeakDayWndEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6009CD2")]
	[Address(RVA = "0x3011D50", Offset = "0x3011D50", VA = "0x3011D50", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009CD3")]
	[Address(RVA = "0x3011F04", Offset = "0x3011F04", VA = "0x3011F04", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009CD4")]
	[Address(RVA = "0x301200C", Offset = "0x301200C", VA = "0x301200C", Slot = "51")]
	public virtual UIBigEventPeakDayWndBaseController GetPeakDayWndCtrl()
	{
		return null;
	}

	[Token(Token = "0x6009CD5")]
	[Address(RVA = "0x301211C", Offset = "0x301211C", VA = "0x301211C")]
	public string GetPeakDayTitleKey()
	{
		return null;
	}

	[Token(Token = "0x6009CD6")]
	[Address(RVA = "0x30121C0", Offset = "0x30121C0", VA = "0x30121C0", Slot = "52")]
	public virtual void RefreshView()
	{
	}

	[Token(Token = "0x6009CD7")]
	[Address(RVA = "0x301317C", Offset = "0x301317C", VA = "0x301317C")]
	public bool IsOpeningPeakDay()
	{
		return default(bool);
	}

	[Token(Token = "0x6009CD8")]
	[Address(RVA = "0x3013260", Offset = "0x3013260", VA = "0x3013260")]
	public void InitBtnPeakDay(UIButton btnPeakDay, GameObject bubble, GameObject bubbleVFX, UILabel bubbleLabel)
	{
	}

	[Token(Token = "0x6009CD9")]
	[Address(RVA = "0x30133B4", Offset = "0x30133B4", VA = "0x30133B4")]
	private void OnWebViewClose(object[] data)
	{
	}

	[Token(Token = "0x6009CDA")]
	[Address(RVA = "0x3013428", Offset = "0x3013428", VA = "0x3013428")]
	private void OnBtnPeakDayClick()
	{
	}

	[Token(Token = "0x6009CDB")]
	[Address(RVA = "0x301238C", Offset = "0x301238C", VA = "0x301238C")]
	private void RefreshPeakDayBtnView()
	{
	}

	[Token(Token = "0x6009CDC")]
	[Address(RVA = "0x3011864", Offset = "0x3011864", VA = "0x3011864")]
	protected void AutoOpenPeakDayWnd(float time, bool autoOpenEnabled = true)
	{
	}

	[Token(Token = "0x6009CDD")]
	[Address(RVA = "0x3012708", Offset = "0x3012708", VA = "0x3012708")]
	public void RefreshBigEventBtnEntrance(BigEventEntranceView entranceView)
	{
	}

	[Token(Token = "0x6009CDE")]
	[Address(RVA = "0x3013A20", Offset = "0x3013A20", VA = "0x3013A20")]
	public BigEventEntranceView GetEntranceViewById(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
		return null;
	}

	[Token(Token = "0x6009CDF")]
	[Address(RVA = "0x3013B08", Offset = "0x3013B08", VA = "0x3013B08")]
	public void AddBigEventBtnEntranceCDN(UIModelBigEvent.EBigEventEntranceID entranceID, UINetworkTexture cdnIcon, GameObject defaultIcon)
	{
	}

	[Token(Token = "0x6009CE0")]
	[Address(RVA = "0x3013BB0", Offset = "0x3013BB0", VA = "0x3013BB0")]
	public void AddBigEventBtnEntranceEffect(UIModelBigEvent.EBigEventEntranceID entranceID, GameObject effect, float effectTime = 0.5f)
	{
	}

	[Token(Token = "0x6009CE1")]
	[Address(RVA = "0x3013E24", Offset = "0x3013E24", VA = "0x3013E24")]
	private IEnumerator NaviCoroutine(List<EventDelegate> actionList, float effectTime)
	{
		return null;
	}

	[Token(Token = "0x6009CE2")]
	[Address(RVA = "0x3013F38", Offset = "0x3013F38", VA = "0x3013F38")]
	public void InitBigEventBtnEntrance(UIModelBigEvent.EBigEventEntranceID entranceID, UIButton btnEntrance, [Optional] GameObject openObj, [Optional] GameObject greyObj, [Optional] GameObject onceRedPoint, [Optional] UILabel labelIntroduce, [Optional] Callback onBtnClick)
	{
	}

	[Token(Token = "0x6009CE3")]
	[Address(RVA = "0x30142AC", Offset = "0x30142AC", VA = "0x30142AC")]
	private bool CheckEntranceState(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
		return default(bool);
	}

	[Token(Token = "0x6009CE4")]
	[Address(RVA = "0x3014670", Offset = "0x3014670", VA = "0x3014670")]
	private void OnGoToNavigation(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
	}

	[Token(Token = "0x6009CE5")]
	[Address(RVA = "0x3014A10", Offset = "0x3014A10", VA = "0x3014A10", Slot = "53")]
	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009CE6")]
	[Address(RVA = "0x3014AE8", Offset = "0x3014AE8", VA = "0x3014AE8", Slot = "54")]
	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009CE7")]
	[Address(RVA = "0x3014B7C", Offset = "0x3014B7C", VA = "0x3014B7C")]
	public void SetTitelView(UILabel labelDate, UINetworkTextureExt cdnTexture, int cdnType)
	{
	}

	[Token(Token = "0x6009CE8")]
	[Address(RVA = "0x3014E00", Offset = "0x3014E00", VA = "0x3014E00")]
	private void _003CAutoOpenPeakDayWnd_003Em__0()
	{
	}

	[Token(Token = "0x6009CE9")]
	[Address(RVA = "0x3014E1C", Offset = "0x3014E1C", VA = "0x3014E1C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009CEA")]
	[Address(RVA = "0x3014E24", Offset = "0x3014E24", VA = "0x3014E24")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009CEB")]
	[Address(RVA = "0x3014E2C", Offset = "0x3014E2C", VA = "0x3014E2C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6009CEC")]
	[Address(RVA = "0x3014E34", Offset = "0x3014E34", VA = "0x3014E34")]
	public new EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x6009CED")]
	[Address(RVA = "0x3014E38", Offset = "0x3014E38", VA = "0x3014E38")]
	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}
}
