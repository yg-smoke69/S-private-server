using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002360")]
public class UISceneEditUGCRankRewardLevelUpController : UIPopupWindowController
{
	[Token(Token = "0x2002361")]
	private enum UIRewardState
	{
		[Token(Token = "0x400DC5A")]
		None,
		[Token(Token = "0x400DC5B")]
		LevelShow,
		[Token(Token = "0x400DC5C")]
		ChestShow
	}

	[Token(Token = "0x2002362")]
	private sealed class _003CAutoCrateChest_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DC5D")]
		[FieldOffset(Offset = "0x8")]
		internal UISceneEditUGCRankRewardLevelUpController _0024this;

		[Token(Token = "0x400DC5E")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DC5F")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DC60")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010CA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C56A")]
			[Address(RVA = "0x1A40ACC", Offset = "0x1A40ACC", VA = "0x1A40ACC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010CB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C56B")]
			[Address(RVA = "0x1A40AD4", Offset = "0x1A40AD4", VA = "0x1A40AD4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C568")]
		[Address(RVA = "0x1A3F188", Offset = "0x1A3F188", VA = "0x1A3F188")]
		public _003CAutoCrateChest_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C569")]
		[Address(RVA = "0x1A40964", Offset = "0x1A40964", VA = "0x1A40964", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C56C")]
		[Address(RVA = "0x1A40ADC", Offset = "0x1A40ADC", VA = "0x1A40ADC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C56D")]
		[Address(RVA = "0x1A40AF0", Offset = "0x1A40AF0", VA = "0x1A40AF0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002363")]
	private sealed class _003COpenChestCoroutine_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DC61")]
		[FieldOffset(Offset = "0x8")]
		internal UISceneEditUGCRankRewardLevelUpController _0024this;

		[Token(Token = "0x400DC62")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DC63")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DC64")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010CC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C570")]
			[Address(RVA = "0x1A40CE0", Offset = "0x1A40CE0", VA = "0x1A40CE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010CD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C571")]
			[Address(RVA = "0x1A40CE8", Offset = "0x1A40CE8", VA = "0x1A40CE8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C56E")]
		[Address(RVA = "0x1A402E0", Offset = "0x1A402E0", VA = "0x1A402E0")]
		public _003COpenChestCoroutine_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600C56F")]
		[Address(RVA = "0x1A40B78", Offset = "0x1A40B78", VA = "0x1A40B78", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C572")]
		[Address(RVA = "0x1A40CF0", Offset = "0x1A40CF0", VA = "0x1A40CF0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C573")]
		[Address(RVA = "0x1A40D04", Offset = "0x1A40D04", VA = "0x1A40D04", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DC52")]
	[FieldOffset(Offset = "0x48")]
	private UIRewardState m_UIState;

	[Token(Token = "0x400DC53")]
	[FieldOffset(Offset = "0x4C")]
	private UISceneEditUGCRankRewardLevelUpView m_View;

	[Token(Token = "0x400DC54")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_ModelChest;

	[Token(Token = "0x400DC55")]
	[FieldOffset(Offset = "0x54")]
	private List<WorkshopLevelReward> m_RewardInfoList;

	[Token(Token = "0x400DC56")]
	[FieldOffset(Offset = "0x58")]
	private Transform[] m_AwardGridArray;

	[Token(Token = "0x400DC57")]
	[FieldOffset(Offset = "0x5C")]
	private List<UIStandardItemMAXBController> itemCtrlList;

	[Token(Token = "0x400DC58")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600C557")]
	[Address(RVA = "0x1A3EB68", Offset = "0x1A3EB68", VA = "0x1A3EB68")]
	public UISceneEditUGCRankRewardLevelUpController()
	{
	}

	[Token(Token = "0x600C558")]
	[Address(RVA = "0x1A3EBF4", Offset = "0x1A3EBF4", VA = "0x1A3EBF4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C559")]
	[Address(RVA = "0x1A3EC98", Offset = "0x1A3EC98", VA = "0x1A3EC98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C55A")]
	[Address(RVA = "0x1A3F0BC", Offset = "0x1A3F0BC", VA = "0x1A3F0BC")]
	private IEnumerator AutoCrateChest()
	{
		return null;
	}

	[Token(Token = "0x600C55B")]
	[Address(RVA = "0x1A3F190", Offset = "0x1A3F190", VA = "0x1A3F190", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C55C")]
	[Address(RVA = "0x1A3F2B4", Offset = "0x1A3F2B4", VA = "0x1A3F2B4")]
	private void GoToNextStep()
	{
	}

	[Token(Token = "0x600C55D")]
	[Address(RVA = "0x1A3FB10", Offset = "0x1A3FB10", VA = "0x1A3FB10")]
	private void OnContinueClick()
	{
	}

	[Token(Token = "0x600C55E")]
	[Address(RVA = "0x1A3F5C0", Offset = "0x1A3F5C0", VA = "0x1A3F5C0")]
	private void OnClickChest()
	{
	}

	[Token(Token = "0x600C55F")]
	[Address(RVA = "0x1A3FB70", Offset = "0x1A3FB70", VA = "0x1A3FB70")]
	private void OnClickRewardView()
	{
	}

	[Token(Token = "0x600C560")]
	[Address(RVA = "0x1A3FC88", Offset = "0x1A3FC88", VA = "0x1A3FC88")]
	public void SetViewData(CSClaimWorkshopLevelRewardRes data, uint beforeLv, uint afterLv)
	{
	}

	[Token(Token = "0x600C561")]
	[Address(RVA = "0x1A3F3B4", Offset = "0x1A3F3B4", VA = "0x1A3F3B4")]
	private void CreateChest()
	{
	}

	[Token(Token = "0x600C562")]
	[Address(RVA = "0x1A40214", Offset = "0x1A40214", VA = "0x1A40214")]
	private IEnumerator OpenChestCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600C563")]
	[Address(RVA = "0x1A402E8", Offset = "0x1A402E8", VA = "0x1A402E8")]
	public void ShowChestReward()
	{
	}

	[Token(Token = "0x600C564")]
	[Address(RVA = "0x1A4076C", Offset = "0x1A4076C", VA = "0x1A4076C")]
	private void OnPlayRewardAudio(string audioName)
	{
	}

	[Token(Token = "0x600C565")]
	[Address(RVA = "0x1A4094C", Offset = "0x1A4094C", VA = "0x1A4094C")]
	private static CommonRewardItemInfo _003COnClickChest_003Em__0(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x600C566")]
	[Address(RVA = "0x1A40954", Offset = "0x1A40954", VA = "0x1A40954")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C567")]
	[Address(RVA = "0x1A4095C", Offset = "0x1A4095C", VA = "0x1A4095C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
