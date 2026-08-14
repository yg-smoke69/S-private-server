using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002002")]
public class UIChampionshipEntranceItemController : UIOnlineMatchEntranceItemController, _Attribute
{
	[Token(Token = "0x2002003")]
	private class EntranceInfo
	{
		[Token(Token = "0x2002004")]
		protected class EntranceStateInfo
		{
			[Token(Token = "0x400C934")]
			[FieldOffset(Offset = "0x8")]
			public bool SubscriptState;

			[Token(Token = "0x400C935")]
			[FieldOffset(Offset = "0xC")]
			public string SubscriptText;

			[Token(Token = "0x400C936")]
			[FieldOffset(Offset = "0x10")]
			public bool TicketState;

			[Token(Token = "0x400C937")]
			[FieldOffset(Offset = "0x11")]
			public bool ShowTimeEffect;

			[Token(Token = "0x400C938")]
			[FieldOffset(Offset = "0x12")]
			public bool ShowSeasonTime;

			[Token(Token = "0x400C939")]
			[FieldOffset(Offset = "0x13")]
			public bool ShowWeekTime;

			[Token(Token = "0x400C93A")]
			[FieldOffset(Offset = "0x14")]
			public bool ShowDayTime;

			[Token(Token = "0x400C93B")]
			[FieldOffset(Offset = "0x15")]
			public bool ShowStartTime;

			[Token(Token = "0x400C93C")]
			[FieldOffset(Offset = "0x16")]
			public bool ShowSettleTime;

			[Token(Token = "0x400C93D")]
			[FieldOffset(Offset = "0x17")]
			public bool ShowMatchFinished;

			[Token(Token = "0x400C93E")]
			[FieldOffset(Offset = "0x18")]
			public string OpenTimeDescText;

			[Token(Token = "0x400C93F")]
			[FieldOffset(Offset = "0x1C")]
			public bool ShowComingSoon;

			[Token(Token = "0x400C940")]
			[FieldOffset(Offset = "0x1D")]
			public bool ShowDetailBtn;

			[Token(Token = "0x400C941")]
			[FieldOffset(Offset = "0x1E")]
			public bool ShowOpenTime;

			[Token(Token = "0x600A1D4")]
			[Address(RVA = "0x2827BC8", Offset = "0x2827BC8", VA = "0x2827BC8")]
			public EntranceStateInfo()
			{
			}
		}

		[Token(Token = "0x400C927")]
		[FieldOffset(Offset = "0x8")]
		protected UIChampionshipEntranceItemView m_View;

		[Token(Token = "0x400C928")]
		[FieldOffset(Offset = "0xC")]
		protected ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

		[Token(Token = "0x400C929")]
		[FieldOffset(Offset = "0x10")]
		protected ChampionshipSettingDesc m_ChampionshipSettingInfo;

		[Token(Token = "0x400C92A")]
		[FieldOffset(Offset = "0x14")]
		protected UIModelChampionship m_ModelChampionship;

		[Token(Token = "0x400C92B")]
		[FieldOffset(Offset = "0x18")]
		protected uint m_ChampionshipType;

		[Token(Token = "0x400C92C")]
		[FieldOffset(Offset = "0x1C")]
		protected UIModelChampionship.ChampionshipOpenState m_ChampionshipState;

		[Token(Token = "0x400C92D")]
		[FieldOffset(Offset = "0x20")]
		protected MapOpeningInfo m_MapInfo;

		[Token(Token = "0x400C92E")]
		[FieldOffset(Offset = "0x24")]
		private bool m_Clicked;

		[Token(Token = "0x400C92F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, UIToggleButton> m_StateBtnDict;

		[Token(Token = "0x400C930")]
		[FieldOffset(Offset = "0x2C")]
		private Dictionary<uint, GameObject> m_OpenDayDict;

		[Token(Token = "0x400C931")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, GameObject> m_UnOpenDayDict;

		[Token(Token = "0x400C932")]
		[FieldOffset(Offset = "0x34")]
		private UIChampionshipEntranceItemController m_Ctrl;

		[Token(Token = "0x400C933")]
		[FieldOffset(Offset = "0x0")]
		protected static Dictionary<int, EntranceStateInfo> m_EntranceStateInfoDict;

		[Token(Token = "0x600A1C7")]
		[Address(RVA = "0x2823E44", Offset = "0x2823E44", VA = "0x2823E44")]
		public EntranceInfo(UIChampionshipEntranceItemController ctrl, uint type)
		{
		}

		[Token(Token = "0x600A1C8")]
		[Address(RVA = "0x28229B8", Offset = "0x28229B8", VA = "0x28229B8")]
		public void RefreshView()
		{
		}

		[Token(Token = "0x600A1C9")]
		[Address(RVA = "0x28250A4", Offset = "0x28250A4", VA = "0x28250A4", Slot = "4")]
		protected virtual void OnRefreshView()
		{
		}

		[Token(Token = "0x600A1CA")]
		[Address(RVA = "0x28250F8", Offset = "0x28250F8", VA = "0x28250F8")]
		private void SetDetailedInfo()
		{
		}

		[Token(Token = "0x600A1CB")]
		[Address(RVA = "0x2825E38", Offset = "0x2825E38", VA = "0x2825E38")]
		private void SetSettingInfo()
		{
		}

		[Token(Token = "0x600A1CC")]
		[Address(RVA = "0x28261F8", Offset = "0x28261F8", VA = "0x28261F8", Slot = "5")]
		protected virtual void OnSetSettingInfo()
		{
		}

		[Token(Token = "0x600A1CD")]
		[Address(RVA = "0x28264C4", Offset = "0x28264C4", VA = "0x28264C4")]
		protected void SetOpenInfo()
		{
		}

		[Token(Token = "0x600A1CE")]
		[Address(RVA = "0x28266C8", Offset = "0x28266C8", VA = "0x28266C8")]
		protected void SetMapOpenInfo()
		{
		}

		[Token(Token = "0x600A1CF")]
		[Address(RVA = "0x2824724", Offset = "0x2824724", VA = "0x2824724")]
		private void RefreshViewByState()
		{
		}

		[Token(Token = "0x600A1D0")]
		[Address(RVA = "0x2826BDC", Offset = "0x2826BDC", VA = "0x2826BDC")]
		private void OnEntranceBtnClick()
		{
		}

		[Token(Token = "0x600A1D1")]
		[Address(RVA = "0x282355C", Offset = "0x282355C", VA = "0x282355C")]
		public void OnEntranceAnimFinish()
		{
		}

		[Token(Token = "0x600A1D2")]
		[Address(RVA = "0x2822780", Offset = "0x2822780", VA = "0x2822780")]
		public void Clear()
		{
		}
	}

	[Token(Token = "0x2002005")]
	private class FFCEntrance : EntranceInfo
	{
		[Token(Token = "0x600A1D5")]
		[Address(RVA = "0x282314C", Offset = "0x282314C", VA = "0x282314C")]
		public FFCEntrance(UIChampionshipEntranceItemController ctrl, uint type)
		{
		}

		[Token(Token = "0x600A1D6")]
		[Address(RVA = "0x2827C84", Offset = "0x2827C84", VA = "0x2827C84", Slot = "4")]
		protected override void OnRefreshView()
		{
		}

		[Token(Token = "0x600A1D7")]
		[Address(RVA = "0x2827D1C", Offset = "0x2827D1C", VA = "0x2827D1C", Slot = "5")]
		protected override void OnSetSettingInfo()
		{
		}

		[Token(Token = "0x600A1D8")]
		[Address(RVA = "0x2827E90", Offset = "0x2827E90", VA = "0x2827E90")]
		public void _003C_003EiFixBaseProxy_OnRefreshView()
		{
		}

		[Token(Token = "0x600A1D9")]
		[Address(RVA = "0x2827E94", Offset = "0x2827E94", VA = "0x2827E94")]
		public void _003C_003EiFixBaseProxy_OnSetSettingInfo()
		{
		}
	}

	[Token(Token = "0x2002006")]
	private class OpenThirdPartyEntrance : EntranceInfo
	{
		[Token(Token = "0x600A1DA")]
		[Address(RVA = "0x2823404", Offset = "0x2823404", VA = "0x2823404")]
		public OpenThirdPartyEntrance(UIChampionshipEntranceItemController ctrl, uint type)
		{
		}

		[Token(Token = "0x600A1DB")]
		[Address(RVA = "0x2827E98", Offset = "0x2827E98", VA = "0x2827E98", Slot = "4")]
		protected override void OnRefreshView()
		{
		}

		[Token(Token = "0x600A1DC")]
		[Address(RVA = "0x2827F30", Offset = "0x2827F30", VA = "0x2827F30", Slot = "5")]
		protected override void OnSetSettingInfo()
		{
		}

		[Token(Token = "0x600A1DD")]
		[Address(RVA = "0x2827F90", Offset = "0x2827F90", VA = "0x2827F90")]
		public void _003C_003EiFixBaseProxy_OnRefreshView()
		{
		}

		[Token(Token = "0x600A1DE")]
		[Address(RVA = "0x2827F94", Offset = "0x2827F94", VA = "0x2827F94")]
		public void _003C_003EiFixBaseProxy_OnSetSettingInfo()
		{
		}
	}

	[Token(Token = "0x400C923")]
	[FieldOffset(Offset = "0x60")]
	private uint m_ChampionshipType;

	[Token(Token = "0x400C924")]
	[FieldOffset(Offset = "0x64")]
	private UIChampionshipEntranceItemView m_View;

	[Token(Token = "0x400C925")]
	[FieldOffset(Offset = "0x68")]
	private EntranceInfo m_EntranceInfo;

	[Token(Token = "0x400C926")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x600A1B5")]
	[Address(RVA = "0x282223C", Offset = "0x282223C", VA = "0x282223C")]
	public UIChampionshipEntranceItemController()
	{
	}

	[Token(Token = "0x600A1B6")]
	[Address(RVA = "0x2822244", Offset = "0x2822244", VA = "0x2822244")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A1B7")]
	[Address(RVA = "0x28222E8", Offset = "0x28222E8", VA = "0x28222E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A1B8")]
	[Address(RVA = "0x28224EC", Offset = "0x28224EC", VA = "0x28224EC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A1B9")]
	[Address(RVA = "0x28225F4", Offset = "0x28225F4", VA = "0x28225F4")]
	public void SetViewData(EntranceType type, uint championshipType = 1u)
	{
	}

	[Token(Token = "0x600A1BA")]
	[Address(RVA = "0x2822A5C", Offset = "0x2822A5C", VA = "0x2822A5C")]
	private void SetLockView()
	{
	}

	[Token(Token = "0x600A1BB")]
	[Address(RVA = "0x28228B4", Offset = "0x28228B4", VA = "0x28228B4")]
	private void CreateEntranceInfo(EntranceType type)
	{
	}

	[Token(Token = "0x600A1BC")]
	[Address(RVA = "0x28234F4", Offset = "0x28234F4", VA = "0x28234F4", Slot = "31")]
	protected override void OnEntranceAnimFinish()
	{
	}

	[Token(Token = "0x600A1BD")]
	[Address(RVA = "0x28239B0", Offset = "0x28239B0", VA = "0x28239B0", Slot = "36")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x600A1BE")]
	[Address(RVA = "0x2823C2C", Offset = "0x2823C2C", VA = "0x2823C2C", Slot = "32")]
	public override long GetEntranceOpenTime()
	{
		return default(long);
	}

	[Token(Token = "0x600A1BF")]
	[Address(RVA = "0x2823CF4", Offset = "0x2823CF4", VA = "0x2823CF4", Slot = "33")]
	public override long GetSeasonStartTime()
	{
		return default(long);
	}

	[Token(Token = "0x600A1C0")]
	[Address(RVA = "0x2823DBC", Offset = "0x2823DBC", VA = "0x2823DBC", Slot = "34")]
	public override int GetPriority()
	{
		return default(int);
	}

	[Token(Token = "0x600A1C1")]
	[Address(RVA = "0x2823E14", Offset = "0x2823E14", VA = "0x2823E14")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A1C2")]
	[Address(RVA = "0x2823E1C", Offset = "0x2823E1C", VA = "0x2823E1C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600A1C3")]
	[Address(RVA = "0x2823E24", Offset = "0x2823E24", VA = "0x2823E24")]
	public void _003C_003EiFixBaseProxy_OnEntranceAnimFinish()
	{
	}

	[Token(Token = "0x600A1C4")]
	[Address(RVA = "0x2823E2C", Offset = "0x2823E2C", VA = "0x2823E2C")]
	public long _003C_003EiFixBaseProxy_GetEntranceOpenTime()
	{
		return default(long);
	}

	[Token(Token = "0x600A1C5")]
	[Address(RVA = "0x2823E34", Offset = "0x2823E34", VA = "0x2823E34")]
	public long _003C_003EiFixBaseProxy_GetSeasonStartTime()
	{
		return default(long);
	}

	[Token(Token = "0x600A1C6")]
	[Address(RVA = "0x2823E3C", Offset = "0x2823E3C", VA = "0x2823E3C")]
	public int _003C_003EiFixBaseProxy_GetPriority()
	{
		return default(int);
	}
}
