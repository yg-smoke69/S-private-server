using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001EDC")]
internal class UIDigitaluniverseBMapDoorController : UIBigEventNaviPopBaseController, _Attribute
{
	[Token(Token = "0x2001EDD")]
	public enum DigitalUniverseBMapGuide
	{
		[Token(Token = "0x400C265")]
		Welcome,
		[Token(Token = "0x400C266")]
		Introduce,
		[Token(Token = "0x400C267")]
		ClickGo,
		[Token(Token = "0x400C268")]
		Done
	}

	[Token(Token = "0x2001EDE")]
	private sealed class _003CPrepareMapAreaCtrl_003Ec__AnonStorey1
	{
		[Token(Token = "0x400C269")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x400C26A")]
		[FieldOffset(Offset = "0xC")]
		internal UIDigitaluniverseBMapDoorController _0024this;

		[Token(Token = "0x6009693")]
		[Address(RVA = "0x2F7719C", Offset = "0x2F7719C", VA = "0x2F7719C")]
		public _003CPrepareMapAreaCtrl_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6009694")]
		[Address(RVA = "0x2F7CD4C", Offset = "0x2F7CD4C", VA = "0x2F7CD4C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2001EDF")]
	private sealed class _003CGetMissionByStateAndIndex_003Ec__AnonStorey2
	{
		[Token(Token = "0x400C26B")]
		[FieldOffset(Offset = "0x8")]
		internal EActivity.State state;

		[Token(Token = "0x400C26C")]
		[FieldOffset(Offset = "0xC")]
		internal UIDigitaluniverseBMapDoorController _0024this;

		[Token(Token = "0x6009695")]
		[Address(RVA = "0x2F7974C", Offset = "0x2F7974C", VA = "0x2F7974C")]
		public _003CGetMissionByStateAndIndex_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6009696")]
		[Address(RVA = "0x2F7C5EC", Offset = "0x2F7C5EC", VA = "0x2F7C5EC")]
		internal bool _003C_003Em__0(DigitaluniverseBMapMissionDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001EE0")]
	private sealed class _003COnMapClaim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C26D")]
		[FieldOffset(Offset = "0x8")]
		internal string _003CanimName_003E__0;

		[Token(Token = "0x400C26E")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Clength_003E__0;

		[Token(Token = "0x400C26F")]
		[FieldOffset(Offset = "0x10")]
		internal UIDigitaluniverseBMapDoorController _0024this;

		[Token(Token = "0x400C270")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400C271")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400C272")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17000F66")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009699")]
			[Address(RVA = "0x2F7CCA0", Offset = "0x2F7CCA0", VA = "0x2F7CCA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F67")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600969A")]
			[Address(RVA = "0x2F7CCA8", Offset = "0x2F7CCA8", VA = "0x2F7CCA8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009697")]
		[Address(RVA = "0x2F79F20", Offset = "0x2F79F20", VA = "0x2F79F20")]
		public _003COnMapClaim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009698")]
		[Address(RVA = "0x2F7C670", Offset = "0x2F7C670", VA = "0x2F7C670", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600969B")]
		[Address(RVA = "0x2F7CCB0", Offset = "0x2F7CCB0", VA = "0x2F7CCB0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600969C")]
		[Address(RVA = "0x2F7CCC4", Offset = "0x2F7CCC4", VA = "0x2F7CCC4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C24E")]
	[FieldOffset(Offset = "0x70")]
	private UIDigitaluniverseBMapDoorView m_View;

	[Token(Token = "0x400C24F")]
	[FieldOffset(Offset = "0x74")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C250")]
	[FieldOffset(Offset = "0x78")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C251")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C252")]
	[FieldOffset(Offset = "0x80")]
	private DigitalUniverseBMapGuide m_GuideState;

	[Token(Token = "0x400C253")]
	[FieldOffset(Offset = "0x84")]
	private bool m_InAwardProgress;

	[Token(Token = "0x400C254")]
	[FieldOffset(Offset = "0x85")]
	private bool m_AllMissionsClaimed;

	[Token(Token = "0x400C255")]
	[FieldOffset(Offset = "0x86")]
	private bool m_InGuide;

	[Token(Token = "0x400C256")]
	private const int AWARDCOUNT = 7;

	[Token(Token = "0x400C257")]
	private const int MAPCOUNT = 10;

	[Token(Token = "0x400C258")]
	[FieldOffset(Offset = "0x88")]
	private float m_FirstAwardProgressValue;

	[Token(Token = "0x400C259")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400C25A")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<int, string> MapID2Name;

	[Token(Token = "0x400C25B")]
	[FieldOffset(Offset = "0x94")]
	private UIDigitaluniverseBTopBtnController m_TopBtnCtrl;

	[Token(Token = "0x400C25C")]
	[FieldOffset(Offset = "0x98")]
	private List<Transform> m_ListAwardItemPos;

	[Token(Token = "0x400C25D")]
	[FieldOffset(Offset = "0x9C")]
	private List<UIButton> m_MapDoorAreaPos;

	[Token(Token = "0x400C25E")]
	[FieldOffset(Offset = "0xA0")]
	private List<GameObject> m_MapDoorUnLockEff;

	[Token(Token = "0x400C25F")]
	[FieldOffset(Offset = "0xA4")]
	private readonly List<UIDigitaluniverseBMapDoorAreaController> m_MapDoorAreaCtrlList;

	[Token(Token = "0x400C260")]
	[FieldOffset(Offset = "0xA8")]
	private readonly List<UIDigitaluniverseBMapDoorMissionController> m_MapDoorMissionCtrlList;

	[Token(Token = "0x400C261")]
	[FieldOffset(Offset = "0xAC")]
	private readonly List<UIDigitaluniverseBNormalAwardItemController> m_ListNormalAwardItem;

	[Token(Token = "0x400C262")]
	[FieldOffset(Offset = "0xB0")]
	private readonly List<UIStandardItemMiniController> m_ItemMiniList;

	[Token(Token = "0x400C263")]
	[FieldOffset(Offset = "0xB4")]
	private int m_CurMapIndex;

	[Token(Token = "0x6009663")]
	[Address(RVA = "0x2F74FF0", Offset = "0x2F74FF0", VA = "0x2F74FF0")]
	public UIDigitaluniverseBMapDoorController()
	{
	}

	[Token(Token = "0x6009664")]
	[Address(RVA = "0x2F75478", Offset = "0x2F75478", VA = "0x2F75478")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009665")]
	[Address(RVA = "0x2F75520", Offset = "0x2F75520", VA = "0x2F75520")]
	public static void Push()
	{
	}

	[Token(Token = "0x6009666")]
	[Address(RVA = "0x2F756C4", Offset = "0x2F756C4", VA = "0x2F756C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009667")]
	[Address(RVA = "0x2F76FD8", Offset = "0x2F76FD8", VA = "0x2F76FD8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6009668")]
	[Address(RVA = "0x2F7703C", Offset = "0x2F7703C", VA = "0x2F7703C", Slot = "43")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009669")]
	[Address(RVA = "0x2F77094", Offset = "0x2F77094", VA = "0x2F77094", Slot = "45")]
	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x600966A")]
	[Address(RVA = "0x2F770EC", Offset = "0x2F770EC", VA = "0x2F770EC", Slot = "44")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x600966B")]
	[Address(RVA = "0x2F77144", Offset = "0x2F77144", VA = "0x2F77144")]
	private ELimitedEvent.DigitaluniverseBGateType GetGateType()
	{
		return default(ELimitedEvent.DigitaluniverseBGateType);
	}

	[Token(Token = "0x600966C")]
	[Address(RVA = "0x2F75D5C", Offset = "0x2F75D5C", VA = "0x2F75D5C")]
	private void PrepareTopBtn()
	{
	}

	[Token(Token = "0x600966D")]
	[Address(RVA = "0x2F75FF0", Offset = "0x2F75FF0", VA = "0x2F75FF0")]
	private void PrepareMapAreaCtrl()
	{
	}

	[Token(Token = "0x600966E")]
	[Address(RVA = "0x2F768A0", Offset = "0x2F768A0", VA = "0x2F768A0")]
	private void PrePareProgress()
	{
	}

	[Token(Token = "0x600966F")]
	[Address(RVA = "0x2F779B8", Offset = "0x2F779B8", VA = "0x2F779B8")]
	private void RefreshTopBtn()
	{
	}

	[Token(Token = "0x6009670")]
	[Address(RVA = "0x2F77AEC", Offset = "0x2F77AEC", VA = "0x2F77AEC")]
	private void MapAreaOnClick(int index)
	{
	}

	[Token(Token = "0x6009671")]
	[Address(RVA = "0x2F77E38", Offset = "0x2F77E38", VA = "0x2F77E38")]
	private void RefreshCurMap()
	{
	}

	[Token(Token = "0x6009672")]
	[Address(RVA = "0x2F77F6C", Offset = "0x2F77F6C", VA = "0x2F77F6C")]
	private void RefreshCurMission()
	{
	}

	[Token(Token = "0x6009673")]
	[Address(RVA = "0x2F76B64", Offset = "0x2F76B64", VA = "0x2F76B64")]
	private void RefreshMap()
	{
	}

	[Token(Token = "0x6009674")]
	[Address(RVA = "0x2F771A4", Offset = "0x2F771A4", VA = "0x2F771A4")]
	private void RefreshProgress()
	{
	}

	[Token(Token = "0x6009675")]
	[Address(RVA = "0x2F78C70", Offset = "0x2F78C70", VA = "0x2F78C70")]
	private uint GetMissionClaimByIndex(int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6009676")]
	[Address(RVA = "0x2F78C00", Offset = "0x2F78C00", VA = "0x2F78C00")]
	private uint GetMissionClaimedByIndex(int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6009677")]
	[Address(RVA = "0x2F79554", Offset = "0x2F79554", VA = "0x2F79554")]
	private uint GetMissionByStateAndIndex(EActivity.State state, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6009678")]
	[Address(RVA = "0x2F79754", Offset = "0x2F79754", VA = "0x2F79754")]
	private void OnCountDownRefresh(object[] data)
	{
	}

	[Token(Token = "0x6009679")]
	[Address(RVA = "0x2F797BC", Offset = "0x2F797BC", VA = "0x2F797BC")]
	private void ShowClaimAwardVFX(object[] data)
	{
	}

	[Token(Token = "0x600967A")]
	[Address(RVA = "0x2F79D18", Offset = "0x2F79D18", VA = "0x2F79D18")]
	private void ShowClaimAwardMapVFX()
	{
	}

	[Token(Token = "0x600967B")]
	[Address(RVA = "0x2F79E54", Offset = "0x2F79E54", VA = "0x2F79E54")]
	private IEnumerator OnMapClaim()
	{
		return null;
	}

	[Token(Token = "0x600967C")]
	[Address(RVA = "0x2F791BC", Offset = "0x2F791BC", VA = "0x2F791BC")]
	private void CheckMapUnLock()
	{
	}

	[Token(Token = "0x600967D")]
	[Address(RVA = "0x2F79F28", Offset = "0x2F79F28", VA = "0x2F79F28")]
	private bool CheckGuide()
	{
		return default(bool);
	}

	[Token(Token = "0x600967E")]
	[Address(RVA = "0x2F7A490", Offset = "0x2F7A490", VA = "0x2F7A490")]
	private void DoNextGuide()
	{
	}

	[Token(Token = "0x600967F")]
	[Address(RVA = "0x2F7A358", Offset = "0x2F7A358", VA = "0x2F7A358")]
	public void RefreshShareBubble()
	{
	}

	[Token(Token = "0x6009680")]
	[Address(RVA = "0x2F7B228", Offset = "0x2F7B228", VA = "0x2F7B228", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x6009681")]
	[Address(RVA = "0x2F7B3FC", Offset = "0x2F7B3FC", VA = "0x2F7B3FC", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x6009682")]
	[Address(RVA = "0x2F7AFC8", Offset = "0x2F7AFC8", VA = "0x2F7AFC8")]
	private void InCreaseGoDepth()
	{
	}

	[Token(Token = "0x6009683")]
	[Address(RVA = "0x2F7A9F0", Offset = "0x2F7A9F0", VA = "0x2F7A9F0")]
	private void AutoChooseMap()
	{
	}

	[Token(Token = "0x6009684")]
	[Address(RVA = "0x2F7B664", Offset = "0x2F7B664", VA = "0x2F7B664")]
	private void OnShareBtn()
	{
	}

	[Token(Token = "0x6009685")]
	[Address(RVA = "0x2F7B7D8", Offset = "0x2F7B7D8", VA = "0x2F7B7D8")]
	private void OnClickMask()
	{
	}

	[Token(Token = "0x6009686")]
	[Address(RVA = "0x2F7BABC", Offset = "0x2F7BABC", VA = "0x2F7BABC")]
	private void OnBtnCliamClick()
	{
	}

	[Token(Token = "0x6009687")]
	[Address(RVA = "0x2F7BC34", Offset = "0x2F7BC34", VA = "0x2F7BC34")]
	private void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x6009688")]
	[Address(RVA = "0x2F7BD88", Offset = "0x2F7BD88", VA = "0x2F7BD88")]
	private void OnBtnGoClick()
	{
	}

	[Token(Token = "0x6009689")]
	[Address(RVA = "0x2F7C098", Offset = "0x2F7C098", VA = "0x2F7C098", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600968A")]
	[Address(RVA = "0x2F7C33C", Offset = "0x2F7C33C", VA = "0x2F7C33C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600968B")]
	[Address(RVA = "0x2F7C420", Offset = "0x2F7C420", VA = "0x2F7C420")]
	private void HandleDebugConsoleKeyCode()
	{
	}

	[Token(Token = "0x600968C")]
	[Address(RVA = "0x2F7C5B4", Offset = "0x2F7C5B4", VA = "0x2F7C5B4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600968D")]
	[Address(RVA = "0x2F7C5BC", Offset = "0x2F7C5BC", VA = "0x2F7C5BC")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600968E")]
	[Address(RVA = "0x2F7C5C4", Offset = "0x2F7C5C4", VA = "0x2F7C5C4")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x600968F")]
	[Address(RVA = "0x2F7C5CC", Offset = "0x2F7C5CC", VA = "0x2F7C5CC")]
	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x6009690")]
	[Address(RVA = "0x2F7C5D4", Offset = "0x2F7C5D4", VA = "0x2F7C5D4")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009691")]
	[Address(RVA = "0x2F7C5DC", Offset = "0x2F7C5DC", VA = "0x2F7C5DC")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6009692")]
	[Address(RVA = "0x2F7C5E4", Offset = "0x2F7C5E4", VA = "0x2F7C5E4")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
