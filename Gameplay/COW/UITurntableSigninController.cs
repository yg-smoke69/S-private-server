using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002B85")]
public class UITurntableSigninController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002B86")]
	private sealed class _003CWaitInitHttpRequest_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010A8E")]
		[FieldOffset(Offset = "0x8")]
		internal HttpRequest request;

		[Token(Token = "0x4010A8F")]
		[FieldOffset(Offset = "0xC")]
		internal UITurntableSigninController _0024this;

		[Token(Token = "0x4010A90")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4010A91")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x4010A92")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170012F1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6011FD6")]
			[Address(RVA = "0x1C35120", Offset = "0x1C35120", VA = "0x1C35120", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012F2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6011FD7")]
			[Address(RVA = "0x1C35128", Offset = "0x1C35128", VA = "0x1C35128", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6011FD4")]
		[Address(RVA = "0x1C31AAC", Offset = "0x1C31AAC", VA = "0x1C31AAC")]
		public _003CWaitInitHttpRequest_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6011FD5")]
		[Address(RVA = "0x1C35060", Offset = "0x1C35060", VA = "0x1C35060", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6011FD8")]
		[Address(RVA = "0x1C35130", Offset = "0x1C35130", VA = "0x1C35130", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6011FD9")]
		[Address(RVA = "0x1C35144", Offset = "0x1C35144", VA = "0x1C35144", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002B87")]
	private sealed class _003CRefreshSignedAward_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010A93")]
		[FieldOffset(Offset = "0x8")]
		internal uint signID;

		[Token(Token = "0x6011FDA")]
		[Address(RVA = "0x1C33438", Offset = "0x1C33438", VA = "0x1C33438")]
		public _003CRefreshSignedAward_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6011FDB")]
		[Address(RVA = "0x1C34F70", Offset = "0x1C34F70", VA = "0x1C34F70")]
		internal bool _003C_003Em__0(UITurntableSigninItemController item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002B88")]
	private sealed class _003CShowGetRewardEffect_003Ec__AnonStorey2
	{
		[Token(Token = "0x4010A94")]
		[FieldOffset(Offset = "0x8")]
		internal uint signID;

		[Token(Token = "0x6011FDC")]
		[Address(RVA = "0x1C33794", Offset = "0x1C33794", VA = "0x1C33794")]
		public _003CShowGetRewardEffect_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6011FDD")]
		[Address(RVA = "0x1C35020", Offset = "0x1C35020", VA = "0x1C35020")]
		internal bool _003C_003Em__0(UITurntableSigninItemController item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002B89")]
	private sealed class _003CDelayShowReward_003Ec__AnonStorey3
	{
		[Token(Token = "0x4010A95")]
		[FieldOffset(Offset = "0x8")]
		internal uint signID;

		[Token(Token = "0x6011FDE")]
		[Address(RVA = "0x1C34018", Offset = "0x1C34018", VA = "0x1C34018")]
		public _003CDelayShowReward_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6011FDF")]
		[Address(RVA = "0x1C34F38", Offset = "0x1C34F38", VA = "0x1C34F38")]
		internal bool _003C_003Em__0(AttendanceItem award)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4010A82")]
	[FieldOffset(Offset = "0x48")]
	private UITurntableSignInView m_View;

	[Token(Token = "0x4010A83")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelAnnoucementReward m_ModelAnnoucement;

	[Token(Token = "0x4010A84")]
	[FieldOffset(Offset = "0x50")]
	private UIModelRampage m_ModelRampage;

	[Token(Token = "0x4010A85")]
	[FieldOffset(Offset = "0x54")]
	private List<UITurntableSigninItemController> m_AwardCtrlList;

	[Token(Token = "0x4010A86")]
	[FieldOffset(Offset = "0x58")]
	private List<Transform> m_AwardContainerList;

	[Token(Token = "0x4010A87")]
	[FieldOffset(Offset = "0x5C")]
	private List<uint> m_SignIDList;

	[Token(Token = "0x4010A88")]
	[FieldOffset(Offset = "0x60")]
	private uint m_DelayCall;

	[Token(Token = "0x4010A89")]
	[FieldOffset(Offset = "0x64")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x4010A8A")]
	[FieldOffset(Offset = "0x68")]
	private ClientActivityDesc m_PeakDayClientActivityDesc;

	[Token(Token = "0x4010A8B")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_PeakDayAwardClaimed;

	[Token(Token = "0x4010A8C")]
	[FieldOffset(Offset = "0x70")]
	private UIStandardItemMAXBController m_PeakDayAwardCtrl;

	[Token(Token = "0x4010A8D")]
	[FieldOffset(Offset = "0x74")]
	private IEnumerator m_WaitInitHttpRequest;

	[Token(Token = "0x6011FB8")]
	[Address(RVA = "0x1C31034", Offset = "0x1C31034", VA = "0x1C31034")]
	public UITurntableSigninController()
	{
	}

	[Token(Token = "0x6011FB9")]
	[Address(RVA = "0x1C31128", Offset = "0x1C31128", VA = "0x1C31128")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011FBA")]
	[Address(RVA = "0x1C311D0", Offset = "0x1C311D0", VA = "0x1C311D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011FBB")]
	[Address(RVA = "0x1C319C0", Offset = "0x1C319C0", VA = "0x1C319C0")]
	private IEnumerator WaitInitHttpRequest(HttpRequest request)
	{
		return null;
	}

	[Token(Token = "0x6011FBC")]
	[Address(RVA = "0x1C31AB4", Offset = "0x1C31AB4", VA = "0x1C31AB4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011FBD")]
	[Address(RVA = "0x1C31734", Offset = "0x1C31734", VA = "0x1C31734")]
	private void InitAwardContainer()
	{
	}

	[Token(Token = "0x6011FBE")]
	[Address(RVA = "0x1C31C7C", Offset = "0x1C31C7C", VA = "0x1C31C7C")]
	private void RefreshPeakDayAward()
	{
	}

	[Token(Token = "0x6011FBF")]
	[Address(RVA = "0x1C32364", Offset = "0x1C32364", VA = "0x1C32364")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6011FC0")]
	[Address(RVA = "0x1C323DC", Offset = "0x1C323DC", VA = "0x1C323DC")]
	private void RefreshNetworkBg()
	{
	}

	[Token(Token = "0x6011FC1")]
	[Address(RVA = "0x1C32668", Offset = "0x1C32668", VA = "0x1C32668")]
	private void RefreshAwardList()
	{
	}

	[Token(Token = "0x6011FC2")]
	[Address(RVA = "0x1C329A0", Offset = "0x1C329A0", VA = "0x1C329A0")]
	private void RefreshTime()
	{
	}

	[Token(Token = "0x6011FC3")]
	[Address(RVA = "0x1C33154", Offset = "0x1C33154", VA = "0x1C33154")]
	private void RefreshSignedAward()
	{
	}

	[Token(Token = "0x6011FC4")]
	[Address(RVA = "0x1C334B0", Offset = "0x1C334B0", VA = "0x1C334B0")]
	private void ShowGetRewardEffect()
	{
	}

	[Token(Token = "0x6011FC5")]
	[Address(RVA = "0x1C32C5C", Offset = "0x1C32C5C", VA = "0x1C32C5C")]
	private void RefreshSignBtn()
	{
	}

	[Token(Token = "0x6011FC6")]
	[Address(RVA = "0x1C3382C", Offset = "0x1C3382C", VA = "0x1C3382C")]
	private void ShowResult(object[] param)
	{
	}

	[Token(Token = "0x6011FC7")]
	[Address(RVA = "0x1C3394C", Offset = "0x1C3394C", VA = "0x1C3394C")]
	private void DelayShowReward()
	{
	}

	[Token(Token = "0x6011FC8")]
	[Address(RVA = "0x1C33F80", Offset = "0x1C33F80", VA = "0x1C33F80")]
	private void SetSignBtnState(bool enable)
	{
	}

	[Token(Token = "0x6011FC9")]
	[Address(RVA = "0x1C34020", Offset = "0x1C34020", VA = "0x1C34020")]
	private void OnRuleBtnClick()
	{
	}

	[Token(Token = "0x6011FCA")]
	[Address(RVA = "0x1C34074", Offset = "0x1C34074", VA = "0x1C34074")]
	private void OnSigninBtnClick()
	{
	}

	[Token(Token = "0x6011FCB")]
	[Address(RVA = "0x1C3430C", Offset = "0x1C3430C", VA = "0x1C3430C")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x6011FCC")]
	[Address(RVA = "0x1C34370", Offset = "0x1C34370", VA = "0x1C34370", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011FCD")]
	[Address(RVA = "0x1C343D4", Offset = "0x1C343D4", VA = "0x1C343D4")]
	private void OnTimeBtnClick()
	{
	}

	[Token(Token = "0x6011FCE")]
	[Address(RVA = "0x1C3461C", Offset = "0x1C3461C", VA = "0x1C3461C")]
	private void OnPeakDayAwardClick()
	{
	}

	[Token(Token = "0x6011FCF")]
	[Address(RVA = "0x1C34B4C", Offset = "0x1C34B4C", VA = "0x1C34B4C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011FD0")]
	[Address(RVA = "0x1C34E68", Offset = "0x1C34E68", VA = "0x1C34E68", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011FD1")]
	[Address(RVA = "0x1C34F20", Offset = "0x1C34F20", VA = "0x1C34F20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011FD2")]
	[Address(RVA = "0x1C34F28", Offset = "0x1C34F28", VA = "0x1C34F28")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011FD3")]
	[Address(RVA = "0x1C34F30", Offset = "0x1C34F30", VA = "0x1C34F30")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
