using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200206A")]
public class UICupMatchEntranceItemController : UIOnlineMatchEntranceItemController, _Attribute
{
	[Token(Token = "0x200206B")]
	private class EntranceInfo
	{
		[Token(Token = "0x200206C")]
		protected class EntranceStateInfo
		{
			[Token(Token = "0x400CB4E")]
			[FieldOffset(Offset = "0x8")]
			public bool SubscriptState;

			[Token(Token = "0x400CB4F")]
			[FieldOffset(Offset = "0xC")]
			public string SubscriptText;

			[Token(Token = "0x400CB50")]
			[FieldOffset(Offset = "0x10")]
			public bool TicketState;

			[Token(Token = "0x400CB51")]
			[FieldOffset(Offset = "0x11")]
			public bool ShowTimeEffect;

			[Token(Token = "0x400CB52")]
			[FieldOffset(Offset = "0x12")]
			public bool ShowSeasonTime;

			[Token(Token = "0x400CB53")]
			[FieldOffset(Offset = "0x13")]
			public bool ShowWeekTime;

			[Token(Token = "0x400CB54")]
			[FieldOffset(Offset = "0x14")]
			public bool ShowDayTime;

			[Token(Token = "0x400CB55")]
			[FieldOffset(Offset = "0x15")]
			public bool ShowStartTime;

			[Token(Token = "0x400CB56")]
			[FieldOffset(Offset = "0x16")]
			public bool ShowSettleTime;

			[Token(Token = "0x400CB57")]
			[FieldOffset(Offset = "0x17")]
			public bool ShowMatchFinished;

			[Token(Token = "0x400CB58")]
			[FieldOffset(Offset = "0x18")]
			public string OpenTimeDescText;

			[Token(Token = "0x400CB59")]
			[FieldOffset(Offset = "0x1C")]
			public bool ShowComingSoon;

			[Token(Token = "0x400CB5A")]
			[FieldOffset(Offset = "0x1D")]
			public bool ShowDetailBtn;

			[Token(Token = "0x400CB5B")]
			[FieldOffset(Offset = "0x1E")]
			public bool ShowOpenTime;

			[Token(Token = "0x600A646")]
			[Address(RVA = "0x2AA1998", Offset = "0x2AA1998", VA = "0x2AA1998")]
			public EntranceStateInfo()
			{
			}
		}

		[Token(Token = "0x400CB3F")]
		[FieldOffset(Offset = "0x8")]
		private UIChampionshipEntranceItemView m_View;

		[Token(Token = "0x400CB40")]
		[FieldOffset(Offset = "0xC")]
		private CupOpenInfoDesc m_CupMatchOpenInfo;

		[Token(Token = "0x400CB41")]
		[FieldOffset(Offset = "0x10")]
		private CupSettingDesc m_CupMatchSetting;

		[Token(Token = "0x400CB42")]
		[FieldOffset(Offset = "0x14")]
		private CupCDNSettingDesc m_CupCDNSetting;

		[Token(Token = "0x400CB43")]
		[FieldOffset(Offset = "0x18")]
		private UIModelCupMatch m_ModelCupMatch;

		[Token(Token = "0x400CB44")]
		[FieldOffset(Offset = "0x1C")]
		private int m_CupMatchKey;

		[Token(Token = "0x400CB45")]
		[FieldOffset(Offset = "0x20")]
		private UIModelCupMatch.CupMatchOpenState m_CupMatchState;

		[Token(Token = "0x400CB46")]
		[FieldOffset(Offset = "0x24")]
		private MapOpeningInfo m_MapInfo;

		[Token(Token = "0x400CB47")]
		[FieldOffset(Offset = "0x28")]
		private bool m_Clicked;

		[Token(Token = "0x400CB48")]
		[FieldOffset(Offset = "0x2C")]
		private Dictionary<int, UIToggleButton> m_StateBtnDict;

		[Token(Token = "0x400CB49")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, GameObject> m_OpenDayDict;

		[Token(Token = "0x400CB4A")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<uint, GameObject> m_UnOpenDayDict;

		[Token(Token = "0x400CB4B")]
		[FieldOffset(Offset = "0x38")]
		private UICupMatchEntranceItemController m_Ctrl;

		[Token(Token = "0x400CB4C")]
		[FieldOffset(Offset = "0x3C")]
		private UICountDownController m_CountDownCtrl;

		[Token(Token = "0x400CB4D")]
		[FieldOffset(Offset = "0x40")]
		protected Dictionary<int, EntranceStateInfo> m_EntranceStateInfoDict;

		[Token(Token = "0x600A63C")]
		[Address(RVA = "0x2750444", Offset = "0x2750444", VA = "0x2750444")]
		public EntranceInfo(UICupMatchEntranceItemController ctrl, int key)
		{
		}

		[Token(Token = "0x600A63D")]
		[Address(RVA = "0x274FCE8", Offset = "0x274FCE8", VA = "0x274FCE8")]
		public void RefreshView()
		{
		}

		[Token(Token = "0x600A63E")]
		[Address(RVA = "0x2752B40", Offset = "0x2752B40", VA = "0x2752B40")]
		private void SetDetailedInfo()
		{
		}

		[Token(Token = "0x600A63F")]
		[Address(RVA = "0x27536AC", Offset = "0x27536AC", VA = "0x27536AC")]
		private void SetSettingInfo()
		{
		}

		[Token(Token = "0x600A640")]
		[Address(RVA = "0x2753A04", Offset = "0x2753A04", VA = "0x2753A04")]
		protected void SetOpenInfo()
		{
		}

		[Token(Token = "0x600A641")]
		[Address(RVA = "0x2753C08", Offset = "0x2753C08", VA = "0x2753C08")]
		protected void SetMapOpenInfo()
		{
		}

		[Token(Token = "0x600A642")]
		[Address(RVA = "0x2751F88", Offset = "0x2751F88", VA = "0x2751F88")]
		private void RefreshViewByState()
		{
		}

		[Token(Token = "0x600A643")]
		[Address(RVA = "0x275411C", Offset = "0x275411C", VA = "0x275411C")]
		private void OnEntranceBtnClick()
		{
		}

		[Token(Token = "0x600A644")]
		[Address(RVA = "0x2751718", Offset = "0x2751718", VA = "0x2751718")]
		public void OnEntranceAnimFinish()
		{
		}

		[Token(Token = "0x600A645")]
		[Address(RVA = "0x27549F4", Offset = "0x27549F4", VA = "0x27549F4")]
		private void _003CRefreshViewByState_003Em__0()
		{
		}
	}

	[Token(Token = "0x400CB3B")]
	[FieldOffset(Offset = "0x60")]
	private UIChampionshipEntranceItemView m_View;

	[Token(Token = "0x400CB3C")]
	[FieldOffset(Offset = "0x64")]
	private EntranceInfo m_EntranceInfo;

	[Token(Token = "0x400CB3D")]
	[FieldOffset(Offset = "0x68")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CB3E")]
	[FieldOffset(Offset = "0x6C")]
	private int m_CupMatchKey;

	[Token(Token = "0x600A627")]
	[Address(RVA = "0x274F5F0", Offset = "0x274F5F0", VA = "0x274F5F0")]
	public UICupMatchEntranceItemController()
	{
	}

	[Token(Token = "0x600A628")]
	[Address(RVA = "0x274F5F8", Offset = "0x274F5F8", VA = "0x274F5F8")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A629")]
	[Address(RVA = "0x274F69C", Offset = "0x274F69C", VA = "0x274F69C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A62A")]
	[Address(RVA = "0x274F8B4", Offset = "0x274F8B4", VA = "0x274F8B4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A62B")]
	[Address(RVA = "0x274F93C", Offset = "0x274F93C", VA = "0x274F93C")]
	public void SetViewData(int key)
	{
	}

	[Token(Token = "0x600A62C")]
	[Address(RVA = "0x274FD54", Offset = "0x274FD54", VA = "0x274FD54")]
	private void SetLockView()
	{
	}

	[Token(Token = "0x600A62D")]
	[Address(RVA = "0x274FC24", Offset = "0x274FC24", VA = "0x274FC24")]
	private void CreateEntranceInfo(int key)
	{
	}

	[Token(Token = "0x600A62E")]
	[Address(RVA = "0x27516B0", Offset = "0x27516B0", VA = "0x27516B0", Slot = "31")]
	protected override void OnEntranceAnimFinish()
	{
	}

	[Token(Token = "0x600A62F")]
	[Address(RVA = "0x27519D8", Offset = "0x27519D8", VA = "0x27519D8", Slot = "32")]
	public override long GetEntranceOpenTime()
	{
		return default(long);
	}

	[Token(Token = "0x600A630")]
	[Address(RVA = "0x2751A70", Offset = "0x2751A70", VA = "0x2751A70", Slot = "33")]
	public override long GetSeasonStartTime()
	{
		return default(long);
	}

	[Token(Token = "0x600A631")]
	[Address(RVA = "0x2751B08", Offset = "0x2751B08", VA = "0x2751B08", Slot = "34")]
	public override int GetPriority()
	{
		return default(int);
	}

	[Token(Token = "0x600A632")]
	[Address(RVA = "0x2751B60", Offset = "0x2751B60", VA = "0x2751B60", Slot = "35")]
	public override int GetMatchType()
	{
		return default(int);
	}

	[Token(Token = "0x600A633")]
	[Address(RVA = "0x2751BC4", Offset = "0x2751BC4", VA = "0x2751BC4", Slot = "36")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A634")]
	[Address(RVA = "0x2751EBC", Offset = "0x2751EBC", VA = "0x2751EBC", Slot = "37")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A635")]
	[Address(RVA = "0x2751F50", Offset = "0x2751F50", VA = "0x2751F50")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A636")]
	[Address(RVA = "0x2751F58", Offset = "0x2751F58", VA = "0x2751F58")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A637")]
	[Address(RVA = "0x2751F60", Offset = "0x2751F60", VA = "0x2751F60")]
	public void _003C_003EiFixBaseProxy_OnEntranceAnimFinish()
	{
	}

	[Token(Token = "0x600A638")]
	[Address(RVA = "0x2751F68", Offset = "0x2751F68", VA = "0x2751F68")]
	public long _003C_003EiFixBaseProxy_GetEntranceOpenTime()
	{
		return default(long);
	}

	[Token(Token = "0x600A639")]
	[Address(RVA = "0x2751F70", Offset = "0x2751F70", VA = "0x2751F70")]
	public long _003C_003EiFixBaseProxy_GetSeasonStartTime()
	{
		return default(long);
	}

	[Token(Token = "0x600A63A")]
	[Address(RVA = "0x2751F78", Offset = "0x2751F78", VA = "0x2751F78")]
	public int _003C_003EiFixBaseProxy_GetPriority()
	{
		return default(int);
	}

	[Token(Token = "0x600A63B")]
	[Address(RVA = "0x2751F80", Offset = "0x2751F80", VA = "0x2751F80")]
	public int _003C_003EiFixBaseProxy_GetMatchType()
	{
		return default(int);
	}
}
